# Báo cáo Phân tích DLL: FARptBCPT08.dll

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
| Assembly Name | FARptBCPT08 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Target Framework | net35 |

---

## Cấu trúc File

```
FARptBCPT08.dll/
├── FARptBCPT08.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFARptBCPT08.cs        # Main report form
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
| `frmFARptBCPT08` | `frmReport` | Form báo cáo phân tích tài sản 08 |

---

## Controls và UI

### Filter Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_ts | AsTextBox | Mã tài sản |
| lblTen_ts | Label | Tên tài sản |
| lblMa_ts | Label | Nhãn "Mã TS" |
| txtMa_Nhts1 | AsTextBox | Mã nhóm tài sản 1 |
| lblTen_Nhts1 | Label | Tên nhóm tài sản 1 |
| lblMa_Nhts1 | Label | Nhãn "Mã nhóm TS1" |
| txtMa_Nhts2 | AsTextBox | Mã nhóm tài sản 2 |
| lblTen_Nhts2 | Label | Tên nhóm tài sản 2 |
| lblMa_Nhts2 | Label | Nhãn "Mã nhóm TS2" |
| txtMa_Nhts3 | AsTextBox | Mã nhóm tài sản 3 |
| lblTen_Nhts3 | Label | Tên nhóm tài sản 3 |
| lblMa_Nhts3 | Label | Nhãn "Mã nhóm TS3" |
| txtMa_BPSD | AsTextBox | Mã bộ phận sử dụng |
| lblTen_BPSD | Label | Tên bộ phận sử dụng |
| lblMa_BPSD | Label | Nhãn "Mã BPSD" |
| txtMa_Phi | AsTextBox | Mã phí |
| lblTen_Phi | Label | Tên phí |
| lblMa_Phi | Label | Nhãn "Mã phí" |
| txtMa_SPCT | AsTextBox | Mã sản phẩm công trình |
| lblTen_SPCT | Label | Tên sản phẩm công trình |
| lblMa_SPCT | Label | Nhãn "Mã SPCT" |
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
- Focus vào cboKyBc

#### `LoadData()`
- Lấy dữ liệu báo cáo từ controller
- Tham số truyền vào:
  - CompanyID
  - Ngày bắt đầu (txtNgay1)
  - Ngày kết thúc (txtNgay2)
  - Mã tài sản
  - Mã nhóm TS1, TS2, TS3
  - Mã BPSD
  - Mã phí
  - Mã SPCT
- Thiết lập formula fields: strSubTitle1

#### `GetFilterTitle()`
- Tạo chuỗi mô tả các điều kiện lọc đã chọn
- Bao gồm: mã TS, nhóm TS1-3, BPSD, phí, SPCT

---

## Lookup Codes

| Control | LookupCodeName | LookupWhereCondition | MaxLength |
|---------|----------------|----------------------|-----------|
| txtMa_ts | MA_TS | - | 8 |
| txtMa_Nhts1 | MA_NHTS | loai_nh=1 | 8 |
| txtMa_Nhts2 | MA_NHTS | loai_nh=2 | 8 |
| txtMa_Nhts3 | MA_NHTS | loai_nh=3 | 8 |
| txtMa_BPSD | MA_BPSD | - | 8 |
| txtMa_Phi | MA_PHI | - | 8 |
| txtMa_SPCT | MA_SPCT | - | 8 |

---

## Mục đích sử dụng

**FARptBCPT08.dll là module báo cáo phân tích tài sản 08** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo phân tích tài sản chi tiết
- Phân tích tài sản theo mã tài sản
- Phân tích theo 3 cấp nhóm tài sản (NHTS1, NHTS2, NHTS3)
- Phân tích theo bộ phận sử dụng
- Phân tích theo mã phí và SPCT

#### 2. Lọc dữ liệu đa chiều
- Theo kỳ báo cáo (từ ngày - đến ngày)
- Theo mã tài sản
- Theo 3 cấp nhóm tài sản (có điều kiện loai_nh)
- Theo mã BPSD
- Theo mã phí
- Theo mã SPCT

#### 3. Xuất báo cáo
- Xem trước báo cáo
- In ấn
- Xuất Excel
- Tích hợp Crystal Reports

### Đặc điểm kỹ thuật

- Hỗ trợ 3 cấp nhóm tài sản với điều kiện loai_nh khác nhau
- LookupCodeName MA_NHTS được sử dụng cho cả 3 nhóm với where condition khác nhau
- MaxLength chuẩn 8 ký tự cho các trường mã

---

## Kết luận

Đây là module báo cáo phân tích tài sản chi tiết với khả năng lọc theo 3 cấp nhóm tài sản, phục vụ cho việc phân tích tài sản theo nhiều chiều phân loại khác nhau.

---

*Ngày phân tích: 2026-03-29*
