# HomeVault

HomeVault is an offline-first Windows desktop app for tracking household assets, warranty records, and maintenance context in one local system.

## Current Progress

- Item 1 (Foundation and Data Model) is implemented.
- Solution, data model, EF Core migration flow, tests, and WinUI shell bootstrap are in place.
- Next roadmap focus is Inventory CRUD and Organization.

## Tech Stack

- C#, XAML
- WinUI 3
- Entity Framework Core + SQLite
- .NET 9 SDK
- xUnit for tests

## Repository Layout

```text
HomeVault.sln
global.json
src/
  HomeVault.App/
  HomeVault.Domain/
  HomeVault.Data/
tests/
  HomeVault.Tests/
docs/
  project.md
  status.md
  prd/
  style/
  workitems/
```

## Prerequisites

- Windows 10 or Windows 11
- .NET SDK 9.0.318 or compatible 9.x SDK

## Build and Test

```powershell
dotnet restore HomeVault.sln
dotnet build HomeVault.sln
dotnet test HomeVault.sln
```

## Run the App

```powershell
dotnet run --project src/HomeVault.App/HomeVault.App.csproj
```

On launch, the app applies pending EF Core migrations to a local SQLite database at:

`%LOCALAPPDATA%\HomeVault\homevault.db`

## EF Core Migrations

This repository uses a local tool manifest for EF commands.

```powershell
dotnet tool restore
dotnet tool run dotnet-ef migrations add <MigrationName> --project src/HomeVault.Data/HomeVault.Data.csproj --startup-project src/HomeVault.Data/HomeVault.Data.csproj --output-dir Migrations
dotnet tool run dotnet-ef database update --project src/HomeVault.Data/HomeVault.Data.csproj --startup-project src/HomeVault.Data/HomeVault.Data.csproj
```

## Workflow Docs

- Project-level roadmap and milestones: `docs/project.md`
- Current branch work status: `docs/status.md`
- Item-level planning and task artifacts: `docs/workitems/`
