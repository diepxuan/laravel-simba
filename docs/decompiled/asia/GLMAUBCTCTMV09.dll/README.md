# Báo cáo Phân tích DLL: GLMAUBCTCTMV09.dll

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
| Assembly Name | GLMAUBCTCTMV09 |
| Assembly Title | GLBCTC07V09 |
| Assembly Company | (trống) |
| Assembly Product | GLBCTC07V09 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | (trống) |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | de80061a-33f9-4bf2-9939-3a34f3f95c1a |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV09.dll/
├── GLMAUBCTCTMV09.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMV09.cs     # Main view form
│   └── frmGLMAUBCTCTMV09Edit.cs # Edit form
├── AsiaErp.UserInterface.My/
│   ├── MyProject.cs             # VB.NET project support
│   ├── MySettings.cs            # Application settings
│   ├── MySettingsProperty.cs    # Settings property accessor
│   ├── MyApplication.cs         # Application events
│   └── MyComputer.cs            # Computer info accessor
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMV09` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính |
| `frmGLMAUBCTCTMV09Edit` | `frmDMComplexEdit` | Form chỉnh sửa mẫu báo cáo tài chính |
| `Resources` | - | Resource manager cho localization |

---

## Chi tiết Form Edit (frmGLMAUBCTCTMV09Edit)

### Controls chính

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsTextBox | txtMa_chtieu | Mã chỉ tiêu báo cáo |
| TextBox | txtChi_tieu | Tên chỉ tiêu |
| TextBox | txtNd_chtieu | Nội dung chỉ tiêu (multiline) |
| TextBox | txtCach_tinh | Công thức tính toán |
| AsTextBox | txtTk1 - txtTk7 | Tài khoản kế toán 1-7 (có lookup) |
| Label | lblTK1 - lblTK7 | Hiển thị tên tài khoản tương ứng |
| AsComboBox | cboLoai_ps | Loại phát sinh |
| CheckBox | ChkIs_print | Có in hay không |
| CheckBox | ChkIs_italic | In nghiêng |
| AsCheckBox | chkKsd | In đậm |
| AsTextBox | txtMauQD | Mẫu quyết định |

### Loại phát sinh (cboLoai_ps)

| Key | Value |
|-----|-------|
| "" | (trống) |
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| PSNO | Phát sinh nợ |
| PSCO | Phát sinh có |

### Data Binding

| Control | Field | Binding |
|---------|-------|---------|
| txtMauQD | mau | Text |
| txtMa_chtieu | ma_so | Text |
| txtChi_tieu | chi_tieu | Text |
| txtNd_chtieu | nd_chtieu | Text |
| txtCach_tinh | cach_tinh | Text |
| cboLoai_ps | loai_ps | SelectedValue |
| txtTk1 | tk_01 | Text |
| txtTk2 | tk_02 | Text |
| txtTk3 | tk_03 | Text |
| txtTk4 | tk_04 | Text |
| txtTk5 | tk_05 | Text |
| txtTk6 | tk_06 | Text |
| txtTk7 | tk_07 | Text |
| ChkIs_italic | IsItalic | Checked |
| ChkIs_print | IsPrint | Checked |
| chkKsd | bold | Checked |

### Business Logic

#### Validation (ValidData)
- Kiểm tra mã chỉ tiêu không được trống
- Kiểm tra tên chỉ tiêu không được trống
- Auto-fill mẫu QĐ từ `CompanyInformations.Qd_cdkt` nếu trống

#### Events
- `frmGLMAUBCTCTMV09Edit_Load`: Mặc định check "Có in" khi thêm mới
- `ProcessKeyPreview`: Xử lý phím tắt (bỏ qua khi focus ở txtNd_chtieu)

#### Disable Fields
- Khi ở chế độ xem/sửa: disable txtMauQD và txtMa_chtieu
- Focus vào txtChi_tieu sau khi disable

---

## Mục đích sử dụng

**GLMAUBCTCTMV09.dll là module quản lý mẫu báo cáo tài chính (BCTC)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý mẫu báo cáo tài chính
- Định nghĩa các chỉ tiêu báo cáo tài chính
- Cấu hình công thức tính toán cho từng chỉ tiêu
- Liên kết với tối đa 7 tài khoản kế toán

#### 2. Cấu hình loại phát sinh
- Hỗ trợ 6 loại phát sinh: Dư nợ/có đầu kỳ, Dư nợ/có cuối kỳ, Phát sinh nợ/có
- Cho phép để trống nếu không áp dụng

#### 3. Định dạng in ấn
- Cấu hình in đậm (bold)
- Cấu hình in nghiêng (italic)
- Cấu hình có in hay không (printable)

#### 4. Tích hợp tài khoản kế toán
- Lookup tài khoản từ bảng TK
- Auto-complete khi nhập mã tài khoản
- Hiển thị tên tài khoản tương ứng

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ lookup và auto-complete cho tài khoản
- Kế thừa từ frmDMComplexView/frmDMComplexEdit (framework chuẩn)

### Mã chức năng

**GLMAUBCTCTMV09** - Mẫu báo cáo tài chính theo Thông tư 200 (hoặc QĐ số 48/QĐ-BTC) - Phiên bản 09.

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình và quản lý mẫu báo cáo tài chính. Module cho phép người dùng định nghĩa các chỉ tiêu báo cáo, công thức tính toán, và liên kết với các tài khoản kế toán để tự động tính toán số liệu báo cáo.

---

*Ngày phân tích: 2026-03-29*
