# Báo cáo Phân tích DLL: GlRptBctc03.dll

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
| Assembly Name | GlRptBctc03 |
| Assembly Title | Báo cáo kết quả hoạt động kinh doanh |
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
GlRptBctc03.dll/
├── GlRptBctc03.csproj         # Project file
├── app.config                   # Application configuration
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGlRptBctc03.cs      # Main form class
│   ├── frmGLMauPL01.cs        # Form mẫu báo cáo KQKD
│   └── frmGLMauPL01Edit.cs      # Form chỉnh sửa mẫu
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
| `frmGlRptBctc03` | `frmReport` | Form báo cáo kết quả hoạt động kinh doanh |
| `frmGLMauPL01` | - | Form quản lý mẫu báo cáo KQKD |
| `frmGLMauPL01Edit` | - | Form chỉnh sửa mẫu báo cáo |

---

## Controls và UI Components

### Controls chính

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `cboKyTruoc` | ComboBox | Chọn kỳ trước để so sánh |
| `txtNgay01`, `txtNgay02` | AsMaskedTextBox | Ngày bắt đầu/kết thúc kỳ trước |
| `txtMa_Bp` | AsTextBox | Mã bộ phận |
| `lblTen_Bp` | Label | Tên bộ phận |
| `cmdPL` | Button | Nút "KB Công thức" |
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
| `ma_bp` | Mã bộ phận |
| `KyBaoCao` | Kỳ báo cáo |

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
   - Mã bộ phận (txtMa_Bp)
   - Mã ngoại tệ (txtMa_Nt)
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập FilterTitle và Quy vào FomularFields

### GetFilterCondiction

Tạo chuỗi điều kiện lọc hiển thị trên báo cáo:
- Kỳ báo cáo
- Kỳ trước (nếu có)
- Mã bộ phận (nếu có)
- Mã ngoại tệ (nếu có)

### cmdPL_Click

Mở form `frmGLMauPL01` để khai báo công thức tính các chỉ tiêu báo cáo KQKD.

### Drill-down

Hỗ trợ drill-down với phím F5:
- Nếu có `cach_tinh`: Drill-down xem chi tiết công thức
- Nếu có `tk_no` hoặc `tk_co`: Drill-down đến báo cáo chi tiết

---

## Mục đích sử dụng

**GlRptBctc03.dll là module báo cáo "Báo cáo kết quả hoạt động kinh doanh" (Income Statement)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

1. **Báo cáo KQKD**: Hiển thị báo cáo kết quả hoạt động kinh doanh theo Thông tư 200/2014/TT-BTC
2. **So sánh kỳ**: Hỗ trợ so sánh với kỳ trước (cùng kỳ năm trước)
3. **Lọc theo bộ phận**: Cho phép xem báo cáo theo từng bộ phận
4. **Khai báo công thức**: Định nghĩa công thức tính các chỉ tiêu doanh thu, chi phí, lợi nhuận
5. **Drill-down**: Xem chi tiết từ báo cáo tổng hợp

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Tích hợp với module khai báo mẫu báo cáo (`frmGLMauPL01`)
- Sử dụng `KyBaoCao` để quản lý các kỳ báo cáo
- Hỗ trợ so sánh với kỳ trước (cùng kỳ năm trước)
- Hỗ trợ lọc theo bộ phận (profit center)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn báo cáo kết quả hoạt động kinh doanh - một trong 4 báo cáo tài chính bắt buộc theo chế độ kế toán Việt Nam.

---

*Ngày phân tích: 2026-03-29*
