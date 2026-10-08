## Master PRD

This document is the executive summary of the product requirements.

### Product Summary

- Product Name: HomeVault

- Problem Statement

  Homeowners often do not have a centralized inventory of valuable household assets. Information such as purchase date, warranty period, maintenance history, storage location, and ownership records is typically distributed across paper documents, emails, or multiple applications.

  This creates challenges when:
  - Tracking owned items.
  - Managing warranties.
  - Performing maintenance.
  - Filing insurance claims.
  - Locating items within a property.

  Users need a simple offline solution that securely stores all asset information in one place.

- Primary Users

  - Homeowners
  - Renters
  - Families
  - Property managers
  - Insurance-conscious users

- Value Proposition

  HomeVault provides an offline-first Windows application that allows users to manage household assets, warranties, maintenance records, and inventory information from a single local database.

### Product Vision

Enable users to maintain a complete digital catalog of household assets with minimal effort while ensuring data privacy through local storage.

### Target Platform

- Windows Desktop Application
- Windows 10 / Windows 11

### Technology Direction

- Frontend: WinUI 3
- Backend: .NET 9
- ORM: Entity Framework Core
- Database: SQLite
- Architecture: MVVM
- Localization: zh-TW / en

### Scope Snapshot

#### In Scope

Asset inventory management:

- Create assets
- Edit assets
- Delete assets
- Archive assets

Asset categorization:

- Furniture
- Electronics
- Appliances
- Tools
- Vehicles
- Other custom categories

Inventory tracking:

- Physical location tracking
- Quantity tracking
- Serial numbers
- Purchase information

Warranty management:

- Warranty expiration dates
- Warranty provider information
- Warranty reminders

Maintenance tracking:

- Maintenance records
- Service history
- Maintenance scheduling

Media management:

- Asset photos
- Receipts
- Warranty documents

Search and analytics:

- Global search
- Filters
- Dashboard statistics
- Asset value reports

Localization:

- English (en)
- Traditional Chinese (zh-TW)

Data management:

- Backup database
- Restore database
- Data export

#### Out of Scope

- Cloud synchronization
- Mobile applications
- Multi-user access
- Online collaboration
- E-commerce integrations
- AI image recognition
- Financial investment tracking

### Major Modules

#### Module 1: Dashboard

Provides overview statistics:

- Total assets
- Total estimated value
- Assets by category
- Upcoming warranty expiration
- Upcoming maintenance tasks

#### Module 2: Inventory Management

Core asset management.

Capabilities:

- Create asset
- Edit asset
- Delete asset
- Categorize asset
- Assign room/location
- Upload photos

#### Module 3: Warranty Tracker

Track warranty status.

Capabilities:

- Warranty provider
- Coverage period
- Expiration notifications

#### Module 4: Maintenance Manager

Track maintenance activities.

Capabilities:

- Maintenance log
- Scheduled maintenance
- History reporting

#### Module 5: Reports

Generate reports including:

- Inventory report
- Warranty report
- Maintenance report
- Asset valuation report

#### Module 6: Settings

System configuration.

Capabilities:

- Language selection
- Backup settings
- Import/export
- Database management

### Requirement Summary

- Functional requirements:
  See [Functional Requirements](20-requirements-functional.md)

- Non-functional requirements:
  See [Non-Functional Requirements](30-requirements-nonfunctional.md)

- User journeys:
  See [User Flows](40-user-flows.md)

### Key Non-Functional Goals

- Offline first
- Local data ownership
- Fast startup (< 3 seconds)
- Search response (< 500 ms)
- SQLite database support
- Localization support
- Accessible user interface

### Release Criteria Snapshot

- Acceptance criteria map:
  See [Acceptance Criteria](50-acceptance-criteria.md)

- Open issues and unresolved decisions:
  See [Open Questions](90-open-questions.md)

### Success Metrics

- User can create asset within 1 minute.
- Search returns results within 500 ms.
- Backup operation completes successfully.
- All UI elements support language switching.
- Application functions without network connectivity.

### Revision Metadata

- Version: v1.0
- Last Updated: 2026-10-08
- Owner: Davis Chen
