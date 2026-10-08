## Non-Functional Requirements

### Quality Attributes

| ID | Attribute | Requirement | Target | Validation |
|------|------|------|------|------|
| NFR-001 | Performance | Application startup performance | <3 seconds | Automated performance test |
| NFR-002 | Performance | Asset search response | <500ms for 10,000 assets | Performance test |
| NFR-003 | Security | Local database protection | Database accessible only to local user account | Manual validation |
| NFR-004 | Security | Backup integrity | Prevent backup corruption | Backup/restore testing |
| NFR-005 | Reliability | Application crash recovery | No data loss after unexpected termination | Recovery testing |
| NFR-006 | Reliability | Backup success | 100% successful backup execution | Automated tests |
| NFR-007 | Usability | Asset creation workflow | New asset created within 60 seconds | User testing |
| NFR-008 | Usability | UI consistency | Consistent navigation across screens | UX review |
| NFR-009 | Localization | Language support | 100% of UI localized for zh-TW and en | Localization testing |
| NFR-010 | Accessibility | Keyboard navigation | All major screens keyboard accessible | Accessibility testing |
| NFR-011 | Maintainability | Architecture standard | MVVM architecture enforced | Code review |
| NFR-012 | Maintainability | Unit test coverage | ≥70% business logic coverage | CI validation |
| NFR-013 | Data Integrity | Transaction handling | No partial transaction commits | Integration testing |
| NFR-014 | Scalability | Asset capacity | Support 100,000 asset records | Load testing |
| NFR-015 | Storage | Attachment support | Support image and PDF attachments up to 20 MB each | Functional testing |

### Operational Constraints

- Observability:
  - Structured application logging.
  - Error logging for all unhandled exceptions.
  - Audit log for create/update/delete asset operations.

- Availability:
  - Fully functional without internet connectivity.
  - No external service dependency required for normal operation.

- Scalability:
  - Support up to 100,000 assets.
  - Support up to 500,000 maintenance records.
  - Support up to 50 GB attachment storage.

- Data retention:
  - Data retained until user deletion.
  - Backups retained according to user configuration.
  - Deleted assets moved to archive before permanent removal.
