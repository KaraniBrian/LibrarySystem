# Library Management System

A desktop library system built with **VB.NET (.NET 8) + Windows Forms** and a **MySQL** database.
Built for the *Visual Programming* course unit (Kirinyaga University).

* **Librarian** – manage students and books, issue and return books, fines and payments, reports, settings, backup.
* **Student** – browse the catalogue, borrow books, see own loans, fines and profile, request returns.

## Architecture (three layers)

```
LibraryManagementSystem.sln
├── LibraryManagementSystem/     Windows Forms front end (screens only – no SQL here)
├── LibraryManagement.Core/      Back end: services, validation, security, data access
├── LibraryManagement.Tests/     xUnit tests (hashing, validation, fines, CSV)
├── Database/library_db.sql      MySQL schema (3NF) + sample data
└── docs/                        Requirements, ERD, test plan for your report
```

## 1. Install the tools (once)

| Tool | Notes |
|---|---|
| **Visual Studio 2022** (17.8+) | Workload: **.NET desktop development** |
| **MySQL Server 8.0+** and **MySQL Workbench** | Remember the `root` password you set |
| **Git for Windows** | Only needed for GitHub |

## 2. Create the database

1. Open **MySQL Workbench** and connect to your local server.
2. **File → Open SQL Script…** and choose `Database/library_db.sql`.
3. Click the lightning-bolt **Execute** button. This creates `library_db` with sample data.
   (Re-running the script resets all data.)

## 3. Tell the app your MySQL password

Copy `LibraryManagementSystem/appsettings.local.json.example` to
`LibraryManagementSystem/appsettings.local.json` and put your real password in it:

```json
{
  "ConnectionString": "Server=localhost;Port=3306;Database=library_db;User ID=root;Password=YOUR_PASSWORD;"
}
```

`appsettings.local.json` is ignored by Git, so your password is never uploaded.
(The connection string lives in this one place only, as the guidelines require.)

## 4. Open and run in Visual Studio

1. Double-click **`LibraryManagementSystem.sln`**.
2. In Solution Explorer, right-click **LibraryManagementSystem** → **Set as Startup Project**.
3. Wait for NuGet to restore packages (bottom status bar), then press **F5**.
4. Run the tests: **Test → Run All Tests**.

### Demo logins

| Role | Email | Password |
|---|---|---|
| Librarian | `librarian@library.com` | `Admin@123` |
| Student | `alice@school.com` | `Student@123` |
| Student (has an overdue book) | `bob@school.com` | `Student@123` |
| Student (has a part-paid fine) | `carol@school.com` | `Student@123` |

New students added by the librarian start with password `Student@123` and should change it.

## 5. Push to GitHub

1. Create an empty repository on <https://github.com/new> (name it e.g. `library-management-system`, **do not** tick "add README").
2. Open a terminal in the solution folder and run:

```bash
git init
git add .
git commit -m "Initial commit: Library Management System"
git branch -M main
git remote add origin https://github.com/YOUR-USERNAME/library-management-system.git
git push -u origin main
```

Check that `appsettings.local.json` does **not** appear in `git status` before you commit.
(Visual Studio alternative: **Git → Create Git Repository…** and push to GitHub from the dialog.)

On every push, GitHub Actions (`.github/workflows/build-release.yml`) builds the solution and runs the tests –
see the **Actions** tab.

## 6. Publish a downloadable release and share the link

A desktop app cannot run from a web link, so you share a **download link** instead:

```bash
git tag v1.0.0
git push origin v1.0.0
```

GitHub Actions then builds a self-contained Windows package (no .NET install needed) and attaches
`LibraryManagementSystem-win-x64.zip` to a **Release**. Share either:

* the repository link: `https://github.com/YOUR-USERNAME/library-management-system`
* the download page: `https://github.com/YOUR-USERNAME/library-management-system/releases/latest`

**For someone who downloads the zip:** install MySQL, run `Database/library_db.sql`, edit
`appsettings.json` (set the password), then double-click `LibraryManagementSystem.exe`.
If the repository is private, they need to be added under **Settings → Collaborators**.

## Security features

* PBKDF2-SHA256 salted password hashes (never plain text).
* Role checks enforced inside the services, not only by hiding buttons.
* Parameterised SQL everywhere; wildcard characters in searches are escaped.
* Borrow/return/payment changes run in database transactions with row locks.
* CSV export neutralises spreadsheet formulas.
* Technical errors go to `%LocalAppData%\LibraryManagementSystem\error.log`; users see friendly messages.

## Troubleshooting

| Message / symptom | Fix |
|---|---|
| "Could not connect to the database" | Start MySQL; check the password/port in `appsettings.local.json`. |
| "Authentication ... RSA public key" | Append `AllowPublicKeyRetrieval=true;` to the connection string (local use only). |
| Backup/Restore says tools not found | Set `"MySqlBinPath"` to MySQL's `bin` folder (see the example file). |
| Build error about Windows Forms | Install the **.NET desktop development** workload in Visual Studio Installer. |

## Known limitations

No email-based password reset (the librarian resets passwords), no online payments (payments are recorded
at the desk), no login lockout, single library branch, English only.
