## Scope and Goals

### Business Goals

- BG-001: Provide a centralized offline system to manage household assets and inventory.
- BG-002: Reduce the effort required to locate, maintain, and track ownership of personal belongings.
- BG-003: Enable homeowners to maintain accurate records for insurance and warranty purposes.
- BG-004: Demonstrate a production-quality Windows desktop application architecture using WinUI 3, .NET, and SQLite.

### User Goals

- UG-001: Quickly register and organize household assets.
- UG-002: Easily locate items by room, category, keyword, or tag.
- UG-003: Track warranty expiration and maintenance schedules.
- UG-004: Store receipts, photos, and supporting documents together with assets.
- UG-005: Use the application entirely offline.
- UG-006: Switch application language between Traditional Chinese (zh-TW) and English (en).

### In Scope

- Windows desktop application.
- Local SQLite database.
- Asset management.
- Category management.
- Room/location management.
- Asset photo attachment.
- Receipt attachment.
- Warranty tracking.
- Maintenance tracking.
- Search and filtering.
- Dashboard and statistics.
- Import/export functionality.
- Backup/restore functionality.
- Localization (zh-TW / en).
- Settings management.

### Out of Scope

- Mobile applications.
- Cloud synchronization.
- Multi-user collaboration.
- Online authentication.
- E-commerce integration.
- AI-powered object recognition.
- Barcode scanning hardware integration.
- Insurance company integration.
- Smart home integration.

### Constraints

- Timeline: MVP completed within 12 weeks.
- Budget: Development cost minimized by using open-source technologies.
- Compliance: No regulatory compliance requirements for MVP.
- Dependency constraints:
  - .NET 9
  - WinUI 3
  - Entity Framework Core
  - SQLite
  - CommunityToolkit.Mvvm

### Success Metrics

| Metric | Baseline | Target | Measurement Method |
|----------|----------|----------|----------|
| Asset creation success rate | N/A | >95% | User testing |
| Asset search response time | N/A | <500ms | Performance testing |
| App startup time | N/A | <3 seconds | Performance testing |
| Backup success rate | N/A | 100% | Automated testing |
| Localization coverage | N/A | 100% UI localized | Manual validation |
| Average time to create asset | N/A | <60 seconds | User testing |
| Maintenance reminder accuracy | N/A | 100% | Functional testing |
