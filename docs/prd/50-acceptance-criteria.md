## Acceptance Criteria

### Functional Mapping

| Requirement ID | Acceptance Criteria | Verification Type |
|------|------|------|
| FR-001 | AC-FR-001: Given user opens Add Asset screen, when valid required fields are entered and Save is clicked, then a new asset record is stored and visible in inventory list. | Test |
| FR-002 | AC-FR-002: Given an existing asset, when user modifies fields and saves, then updated values are persisted. | Test |
| FR-003 | AC-FR-003: Given an existing asset, when Delete is confirmed, then asset is removed from active inventory. | Test |
| FR-009 | AC-FR-009: Given a valid image file, when uploaded, then image appears in asset details. | Test |
| FR-013 | AC-FR-013: Given warranty information is entered, when user saves, then warranty data is linked to the asset. | Test |
| FR-014 | AC-FR-014: Given warranty expiration date exists, when dashboard loads, then expiring warranties are listed. | Test |
| FR-017 | AC-FR-017: Given maintenance task data is entered, when saved, then new task appears in schedule list. | Test |
| FR-019 | AC-FR-019: Given assets exist, when a keyword is entered, then matching assets are returned. | Test |
| FR-023 | AC-FR-023: Given assets exist, when dashboard loads, then statistics are displayed correctly. | Test |
| FR-028 | AC-FR-028: Given valid destination folder, when backup runs, then backup file is generated successfully. | Test |
| FR-029 | AC-FR-029: Given valid backup file, when restore runs, then database contents are restored successfully. | Test |
| FR-030 | AC-FR-030: Given language setting is changed, when UI reloads, then all supported screens display selected language. | Demo |
| FR-031 | AC-FR-031: Given language preference was saved, when application restarts, then selected language remains active. | Test |
| FR-035 | AC-FR-035: Given inventory data exists, when report generation starts, then report is produced successfully. | Demo |

### Non-Functional Mapping

| Requirement ID | Acceptance Criteria | Verification Type |
|------|------|------|
| NFR-001 | Application starts within 3 seconds on target hardware. | Benchmark |
| NFR-002 | Asset search returns results within 500ms for 10,000 assets. | Benchmark |
| NFR-003 | Database files are accessible only by local user permissions. | Security Review |
| NFR-005 | No committed data is lost after unexpected application termination. | Recovery Test |
| NFR-006 | Backup and restore complete successfully in 100% of automated test runs. | Automated Test |
| NFR-009 | All user-facing UI strings support both zh-TW and English. | Localization Review |
| NFR-010 | Major workflows can be completed using keyboard navigation. | Accessibility Test |
| NFR-012 | Business logic test coverage is at least 70%. | CI Validation |
| NFR-014 | System supports at least 100,000 asset records. | Load Test |

---

## MVP Release Gate

### Functional

- All High-priority Functional Requirements accepted.
- No blocker defects remain.
- Add Asset flow passes.
- Search Asset flow passes.
- Warranty Management flow passes.
- Maintenance flow passes.
- Backup and Restore flow passes.
- Localization flow passes.

### Non-Functional

- Startup < 3 seconds.
- Search < 500 ms.
- 100% localization coverage.
- Backup and restore validated.
- Offline functionality validated.

### Quality

- All critical defects resolved.
- Automated test suite passing.
- No open security blockers.

### Localization Gate

- English language fully supported.
- Traditional Chinese (zh-TW) fully supported.
- Language switching verified.
- Mixed-language UI defects = 0.
