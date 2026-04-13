# Báo cáo Phân tích DLL: FARptBCTS09.dll

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
| Assembly Name | FARptBCTS09 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Target Framework | net35 |

---

## Cấu trúc File

```
FARptBCTS09.dll/
├── FARptBCTS09.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFARptBCTS09.cs        # Main report form
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

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCTS09` | `frmReport` | Form báo cáo biến động tài sản 09 |

---

## Controls và UI

### Filter Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| cboLoai | ComboBox | Loại (Tất cả/Tài sản/Công cụ) |
| Label1 | Label | Nhãn "Tài sản/công cụ" |
| txtMa_ts | AsTextBox | Mã tài sản |
| lblTen_ts | Label | Tên tài sản |
| lblMa_bpsd | Label | Nhãn "Mã tài sản" |
| txtMa_cc | AsTextBox | Mã công cụ, dụng cụ |
| lblTen_cc | Label | Tên công cụ |
| Label2 | Label | Nhãn "Mã công cụ, dụng cụ" |
| txtMa_bpsd | AsTextBox | Mã bộ phận sử dụng |
| lblTen_bpsd | Label | Tên bộ phận sử dụng |
| Label4 | Label | Nhãn "Mã bộ phận sử dụng" |
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
- Khởi tạo giá trị mặc định
- Thiết lập `cboLoai.SelectedIndex = 0` (Tất cả)

#### `LoadData()`
- Lấy dữ liệu báo cáo từ controller
- Tham số truyền vào:
  - CompanyID
  - Ngày bắt đầu (txtNgay1)
  - Ngày kết thúc (txtNgay2)
  - Mã tài sản
  - Mã công cụ
  - Mã bộ phận sử dụng
  - Loại (cboLoai.SelectedIndex)
- Xử lý exception và hiển thị thông báo lỗi
- Thiết lập formula fields: strSubTitle1

#### `GetFilterTitle()`
- Tạo chuỗi mô tả các điều kiện lọc đã chọn
- Bao gồm: bộ phận sử dụng, tài sản, công cụ, loại
- Cắt bỏ dấu ";" cuối chuỗi nếu có

### Event Handlers

#### `cboLoai_SelectedIndexChanged()`
- Xử lý khi thay đổi loại báo cáo:
  - Index 0 (Tất cả): Cho phép nhập cả TS và CC
  - Index 1 (Tài sản): Chỉ cho phép nhập TS, xóa CC
  - Index 2 (Công cụ): Chỉ cho phép nhập CC, xóa TS

---

## Lookup Codes

| Control | LookupCodeName | MaxLength |
|---------|----------------|-----------|
| txtMa_ts | MA_TS | - |
| txtMa_cc | MA_CC | - |
| txtMa_bpsd | MA_BPSD | - |

---

## ComboBox Items

### cboLoai

| Index | Value | Ý nghĩa |
|-------|-------|---------|
| 0 | "Tất cả" | Hiển thị cả tài sản và công cụ |
| 1 | "Tài sản" | Chỉ hiển thị tài sản |
| 2 | "Công cụ" | Chỉ hiển thị công cụ |

---

## Mục đích sử dụng

**FARptBCTS09.dll là module báo cáo biến động tài sản 09** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo biến động tài sản và công cụ
- Báo cáo tổng hợp cả tài sản và công cụ dụng cụ
- Có thể chọn xem riêng từng loại hoặc xem tất cả

#### 2. Lọc dữ liệu
- Theo kỳ báo cáo (từ ngày - đến ngày)
- Theo loại (Tất cả/Tài sản/Công cụ)
- Theo mã tài sản
- Theo mã công cụ
- Theo bộ phận sử dụng

#### 3. Điều khiển nhập liệu động
- Khi chọn "Tài sản": Vô hiệu hóa nhập công cụ, tự động xóa giá trị công cụ
- Khi chọn "Công cụ": Vô hiệu hóa nhập tài sản, tự động xóa giá trị tài sản
- Khi chọn "Tất cả": Cho phép nhập cả hai

#### 4. Xuất báo cáo
- Xem trước báo cáo
- In ấn
- Xuất Excel
- Tích hợp Crystal Reports

### Đặc điểm kỹ thuật

- Tên form trong code: `frmFARptSoSD` (Sổ sử dụng)
- Có xử lý try-catch trong LoadData
- Event handler điều khiển trạng thái enable/disable của các trường nhập liệu
- AutoValid = true cho các trường lookup

---

## Kết luận

Đây là module báo cáo biến động tài sản và công cụ dụng cụ, hỗ trợ lọc theo loại và có logic điều khiển nhập liệu thông minh để tránh nhập sai dữ liệu.

---

*Ngày phân tích: 2026-03-29*
