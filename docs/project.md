# PROJECT OVERVIEW

> Use this file for a **whole new codebase**.
> Fill it in once at project start (typically from a PRD via `init`) to define the architecture, final target, roadmap, and milestones.
> Each roadmap item is later implemented on its own branch using `status.md`.

## Init Status

Status: DEFINED

> TEMPLATE = not yet defined; DEFINED = initialization complete.
> Set to DEFINED only after Final Target, Architecture, and Roadmap are filled in.
> This marker is the single source of truth for "is project.md defined?".

---

## Project

Project Name: HomeVault

Repository: home_inventory (local)

Owner: Davis Chen

Project Type: Desktop App (Windows)

Target Platforms: Windows 10 / Windows 11

Tech Stack:

- Language(s): C#, XAML
- Framework / UI: WinUI 3, MVVM (CommunityToolkit.Mvvm)
- Data / Storage: SQLite, Entity Framework Core
- Backend / Services: Local-only application services (offline-first)
- Build / Packaging: .NET 9 SDK, MSIX (release packaging target)
- Infrastructure / Distribution: Local development initially; optional GitHub CI/CD later

---

## Delivery Policy

> Decided once, after this file is defined. Governs how work branches land.

- Main Branch Protected: no
- Pull Request Required: same as Main Branch Protected
- CI Required: same as Pull Request Required (must pass before merge)
- Merge Method: squash
- One PR per Branch: yes  (if a PR already exists for the branch, update it)

If Main Branch Protected is **no** (therefore Pull Request Required is **no**) (local-only), delivery may push directly to `main` and CI is optional.

---

## Branch Naming

Pattern: `<type>/<short-name>`  (base branch: main or master)

Types:

- feature/ — new functionality
- fix/ — bug fix
- chore/ — tooling, deps, refactor, config
- docs/ — documentation only

Each branch carries one `status.md` and one work item from the Roadmap, regardless of type.

---

## Repository Layout

Template repository layout (this repo):

```
README.md
docs/
  project.md
  status.md
  prd/
  style/
  workitems/<name>.md
```

Recommended layout inside a target project:

```
docs/
  project.md            (this file — whole-project overview, read once)
  status.md             (per-task workflow, one copy per branch)
  prd/                  (product requirements source files)
  style/                (coding style baseline + language appendices)
  workitems/<name>.md   (FULL track: PLAN output — Spec + Tasks — in one file)
<source>/               (application/source code)
```

---

## Final Target

Vision:

HomeVault is an offline-first Windows desktop app that helps users keep a complete, trustworthy household asset catalog with warranty and maintenance context in one place.

Problem Statement:

Household asset records are fragmented across paper documents, email, and multiple apps, making it hard to track ownership, warranty status, maintenance history, and insurance-relevant evidence.

Success Definition (Done means):

- Users can create, edit, search, and organize assets quickly.
- Warranty and maintenance workflows are usable end-to-end.
- Backup and restore protect local data reliably.
- The app is fully usable offline and supports en and zh-TW.
- MVP acceptance criteria in the PRD are satisfied.

Out of Scope:

- Cloud synchronization
- Mobile applications
- Multi-user collaboration
- Online authentication
- E-commerce or insurance platform integrations
- AI recognition and smart-home hardware integrations

---

## Architecture

High-Level Overview:

HomeVault is a Windows desktop app built with WinUI 3 and MVVM, backed by a local SQLite database through Entity Framework Core. The app is organized into feature modules (Dashboard, Inventory, Warranty, Maintenance, Reports, Settings) with offline-first behavior and bilingual UI resources.

Components:

| Component | Responsibility | Tech |
| --- | --- | --- |
| Presentation Layer | Render screens, user interactions, navigation, localization switching | WinUI 3, XAML |
| ViewModel Layer | UI state, commands, validation, orchestration | CommunityToolkit.Mvvm |
| Application Services | Business logic for assets, warranties, maintenance, backup/restore, reporting | .NET 9 |
| Data Access Layer | Persistence, transactions, migrations, query performance | EF Core |
| Local Storage | Relational data and attachments metadata | SQLite |
| File Storage/IO | Photos, receipts, backup files, import/export files | Windows file system APIs |

Data Flow:

User actions in WinUI views trigger ViewModel commands, which call application services. Services execute validation and business rules, then persist or query data through EF Core against SQLite. For attachments and backups, services coordinate file-system IO and store file references in the database. Dashboard and reports aggregate query outputs for UI display.

Key Decisions:

- Offline-first architecture with no cloud dependency in MVP.
- MVVM as the mandatory UI architecture pattern.
- SQLite as the single local source of truth.
- Bilingual localization (en, zh-TW) across all user-facing text.
- Backup/restore built into MVP to mitigate local-device risk.

Constraints / Non-Functional Requirements:

- Performance: startup under 3 seconds; search under 500 ms at 10,000 assets.
- Security: local-user-only data access permissions and backup integrity checks.
- Scalability: support 100,000 assets, 500,000 maintenance records, and large attachment datasets.

---

## Roadmap / Todo List

> Each item becomes a work branch. On start, copy the status template into your workflow directory (`<workflow-dir>/status.md`, usually `docs/status.md`),
> set the work item, choose a Track (FULL for risky/unknown items, LIGHT for
> small/clear ones), reset items to TBD, and begin at the INIT stage.
>
> Slicing rules to avoid redundant work:
> - Define each item by a distinct, user-visible outcome, captured in its one-line Definition of Done.
> - Before starting an item, check overlap: if an earlier item already forces this work, fold them together or keep the earlier one deliberately minimal.
> - If two rows share Definition-of-Done language, merge or re-scope them.
> - Whenever any roadmap row is added or edited, re-run the overlap check and merge/re-scope duplicates immediately.
> - For vertical slices, mark any pulled-in work in the roadmap immediately, or defer it with an explicit stub — never leave silent overlap.

| # | Work Item | Definition of Done | Priority | Track | Depends On | Status |
| --- | --- | --- | --- | --- | --- | --- |
| 1 | Foundation and Data Model | App boots to shell and can persist core asset entities in local SQLite with migrations working. | High | FULL | - | TODO |
| 2 | Inventory CRUD and Organization | Users can create/edit/delete/archive assets and organize them by category and location. | High | FULL | 1 | TODO |
| 3 | Media and Purchase Metadata | Users can add photos, receipts, serial numbers, and purchase data to asset records. | High | LIGHT | 2 | TODO |
| 4 | Warranty and Maintenance Workflows | Users can manage warranty expirations and schedule/complete maintenance tasks. | High | FULL | 2 | TODO |
| 5 | Search, Filters, and Dashboard | Users can search/filter assets and view accurate dashboard summary statistics. | High | LIGHT | 2 | TODO |
| 6 | Data Portability and Safety | Users can import/export inventory and complete backup/restore without data loss. | High | FULL | 1 | TODO |
| 7 | Reports and Localization | Inventory reports generate successfully and all supported screens switch cleanly between en and zh-TW. | Medium | LIGHT | 5 | TODO |
| 8 | Quality Hardening for MVP Gate | MVP release criteria pass for performance, reliability, accessibility, and automated quality checks. | High | FULL | 4, 5, 6, 7 | TODO |

Definition of Done: one line describing a distinct user-visible outcome; no two rows should share it.
Track values: FULL (full pipeline) / LIGHT (skip PLAN)
Status values: TODO / IN PROGRESS / DONE / BLOCKED

---

## Milestones

> Defined here on `init` (from the PRD/Final Target). Each finished milestone triggers a README refresh.

- [ ] M1: Core Inventory MVP (Items 1-3 complete)
- [ ] M2: Ownership Lifecycle MVP (Items 4-6 complete)
- [ ] M3: Release-Ready MVP (Items 7-8 complete)

---

## AI Instructions

Read this file **once** to initialize the project (architecture, final target, roadmap).
After initialization, do **not** read or update it again during work on a branch — use `status.md` on the work branch instead.
Re-read this file only when: (a) the user explicitly asks to modify it, or (b) the user says `report` while on the `main` (or `master`) branch.

Detecting whether the project is defined:

- Resolve `project.md` location first: prefer `docs/project.md`; for large existing repos, `.workflow/project.md` is also valid; use root `project.md` only for legacy layouts.
- If the resolved file is missing → not defined; initialize first.
- If it exists but `Init Status` is `TEMPLATE` → not defined; finish initialization.
- If `Init Status` is `DEFINED` → already defined; do not re-initialize.

Initializing (`init`):

- If `Init Status` is already `DEFINED`, do nothing unless the user asks to modify.
- If the user provides a PRD (product requirements doc), read it and (re)define this whole file from it: Final Target, Architecture, Roadmap, and Milestones. The PRD is the source of truth for scope and goals; treat `init` as a full re-definition of project.md.
- For an existing codebase: scan the repo (languages, frameworks, structure, build files) and draft the empty fields — Project Type, Target Platforms, Tech Stack, Architecture summary.
- For an empty project: interview the user (or read the PRD) to fill the same fields.
- Always present the drafted values for confirmation; set `Status: DEFINED` only after the user approves.
- Without a PRD, never invent Final Target or Roadmap from a scan — those come from the user.
- After `Status: DEFINED`, write/update the project README so it describes the whole project's intended final state as fully as possible (from the PRD/Final Target); it is then refreshed as each milestone finishes.

Rules:

1. Define architecture and final target before writing any code.
2. Keep the roadmap as the single source of truth for what to build next; define the Roadmap and Milestones here in project.md (from the PRD on `init`), not elsewhere.
3. Prefer MVP solutions and avoid over-engineering.
4. Suggest architecture changes only when absolutely necessary; record them under Key Decisions.
5. Give every roadmap item a one-line Definition of Done describing a distinct, user-visible outcome; no two items should share it.
6. Before starting a work item, run an overlap check against earlier/related items — if an earlier item already forces this work, fold them together or keep the earlier one deliberately minimal instead of duplicating.
7. When a vertical slice pulls in adjacent work, record it in the roadmap immediately or defer it with an explicit stub; never leave silent overlap. Re-run overlap checks whenever a roadmap row is added or edited.
8. Do not start a work item until it exists in the Roadmap and `Init Status` is `DEFINED`.
9. When starting a work item, hand off to `status.md` (per-task workflow) on a new branch.
10. During work branches, ignore this file; it is only revisited when the user asks to modify it.
11. On `report`, check the current branch first: if branch is `main` or `master`, summarize progress from this file; otherwise do not use this file and report from `status.md`.
12. Keep the project README aligned with the Final Target: on `init` write it toward the whole project's intended final state, and update it whenever a milestone finishes.
13. Before Delivery, complete IMPLEMENTATION and VERIFICATION in `status.md`.
14. Delivery is post-verification only: update Roadmap/Milestones and relevant docs/README, then commit.
15. If Main Branch Protected = yes (therefore Pull Request Required = yes), open or update the branch PR (never create a second PR for the same branch).
16. If Main Branch Protected = no (therefore Pull Request Required = no), skip PR creation and push the delivery commit directly to `main`.
17. On `finish`, clean up the completed branch; if PR was skipped, ensure delivery docs update + commit + push are complete first.

---

## Commands

init   (read a PRD if provided — or scan the codebase / interview — to (re)define Final Target, Architecture, Roadmap, and Milestones; confirm, set Init Status = DEFINED, then write the project README toward the final target)

show final target

show architecture

show roadmap

add roadmap item   (add a row with a one-line Definition of Done; check it doesn't overlap an existing item)

start <type>/<name> [full|light]   (copy the status template to `<workflow-dir>/status.md` (usually `docs/status.md`), reset to INIT stage, set the Track; type = feature/fix/chore/docs; Track defaults to the Roadmap row, else LIGHT)

report   (check branch first: on main/master, re-read this file and summarize roadmap progress; on other branches, report from `status.md`)

finish   (after a work item is delivered: clean up the completed branch; if PR was skipped, ensure Roadmap/Milestones + docs/README update, commit, and push are done before cleanup)
