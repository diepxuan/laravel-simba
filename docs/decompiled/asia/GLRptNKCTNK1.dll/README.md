# Báo cáo Phân tích DLL: GLRptNKCTNK1.dll

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
| Assembly Name | GLRptNKCTNK1 |
| Assembly Title | GLRptNKCTNK1 |
| Assembly Company | (trống) |
| Assembly Product | GLRptNKCTNK1 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | (trống) |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | f62a3cf2-9d59-4df4-bb3f-b470725f545f |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptNKCTNK1.dll/
├── GLRptNKCTNK1.csproj          # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptNKCTNK1.cs       # Main report form
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs         # Application settings
│   ├── MyComputer.cs            # Computer settings
│   ├── MyProject.cs             # Project settings
│   ├── MySettings.cs            # User settings
│   └── MySettingsProperty.cs    # Settings properties
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
- `System`, `System.Collections`, `System.ComponentModel`
- `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptNKCTNK1` | `frmReport` | Form báo cáo Nhật ký chung theo tài khoản |
| `Resources` | - | Resource manager cho localization |

---

## Chi tiết Form: frmGLRptNKCTNK1

### Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `lblTk` | Label | Hiển thị tên tài khoản (kết quả lookup) |
| `Label1` | Label | Nhãn "Tài khoản" |
| `txtTk` | AsTextBox | Textbox nhập mã tài khoản (AutoLookup, AutoValid) |
| `txtNgay1` | AsTextBox | Ngày bắt đầu (kế thừa từ frmReport) |
| `txtNgay2` | AsTextBox | Ngày kết thúc (kế thừa từ frmReport) |
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo (kế thừa từ frmReport) |
| `txtTieu_De` | AsTextBox | Tiêu đề báo cáo (kế thừa từ frmReport) |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo (kế thừa từ frmReport) |
| `cmdOk` | Button | Nút OK để chạy báo cáo |
| `cmdCancel` | Button | Nút Hủy (kế thừa từ frmReport) |
| `cmdExcel` | Button | Xuất Excel (kế thừa từ frmReport) |
| `cmdModifyReport` | Button | Sửa mẫu báo cáo (kế thừa từ frmReport) |

### Thuộc tính Controls

**txtTk (AsTextBox):**
- `AutoLookup = true` - Tự động lookup khi nhập
- `AutoValid = true` - Tự động validate
- `BackColor = SystemColors.Info` - Màu nền info
- `CharacterCasing = Upper` - Chuyển thành chữ hoa
- `LookupCodeName = "TK"` - Lookup theo code TK (Tài khoản)
- `NameControl = lblTk` - Control hiển thị tên tài khoản
- `UseAutoCompleteSource = true` - Sử dụng autocomplete

### Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| `tabFilter.Click` | `tabFilter_Click` | Focus vào txtTk khi click tab |

### Methods

| Method | Mô tả |
|--------|-------|
| `LoadData()` | Load dữ liệu báo cáo với tham số: CompanyID, Ngày1, Ngày2, TK |
| `ValidData()` | Validate dữ liệu: bắt buộc nhập TK |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `TK` | Tài khoản kế toán |
| `NKCT` | Nhật ký chung theo tài khoản |
| `KyBc` | Kỳ báo cáo |
| `Mau_bc` | Mẫu báo cáo |

---

## Mục đích sử dụng

**GLRptNKCTNK1.dll là module báo cáo "Nhật ký chung theo tài khoản"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Nhật ký chung theo tài khoản
- Lọc theo tài khoản kế toán (bắt buộc nhập)
- Lọc theo khoảng thời gian (từ ngày - đến ngày)
- Chọn kỳ báo cáo
- Chọn mẫu báo cáo khác nhau

#### 2. Tính năng hỗ trợ
- AutoLookup tài khoản kế toán
- AutoComplete khi nhập mã TK
- Validate dữ liệu đầu vào
- Xuất báo cáo ra Excel
- Sửa đổi mẫu báo cáo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form cho các báo cáo
- Sử dụng `AsTextBox` với tính năng AutoLookup
- Tích hợp với Asia ERP Framework và Helper
- Gọi stored procedure qua `base.MyController.GetData()`

### Tham số báo cáo

```
@CompanyID  - Mã công ty
@Ngay1      - Ngày bắt đầu
@Ngay2      - Ngày kết thúc
@TK         - Mã tài khoản
```

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in báo cáo Nhật ký chung theo tài khoản - một báo cáo kế toán tổng hợp quan trọng giúp theo dõi phát sinh của từng tài khoản trong kỳ.

---

*Ngày phân tích: 2026-03-29*
