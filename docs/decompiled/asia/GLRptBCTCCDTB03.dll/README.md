# Báo cáo Phân tích DLL: GLRptBCTCCDTB03.dll

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
| Assembly Name | GLRptBCTCCDTB03 |
| Assembly Title | GLRptKPDA01 |
| Assembly Company | - |
| Assembly Product | GLRptKPDA01 |
| Assembly Copyright | Copyright © 2013 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 9e59f574-a6c1-478e-8b30-0386e1a700c3 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptBCTCCDTB03.dll/
├── GLRptBCTCCDTB03.csproj       # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptBCTCCDTB03.cs    # Main form class
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs           # Application settings
│   ├── MyComputer.cs             # Computer settings
│   ├── MyProject.cs              # Project settings
│   ├── MySettings.cs             # Settings
│   └── MySettingsProperty.cs       # Settings property
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs              # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.Helper | Asia ERP Helper |
| System.Data | Data access |
| System.Windows.Forms | Windows Forms |
| Microsoft.VisualBasic.CompilerServices | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCTCCDTB03` | `frmReport` | Form báo cáo tài chính chi tiết B03 |

---

## Controls và UI Components

### Controls chính

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `txtTk` | AsTextBox | Nhập tài khoản |
| `lblTen_Tk` | Label | Tên tài khoản |
| `lblTk` | Label | Nhãn "Tài khoản" |
| `txtBacTk` | AsTextNumeric | Bậc tài khoản |
| `lblBacTk` | Label | Nhãn "Bậc tài khoản" |

### Controls kế thừa từ frmReport

| Control | Mục đích |
|---------|----------|
| `cboKyBc` | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | Ngày bắt đầu/kết thúc |
| `cboMau_bc` | Chọn mẫu báo cáo |
| `txtTieu_De` | Tiêu đề báo cáo |
| `txtMa_Nt` | Mã ngoại tệ (ẩn) |
| `optVND`, `optNt` | Tùy chọn tiền tệ (ẩn) |
| `cmdOk`, `cmdCancel` | Nút OK/Cancel |
| `cmdExcel` | Xuất Excel |
| `cmdModifyReport` | Sửa báo cáo |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `tk` | Tài khoản |
| `bac_tk` | Bậc tài khoản |
| `ngay_ct1`, `ngay_ct2` | Ngày chứng từ từ/đến |
| `ma_nt` | Mã ngoại tệ |

---

## Business Logic

### InitOtherComponents

Khởi tạo giá trị mặc định:
- `txtTk.Text = MyMenuInfo.par1` (tài khoản từ menu)
- `txtBacTk.Text = MyMenuInfo.par2` (bậc tài khoản từ menu)

### LoadData

Phương thức `LoadData` thực hiện:
1. Tạo ArrayList với các tham số:
   - CompanyID
   - Ngày bắt đầu (txtNgay1)
   - Ngày kết thúc (txtNgay2)
   - Tài khoản (txtTk)
   - Bậc tài khoản (txtBacTk)
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập FilterTitle vào FomularFields

### GetFilterTitle

Tạo chuỗi tiêu đề lọc hiển thị trên báo cáo:
- Tài khoản (nếu có)
- Bậc tài khoản (nếu có)

---

## Mục đích sử dụng

**GLRptBCTCCDTB03.dll là module báo cáo "Báo cáo tài chính chi tiết B03"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

1. **Báo cáo chi tiết B03**: Hiển thị báo cáo tài chính chi tiết theo mẫu B03
2. **Lọc theo tài khoản**: Cho phép lọc theo tài khoản cụ thể và bậc tài khoản
3. **Tham số từ menu**: Nhận tham số tài khoản và bậc từ menu gọi
4. **Xuất Excel**: Hỗ trợ xuất báo cáo ra Excel

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Sử dụng tham số từ `MyMenuInfo` (par1, par2)
- Ẩn các tùy chọn tiền tệ (chỉ hiển thị VND)
- Đơn giản hóa giao diện so với các báo cáo tài chính khác

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn báo cáo tài chính chi tiết B03 - một báo cáo chi tiết trong hệ thống báo cáo tài chính.

---

*Ngày phân tích: 2026-03-29*
