# Báo cáo Phân tích DLL: DashBoard.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | DashBoard |
| Assembly Title | DashBoard |
| Assembly Company | (rỗng) |
| Assembly Product | DashBoard |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | (rỗng) |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | d150fd95-68dc-4757-acf0-faf794d7f362 |
| ComVisible | false |

---

## Cấu trúc File

```
DashBoard.dll/
├── DashBoard.csproj              # Project file
├── app.ico                      # Application icon
├── Resources.resx                 # Resource file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── DashBoardDAO.cs          # DAO Interface
│   └── MsSqlDashBoardDAO.cs    # SQL Server DAO Implementation
├── My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   └── MySettingsProperty.cs
├── My.Resources/
│   └── Resources.cs              # Resource manager
├── asPanel.cs                  # Custom Panel control
├── asFlowPanel.cs              # Custom FlowLayoutPanel control
├── ResizeableControl.cs          # Resize/Move control handler
├── frmDashBoard.cs             # Main Dashboard Form
├── frmDashlet.cs               # Dashboard Widget Control
├── frmCreateDashlet.cs         # Create/Edit Widget Dialog
└── frmListFunction.cs          # Function List Dialog
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Configuration | Configuration management |
| System.Core | LINQ và extension methods |
| System.Windows.Forms.DataVisualization | Chart controls |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| Docking | Docking library cho forms |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `AsiaErp.Framework.Docking`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `System.Windows.Forms.DataVisualization.Charting`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

### Forms

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmDashBoard` | `DockContent` | Form Dashboard chính, container chứa các dashlet |
| `frmDashlet` | `UserControl` | Widget/component hiển thị dữ liệu trên dashboard |
| `frmCreateDashlet` | `frmAsiaRoot` | Dialog tạo/sửa dashlet |
| `frmListFunction` | `frmAsiaRoot` | Dialog quản lý danh sách chức năng |

### Custom Controls

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `asPanel` | `Panel` | Panel tùy chỉnh với DoubleBuffered |
| `asFlowPanel` | `FlowLayoutPanel` | FlowPanel tùy chỉnh với DoubleBuffered |
| `ResizeableControl` | - | Handler resize/move cho controls |

### Data Access

| Interface/Class | Mục đích |
|----------------|----------|
| `DashBoardDAO` | Interface định nghĩa các phương thức DAO |
| `MsSqlDashBoardDAO` | Implementation SQL Server cho DashBoardDAO |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Thêm mới màn hình con"
- "Làm tươi dữ liệu"
- "Sửa màn hình con"
- "Xóa màn hình con"
- "Sắp xếp chức năng"
- "Thêm chức năng"
- "Xóa chức năng"
- "Giãn dòng", "Thêm giãn dòng", "Xoá dãn dòng"
- "Định dạng màn hình con"
- "Bảng", "Đồ thị"

### Labels Form

- "Loại" - Phân loại dashlet (Dữ liệu tổng hợp / Chức năng thường dùng)
- "Chức năng" - Chọn chức năng từ danh sách
- "Định dạng" - Định dạng hiển thị (Bảng/Đồ thị)
- "Vị trí" - Vị trí đặt dashlet (Bên trái/Bên phải)
- "Tiêu đề" - Tiêu đề dashlet
- "Danh sách tham số" - Cấu hình tham số stored procedure

### Resource Keys (Localization)

- `#DASHBOARD_CONTEXTMENU_ADD_TEXT`
- `#DASHBOARD_CONTEXTMENU_REFRESH_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_EDIT_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_DELETE_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_SORTITEM_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_ADDITEM_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_DELETEITEM_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_ROWSTRETCH_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_ROWSTRETCHMORE_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_ROWSTRETCHLESS_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_FORMAT_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_FORMAT_TABLE_TEXT`
- `#DASHBOARD_DASHLET_CONTEXTMENU_FORMAT_CHART_TEXT`

---

## Mục đích sử dụng

**DashBoard.dll là module Dashboard Widget System** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý Dashboard
- Container chính (`frmDashBoard`) hiển thị các widget (dashlet) dạng dockable
- Hỗ trợ layout 2 cột (trái/phải) với khả năng resize
- Drag & drop để sắp xếp lại vị trí các dashlet

#### 2. Dashlet Types

| Loại | Mô tả |
|------|---------|
| `MENU` | Hiển thị danh sách chức năng thường dùng dạng LinkLabel |
| `TABLE` | Hiển thị dữ liệu dạng bảng (AsDataGridView) |
| `CHART` | Hiển thị dữ liệu dạng đồ thị (Chart control) |

#### 3. Tạo/Sửa Dashlet
- Chọn loại: Dữ liệu tổng hợp hoặc Chức năng thường dùng
- Chọn chức năng từ danh sách có quyền truy cập
- Cấu hình tham số cho stored procedure
- Đặt tiêu đề và vị trí

#### 4. Quản lý Menu Frequency
- Thêm/xóa chức năng vào dashlet
- Sắp xếp thứ tự chức năng (drag & drop)
- Giãn dòng để điều chỉnh khoảng cách

#### 5. Data Binding
- Kết nối SQL Server qua `DashBoardDAO`
- Thực thi stored procedure với tham số động
- Hỗ trợ tham số đặc biệt: `@PMA_CTY`, `@PUSERNAME`, `@PNAM`

### Đặc điểm kỹ thuật

- Sử dụng `ResizeableControl` để xử lý resize/move dashlet
- Lưu trữ vị trí, kích thước dashlet vào database
- Double buffering cho custom panels để giảm flickering
- Event-driven architecture giữa frmDashBoard và frmDashlet
- Tích hợp với `frmUpdRptChartResX` để cấu hình biểu đồ

### Database Operations

| Phương thức | Mục đích |
|---------------|----------|
| `GetDashForm()` | Lấy danh sách dashlet |
| `InsDashForm()` | Tạo dashlet mới |
| `UpdDashForm()` | Cập nhật dashlet |
| `DelDashForm()` | Xóa dashlet |
| `GetDashMenu()` | Lấy menu cho dashlet |
| `InsMenuFrequence()` | Thêm menu vào dashlet |
| `DelMenuFrequence()` | Xóa menu khỏi dashlet |
| `SortMenuFrequence()` | Sắp xếp menu |
| `ProcessSPDashBoard()` | Thực thi stored procedure |

---

## Kết luận

Đây là module Windows Forms cung cấp hệ thống Dashboard Widget cho phép người dùng tùy biến giao diện làm việc với các widget hiển thị dữ liệu dạng bảng, đồ thị hoặc danh sách chức năng thường dùng. Module hỗ trợ drag-drop, resize và lưu trữ cấu hình người dùng vào database.

---

*Ngày phân tích: 2026-03-29*
