## Functional Requirements

### Requirement Table

| ID | Requirement | Priority | Rationale | Depends On |
|------|------|------|------|------|
| FR-001 | User shall create an asset record. | High | Core functionality | - |
| FR-002 | User shall edit an asset record. | High | Asset maintenance | FR-001 |
| FR-003 | User shall delete an asset record. | High | Data management | FR-001 |
| FR-004 | User shall archive an asset record. | Medium | Preserve history | FR-001 |
| FR-005 | User shall assign an asset to a category. | High | Organization | FR-001 |
| FR-006 | User shall create custom categories. | Medium | Flexibility | FR-005 |
| FR-007 | User shall assign an asset to a room/location. | High | Asset tracking | FR-001 |
| FR-008 | User shall manage room/location records. | Medium | Inventory organization | FR-007 |
| FR-009 | User shall upload one or more photos for an asset. | High | Asset identification | FR-001 |
| FR-010 | User shall attach receipt files to an asset. | Medium | Proof of purchase | FR-001 |
| FR-011 | User shall store purchase information. | High | Asset valuation | FR-001 |
| FR-012 | User shall store serial numbers. | High | Asset tracking | FR-001 |
| FR-013 | User shall store warranty information. | High | Warranty management | FR-001 |
| FR-014 | User shall record warranty expiration dates. | High | Reminder capability | FR-013 |
| FR-015 | User shall view assets with expiring warranties. | High | User awareness | FR-014 |
| FR-016 | User shall create maintenance records. | High | Maintenance tracking | FR-001 |
| FR-017 | User shall schedule maintenance activities. | High | Preventive maintenance | FR-016 |
| FR-018 | User shall record maintenance completion. | High | Maintenance history | FR-017 |
| FR-019 | User shall search assets by keyword. | High | Usability | FR-001 |
| FR-020 | User shall filter assets by category. | High | Discoverability | FR-005 |
| FR-021 | User shall filter assets by location. | High | Discoverability | FR-007 |
| FR-022 | User shall filter assets by warranty status. | Medium | Warranty analysis | FR-013 |
| FR-023 | User shall view dashboard statistics. | High | System overview | FR-001 |
| FR-024 | User shall view total inventory value. | Medium | Reporting | FR-011 |
| FR-025 | User shall view asset counts by category. | Medium | Reporting | FR-005 |
| FR-026 | User shall export inventory data to CSV. | Medium | Data portability | FR-001 |
| FR-027 | User shall import inventory data from CSV. | Medium | Data migration | FR-001 |
| FR-028 | User shall backup application data. | High | Data protection | FR-001 |
| FR-029 | User shall restore application data from backup. | High | Disaster recovery | FR-028 |
| FR-030 | User shall switch application language between zh-TW and en. | High | Localization support | - |
| FR-031 | User shall persist language preference across sessions. | Medium | User experience | FR-030 |
| FR-032 | User shall manage application settings. | Medium | Configuration management | - |
| FR-033 | User shall view recently added assets. | Medium | Productivity | FR-001 |
| FR-034 | User shall view upcoming maintenance tasks. | High | Maintenance planning | FR-017 |
| FR-035 | User shall generate inventory reports. | Medium | Reporting | FR-001 |

### Notes

- Keep each requirement atomic and testable.
- Avoid combining unrelated outcomes in one requirement.
- All user-facing text shall support both English (en) and Traditional Chinese (zh-TW).
