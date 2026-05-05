# DashBoard.dll - Tài liệu phân tích

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | DashBoard |
| Loại file | .NET Class Library (DLL) - Windows Forms |
| Framework | .NET Framework 3.5 |
| Version | 1.0.0.0 |
| Copyright | 2012 |
| GUID | d150fd95-68dc-4757-acf0-faf794d7f362 |
| AllowUnsafeBlocks | True |

**Mục đích:** Module Dashboard Widget cho hệ thống Asia ERP. Cung cấp giao diện dashboard với các widget (dashlet) có thể tùy biến: hiển thị dữ liệu dạng bảng, đồ thị, hoặc danh sách chức năng thường dùng. Hỗ trợ drag-drop, resize, và lưu cấu hình vào database.

---

## Cấu trúc thư mục

```
DashBoard.dll/
├── AsiaErp.DataAccess/
│   ├── DashBoardDAO.cs           # Interface định nghĩa data access methods
│   └── MsSqlDashBoardDAO.cs      # SQL Server implementation
├── My/                           # VB.NET My namespace boilerplate
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   └── MySettingsProperty.cs
├── My.Resources/
│   └── Resources.cs              # ResourceManager (imgCancel, save)
├── asPanel.cs                    # Custom Panel (DoubleBuffered)
├── asFlowPanel.cs                # Custom FlowLayoutPanel (DoubleBuffered)
├── ResizeableControl.cs           # Handler resize/move cho controls
├── frmDashBoard.cs               # Main Dashboard Form (DockContent)
├── frmDashlet.cs                 # Dashboard Widget UserControl
├── frmCreateDashlet.cs           # Dialog tạo/sửa dashlet
├── frmListFunction.cs            # Dialog danh sách chức năng
└── Properties/
    └── AssemblyInfo.cs
```

---

## Forms

### 1. frmDashBoard

**Kế thừa:** `DockContent` (từ AsiaErp.Framework.Docking)

Form container chính của dashboard, chứa các dashlet và quản lý layout.

**Static Properties:**

| Property | Type | Giá trị mặc định | Mô tả |
|----------|------|------------------|-------|
| `iMdX` | `int` | `400` | Midpoint X (chia đôi width) |
| `bLoading` | `bool` | `true` | Flag đang load dữ liệu |
| `mWidth` | `int` | - | Width của form |
| `mHeight` | `int` | - | Height của form |
| `dWidth` | `int` | - | Dashlet width tính toán |
| `dHeight` | `int` | - | Dashlet height tính toán |
| `maxLWidth` | `int` | - | Max width cột trái |
| `maxRWidth` | `int` | - | Max width cột phải |
| `cSpace` | `int` | `30` | Column spacing (giữa 2 cột) |
| `lSpace` | `int` | `15` | Left/top spacing |

**Instance Fields:**

| Field | Type | Mô tả |
|-------|------|-------|
| `panel` | `asPanel` | Container panel chứa tất cả dashlet |
| `RightMenu` | `ContextMenuStrip` | Context menu (Thêm mới, Làm tươi) |
| `mnuThem_moi` | `ToolStripMenuItem` | Menu item "Thêm mới màn hình con" |
| `mnuLam_tuoi` | `ToolStripMenuItem` | Menu item "Làm tươi dữ liệu" |
| `DashletInfo` | `DataTable` | Bảng thông tin tất cả dashlet |
| `MyDockPanel` | `DockPanel` | Dock panel reference |
| `imgListDetail` | `ImageList` | Icon cho dashlet menu items |
| `frmCreateDashlet` | `frmCreateDashlet` | Reference form tạo dashlet |
| `dlTarget` | `frmDashlet` | Dashlet đích khi drag-drop |
| `dlLocation` | `int` | Vị trí cột (1=trái, 2=phải) |

**Key Methods:**

| Method | Mô tả |
|--------|-------|
| `LoadDashletForm()` | Load tất cả dashlet từ DB, tạo UI |
| `AddDashletForm(int DashID)` | Thêm 1 dashlet vào panel |
| `MovDashletForm()` | Re-layout tất cả dashlet sau khi thay đổi |
| `MoveInitDashlet()` | Xử lý logic di chuyển dashlet (drag) |
| `FinishMove()` | Lưu vị trí mới vào DB sau khi drop |
| `ResizeInitDashlet()` | Xử lý logic resize dashlet |
| `FinishResize()` | Lưu kích thước mới vào DB |
| `GetWidth(int location)` | Tính width cho location 0/1/2 |
| `GetMaxDashPoint()` | Lấy max Y point từ DB cho mỗi cột |
| `GetDataBySp()` | Execute stored procedure với params |
| `RefreshDash_Click()` | Handler reload dashlets |
| `InsertDash_Click()` | Handler mở dialog tạo dashlet mới |

**Layout Logic:**
- 2 cột: Trái (location=1) và Phải (location=2), hoặc Span cả 2 (location=0)
- Dashlet có thể drag giữa các cột, tự động rearrange
- Resize theo cạnh → auto-switch location dựa trên width

---

### 2. frmDashlet

**Kế thừa:** `UserControl`

Widget hiển thị trên dashboard. Hỗ trợ 3 loại format: **MENU**, **TABLE**, **CHART**.

**Events:**

| Event | Delegate | Mô tả |
|-------|----------|-------|
| `AddNewMenu_Click` | `AddNewMenu_ClickEventHandler` | Thêm menu item |
| `DeleteMenu_Click` | `DeleteMenu_ClickEventHandler` | Xóa menu item |
| `UpdateDash_Click` | `UpdateDash_ClickEventHandler` | Cập nhật dashlet |
| `MoveDashlet` | `MoveDashletEventHandler` | Đang di chuyển |
| `ResizeDashlet` | `ResizeDashletEventHandler` | Đang resize |
| `FinishMoveDashlet` | `FinishMoveDashletEventHandler` | Kết thúc di chuyển |
| `FinishResizeDashlet` | `FinishResizeDashletEventHandler` | Kết thúc resize |

**Fields:**

| Field | Type | Mô tả |
|-------|------|-------|
| `f_Row` | `DataRow` | DataRow chứa thông tin dashlet (DashID, Title, Format, Location, X, Y, H, W, Type, spName) |
| `oDtData` | `DataTable` | Dữ liệu từ stored procedure |
| `ImgListDetail` | `ImageList` | Icon cho menu items |
| `rcT` | `ResizeableControl` | Handler di chuyển (gắn trên lblTitle) |
| `rcF` | `ResizeableControl` | Handler resize (gắn trên UserControl) |
| `spacing` | `int` | `15` - khoảng cách giãn dòng |

**Controls:**

| Control | Type | Tên biến | Mô tả |
|---------|------|----------|-------|
| Label | `Label` | `lblTitle` | Tiêu đề dashlet (cũng là drag handle) |
| Panel | `Panel` | `aPanel` | Panel chứa nội dung (table/chart/menu) |
| DataGridView | `AsDataGridView` | `adgvTable` | Hiển thị dữ liệu dạng bảng |
| Chart | `Chart` | `myChart` | Hiển thị đồ thị |
| ContextMenuStrip | `ContextMenuStrip` | `mnsPopup` | Popup menu cho dashlet |

**Menu Items (mnsPopup):**

| Item | Tên biến | Text | Mô tả |
|------|----------|------|-------|
| Sửa | `mnSua_Dashlet` | "Sửa màn hình con" | Mở dialog sửa dashlet |
| Xóa | `mnXoa_Dashlet` | "Xóa màn hình con" | Xóa dashlet |
| Sắp xếp | `mnSap_xep` | "Sắp xếp chức năng" | Mở dialog sắp xếp menu |
| Thêm | `mnThem_Menu` | "Thêm chức năng" | Thêm function vào dashlet |
| Xóa menu | `mnXoa_Menu` | "Xóa chức năng" | Xóa function khỏi dashlet |
| Giãn dòng | `mnGian_dong` | "Giãn dòng" | Submenu: Thêm/Xóa giãn dòng |
| Định dạng | `mnDinh_dang` | "Định dạng màn hình con" | Submenu: Bảng/Đồ thị |

**Dashlet Types (Format):**

| Format | Control | Mô tả |
|--------|---------|-------|
| `MENU` | LinkLabel list | Danh sách chức năng dạng link, click để mở form |
| `TABLE` | `AsDataGridView` | Hiển thị dữ liệu từ stored procedure |
| `CHART` | `Chart` / `ctlReportChart` | Hiển thị đồ thị |

**Key Methods:**

| Method | Mô tả |
|--------|-------|
| `LoadData()` | Load dữ liệu từ SP, render theo format |
| `CreateLinkData()` | Render MENU type (LinkLabel per row) |
| `CreateTableData()` | Render TABLE type (AsDataGridView) |
| `CreateChartData()` | Render CHART type (ctlReportChart) |
| `GetDataBySp()` | Execute SP với tham số, xử lý @PMA_CTY đặc biệt |
| `ExecuteCommand()` | Mở form từ menu click (reflection từ DLL) |
| `CallMyForm()` | Dynamic load form từ DLL bằng `Assembly.Load` + `InvokeMember` |
| `ReportGridviewBrowseDynamic()` | Tạo DataGridView columns tự động từ DataTable schema |
| `EnablePopupMenu()` | Ẩn/hiện menu items theo format |

---

### 3. frmCreateDashlet

**Kế thừa:** `frmAsiaRoot`

Dialog tạo mới hoặc chỉnh sửa dashlet.

**Constructor:**

| Parameter | Type | Mô tả |
|-----------|------|-------|
| `EditMode` | `bool` | `false` = tạo mới, `true` = sửa |
| `f_DashID` | `int` | DashID (chỉ dùng khi EditMode=true) |

**Constants:**

| Constant | Value | Mô tả |
|----------|-------|-------|
| `MENU_TYPE` | `"MENU"` | Loại dữ liệu tổng hợp |
| `TABLE_TYPE` | `"TABLE"` | Hiển thị dạng bảng |
| `CHART_TYPE` | `"CHART"` | Hiển thị dạng đồ thị |

**Controls:**

| Control | Type | Tên biến | Mô tả |
|---------|------|----------|-------|
| ComboBox | `ComboBox` | `cboLoai` | Loại: "Dữ liệu tổng hợp" / "Chức năng thường dùng" |
| AsComboBox | `AsComboBox` | `cboChuc_nang` | Chọn chức năng (lấy từ quyền user) |
| TextBox | `TextBox` | `txtTitle` | Tiêu đề dashlet |
| RadioButton | `RadioButton` | `rdbTable` | Định dạng Bảng |
| RadioButton | `RadioButton` | `rdbChart` | Định dạng Đồ thị |
| ComboBox | `ComboBox` | `cboVi_tri` | Vị trí: "Bên trái" / "Bên phải" |
| AsInputDGV | `AsInputDGV` | `adgvParameter` | Grid nhập tham số cho SP |
| Button | `Button` | `btnSave` | Lưu ("&Nhận") |
| Button | `Button` | `btnExit` | Hủy ("&Huỷ") |

**Columns trong adgvParameter:**

| Column | DataPropertyName | HeaderText | Width |
|--------|-----------------|------------|-------|
| `dgvcDescription` | `Description` | Mô tả | 350 |
| `dgvcParaname` | `PARAMETER_NAME` | Tham số | hidden |
| `dgvcParavalue` | `paravalue` | Giá trị | 139 |
| `dgvcMaxLength` | `CHARACTER_MAXIMUM_LENGTH` | Column1 | hidden |
| `dgvcDataType` | `DATA_TYPE` | Column1 | hidden |

**Key Methods:**

| Method | Mô tả |
|--------|-------|
| `InitComboSource()` | Khởi tạo data source cho các combo box |
| `LoadCombo(string sType)` | Load chức năng theo loại (Type=1: menu, Type=2: function) |
| `GetSpName(string FunctionID)` | Lấy tên stored procedure từ function |
| `GetParameter(bool Exist)` | Lấy tham số của SP, hiển thị lên grid |
| `GetDataBySp()` | Execute SP để preview kết quả |
| `InsDashlet()` | Tạo dashlet mới vào DB |
| `UpdDashlet()` | Cập nhật dashlet trong DB |
| `InsParameter()` | Lưu tham số SP vào DB |
| `UpdateChartDashlet()` | Cập nhật cấu hình chart |

**Tham số đặc biệt auto-fill:**

| Parameter | Giá trị |
|-----------|---------|
| `@PMA_CTY` | `CompanyInformations.CompanyID` |
| `@PUSERNAME` | `SystemInformations.UserName` |
| `@PNAM` | `SystemInformations.FinancialYear` |
| `@PDASHID` | (để trống) |

---

### 4. frmListFunction

**Kế thừa:** `frmAsiaRoot`

Dialog hiển thị danh sách chức năng, hỗ trợ thêm/xóa/sắp xếp (drag-drop).

**Fields:**

| Field | Type | Mô tả |
|-------|------|-------|
| `f_Type` | `int` | 1=Thêm, 2=Xóa, 3=Sắp xếp |
| `f_DashID` | `int` | DashID hiện tại |
| `f_StoreProcedure` | `string` | Stored procedure name |
| `Data` | `DataTable` | Dữ liệu danh sách chức năng |

**Events:**

| Event | Delegate | Mô tả |
|-------|----------|-------|
| `LabelSort_Click` | `LabelSort_ClickEventHandler` | Sau khi sắp xếp xong |
| `LabelAdd_Click` | `LabelAdd_ClickEventHandler` | Sau khi thêm chức năng |
| `LabelRemove_Click` | `LabelRemove_ClickEventHandler` | Sau khi xóa chức năng |

**Key Methods:**

| Method | Mô tả |
|--------|-------|
| `LoadData()` | Load dữ liệu theo f_Type |
| `CreateLinkMenu()` | Tạo LinkLabel list với phân cấp (level 1/2/3) |
| `CreateLabelSort()` | Tạo LinkLabel list với drag-drop enabled |
| `Mouse_Down()` | Bắt đầu drag |
| `Drag_Enter()` | Highlight target khi drag over |
| `Drag_Drop()` | Xử lý drop → gọi `SortMenuFrequence` trong DB |
| `DetailLink_MouseCLick()` | Click để add/remove function |

**Menu levels:**

| Level | Font | Color | Indent |
|-------|------|-------|--------|
| 1 (Module) | 13pt Bold | Blue | 0px |
| 2 (Sub-menu) | 12pt Bold | DarkGreen | 30px |
| 3 (Detail) | 10pt Regular | Black + icon | 60px |

---

## Custom Controls

### asPanel

**Kế thừa:** `Panel`

Panel tùy chỉnh với property `DoubleBuffered` public để giảm flickering.

| Property | Type | Default | Mô tả |
|----------|------|---------|-------|
| `DoubleBuffered` | `bool` | `true` | Bật/tắt double buffering |

---

### asFlowPanel

**Kế thừa:** `FlowLayoutPanel`

FlowLayoutPanel tùy chỉnh với property `DoubleBuffered` public.

| Property | Type | Default | Mô tả |
|----------|------|---------|-------|
| `DoubleBuffered` | `bool` | `true` | Bật/tắt double buffering |

---

### ResizeableControl

**Namespace:** Global (không có namespace)

Handler cho việc resize và di chuyển controls. Gắn lên control cần resize/move.

**Enum `CursorStatusEnum`:**

| Value | Name | Cursor | Mô tả |
|-------|------|--------|-------|
| 0 | `None` | Default | Không ở edge nào |
| 1 | `Right` | SizeWE | Edge phải |
| 2 | `Left` | SizeWE | Edge trái |
| 3 | `Top` | SizeNS | Edge trên |
| 4 | `Bottom` | SizeNS | Edge dưới |
| 5 | `TopLeft` | SizeAll | Góc trên-trái |
| 6 | `BottomLeft` | SizeNESW | Góc dưới-trái |
| 7 | `BottomRight` | SizeNWSE | Góc dưới-phải |

**Constructor:**

| Parameter | Type | Default | Mô tả |
|-----------|------|---------|-------|
| `Control` | `Control` | - | Control cần xử lý |
| `OnlyMove` | `bool` | `false` | Nếu true → chỉ cho di chuyển, không resize |

**Constraints:**

| Constraint | Value | Mô tả |
|------------|-------|-------|
| `minHeight` | `30` | Chiều cao tối thiểu |
| `minWidth` | `200` | Chiều rộng tối thiểu |
| `minX` | `10` | Vị trí X tối thiểu |
| `minY` | `10` | Vị trí Y tối thiểu |
| `mWidth` | `10` | Edge detection zone (pixels) |

**Methods:**

| Method | Return | Mô tả |
|--------|--------|-------|
| `GetLocation(int type)` | `Point` | type=1: form position, type=2: mouse position |
| `GetCursorStatusEnum()` | `int` | Trả về CursorStatusEnum hiện tại |
| `GetMouseStyle()` | `bool` | Trả về isLeft (left mouse button) |

---

## Data Access Layer

### DashBoardDAO (Interface)

**Namespace:** `AsiaErp.DataAccess` | **Kế thừa:** `AsiaErp.Framework.DAO`

| Method | Return | Mô tả |
|--------|--------|-------|
| `GetParameter(string spName)` | `DataTable` | Lấy thông tin tham số của stored procedure |
| `GetValueParameter(int DashID)` | `DataTable` | Lấy giá trị tham số đã lưu của dashlet |
| `InsValueParameter(int DashID, int Stt, string ParaName, string ParaValue)` | `int` | Lưu giá trị tham số |
| `DelValueParameter(int DashID)` | `int` | Xóa giá trị tham số |
| `GetMaxDashID()` | `int` | Lấy DashID lớn nhất |
| `GetDashletType()` | `DataTable` | Lấy danh sách loại dashlet |
| `GetDashMenu(int DashID)` | `DataTable` | Lấy menu functions cho dashlet |
| `GetDashFunction(string FunctionID)` | `DataTable` | Lấy thông tin function (spName, dllName) |
| `GetDashRight()` | `DataTable` | Lấy chức năng user có quyền truy cập |
| `SortMenuFrequence(string MenuIdSource, int SttTarget, int DashID)` | `int` | Sắp xếp lại thứ tự menu |
| `GetMenuFrequence(int DashId, bool Space)` | `DataTable` | Lấy danh sách menu đã add vào dashlet |
| `InsMenuFrequence(string MenuId, int DashId)` | `int` | Thêm menu vào dashlet |
| `UpdMenuFrequence(string MenuId, int DashId, bool Space)` | `int` | Cập nhật menu (giãn dòng) |
| `DelMenuFrequence(string MenuId, int DashId)` | `int` | Xóa menu khỏi dashlet |
| `GetMaxDashPoint(int Location)` | `DataTable` | Lấy max Y point của mỗi cột |
| `ProcessSPDashBoard(params object[] para)` | `DataTable` | Execute stored procedure với tham số động |
| `GetDashForm(string DashID)` | `DataTable` | Lấy danh sách dashlet (tất cả hoặc theo ID) |
| `InsDashForm(Title, Location, Format, FunctionId, X, Y, H, W, Type, ref DashID)` | `int` | Tạo dashlet mới |
| `UpdDashForm(Location, Format, Title, DashId, X, Y, H, W, IsMenu)` | `int` | Cập nhật dashlet |
| `DelDashForm(string DashId)` | `int` | Xóa dashlet |
| `UpdDashLocation(DashIdSrc, LocationTar, XTar, YTar, HSrc, WSrc)` | `int` | Cập nhật vị trí/kích thước |

---

### MsSqlDashBoardDAO

**Namespace:** `AsiaErp.DataAccess` | **Kế thừa:** `MsSqlDAO`, implements `DashBoardDAO`

SQL Server implementation của `DashBoardDAO`. Sử dụng stored procedures:

| Stored Procedure | DAO Method |
|-----------------|------------|
| `asDashGetParameter` | `GetParameter()` |
| `asGetDashParameter` | `GetValueParameter()` |
| `asInsDashParameter` | `InsValueParameter()` |
| `asDelDashParameter` | `DelValueParameter()` |
| `asGetMaxDashID` | `GetMaxDashID()` |
| `asGetDashletType` | `GetDashletType()` |
| `asGetDashMenu` | `GetDashMenu()` |
| `asGetDashFunction` | `GetDashFunction()` |
| `asGetDashRight` | `GetDashRight()` |
| `asSortDashFrequentlyFunction` | `SortMenuFrequence()` |
| `asGetDashFrequentlyFunction` | `GetMenuFrequence()` |
| `asInsDashFrequentlyFunction` | `InsMenuFrequence()` |
| `asUpdDashFrequentlyFunction` | `UpdMenuFrequence()` |
| `asDelDashFrequentlyFunction` | `DelMenuFrequence()` |
| `asGetMaxDashPoint` | `GetMaxDashPoint()` |
| `asGetDashForm` | `GetDashForm()` |
| `asInsDashForm` | `InsDashForm()` |
| `asUpdDashForm` | `UpdDashForm()` |
| `asDelDashForm` | `DelDashForm()` |
| `asUpdDashLocation` | `UpdDashLocation()` |

**Đặc điểm:**
- Tất cả methods đều truyền `SystemInformations.UserName` làm tham số `@pUserName`
- Methods có output parameter `@pRet` để trả về status code (0 = success)
- `ProcessSPDashBoard()` nhận params dạng key-value pairs: `para[0]`=SP name, `para[1]`="@param1", `para[2]`=value1, ...

---

## Resources

**Namespace:** `My.Resources`

| Resource | Type | Mô tả |
|----------|------|-------|
| `imgCancel` | `Bitmap` | Icon cho nút Hủy |
| `save` | `Bitmap` | Icon cho nút Lưu |

---

## External Dependencies

| Assembly | Mục đích |
|----------|----------|
| `Microsoft.VisualBasic` | VB.NET runtime |
| `System.Data` | DataTable, ADO.NET |
| `System.Data.SqlClient` | SQL Server connection |
| `System.Configuration` | ConfigurationManager.AppSettings |
| `System.Windows.Forms.DataVisualization` | Chart controls |
| `AsiaErp.Framework` | Base classes (DAO, frmAsiaRoot, Commons, etc.) |
| `AsiaErp.Framework.Docking` | DockContent, DockPanel, DockState |
| `AsiaErp.Helper` | Helper utilities |

---

## Luồng hoạt động

```
┌─────────────────────────────────────────────────────────────────┐
│                    DASHBOARD WORKFLOW                            │
├─────────────────────────────────────────────────────────────────┤
│                                                                  │
│  1. INIT                                                         │
│     ├─ frmDashBoard.LoadDashletForm()                            │
│     ├─ DAO.GetDashForm() → danh sách dashlet                     │
│     └─ AddDashletForm() cho mỗi row                              │
│                                                                  │
│  2. CREATE NEW DASHLET                                           │
│     ├─ ContextMenu → "Thêm mới" → frmCreateDashlet(EditMode=false)│
│     ├─ Chọn loại (Dữ liệu tổng hợp / Chức năng thường dùng)      │
│     ├─ Nếu "Chức năng thường dùng":                              │
│     │   ├─ Chọn function từ cboChuc_nang                         │
│     │   ├─ GetParameter() → lấy params của SP                    │
│     │   ├─ Nhập giá trị params trên adgvParameter                │
│     │   └─ Chọn định dạng: Bảng hoặc Đồ thị                      │
│     ├─ Nếu "Dữ liệu tổng hợp":                                   │
│     │   └─ Chỉ cần tiêu đề                                       │
│     ├─ btnSave → DAO.InsDashForm() + DAO.InsValueParameter()     │
│     └─ f_IsEdit = true → frmDashBoard.AddDashletForm()           │
│                                                                  │
│  3. DISPLAY DASHLET                                              │
│     ├─ frmDashlet.LoadData()                                     │
│     ├─ Nếu spName = "" → gọi asGetDashFrequentlyFunction         │
│     ├─ Nếu có spName → GetDataBySp() với params                  │
│     ├─ Format = "MENU" → CreateLinkData() (LinkLabel list)       │
│     ├─ Format = "TABLE" → CreateTableData() (AsDataGridView)     │
│     └─ Format = "CHART" → CreateChartData() (ctlReportChart)     │
│                                                                  │
│  4. MENU CLICK (trong MENU dashlet)                              │
│     ├─ Right-click → ExecuteCommand()                            │
│     ├─ Check quyền: Commons.ChkExecRight(menuId)                 │
│     ├─ Nếu form = "1" → CallMyForm()                             │
│     │   ├─ Assembly.Load(dllName)                                │
│     │   ├─ type.InvokeMember() → tạo form                        │
│     │   └─ frmAsiaRoot.Show(dockPanel, DockState.Document)       │
│     └─ Nếu form đã mở → BringToFront()                           │
│                                                                  │
│  5. DRAG-DROP REARRANGE                                          │
│     ├─ MouseDown trên lblTitle → bắt đầu drag                    │
│     ├─ MouseMove → MoveInitDashlet() tính toán vị trí mới        │
│     ├─ MouseUp → FinishMove() → DAO.UpdDashLocation()            │
│     └─ Layout tự động điều chỉnh các dashlet còn lại             │
│                                                                  │
│  6. RESIZE                                                       │
│     ├─ MouseDrag trên cạnh → ResizeInitDashlet()                 │
│     ├─ Auto-switch location nếu width vượt threshold             │
│     ├─ MouseUp → FinishResize() → DAO.UpdDashLocation()          │
│     └─ Layout tự động điều chỉnh                                 │
│                                                                  │
│  7. MANAGE MENU FREQUENCIES                                      │
│     ├─ "Sắp xếp chức năng" → frmListFunction(Type=3)             │
│     │   └─ Drag-drop để sắp xếp → SortMenuFrequence()            │
│     ├─ "Thêm chức năng" → frmListFunction(Type=1)                │
│     │   └─ Click function → LabelAdd_Click → InsMenuFrequence()  │
│     └─ "Xóa chức năng" → frmListFunction(Type=2)                 │
│         └─ Click function → LabelRemove_Click → DelMenuFrequence()│
│                                                                  │
└─────────────────────────────────────────────────────────────────┘
```
