# Báo cáo Phân tích DLL: GlRptBctc04.dll

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
| Assembly Name | GlRptBctc04 |
| Assembly Title | Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
GlRptBctc04.dll/
├── GlRptBctc04.csproj         # Project file
├── app.config                   # Application configuration
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGlRptBctc04.cs      # Main form class
│   ├── frmGLMauCF01.cs        # Form mẫu báo cáo lưu chuyển tiền
│   └── frmGLMauCF01Edit.cs      # Form chỉnh sửa mẫu
└── AsiaErp.UserInterface.My/
    ├── MySettings.cs            # Settings
    └── MySettingsProperty.cs    # Settings property
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
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptBctc04` | `frmReport` | Form báo cáo lưu chuyển tiền tệ |
| `frmGLMauCF01` | - | Form quản lý mẫu báo cáo lưu chuyển tiền |
| `frmGLMauCF01Edit` | - | Form chỉnh sửa mẫu báo cáo |

---

## Controls và UI Components

### Controls chính

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `cboKyTruoc` | ComboBox | Chọn kỳ trước để so sánh |
| `txtNgay01`, `txtNgay02` | AsMaskedTextBox | Ngày bắt đầu/kết thúc kỳ trước |
| `cmdCF` | Button | Nút "KB Công thức" |
| `Label1` | Label | Dấu "-" phân cách ngày |

### Controls kế thừa từ frmReport

| Control | Mục đích |
|---------|----------|
| `cboKyBc` | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | Ngày bắt đầu/kết thúc kỳ này |
| `cboMau_bc` | Chọn mẫu báo cáo |
| `txtTieu_De` | Tiêu đề báo cáo |
| `txtMa_Nt` | Mã ngoại tệ |
| `optVND`, `optNt` | Tùy chọn tiền tệ |
| `cmdOk`, `cmdCancel` | Nút OK/Cancel |
| `cmdExcel` | Xuất Excel |
| `cmdModifyReport` | Sửa báo cáo |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `Qd_cdkt` | Quyết định chế độ kế toán |
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính chỉ tiêu |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `chi_tieu` | Tên chỉ tiêu báo cáo |
| `KyBaoCao` | Kỳ báo cáo |
| `luu_chuyen_tien` | Luồng tiền (cash flow) |

---

## Phím tắt

| Phím | Chức năng |
|------|------------|
| F5 | Chi tiết công thức / Sổ chữ T |
| Ctrl+F5 | Sổ chi tiết |
| Shift+F5 | Cân đối phát sinh công nợ |
| F7 | Xem báo cáo |
| F9 | In báo cáo |

---

## Business Logic

### InitKyBaoCaoTruoc

Khởi tạo danh sách kỳ báo cáo trước:
1. Lấy danh sách kỳ từ `Environment.GetKyBaoCao`
2. Thiết lập ValueMember = "ma", DisplayMember = "ten_ky"
3. Tự động chọn kỳ từ PublicVariables nếu có

### cboKyTruoc_SelectedValueChanged

Xử lý khi chọn kỳ trước:
- Nếu chọn "NGAY": Cho phép nhập ngày thủ công
- Nếu chọn kỳ khác: Tự động tính ngày kỳ trước (trừ 1 năm)

### LoadData

Phương thức `LoadData` thực hiện:
1. Tạo ArrayList với các tham số:
   - CompanyID
   - Qd_cdkt
   - Ngày kỳ này (txtNgay1, txtNgay2)
   - Ngày kỳ trước (txtNgay01, txtNgay02)
   - Mã mẫu báo cáo
   - Mã ngoại tệ (txtMa_Nt)
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập FilterTitle và Quy vào FomularFields

### GetFilterCondiction

Tạo chuỗi điều kiện lọc hiển thị trên báo cáo:
- Kỳ báo cáo
- Kỳ trước (nếu có)
- Mã ngoại tệ (nếu có)

### cmdCF_Click

Mở form `frmGLMauCF01` để khai báo công thức tính các chỉ tiêu báo cáo lưu chuyển tiền.

### Drill-down

Hỗ trợ drill-down với phím F5:
- Nếu có `cach_tinh`: Drill-down xem chi tiết công thức
- Nếu có `tk_no` hoặc `tk_co`: Drill-down đến báo cáo chi tiết

---

## Mục đích sử dụng

**GlRptBctc04.dll là module báo cáo "Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp" (Cash Flow Statement - Direct Method)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

1. **Báo cáo lưu chuyển tiền**: Hiển thị báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp
2. **Phương pháp trực tiếp**: Thu thập thông tin trực tiếp từ các khoản thu/chi tiền
3. **So sánh kỳ**: Hỗ trợ so sánh với kỳ trước (cùng kỳ năm trước)
4. **Khai báo công thức**: Định nghĩa công thức tính các chỉ tiêu luồng tiền
5. **Drill-down**: Xem chi tiết từ báo cáo tổng hợp

### Cấu trúc báo cáo lưu chuyển tiền

Báo cáo bao gồm các phần:
1. **Lưu chuyển tiền từ hoạt động kinh doanh**
2. **Lưu chuyển tiền từ hoạt động đầu tư**
3. **Lưu chuyển tiền từ hoạt động tài chính**
4. **Tiền và tương đương tiền đầu kỳ/cuối kỳ**

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Tích hợp với module khai báo mẫu báo cáo (`frmGLMauCF01`)
- Sử dụng `KyBaoCao` để quản lý các kỳ báo cáo
- Hỗ trợ so sánh với kỳ trước (cùng kỳ năm trước)
- Phương pháp trực tiếp (Direct Method) - khác với phương pháp gián tiếp

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp - một trong 4 báo cáo tài chính bắt buộc theo chế độ kế toán Việt Nam.

---

*Ngày phân tích: 2026-03-29*
