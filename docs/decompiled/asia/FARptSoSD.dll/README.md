# Báo cáo Phân tích DLL: FARptSoSD.dll

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
| Assembly Name | FARptSoSD |
| Assembly Title | Sổ theo dõi TSCĐ và CCDC tại nơi sử dụng |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2012 |
| Assembly Version | 12.1.3.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 6cf0aa81-5a68-42ff-8764-7956a0ff3a07 |
| ComVisible | false |

---

## Cấu trúc File

```
FARptSoSD.dll/
├── FARptSoSD.csproj             # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmFARptSoSD.cs          # Main report form
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptSoSD` | `frmReport` | Form sổ theo dõi TSCĐ và CCDC tại nơi sử dụng |

---

## Các trường dữ liệu Filter

| Control | Loại | Mô tả | Lookup |
|---------|------|-------|--------|
| txtMa_ts | AsTextBox | Mã tài sản | MA_TS |
| txtMa_cc | AsTextBox | Mã công cụ, dụng cụ | MA_CC |
| txtMa_bpsd | AsTextBox | Mã bộ phận sử dụng | MA_BPSD |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản (TSCĐ) |
| `ma_cc` | Mã công cụ, dụng cụ (CCDC) |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ten_ts` | Tên tài sản |
| `ten_cc` | Tên công cụ, dụng cụ |
| `ten_bpsd` | Tên bộ phận sử dụng |

---

## Mục đích sử dụng

**FARptSoSD.dll là module Sổ theo dõi TSCĐ và CCDC tại nơi sử dụng** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Lọc dữ liệu báo cáo
- Lọc theo mã tài sản (MA_TS)
- Lọc theo mã công cụ, dụng cụ (MA_CC)
- Lọc theo bộ phận sử dụng (MA_BPSD)

#### 2. Tham số báo cáo
- Kỳ báo cáo (cboKyBc)
- Ngày bắt đầu/kết thúc (txtNgay1, txtNgay2)
- Mẫu báo cáo (cboMau_bc)
- Tiêu đề báo cáo tùy chỉnh (txtTieu_De)

#### 3. Xuất dữ liệu
- Xem trước báo cáo (cmdOk)
- Xuất Excel (cmdExcel)
- Chỉnh sửa mẫu báo cáo (cmdModifyReport)

#### 4. Xử lý lỗi
- Có try-catch trong phương thức LoadData
- Hiển thị thông báo lỗi bằng MessageBox: "Lỗi lọc dữ liệu: {message}"

### Đặc điểm kỹ thuật

- Sử dụng AsTextBox với AutoLookup và AutoValid cho các trường mã
- Hiển thị tên đối tượng tự động qua NameControl
- Sử dụng UseAutoCompleteSource cho các trường lookup
- Có xử lý ngoại lệ (Exception handling)
- Biến state: DataLoading, sTabName, sMenuID

### Tham số truyền vào Controller

```csharp
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(DateAndTime.DateValue(txtNgay1.Value));
arrayList.Add(DateAndTime.DateValue(txtNgay2.Value));
arrayList.Add(txtMa_ts.Text);
arrayList.Add(txtMa_cc.Text);
arrayList.Add(txtMa_bpsd.Text);
```

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và xuất Sổ theo dõi tài sản cố định (TSCĐ) và công cụ dụng cụ (CCDC) tại nơi sử dụng. Module này có cấu trúc đơn giản hơn các báo cáo phân tích khác, chỉ tập trung vào việc theo dõi tài sản và công cụ theo bộ phận sử dụng.

---

*Ngày phân tích: 2026-03-29*
