# Báo cáo Phân tích DLL: FARptBCPT07.dll

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
| Assembly Name | FARptBCPT07 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Target Framework | net35 |

---

## Cấu trúc File

```
FARptBCPT07.dll/
├── FARptBCPT07.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFARptBCPT07.cs        # Main report form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| System.Xml.Linq | XML LINQ support |
| System.Core | .NET Core extensions |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCPT07` | `frmReport` | Form báo cáo phân tích tài sản 07 |

---

## Controls và UI

### Filter Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_BPSD | AsTextBox | Mã bộ phận sử dụng |
| lblTen_BPSD | Label | Tên bộ phận sử dụng |
| txtMa_Phi | AsTextBox | Mã phí |
| lblTen_Phi | Label | Tên phí |
| txtMa_SPCT | AsTextBox | Mã sản phẩm công trình |
| lblTen_SPCT | Label | Tên sản phẩm công trình |
| txtNgay1 | AsMaskedTextBox | Từ ngày |
| txtNgay2 | AsMaskedTextBox | Đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtTieu_De | TextBox | Tiêu đề báo cáo |

### Buttons

| Button | Chức năng |
|--------|-----------|
| cmdOk | Xem báo cáo |
| cmdCancel | Hủy |
| cmdExcel | Xuất Excel |
| cmdModifyReport | Sửa mẫu báo cáo |

---

## Business Logic

### Phương thức chính

#### `LoadData()`
- Lấy dữ liệu báo cáo từ controller
- Tham số truyền vào:
  - CompanyID
  - Ngày bắt đầu (txtNgay1)
  - Ngày kết thúc (txtNgay2)
  - Mã BPSD
  - Mã phí
  - Mã SPCT
- Gọi `Commons.FAGetTenNguonVon()` để lấy thông tin nguồn vốn
- Thiết lập formula fields cho báo cáo Crystal Reports

#### `GetFilterTitle()`
- Tạo chuỗi mô tả các điều kiện lọc đã chọn
- Hiển thị trên báo cáo

---

## Lookup Codes

| Control | LookupCodeName | MaxLength |
|---------|----------------|-----------|
| txtMa_BPSD | MA_BPSD | 8 |
| txtMa_Phi | MA_PHI | 8 |
| txtMa_SPCT | MA_SPCT | 8 |

---

## Mục đích sử dụng

**FARptBCPT07.dll là module báo cáo phân tích tài sản 07** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo phân tích tài sản theo nguồn vốn
- Phân tích tài sản theo bộ phận sử dụng (BPSD)
- Phân tích theo mã phí
- Phân tích theo sản phẩm công trình (SPCT)
- Hỗ trợ 4 nguồn vốn (strNV1 - strNV4)

#### 2. Lọc dữ liệu
- Theo kỳ báo cáo (ngày/tháng/năm)
- Theo mã BPSD
- Theo mã phí
- Theo mã SPCT

#### 3. Xuất báo cáo
- Xem trước báo cáo
- In ấn
- Xuất Excel
- Tích hợp Crystal Reports

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Sử dụng `AsTextBox` với AutoLookup cho các trường mã
- Tích hợp validation dữ liệu đầu vào
- Hỗ trợ tùy chỉnh mẫu báo cáo

---

## Kết luận

Đây là module báo cáo phân tích tài sản cố định theo nguồn vốn, phục vụ cho việc phân tích và theo dõi tài sản theo các chiều: bộ phận sử dụng, phí, và sản phẩm công trình.

---

*Ngày phân tích: 2026-03-29*
