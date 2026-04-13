# Báo cáo Phân tích DLL: FARptBCTS08.dll

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
| Assembly Name | FARptBCTS08 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Target Framework | net35 |

---

## Cấu trúc File

```
FARptBCTS08.dll/
├── FARptBCTS08.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFARptBCTS08.cs        # Main report form
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
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCTS08` | `frmReport` | Form báo cáo biến động tài sản 08 |

---

## Controls và UI

### Filter Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_ts | AsTextBox | Mã tài sản |
| lblTen_ts | Label | Tên tài sản |
| lblMa_tS | Label | Nhãn "Mã tài sản" |
| txtMa_nhts | AsTextBox | Mã nhóm tài sản |
| lblTen_nhts | Label | Tên nhóm tài sản |
| lblMa_nhts | Label | Nhãn "Mã nhóm tài sản" |
| txtMa_bpsd | AsTextBox | Mã bộ phận sử dụng |
| lblTen_bpsd | Label | Tên bộ phận sử dụng |
| lblMa_BPSD | Label | Nhãn "Mã bộ phận sử dụng" |
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
  - Mã tài sản
  - Mã nhóm tài sản
  - Mã bộ phận sử dụng
- Xử lý exception và hiển thị thông báo lỗi
- Thiết lập formula fields: strSubTitle1

#### `GetFilterTitle()`
- Tạo chuỗi mô tả các điều kiện lọc đã chọn
- Bao gồm: tên tài sản, nhóm tài sản, bộ phận sử dụng
- Cắt bỏ dấu ";" cuối chuỗi nếu có

---

## Lookup Codes

| Control | LookupCodeName | MaxLength |
|---------|----------------|-----------|
| txtMa_ts | MA_TS | - |
| txtMa_nhts | MA_NHTS | - |
| txtMa_bpsd | MA_BPSD | - |

---

## Mục đích sử dụng

**FARptBCTS08.dll là module báo cáo biến động tài sản 08** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo biến động tài sản theo kỳ
- Báo cáo biến động tài sản trong khoảng thời gian
- Theo dõi sự thay đổi của tài sản từ ngày đến ngày

#### 2. Lọc dữ liệu
- Theo kỳ báo cáo (từ ngày - đến ngày)
- Theo mã tài sản cụ thể
- Theo nhóm tài sản
- Theo bộ phận sử dụng

#### 3. Xuất báo cáo
- Xem trước báo cáo
- In ấn
- Xuất Excel
- Tích hợp Crystal Reports

### Đặc điểm kỹ thuật

- Giao diện đơn giản, ít filter hơn so với các báo cáo khác
- Có xử lý try-catch trong LoadData để bắt lỗi
- Hiển thị thông báo lỗi bằng MessageBox
- AutoValid = true cho các trường lookup

---

## Kết luận

Đây là module báo cáo biến động tài sản theo kỳ với giao diện đơn giản, tập trung vào 3 tiêu chí lọc chính: tài sản, nhóm tài sản và bộ phận sử dụng.

---

*Ngày phân tích: 2026-03-29*
