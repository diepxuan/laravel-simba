# Báo cáo Phân tích DLL: FARptBCPT09.dll

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
| Assembly Name | FARptBCPT09 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Target Framework | net35 |

---

## Cấu trúc File

```
FARptBCPT09.dll/
├── FARptBCPT09.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFARptBCPT09.cs        # Main report form
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
| `frmFARptBCPT09` | `frmReport` | Form báo cáo phân tích tài sản 09 |

---

## Controls và UI

### Filter Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| cboTheo_nhom | ComboBox | Nhóm theo (BP sử dụng/Mã phí/Mã SPCT) |
| lblTheo_nhom | Label | Nhãn "Theo nhóm" |
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

#### `InitOtherComponents()`
- Khởi tạo giá trị mặc định cho các control
- Thiết lập `cboTheo_nhom.SelectedIndex = 0`

#### `LoadData()`
- Lấy dữ liệu báo cáo từ controller
- Tham số truyền vào:
  - CompanyID
  - Ngày bắt đầu (txtNgay1)
  - Ngày kết thúc (txtNgay2)
  - Mã BPSD
  - Mã phí
  - Mã SPCT

#### `GetFilterTitle()`
- Tạo chuỗi mô tả các điều kiện lọc đã chọn
- Bao gồm: BPSD, phí, SPCT

---

## Lookup Codes

| Control | LookupCodeName | MaxLength |
|---------|----------------|-----------|
| txtMa_BPSD | MA_BPSD | 8 |
| txtMa_Phi | MA_PHI | 8 |
| txtMa_SPCT | MA_SPCT | 8 |

---

## ComboBox Items

### cboTheo_nhom

| Index | Value | Ý nghĩa |
|-------|-------|---------|
| 0 | "BP sử dụng" | Nhóm theo bộ phận sử dụng |
| 1 | "Mã phí" | Nhóm theo mã phí |
| 2 | "Mã SPCT" | Nhóm theo sản phẩm công trình |

---

## Mục đích sử dụng

**FARptBCPT09.dll là module báo cáo phân tích tài sản 09** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo phân tích tài sản theo nhóm
- Hỗ trợ nhóm báo cáo theo 3 tiêu chí:
  - Bộ phận sử dụng (BP sử dụng)
  - Mã phí
  - Sản phẩm công trình (SPCT)
- Cho phép chuyển đổi linh hoạt giữa các cách nhóm

#### 2. Lọc dữ liệu
- Theo kỳ báo cáo
- Theo mã BPSD
- Theo mã phí
- Theo mã SPCT

#### 3. Xuất báo cáo
- Xem trước báo cáo
- In ấn
- Xuất Excel
- Tích hợp Crystal Reports

### Đặc điểm kỹ thuật

- Có tính năng "Theo nhóm" để chọn cách nhóm dữ liệu
- Control `cboTheo_nhom` được thiết lập ẩn (Visible = false) trong UI
- Mặc định nhóm theo "BP sử dụng"

---

## Kết luận

Đây là module báo cáo phân tích tài sản với khả năng nhóm dữ liệu linh hoạt theo 3 chiều: bộ phận sử dụng, phí, và sản phẩm công trình.

---

*Ngày phân tích: 2026-03-29*
