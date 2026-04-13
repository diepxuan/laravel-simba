# Báo cáo Phân tích DLL: GLRptBCTCCDTF03D.dll

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
| Assembly Name | GLRptBCTCCDTF03D |
| Assembly Title | GLRptKPDA01 |
| Assembly Company | (không có) |
| Assembly Product | GLRptKPDA01 |
| Assembly Copyright | Copyright © 2013 |
| Assembly Trademark | (không có) |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 9e59f574-a6c1-478e-8b30-0386e1a700c3 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptBCTCCDTF03D.dll/
├── GLRptBCTCCDTF03D.csproj      # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptBCTCCDTF03D.cs   # Main report form class
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
- `System`, `System.Collections`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCTCCDTF03D` | `frmReport` | Form báo cáo chính - Báo cáo tài chính |
| `Resources` | - | Resource manager cho localization |

---

## Chi tiết Form: frmGLRptBCTCCDTF03D

### Controls trên Form

| Control | Loại | Mục đích |
|---------|------|----------|
| `txtTk` | `AsTextBox` | Nhập mã tài khoản (AutoLookup, LookupCodeName = "TK") |
| `lblTen_Tk` | `Label` | Hiển thị tên tài khoản (được bind với txtTk qua NameControl) |
| `lblTk` | `Label` | Nhãn "Tài khoản" |
| `txtNgay1`, `txtNgay2` | `AsMaskedTextBox` | Ngày bắt đầu và kết thúc báo cáo |
| `cboKyBc` | `ComboBox` | Chọn kỳ báo cáo |
| `cboMau_bc` | `ComboBox` | Chọn mẫu báo cáo |
| `txtTieu_De` | `TextBox` | Tiêu đề báo cáo |
| `txtMa_Nt` | `AsTextBox` | Mã ngoại tệ (ẩn - Visible = false) |
| `optVND`, `optNt` | `RadioButton` | Tùy chọn tiền tệ VND/Ngoại tệ (ẩn) |
| `cmdOk` | `Button` | Nút OK để chạy báo cáo |
| `cmdCancel` | `Button` | Nút Hủy |
| `cmdExcel` | `Button` | Xuất Excel |
| `cmdModifyReport` | `Button` | Chỉnh sửa mẫu báo cáo |

### Thuộc tính Controls

**txtTk (AsTextBox):**
- `AutoLookup = true` - Tự động tìm kiếm
- `AutoValid = false` - Không tự động validate
- `BackColor = SystemColors.Info` - Màu nền info
- `CharacterCasing = Upper` - Chữ hoa
- `LookupCodeName = "TK"` - Lookup theo mã TK
- `UseAutoCompleteSource = true` - Dùng autocomplete
- `NameControl = lblTen_Tk` - Bind tên TK vào label

### Phương thức chính

| Phương thức | Mô tả |
|-------------|-------|
| `InitOtherComponents()` | Khởi tạo bổ sung, set giá trị mặc định cho txtTk từ MyMenuInfo.par1 |
| `LoadData()` | Tải dữ liệu báo cáo với parameters: CompanyID, Ngay1, Ngay2, Tk |
| `GetFilterTitle()` | Tạo chuỗi tiêu đề filter cho báo cáo |

### Parameters truyền vào Stored Procedure

```
1. CompanyInformations.CompanyID  - Mã công ty
2. txtNgay1.Value                 - Ngày bắt đầu
3. txtNgay2.Value                 - Ngày kết thúc
4. txtTk.Text                     - Mã tài khoản
```

### Formula Fields

| Field | Giá trị |
|-------|---------|
| `strFiltertitle` | Tiêu đề filter (Tài khoản: [TK - Tên TK]) |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tài khoản" - Nhãn cho trường nhập TK
- "Từ ngày", "Đến ngày" - Khoảng thời gian báo cáo
- "Kỳ báo cáo" - Chọn kỳ
- "Mẫu báo cáo" - Chọn mẫu
- "Tiêu đề" - Tiêu đề tùy chỉnh

---

## Mục đích sử dụng

**GLRptBCTCCDTF03D.dll là module báo cáo tài chính** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Báo cáo theo tài khoản
- Lọc báo cáo theo mã tài khoản cụ thể
- AutoLookup tài khoản với gợi ý autocomplete
- Hiển thị tên tài khoản tương ứng

#### 2. Khoảng thời gian báo cáo
- Chọn kỳ báo cáo (cboKyBc)
- Nhập ngày bắt đầu/kết thúc linh hoạt
- Mặc định theo kỳ kế toán

#### 3. Mẫu báo cáo
- Chọn mẫu báo cáo từ danh sách
- Tiêu đề báo cáo tùy chỉnh
- Hỗ trợ chỉnh sửa mẫu báo cáo (cmdModifyReport)

#### 4. Xuất dữ liệu
- Xuất ra Excel (cmdExcel)
- In ấn trực tiếp
- Preview trước khi in

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form cho các báo cáo
- Sử dụng `AsTextBox` với chức năng AutoLookup
- Tích hợp với Asia ERP Framework và Helper
- Hỗ trợ đa tiền tệ (có controls nhưng bị ẩn - có thể do mẫu báo cáo chỉ dùng VND)

### Mã báo cáo

**BCTCCDTF03D** - Báo cáo tài chính theo tài khoản (có thể là "Báo cáo tình hình tài chính" hoặc báo cáo chi tiết công nợ theo tài khoản)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia, phục vụ cho việc xem và xuất báo cáo tài chính theo tài khoản. Form cho phép người dùng lọc báo cáo theo mã tài khoản, khoảng thời gian và mẫu báo cáo, sau đó xuất ra Excel hoặc in ấn.

---

*Ngày phân tích: 2026-03-29*
