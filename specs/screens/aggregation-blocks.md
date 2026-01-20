# Screen Aggregation block
## Panel A: Status & Configuration (Top)
- Component: [Panel.md](components/panel.md)

A data grid displaying operational parameters for two distinct blocks.

* **Action Button:** "Operation plan update" (Top left of panel).
* **Column Headers:** "TEDOM AB1" and "TEDOM AB2".

**Data Rows:**

| Parameter | TEDOM AB1 Value | TEDOM AB2 Value |
| :--- | :--- | :--- |
| **Remote control** | Toggle Switch (Enabled) | Toggle Switch (Enabled) |
| **External source for operation plans** | Toggle Switch (Disabled) | Toggle Switch (Enabled) |
| **AB switch** | Checkbox (Unchecked) | Checkbox (Unchecked) |
| **Current power [MW]** | 0 | 0 |
| **Pdg trend [MW]** | 0 | 0 |
| **Baseline** | Not supported | Not supported |
| **Afrr offer aFRR+ / aFRR- [MW]** | 0 / 0 | 0 / 0 |
| **Activated power aFRR [MW]** | 0 | 0 |
| **Offer mFRR+ [MW]** | 0 | 0 |
| **Activated power DA/SA [MW]** | 0 / 0 | 0 / 0 |
| **Offer mFRR- [MW]** | 0 | 0 |
| **Activated power DA/SA [MW]** | 0 / 0 | 0 / 0 |
| **Offer mFRR5 [MW]** | 0 | Not supported |
| **Activated power mFRR5** | 0 | 0 |

## Panel B: Manual Overrides Log (Bottom)
- Component: [Panel.md](components/panel.md)

A log table tracking user actions and system updates.

* **Header Title:** "Manual overrides log".
* **Controls:**
    * **Search Bar:** Located on the left ("Search...").
    * **Action Button:** "Refresh log" located on the right.

**Data Table:**

| TIMESTAMP (Sortable) | USER | AGGREGATION BLOCK | LOGTYPE | MESSAGE |
| :--- | :--- | :--- | :--- | :--- |
| 20.01.2026 11:38 | admin admin | *(Empty)* | User logged in | *(Empty)* |
| 19.01.2026 08:04 | admin admin | TEDOM AB1 | Operation plan has been manually updated | [Detail] Button |
| 19.01.2026 08:04 | admin admin | TEDOM AB1 | Operation plan has been manually updated | [Detail] Button |
| 19.01.2026 08:04 | admin admin | TEDOM AB1 | Operation plan has been manually updated | [Detail] Button |
| 18.01.2026 04:00 | admin admin | *(Empty)* | User logged in | *(Empty)* |

* **Pagination Controls (Bottom Right):**
    * **Total Count:** "Total: 1085".
    * **Navigation:** `<<` `<` `1` `2` `3` `4` `5` `>` `>>`.
    * **Rows Per Page:** Dropdown menu set to "5".