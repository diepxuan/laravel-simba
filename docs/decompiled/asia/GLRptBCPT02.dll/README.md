# Báo cáo Phân tích DLL: GLRptBCPT02.dll

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
| Assembly Name | GLRptBCPT02 |
| Assembly Title | Bảng cân đối phát sinh một tài khoản theo ngày |
| Assembly Product | GLRptBCPT02 |
| Assembly Company | - |
| Assembly Copyright | Copyright © 2010 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | e0742657-f92b-48bd-a09e-d8fcc770e954 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptBCPT02.dll/
├── GLRptBCPT02.csproj             # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptBCPT02.cs          # Main report form
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MyApplication.cs
    ├── MyComputer.cs
    └── MySettingsProperty.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Drawing | Graphics rendering |
| System.Windows.Forms | UI framework |
| AsiaErp.Framework | Asia ERP Framework base classes |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCPT02` | `frmReport` | Form báo cáo cân đối phát sinh theo ngày |

---

## Controls và UI Components

### Input Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `txtTk` | AsTextBox | Tài khoản cần xem |
| `lblTen_Tk` | Label | Tên tài khoản |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Từ ngày, đến ngày |
| `cboKyBc` | ComboBox | Kỳ báo cáo |
| `cboMau_bc` | ComboBox | Mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Lựa chọn tiền tệ |
| `txtTieu_De` | TextBox | Tiêu đề báo cáo |

### Action Buttons

| Button | Mục đích |
|--------|----------|
| `cmdOk` | Thực hiện báo cáo |
| `cmdCancel` | Hủy bỏ |
| `cmdExcel` | Xuất Excel |
| `cmdModifyReport` | Sửa mẫu báo cáo |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng cân đối phát sinh một tài khoản theo ngày" - Tên chức năng chính
- "Tài khoản" - TK cần xem chi tiết theo ngày

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `tk` | Tài khoản |
| `ma_nt` | Mã ngoại tệ |
| `ngay1`, `ngay2` | Khoảng thời gian báo cáo |

### Cột báo cáo (dự kiến)

| Cột | Ý nghĩa |
|-----|----------|
| Ngày | Ngày giao dịch |
| Số chứng từ | Số hiệu chứng từ |
| Diễn giải | Nội dung giao dịch |
| Phát sinh nợ | Phát sinh bên Nợ |
| Phát sinh có | Phát sinh bên Có |
| Số dư | Số dư sau giao dịch |

---

## Mục đích sử dụng

**GLRptBCPT02.dll là module báo cáo "Bảng cân đối phát sinh một tài khoản theo ngày"** trong hệ thống ERP.

### Chức năng chính

#### 1. Xem chi tiết theo ngày
- Chọn một tài khoản cụ thể
- Hiển thị chi tiết phát sinh theo từng ngày
- Theo dõi biến động số dư qua từng ngày

#### 2. Lọc dữ liệu
- Lọc theo khoảng thời gian
- Lọc theo mã ngoại tệ
- Lựa chọn mẫu báo cáo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form báo cáo của Asia ERP
- Sử dụng `ArrayList` để truyền tham số cho stored procedure
- AutoComplete cho trường tài khoản (LookupCodeName = "TK")
- Validation dữ liệu đầu vào (AutoValid, AutoLookup)

### Tham số truy vấn

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtTk.Text);                     // Tài khoản
params.Add(txtNgay1.Value);                 // Từ ngày
params.Add(txtNgay2.Value);                 // Đến ngày
params.Add(txtMa_Nt.Text);                  // Mã ngoại tệ
```

---

## Kết luận

Đây là module báo cáo cân đối phát sinh theo ngày trong hệ thống ERP Asia Enterprise, cho phép theo dõi chi tiết biến động của một tài khoản theo từng ngày.

---

*Ngày phân tích: 2026-03-29*
