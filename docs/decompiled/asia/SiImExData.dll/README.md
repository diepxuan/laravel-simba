# Báo cáo Phân tích DLL: SiImExData.dll

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
| Assembly Name | SiImExData |
| Assembly Title | Chuyển số liệu vào sổ cái |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly File Version | 1.0.0.0 |
| GUID | 1165f1d1-a507-4a9a-86f3-5d0ebc57f341 |
| ComVisible | false |

---

## Cấu trúc File

```
SiImExData.dll/
├── SiImExData.csproj                  # Project file
├── app.ico                            # Application icon
├── Properties/
│   └── AssemblyInfo.cs                # Assembly metadata
├── AsiaERP.DataAccess/
│   ├── ISiImExDataDAO.cs              # Data Access Interface
│   └── MsSqlSiImExDataDAO.cs          # SQL Server DAO Implementation
├── AsiaERP.UserInterface/
│   └── frmSiImExData.cs               # Main form class
├── My/
│   ├── MyApplication.cs               # Application settings
│   ├── MyComputer.cs                  # Computer info
│   ├── MySettings.cs                  # User settings
│   ├── MySettingsProperty.cs          # Settings property
│   └── MyProject.cs                   # Project helpers
└── My.Resources/
    └── Resources.cs                   # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML processing |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| System.Data | Data access |
| System.Core | Core functionality |
| Microsoft.Office.Interop.Excel | Excel interop for import/export |

### Namespaces sử dụng

- `AsiaERP.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Data.Common`, `System.Data.OleDb`
- `System.IO`, `System.Collections`, `System.Collections.Generic`
- `System.Threading`, `System.Globalization`
- `System.Windows.Forms`, `System.Drawing`
- `Microsoft.Office.Interop.Excel`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSiImExData` | `frmCalc` | Form chính cho chức năng Import/Export dữ liệu |
| `ISiImExDataDAO` | Interface | Interface cho data access operations |
| `MsSqlSiImExDataDAO` | - | Implementation cho SQL Server |

---

## Các trường dữ liệu chính

### Form frmSiImExData

#### Controls chính

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `rbImport` | RadioButton | Chọn chế độ nhập dữ liệu |
| `rbExport` | RadioButton | Chọn chế độ xuất dữ liệu |
| `txtPath` | TextBox | Đường dẫn file Excel |
| `btnOpen` | Button | Mở dialog chọn file/folder |
| `txtVersion` | TextBox | Hiển thị phiên bản |
| `txtWsId` | TextBox | Hiển thị mã trạm |
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Khoảng ngày chứng từ |
| `cboCreateDate` | ComboBox | Chọn kỳ tạo |
| `txtNgay3`, `txtNgay4` | AsMaskedTextBox | Khoảng ngày tạo |
| `dgvSoLieu` | AsDataGridView | Grid hiển thị danh sách chứng từ |
| `dgvDanhMuc` | AsDataGridView | Grid hiển thị danh sách danh mục |
| `chkCheckCTAll` | CheckBox | Chọn tất cả chứng từ |
| `chkDmAll` | CheckBox | Chọn tất cả danh mục |
| `ProgressBar1` | ProgressBar | Thanh tiến trình xử lý |

#### DataGridView Columns (dgvSoLieu)

| Column | DataProperty | Header |
|--------|--------------|--------|
| `dgvcTag` | Tag | Chọn |
| `DataGridViewTextBoxColumn1` | Code_Name | Mã CT |
| `DataGridViewTextBoxColumn3` | description | Diễn giải |
| `dgvcTable1` | table1 | Bảng dữ liệu 1 |
| `dgvcTable2` | table2 | Bảng dữ liệu 2 |

#### DataGridView Columns (dgvDanhMuc)

| Column | DataProperty | Header |
|--------|--------------|--------|
| `DataGridViewCheckBoxColumn1` | Tag | Chọn |
| `DataGridViewTextBoxColumn4` | description | Diễn giải |
| `DataGridViewTextBoxColumn2` | Code_Name | Mã |
| `DataGridViewTextBoxColumn5` | table1 | Bảng dữ liệu 1 |
| `DataGridViewTextBoxColumn6` | table2 | Bảng dữ liệu 2 |

---

## Mục đích sử dụng

**SiImExData.dll là module Import/Export dữ liệu** trong hệ thống ERP của Asia Software Development JSC, cho phép chuyển số liệu giữa các công ty hoặc sao lưu/phục hồi dữ liệu.

### Chức năng chính

#### 1. Export dữ liệu (Xuất khẩu)
- Chọn chứng từ và danh mục cần xuất
- Lọc theo kỳ báo cáo, khoảng ngày chứng từ, khoảng ngày tạo
- Xuất dữ liệu ra file Excel với định dạng: `v{version}_{companyID}_{wsId}_{date1}_{date2}.xls`
- Mỗi bảng dữ liệu được xuất ra một worksheet riêng
- Hỗ trợ xuất nhiều loại bảng: PH (phiếu), CT (chi tiết), CP (chi phí), TAIN (thuế vào), TAOUT (thuế ra), DM (danh mục)

#### 2. Import dữ liệu (Nhập khẩu)
- Nhập dữ liệu từ file Excel đã xuất
- Kiểm tra mã công ty, phiên bản, ws_id
- Hiển thị xác nhận trước khi import
- Import vào database với transaction
- Hỗ trợ import nhiều bảng dữ liệu cùng lúc

#### 3. Xử lý bất đồng bộ
- Sử dụng `Thread` để xử lý import/export nền
- Hiển thị progress bar trong quá trình xử lý
- Sử dụng `AutoResetEvent` để đồng bộ thread
- Cập nhật UI thông qua `Invoke`

### Quy trình Export

1. Người dùng chọn khoảng ngày chứng từ/danh mục
2. Chọn các bảng dữ liệu cần export (checkbox)
3. Chọn folder lưu file Excel
4. Hệ thống tạo file Excel với nhiều worksheets
5. Mỗi worksheet chứa dữ liệu của một bảng
6. Hiển thị tiến trình và thông báo hoàn thành

### Quy trình Import

1. Người dùng chọn file Excel cần import
2. Hệ thống kiểm tra tính hợp lệ (mã công ty, version)
3. Hiển thị thông tin xác nhận
4. Đọc dữ liệu từ Excel vào DataSet
5. Import vào database theo thứ tự
6. Hiển thị tiến trình và thông báo kết quả

### Đặc điểm kỹ thuật

- Sử dụng Microsoft Office Interop Excel để đọc/ghi file
- Định dạng file: `.xls` (Excel 8.0)
- Sử dụng OleDbConnection để đọc Excel
- Hỗ trợ đa thread với `Thread.Start()` và `Thread.Join()`
- DataBinding với DataTable và DataSet
- Filter dữ liệu với `RowFilter`
- Sử dụng DAO pattern cho data access

### Đặt tên file Export

```
v{version}_{companyID}_{wsId}_{startDate}_{endDate}.xls
Ví dụ: v9.1.0.0_CTY01_WS01_03-29-2026_03-29-2026.xls
```

---

## Kết luận

Đây là module quan trọng cho việc sao lưu, chuyển đổi dữ liệu giữa các công ty trong hệ thống ERP Asia. Module hỗ trợ export/import toàn bộ hoặc một phần dữ liệu chứng từ và danh mục ra file Excel, giúp việc di chuyển dữ liệu trở nên linh hoạt và an toàn.

---

*Ngày phân tích: 2026-03-29*
