# Báo cáo Phân tích DLL: GLRptNKCTSoCai.dll

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
| Assembly Name | GLRptNKCTSoCai |
| Assembly Title | GLRptNKC08 |
| Assembly Product | GLRptNKC08 |
| Assembly Company | - |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 4f6fe48a-cfb5-4a89-b28c-669aa1500b43 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptNKCTSoCai.dll/
├── GLRptNKCTSoCai.csproj          # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptNKCTSoCai.cs       # Main report form
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
| `frmGLRptNKCTSoCai` | `frmReport` | Form báo cáo nhật ký chung tổng hợp sổ cái |

---

## Controls và UI Components

### Input Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `txtTk` | AsTextBox | Tài khoản |
| `lblTk` | Label | Tên tài khoản (hiển thị) |
| `Label1` | Label | Nhãn "Tài khoản" |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Từ ngày, đến ngày |
| `cboKyBc` | ComboBox | Kỳ báo cáo |
| `cboMau_bc` | ComboBox | Mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ (ẩn) |
| `optVND`, `optNt` | RadioButton | Lựa chọn tiền tệ (ẩn) |
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

- "Tài khoản" - Tài khoản cần xem nhật ký chung

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `tk` | Tài khoản |
| `ngay1`, `ngay2` | Khoảng thời gian báo cáo |
| `NKCTSoCai` | Nhật ký chung tổng hợp sổ cái |

### Cột báo cáo (dự kiến)

| Cột | Ý nghĩa |
|-----|----------|
| Ngày | Ngày ghi sổ |
| Số chứng từ | Số hiệu chứng từ |
| Diễn giải | Nội dung nghiệp vụ |
| TK đối ứng | Tài khoản đối ứng |
| Phát sinh nợ | Phát sinh bên Nợ |
| Phát sinh có | Phát sinh bên Có |

---

## Mục đích sử dụng

**GLRptNKCTSoCai.dll là module báo cáo "Nhật ký chung tổng hợp sổ cái"** trong hệ thống ERP.

### Chức năng chính

#### 1. Báo cáo nhật ký chung
- Hiển thị nhật ký chung tổng hợp theo tài khoản
- Liệt kê các nghiệp vụ kinh tế phát sinh
- Hiển thị TK đối ứng và số phát sinh

#### 2. Lọc dữ liệu
- Lọc theo tài khoản
- Lọc theo khoảng thời gian
- Lọc theo kỳ báo cáo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form báo cáo của Asia ERP
- Sử dụng `ArrayList` để truyền tham số cho stored procedure
- AutoComplete cho trường tài khoản (LookupCodeName = "TK")
- Validation dữ liệu đầu vào (AutoValid, AutoLookup)
- Event `tabFilter_Click` để xử lý click vào tab filter

### Events

| Event | Mục đích |
|-------|----------|
| `tabFilter_Click` | Xử lý khi click vào tab filter |

### Tham số truy vấn

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtNgay1.Value);                 // Từ ngày
params.Add(txtNgay2.Value);                 // Đến ngày
params.Add(txtTk.Text);                     // Tài khoản
```

---

## Kết luận

Đây là module báo cáo nhật ký chung tổng hợp sổ cái trong hệ thống ERP Asia Enterprise, cho phép xem chi tiết các nghiệp vụ kinh tế phát sinh theo từng tài khoản.

---

*Ngày phân tích: 2026-03-29*
