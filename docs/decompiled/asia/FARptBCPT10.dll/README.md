# Báo cáo Phân tích DLL: FARptBCPT10.dll

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
| Assembly Name | FARptBCPT10 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Target Framework | net35 |

---

## Cấu trúc File

```
FARptBCPT10.dll/
├── FARptBCPT10.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFARptBCPT10.cs        # Main report form
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
| `frmFARptBCPT10` | `frmReport` | Form báo cáo phân tích tài sản 10 |

---

## Controls và UI

### Filter Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| cboTheo_nhom | ComboBox | Nhóm theo (BP sử dụng/Mã phí/Mã SPCT) |
| lblTheo_nhom | Label | Nhãn "Theo nhóm" |
| txtMa_BPSD | AsTextBox | Mã bộ phận sử dụng |
| lblTen_BPSD | Label | Tên bộ phận sử dụng |
| txtMa_cc | AsTextBox | Mã công cụ |
| Label1 | Label | Tên công cụ |
| lblMa_cc | Label | Nhãn "Mã công cụ" |
| txtMa_phi | AsTextBox | Mã phí |
| Label3 | Label | Tên phí |
| lblMa_phi | Label | Nhãn "Mã phí" |
| txtMa_spct | AsTextBox | Mã SPCT |
| Label5 | Label | Tên SPCT |
| lblMa_SPCT | Label | Nhãn "Mã SPCT" |
| txtTK_PB | AsTextBox | TK phân bổ |
| Label7 | Label | Tên TK phân bổ |
| lblTK_PB | Label | Nhãn "TK phân bổ" |
| txtTK_CP | AsTextBox | TK chi phí |
| Label9 | Label | Tên TK chi phí |
| lblTK_CP | Label | Nhãn "TK chi phí" |
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
  - Mã công cụ (cc)
  - Mã phí
  - Mã SPCT
  - TK phân bổ (TK_PB)
  - TK chi phí (TK_CP)

#### `GetFilterTitle()`
- Tạo chuỗi mô tả các điều kiện lọc đã chọn
- Chỉ hiển thị mã BPSD trong filter title

---

## Lookup Codes

| Control | LookupCodeName | MaxLength | AutoComplete |
|---------|----------------|-----------|--------------|
| txtMa_BPSD | MA_BPSD | 20 | Yes |
| txtMa_cc | MA_CC | 20 | Yes |
| txtMa_phi | MA_phi | 20 | Yes |
| txtMa_spct | MA_SPCT | 20 | Yes |
| txtTK_PB | TK | 8 | Yes |
| txtTK_CP | TK | 8 | Yes |

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

**FARptBCPT10.dll là module báo cáo phân tích tài sản 10** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo phân tích tài sản và công cụ
- Phân tích tài sản theo bộ phận sử dụng
- Phân tích theo công cụ, dụng cụ
- Phân tích theo mã phí và SPCT
- Phân tích theo tài khoản phân bổ và chi phí

#### 2. Lọc dữ liệu đa chiều
- Theo kỳ báo cáo
- Theo mã BPSD
- Theo mã công cụ
- Theo mã phí
- Theo mã SPCT
- Theo TK phân bổ
- Theo TK chi phí

#### 3. Nhóm dữ liệu linh hoạt
- Nhóm theo BP sử dụng
- Nhóm theo mã phí
- Nhóm theo mã SPCT

#### 4. Xuất báo cáo
- Xem trước báo cáo
- In ấn
- Xuất Excel
- Tích hợp Crystal Reports

### Đặc điểm kỹ thuật

- Hỗ trợ cả tài sản và công cụ trong cùng báo cáo
- Tích hợp tài khoản kế toán (TK phân bổ, TK chi phí)
- MaxLength lớn hơn (20 ký tự) cho các mã
- Sử dụng AutoCompleteSource cho các trường lookup

---

## Kết luận

Đây là module báo cáo phân tích tài sản và công cụ toàn diện, tích hợp thông tin tài khoản kế toán, phục vụ cho việc phân tích chi phí và phân bổ tài sản/công cụ.

---

*Ngày phân tích: 2026-03-29*
