## User Flows

### Completion Rules

- Each High-priority functional requirement must be covered by at least one flow.
- Each flow must map to acceptance criteria.
- Each flow must include at least one main path and one alternate or error path.

---

## Flow List

| ID | Flow Name | Primary Actor | Trigger | Outcome | FR Links | AC Links |
|------|------|------|------|------|------|------|
| UF-001 | Create Asset | Home User | User clicks Add Asset | Asset created | FR-001 | AC-FR-001 |
| UF-002 | Edit Asset | Home User | User opens asset details | Asset updated | FR-002 | AC-FR-002 |
| UF-003 | Search Asset | Home User | User enters keyword | Matching assets displayed | FR-019 | AC-FR-019 |
| UF-004 | Register Warranty | Home User | User adds warranty info | Warranty saved | FR-013, FR-014 | AC-FR-013 |
| UF-005 | Schedule Maintenance | Home User | User creates maintenance task | Task scheduled | FR-017 | AC-FR-017 |
| UF-006 | Backup Database | Home User | User starts backup | Backup file generated | FR-028 | AC-FR-028 |
| UF-007 | Restore Database | Home User | User selects backup file | Database restored | FR-029 | AC-FR-029 |
| UF-008 | Change Language | Home User | User changes language setting | UI switches language | FR-030, FR-031 | AC-FR-030 |

---

# UF-001 Create Asset

## Traceability

- Related functional requirements: FR-001
- Related acceptance criteria: AC-FR-001

## Preconditions

- Application is running.
- Database is available.

## Main Path

1. User clicks Add Asset.
2. System opens Asset Form.
3. User enters required data.
4. User clicks Save.
5. System validates inputs.
6. System creates asset record.
7. Asset appears in inventory list.

## Alternate Path

### A1: Optional Fields Omitted

Condition:

- User leaves optional fields blank.

Behavior:

- Asset can still be saved.

## Error Path

### E1: Missing Required Field

Condition:

- Asset Name is empty.

Behavior:

- Validation message displayed.
- Asset not saved.

## Postconditions

Success:

- New asset stored in database.

Failure:

- No asset created.

---

# UF-003 Search Asset

## Traceability

- Related functional requirements: FR-019
- Related acceptance criteria: AC-FR-019

## Preconditions

- At least one asset exists.

## Main Path

1. User enters keyword.
2. System performs search.
3. Matching assets displayed.
4. User selects asset.
5. Asset details displayed.

## Alternate Path

### A1: Filter By Category

Condition:

- User selects category filter.

Behavior:

- Results narrowed by category.

## Error Path

### E1: No Results Found

Condition:

- No matching asset exists.

Behavior:

- Empty-state screen displayed.

## Postconditions

Success:

- Matching results shown.

Failure:

- Empty state displayed.

---

# UF-004 Register Warranty

## Traceability

- Related functional requirements: FR-013, FR-014
- Related acceptance criteria: AC-FR-013

## Main Path

1. User opens asset.
2. User adds warranty information.
3. User enters expiration date.
4. User clicks Save.
5. Warranty record stored.

## Error Path

### E1: Invalid Expiration Date

Condition:

- User enters invalid date.

Behavior:

- Validation message displayed.

---

# UF-005 Schedule Maintenance

## Traceability

- Related functional requirements: FR-017

## Main Path

1. User opens asset.
2. User creates maintenance task.
3. User selects due date.
4. User saves task.
5. Task appears in schedule list.

## Error Path

### E1: Date Missing

Condition:

- Due date not selected.

Behavior:

- Save blocked.

---

# UF-006 Backup Database

## Traceability

- Related functional requirements: FR-028

## Main Path

1. User opens Settings.
2. User selects Backup Database.
3. User chooses destination folder.
4. System creates backup.
5. Success message displayed.

## Error Path

### E1: Destination Not Accessible

Condition:

- Folder permission denied.

Behavior:

- Backup cancelled.
- Error displayed.

---

# UF-008 Change Language

## Traceability

- Related functional requirements: FR-030, FR-031

## Main Path

1. User opens Settings.
2. User selects Language.
3. User chooses zh-TW or en.
4. System updates UI text.
5. Preference saved.

## Error Path

### E1: Language Resource Missing

Condition:

- Resource file unavailable.

Behavior:

- System falls back to default language.
