-- =====================================================================
--  Library Management System - MySQL 8.0+ schema and sample data
--  Run this whole script once (MySQL Workbench > File > Open SQL Script > Run).
--  WARNING: it drops and recreates every table, so re-running resets the data.
--  Normalised to 3NF. Passwords are PBKDF2 hashes (never plain text).
--  Demo logins:  librarian@library.com / Admin@123
--                alice@school.com, bob@school.com, carol@school.com / Student@123
-- =====================================================================
CREATE DATABASE IF NOT EXISTS library_db CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE library_db;

SET FOREIGN_KEY_CHECKS = 0;
DROP VIEW  IF EXISTS vw_fines;
DROP VIEW  IF EXISTS vw_loans;
DROP TABLE IF EXISTS payments;
DROP TABLE IF EXISTS fines;
DROP TABLE IF EXISTS loans;
DROP TABLE IF EXISTS book_copies;
DROP TABLE IF EXISTS books;
DROP TABLE IF EXISTS categories;
DROP TABLE IF EXISTS students;
DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS roles;
DROP TABLE IF EXISTS settings;
SET FOREIGN_KEY_CHECKS = 1;

-- ---------- Tables ----------
CREATE TABLE roles (
    role_id   INT AUTO_INCREMENT PRIMARY KEY,
    role_name VARCHAR(30) NOT NULL UNIQUE
) ENGINE=InnoDB;

CREATE TABLE users (
    user_id       INT AUTO_INCREMENT PRIMARY KEY,
    role_id       INT NOT NULL,
    email         VARCHAR(255) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    first_name    VARCHAR(100) NOT NULL,
    last_name     VARCHAR(100) NOT NULL,
    phone         VARCHAR(20) NULL,
    photo_path    VARCHAR(500) NULL,
    is_active     TINYINT(1) NOT NULL DEFAULT 1,
    created_at    DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_users_role FOREIGN KEY (role_id) REFERENCES roles(role_id)
) ENGINE=InnoDB;

CREATE TABLE students (
    student_id   INT AUTO_INCREMENT PRIMARY KEY,
    user_id      INT NOT NULL UNIQUE,
    admission_no VARCHAR(50) NOT NULL UNIQUE,
    CONSTRAINT fk_students_user FOREIGN KEY (user_id) REFERENCES users(user_id)
) ENGINE=InnoDB;

CREATE TABLE categories (
    category_id INT AUTO_INCREMENT PRIMARY KEY,
    name        VARCHAR(100) NOT NULL UNIQUE
) ENGINE=InnoDB;

CREATE TABLE books (
    book_id          INT AUTO_INCREMENT PRIMARY KEY,
    isbn             VARCHAR(20)  NOT NULL UNIQUE,
    title            VARCHAR(255) NOT NULL,
    author           VARCHAR(150) NOT NULL,
    category_id      INT NOT NULL,
    publisher        VARCHAR(150) NULL,
    publication_year SMALLINT NOT NULL,
    description      VARCHAR(1000) NULL,
    CONSTRAINT fk_books_category FOREIGN KEY (category_id) REFERENCES categories(category_id)
) ENGINE=InnoDB;

CREATE TABLE book_copies (
    copy_id  INT AUTO_INCREMENT PRIMARY KEY,
    book_id  INT NOT NULL,
    copy_no  INT NOT NULL,
    status   ENUM('Available','Borrowed') NOT NULL DEFAULT 'Available',
    UNIQUE KEY uq_copy (book_id, copy_no),
    CONSTRAINT fk_copies_book FOREIGN KEY (book_id) REFERENCES books(book_id)
) ENGINE=InnoDB;

CREATE TABLE loans (
    loan_id          INT AUTO_INCREMENT PRIMARY KEY,
    copy_id          INT NOT NULL,
    student_id       INT NOT NULL,
    issued_by        INT NULL,
    issue_date       DATE NOT NULL,
    due_date         DATE NOT NULL,
    return_date      DATE NULL,
    status           ENUM('Active','ReturnRequested','Returned') NOT NULL DEFAULT 'Active',
    return_condition VARCHAR(30) NULL,
    return_notes     VARCHAR(500) NULL,
    CONSTRAINT fk_loans_copy    FOREIGN KEY (copy_id)    REFERENCES book_copies(copy_id),
    CONSTRAINT fk_loans_student FOREIGN KEY (student_id) REFERENCES students(student_id),
    CONSTRAINT fk_loans_issuer  FOREIGN KEY (issued_by)  REFERENCES users(user_id),
    CONSTRAINT chk_loan_dates CHECK (due_date >= issue_date),
    INDEX idx_loans_student (student_id, status),
    INDEX idx_loans_copy (copy_id)
) ENGINE=InnoDB;

CREATE TABLE fines (
    fine_id    INT AUTO_INCREMENT PRIMARY KEY,
    loan_id    INT NOT NULL UNIQUE,
    amount     DECIMAL(10,2) NOT NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_fines_loan FOREIGN KEY (loan_id) REFERENCES loans(loan_id),
    CONSTRAINT chk_fine_amount CHECK (amount > 0)
) ENGINE=InnoDB;

CREATE TABLE payments (
    payment_id  INT AUTO_INCREMENT PRIMARY KEY,
    fine_id     INT NOT NULL,
    amount      DECIMAL(10,2) NOT NULL,
    method      VARCHAR(30) NOT NULL,
    paid_at     DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    recorded_by INT NOT NULL,
    CONSTRAINT fk_pay_fine FOREIGN KEY (fine_id) REFERENCES fines(fine_id),
    CONSTRAINT fk_pay_user FOREIGN KEY (recorded_by) REFERENCES users(user_id),
    CONSTRAINT chk_pay_amount CHECK (amount > 0)
) ENGINE=InnoDB;

CREATE TABLE settings (
    setting_key   VARCHAR(50) PRIMARY KEY,
    setting_value VARCHAR(200) NOT NULL
) ENGINE=InnoDB;

-- ---------- Views (derived values, so nothing is stored twice) ----------
CREATE VIEW vw_loans AS
SELECT l.loan_id, l.student_id, s.admission_no,
       CONCAT(u.first_name, ' ', u.last_name) AS student_name,
       b.book_id, b.title AS book_title, b.author, c.copy_no,
       l.issue_date, l.due_date, l.return_date,
       CASE WHEN l.status = 'Returned'        THEN 'Returned'
            WHEN l.status = 'ReturnRequested' THEN 'Return Requested'
            WHEN l.due_date < CURDATE()       THEN 'Overdue'
            ELSE 'Active' END AS status,
       l.return_condition, l.return_notes
FROM loans l
JOIN students s     ON s.student_id = l.student_id
JOIN users u        ON u.user_id    = s.user_id
JOIN book_copies c  ON c.copy_id    = l.copy_id
JOIN books b        ON b.book_id    = c.book_id;

CREATE VIEW vw_fines AS
SELECT f.fine_id, f.loan_id, l.student_id, s.admission_no,
       CONCAT(u.first_name, ' ', u.last_name) AS student_name,
       b.title AS book_title, f.amount,
       COALESCE(p.paid, 0) AS paid,
       f.amount - COALESCE(p.paid, 0) AS balance,
       CASE WHEN COALESCE(p.paid, 0) = 0        THEN 'Unpaid'
            WHEN COALESCE(p.paid, 0) < f.amount THEN 'Partially Paid'
            ELSE 'Paid' END AS status,
       f.created_at
FROM fines f
JOIN loans l        ON l.loan_id   = f.loan_id
JOIN students s     ON s.student_id = l.student_id
JOIN users u        ON u.user_id   = s.user_id
JOIN book_copies c  ON c.copy_id   = l.copy_id
JOIN books b        ON b.book_id   = c.book_id
LEFT JOIN (SELECT fine_id, SUM(amount) AS paid FROM payments GROUP BY fine_id) p
       ON p.fine_id = f.fine_id;

-- ---------- Reference and sample data ----------
INSERT INTO roles (role_name) VALUES ('Librarian'), ('Student');

INSERT INTO users (role_id, email, password_hash, first_name, last_name, phone) VALUES
 (1, 'librarian@library.com', 'PBKDF2$100000$Uh7aPN9Z3WrFkzov5cGLMg==$R1Mmn0B/OmEJzMleQdEf2aQysa7xxI97Ga/Ke8zMajw=', 'Grace', 'Wanjiru', '0711000111'),
 (2, 'alice@school.com', 'PBKDF2$100000$FI0TxZwvzjT+0zdhqnzhug==$SG4+lNytdlXJo+IXaijt8lajQh573CTRqBKoz87xyOM=', 'Alice', 'Brown', '0712345678'),
 (2, 'bob@school.com',   'PBKDF2$100000$FI0TxZwvzjT+0zdhqnzhug==$SG4+lNytdlXJo+IXaijt8lajQh573CTRqBKoz87xyOM=', 'Bob', 'Smith', '0723456789'),
 (2, 'carol@school.com', 'PBKDF2$100000$FI0TxZwvzjT+0zdhqnzhug==$SG4+lNytdlXJo+IXaijt8lajQh573CTRqBKoz87xyOM=', 'Carol', 'White', '0734567890');

INSERT INTO students (user_id, admission_no) VALUES (2, 'S001'), (3, 'S002'), (4, 'S003');

INSERT INTO categories (name) VALUES ('Programming'), ('Fiction'), ('Science'), ('History'), ('Mathematics');

INSERT INTO books (isbn, title, author, category_id, publisher, publication_year, description) VALUES
 ('978-0132350884', 'Clean Code', 'Robert C. Martin', 1, 'Prentice Hall', 2008, 'A handbook of agile software craftsmanship with practical advice on writing readable, maintainable code.'),
 ('978-0547928227', 'The Hobbit', 'J.R.R. Tolkien', 2, 'Houghton Mifflin', 2012, 'Bilbo Baggins joins a company of dwarves on a quest to reclaim a treasure guarded by the dragon Smaug.'),
 ('978-1449355739', 'Learning Python', 'Mark Lutz', 1, 'O''Reilly Media', 2013, 'A thorough introduction to the Python language, from basics to advanced features.'),
 ('978-0262033848', 'Introduction to Algorithms', 'Thomas H. Cormen', 1, 'MIT Press', 2009, 'A comprehensive textbook covering a broad range of algorithms in depth.'),
 ('978-0553380163', 'A Brief History of Time', 'Stephen Hawking', 3, 'Bantam', 1998, 'An accessible exploration of cosmology, black holes and the nature of time.'),
 ('978-0385474542', 'Things Fall Apart', 'Chinua Achebe', 2, 'Anchor', 1994, 'A classic novel about Igbo society and the arrival of colonial rule in Nigeria.'),
 ('978-1285740621', 'Calculus', 'James Stewart', 5, 'Cengage', 2015, 'A standard university calculus textbook with worked examples.'),
 ('978-0062316097', 'Sapiens', 'Yuval Noah Harari', 4, 'Harper', 2015, 'A brief history of humankind from the Stone Age to the present.');

INSERT INTO book_copies (book_id, copy_no) VALUES
 (1,1),(1,2),(1,3),(2,1),(2,2),(2,3),(3,1),(3,2),(4,1),(4,2),
 (5,1),(5,2),(6,1),(6,2),(6,3),(7,1),(7,2),(8,1),(8,2);

INSERT INTO settings (setting_key, setting_value) VALUES
 ('library_name', 'City Community Library'),
 ('loan_days', '14'),
 ('fine_per_day', '10.00'),
 ('max_books', '3'),
 ('currency', 'KES');

-- Sample loans: one active, one overdue, one returned late (with a part-paid fine)
INSERT INTO loans (copy_id, student_id, issued_by, issue_date, due_date, return_date, status) VALUES
 (1, 1, 1, CURDATE() - INTERVAL 5 DAY,  CURDATE() + INTERVAL 9 DAY,  NULL, 'Active'),
 (4, 2, 1, CURDATE() - INTERVAL 30 DAY, CURDATE() - INTERVAL 16 DAY, NULL, 'Active'),
 (7, 3, 1, CURDATE() - INTERVAL 40 DAY, CURDATE() - INTERVAL 26 DAY, CURDATE() - INTERVAL 20 DAY, 'Returned');
UPDATE book_copies SET status = 'Borrowed' WHERE copy_id IN (1, 4);

INSERT INTO fines (loan_id, amount) VALUES (3, 60.00);
INSERT INTO payments (fine_id, amount, method, recorded_by) VALUES (1, 20.00, 'Cash', 1);
