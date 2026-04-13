# Báo cáo Phân tích DLL: OptFieldSetup.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | OptFieldInfo |
| Assembly Title | Khai báo các trường tự do cho các chứng từ |
| Assembly Company | - |
| Assembly Product | OptFieldInfo |
| Assembly Copyright | Copyright © 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 9b304409-4ff6-4cbc-8537-d3c362024ff9 |
| ComVisible | false |

---

## Cấu trúc File

```
OptFieldSetup.dll/
├── OptFieldSetup.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmOptFieldSetup.cs      # Main form class
├── AsiaErp.DataAccess/
│   ├── FieldSetupDAO.cs         # DAO Interface
│   └── MsSqlFieldSetupDAO.cs    # SQL Server DAO Implementation
└── My/
    ├── MySettings.cs            # Application settings
    ├── MyApplication.cs         # Application context
    ├── MyComputer.cs            # Computer info
    ├── MyProject.cs             # Project info
    └── MySettingsProperty.cs    # Settings properties
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.Helper | Asia ERP Helper |
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmOptFieldSetup` | `frmAsiaRoot` | Form khai báo trường tự do cho chứng từ |
| `FieldSetupDAO` | `DAO` | Interface định nghĩa các phương thức truy xuất dữ liệu |
| `MsSqlFieldSetupDAO` | `MsSqlDAO` | Implementation SQL Server cho FieldSetupDAO |

---

## UI Components (frmOptFieldSetup)

### Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `cboChung_tu` | `AsComboBox` | Chọn loại chứng từ |
| `dgvOpt` | `AsDataGridView` | Grid hiển thị cấu hình trường tự do |
| `cmdOk` | `Button` | Lưu thay đổi |
| `cmdExit` | `Button` | Thoát form |
| `cmdSua` | `Button` | Chuyển sang chế độ sửa |
| `cmdHuy` | `Button` | Hủy thay đổi |
| `Label1` | `Label` | Nhãn "Chứng từ" |

### Cột DataGridView

| Cột | DataPropertyName | HeaderText | Loại | Mô tả |
|-----|------------------|------------|------|-------|
| Column5 | Stt | Stt | TextBox | Số thứ tự (ẩn) |
| Column8 | Caption | Tiêu đề | TextBox | Tiêu đề trường (chỉ đọc) |
| Column4 | Field | Tên trường | TextBox | Tên trường dữ liệu (chỉ đọc) |
| Column6 | descrpt | Column6 | TextBox | Diễn giải (ẩn) |
| Column7 | length | Column7 | TextBox | Độ dài (ẩn) |
| Column9 | LUser | Column9 | TextBox | Người dùng (ẩn) |
| Column1 | Voucher_code | Column1 | TextBox | Mã chứng từ (ẩn) |
| Column2 | Master | Thông tin chung | CheckBox | Hiển thị ở phần thông tin chung |
| Column3 | Detail | Chi tiết | CheckBox | Hiển thị ở phần chi tiết |

---

## Data Access Layer

### FieldSetupDAO Interface

| Phương thức | Tham số | Return | Mô tả |
|-------------|---------|--------|-------|
| `GetFieldSetup(pVoucher_code)` | pVoucher_code | `DataTable` | Lấy cấu hình trường tự do theo loại chứng từ |
| `GetFieldInfo()` | - | `DataTable` | Lấy thông tin các trường tự do |
| `GetCt(pMa_cty, pMa_ct)` | pMa_cty, pMa_ct | `DataTable` | Lấy danh mục chứng từ |
| `UpdFieldSetup(...)` | pVoucher_code, pField, pMaster, pDetail | `int` | Cập nhật cấu hình trường |
| `InsFieldSetup(...)` | pVoucher_code, pField, pMaster, pDetail | `int` | Thêm cấu hình trường |
| `DelFieldSetup(...)` | pVoucher_code, pField | `int` | Xóa cấu hình trường |

### Stored Procedures

| Procedure | Mục đích |
|-----------|----------|
| `asGetOptFieldInfo` | Lấy thông tin các trường tự do |
| `asGetOptFieldSetup` | Lấy cấu hình trường tự do theo loại chứng từ |
| `asSIGetDMCT` | Lấy danh mục chứng từ |
| `asUpdOptFieldSetup` | Cập nhật cấu hình trường tự do |
| `asInsOptFieldSetup` | Thêm cấu hình trường tự do |
| `asDelOptFieldSetup` | Xóa cấu hình trường tự do |

---

## Business Logic

### 1. Load dữ liệu ban đầu
- Gọi `asGetOptFieldInfo` để lấy danh sách trường tự do
- Gọi `asSIGetDMCT` để load danh mục chứng từ vào combo box
- Bind dữ liệu vào `dgvOpt`
- Form ở chế độ chỉ đọc (ReadOnly)

### 2. Chọn chứng từ
- Khi chọn chứng từ từ `cboChung_tu`:
  - Lấy lại danh sách trường tự do
  - Thêm các cột: Voucher_code, Master, Detail
  - Gọi `asGetOptFieldSetup` để lấy cấu hình hiện tại
  - Merge dữ liệu để hiển thị trạng thái checkbox

### 3. Chế độ sửa (cmdSua_Click)
- Ẩn nút "Sửa", hiện nút "Lưu" và "Hủy"
- Vô hiệu hóa combo box chứng từ
- Bật chế độ chỉnh sửa cho grid

### 4. Lưu thay đổi (cmdOk_Click)
- Xóa các cấu hình cũ (`DelFieldSetup`)
- Thêm các cấu hình mới (`InsFieldSetup`)
- Hiển thị thông báo thành công
- Chuyển về chế độ xem

### 5. Hủy thay đổi (cmdHuy_Click)
- Bật lại combo box chứng từ
- Ẩn nút "Lưu" và "Hủy", hiện nút "Sửa"
- Reload dữ liệu

---

## Mục đích sử dụng

**OptFieldSetup.dll là module khai báo cấu hình trường tự do cho từng loại chứng từ** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Cấu hình trường tự do theo chứng từ
- Chọn loại chứng từ từ danh mục
- Hiển thị các trường tự do có trong hệ thống
- Cho phép kích hoạt trường ở 2 vị trí:
  - **Thông tin chung (Master)**: Phần header của chứng từ
  - **Chi tiết (Detail)**: Phần line items của chứng từ

#### 2. Quản lý hiển thị
- Mỗi loại chứng từ có thể có cấu hình trường tự do khác nhau
- Linh hoạt bật/tắt trường tùy theo nhu cầu
- Không cần thay đổi code khi thêm/bớt trường

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Chế độ xem/sửa rõ ràng
- Xóa và thêm lại toàn bộ cấu hình khi lưu
- Kết nối đến database hệ thống (`a_blnIsSysDB: true`)
- Sử dụng `CompanyInformations.CompanyID` để lọc dữ liệu

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình linh hoạt các trường tự do (custom fields) cho từng loại chứng từ - cho phép người dùng tùy chỉnh hiển thị các trường mở rộng ở phần thông tin chung và/hoặc phần chi tiết của chứng từ.

---

*Ngày phân tích: 2026-03-29*
