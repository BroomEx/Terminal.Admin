Here is the aggregation_blocks.md file based on the previous description.

Markdown

# Screen Description: Aggregation Blocks

### 1. Left Sidebar Navigation
A vertical rail containing navigation elements.

* **Top Area:** [Excluded]
* **Primary Navigation Icons (Top to Bottom):**
    1.  **Lightning Bolt:** Inside a square container.
    2.  **Speedometer/Gauge:** (Currently active/selected) Circular dial style.
    3.  **Rosette/Award Badge:** Ribbon shape.
    4.  **Computer Monitor:** Desktop screen shape.
    5.  **Electrical Plug:** Two-prong plug shape.
    6.  **Calculator:** Standard calculator representation.
    7.  **Line Graph:** Pulse/heartbeat style line.
    8.  **Bug:** Insect/beetle shape.
    9.  **Calendar:** Square with a top binder bar.
* **Secondary Action Icons (Bottom):**
    1.  **Action Button 1:** Square containing a quotation mark or comma symbol.
    2.  **Action Button 2:** Identical to the above.
    3.  **Settings:** Gear/cogwheel icon.

---

### 2. Top Header Bar
A horizontal bar spanning the width of the screen.

* **Left Side:** Text label reading **"Aggregation blocks"**.
* **Right Side:** User profile avatar.

---

### 3. Main Content Area
The central workspace is divided into two distinct panels arranged vertically.

#### Panel A: Status & Configuration (Top)
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
| **Activated power mFRR5** | 0 | *(Merged with above)* |

#### Panel B: Manual Overrides Log (Bottom)
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