# Báo cáo Phân tích DLL: GLRptBCTCCDTF03A.dll

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
| Assembly Name | GLRptBCTCCDTF03A |
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
GLRptBCTCCDTF03A.dll/
├── GLRptBCTCCDTF03A.csproj      # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptBCTCCDTF03A.cs   # Main form class
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
| `frmGLRptBCTCCDTF03A` | `frmReport` | Form báo cáo tài chính chi tiết F03A |

---

## Controls và UI Components

### Controls chính

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `txtTk_xaylap` | AsTextBox | Tài khoản xây lắp |
| `lblTen_Tk_xaylap` | Label | Tên TK xây lắp |
| `lblTk_xaylap` | Label | Nhãn "Tk xây lắp" |
| `txtTk_Thietbi` | AsTextBox | Tài khoản thiết bị |
| `lblTen_Tk_Thietbi` | Label | Tên TK thiết bị |
| `lblTk_Thietbi` | Label | Nhãn "Tk thiết bị" |
| `txtTk_boithuong` | AsTextBox | Tài khoản bồi thường |
| `lblTen_Tk_boithuong` | Label | Tên TK bồi thường |
| `lblTk_boithuong` | Label | Nhãn "Tk bồi thường" |
| `txtTk_QLDA` | AsTextBox | Tài khoản quản lý dự án |
| `lblTen_Tk_QLDA` | Label | Tên TK QLDA |
| `lblTk_QLDA` | Label | Nhãn "Tk QLDA" |
| `txtTk_TuVan` | AsTextBox | Tài khoản tư vấn |
| `lblTen_Tk_TuVan` | Label | Tên TK tư vấn |
| `lblTk_TuVan` | Label | Nhãn "Tk tư vấn" |
| `txtTk_Khac` | AsTextBox | Tài khoản khác |
| `lblTen_Tk_Khac` | Label | Tên TK khác |
| `lblTk_Khac` | Label | Nhãn "Tk khác" |
| `txtMa_SPCT` | AsTextBox | Mã sản phẩm chi tiết |
| `lblTen_SPCT` | Label | Tên SPCT |
| `lblMa_SPCT` | Label | Nhãn "Mã SPCT" |

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
| `tk_xaylap` | Tài khoản xây lắp |
| `tk_thietbi` | Tài khoản thiết bị |
| `tk_boithuong` | Tài khoản bồi thường |
| `tk_qlda` | Tài khoản quản lý dự án |
| `tk_tuvan` | Tài khoản tư vấn |
| `tk_khac` | Tài khoản khác |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ngay_ct1`, `ngay_ct2` | Ngày chứng từ từ/đến |

---

## Business Logic

### InitOtherComponents

Khởi tạo giá trị mặc định từ menu:
- `txtTk_xaylap.Text = MyMenuInfo.par1`
- `txtTk_Thietbi.Text = MyMenuInfo.par2`
- `txtTk_boithuong.Text = MyMenuInfo.par3`
- `txtTk_QLDA.Text = MyMenuInfo.par4`
- `txtTk_TuVan.Text = MyMenuInfo.par5`
- `txtTk_Khac.Text = MyMenuInfo.par6`

### LoadData

Phương thức `LoadData` thực hiện:
1. Tạo ArrayList với các tham số:
   - CompanyID
   - Ngày bắt đầu (txtNgay1)
   - Ngày kết thúc (txtNgay2)
   - Tài khoản xây lắp (txtTk_xaylap)
   - Tài khoản thiết bị (txtTk_Thietbi)
   - Tài khoản bồi thường (txtTk_boithuong)
   - Tài khoản QLDA (txtTk_QLDA)
   - Tài khoản tư vấn (txtTk_TuVan)
   - Tài khoản khác (txtTk_Khac)
   - Mã SPCT (txtMa_SPCT)
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập FilterTitle vào FomularFields

### getfiltertitle

Tạo chuỗi tiêu đề lọc hiển thị trên báo cáo:
- Tài khoản xây lắp (nếu có)
- Tài khoản thiết bị (nếu có)
- Tài khoản bồi thường (nếu có)
- Tài khoản QLDA (nếu có)
- Tài khoản tư vấn (nếu có)
- Tài khoản khác (nếu có)
- Mã SPCT (nếu có)

---

## Mục đích sử dụng

**GLRptBCTCCDTF03A.dll là module báo cáo "Báo cáo tài chính chi tiết F03A"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

1. **Báo cáo chi tiết F03A**: Hiển thị báo cáo tài chính chi tiết theo mẫu F03A
2. **Phân loại TK xây dựng**: Hỗ trợ nhập nhiều loại tài khoản liên quan đến xây dựng:
   - Xây lắp
   - Thiết bị
   - Bồi thường
   - Quản lý dự án
   - Tư vấn
   - Khác
3. **Lọc theo SPCT**: Cho phép lọc theo mã sản phẩm chi tiết
4. **Tham số từ menu**: Nhận 6 tham số tài khoản từ menu gọi
5. **Xuất Excel**: Hỗ trợ xuất báo cáo ra Excel

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Sử dụng nhiều tham số từ `MyMenuInfo` (par1 đến par6)
- Chuyên biệt cho ngành xây dựng, dự án
- Hỗ trợ lọc theo sản phẩm chi tiết (SPCT)
- Ẩn các tùy chọn tiền tệ (chỉ hiển thị VND)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn báo cáo tài chính chi tiết F03A - một báo cáo chi tiết chuyên dụng cho ngành xây dựng, cho phép phân loại chi phí theo nhiều loại tài khoản khác nhau.

---

*Ngàng phân tích: 2026-03-29*
