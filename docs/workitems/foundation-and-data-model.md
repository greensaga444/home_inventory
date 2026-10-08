# Foundation and Data Model

## Spec

### Business Goal
Deliver a reliable persistence foundation so HomeVault can store and retrieve core asset data locally.

### User Story
As a HomeVault user, I want a valid asset to be saved and appear in inventory so I can trust the app as my source of record.

### MVP
- .NET 9 solution with Domain, Data, and Tests projects.
- EF Core DbContext for asset persistence.
- AC-FR-001 behavior covered with automated tests.
- WinUI shell project that boots and initializes the local database.

### Scope
In scope:
- Asset entity model (core fields)
- SQLite-backed DbContext model configuration
- Automated tests for first persistence slice
- First EF Core migration for asset schema
- Minimal WinUI app shell bootstrap

Out of scope:
- Full CRUD workflows beyond first create/list behavior
- Backup/restore and reporting

### Acceptance Criteria (Slice 1)
- AC-FR-001: Given user opens Add Asset screen, when valid required fields are entered and Save is clicked, then a new asset record is stored and visible in inventory list.

### Test-First Evidence
Red:
- `dotnet test tests/HomeVault.Tests/HomeVault.Tests.csproj`
- Failed with missing `HomeVaultDbContext` implementation (CS0246).

Green:
- `dotnet test tests/HomeVault.Tests/HomeVault.Tests.csproj`
- Passed: 3 tests, 0 failed.

Infrastructure validation:
- `dotnet build HomeVault.sln`
- Passed.

## Tasks

- [x] Scaffold .NET 9 solution and projects (`Domain`, `Data`, `Tests`).
- [x] Add EF Core package baseline compatible with net9.0.
- [x] Write failing tests for AC-FR-001 happy/validation/boundary cases.
- [x] Implement minimal `Asset` entity and `HomeVaultDbContext`.
- [x] Run tests and confirm green.
- [x] Add first EF Core migration for asset table.
- [x] Bootstrap WinUI app shell and run DB migration on launch.
