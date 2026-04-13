# Báo cáo Phân tích DLL: GlRptBctc02.dll

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
| Assembly Name | GlRptBctc02 |
| Assembly Title | Bảng cân đối kế toán |
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
GlRptBctc02.dll/
├── GlRptBctc02.csproj         # Project file
├── app.config                   # Application configuration
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGlRptBctc02.cs      # Main form class
│   ├── frmGLMauBS01.cs        # Form mẫu bảng cân đối kế toán
│   └── frmGLMauBS01Edit.cs      # Form chỉnh sửa mẫu
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
- `AsiaErp.UserInterface.My`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptBctc02` | `frmReport` | Form báo cáo bảng cân đối kế toán |
| `frmGLMauBS01` | - | Form quản lý mẫu bảng cân đối kế toán |
| `frmGLMauBS01Edit` | - | Form chỉnh sửa mẫu báo cáo |

---

## Controls và UI Components

### Controls chính

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `cmdBS` | Button | Nút "KB Công thức" - mở form khai báo công thức |
| `chkChiTieuCoSoLieu` | CheckBox | Chỉ lên các chỉ tiêu có số liệu |

### Controls kế thừa từ frmReport

| Control | Mục đích |
|---------|----------|
| `cboKyBc` | Chọn kỳ báo cáo |
| `txtNgay2` | Ngày lập báo cáo |
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
| `Qd_cdkt` | Quyết định chế độ kế toán |
| `ma_so` | Mã số chỉ tiêu (ví dụ: 270, 440) |
| `tien0` | Số tiền kỳ trước |
| `tien` | Số tiền kỳ này |
| `cach_tinh` | Cách tính chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu báo cáo |
| `cong_no` | Công nợ |

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

### LoadData

Phương thức `LoadData` thực hiện:
1. Tạo ArrayList với các tham số:
   - CompanyID
   - Qd_cdkt
   - Ngày báo cáo (txtNgay2)
   - Checkbox chỉ tiêu có số liệu
   - Mã mẫu báo cáo
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập subtitle với ngày lập báo cáo
4. Kiểm tra cân đối tài sản = nguồn vốn (mã số 270 và 440)
5. Hiển thị cảnh báo nếu không cân đối

### Kiểm tra cân đối

Sau khi load dữ liệu, hệ thống tự động kiểm tra:
- Tổng tài sản (mã số 270) phải bằng Tổng nguồn vốn (mã số 440)
- Nếu không cân đối, hiển thị thông báo lỗi với số chênh lệch

### cmdBS_Click

Mở form `frmGLMauBS01` để khai báo công thức tính các chỉ tiêu bảng cân đối kế toán.

### Drill-down

Hỗ trợ drill-down với phím F5:
- Nếu có `cach_tinh`: Drill-down xem chi tiết công thức
- Nếu có `tk`: Drill-down đến sổ chữ T
- Ctrl+F5: Drill-down đến sổ chi tiết
- Shift+F5: Drill-down đến cân đối phát sinh công nợ (nếu cong_no = 1)

---

## Mục đích sử dụng

**GlRptBctc02.dll là module báo cáo "Bảng cân đối kế toán" (Balance Sheet)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

1. **Bảng cân đối kế toán**: Hiển thị bảng cân đối kế toán theo Thông tư 200/2014/TT-BTC
2. **Kiểm tra cân đối**: Tự động kiểm tra tổng tài sản = tổng nguồn vốn
3. **Lọc chỉ tiêu có số liệu**: Chỉ hiển thị các chỉ tiêu có phát sinh
4. **Khai báo công thức**: Định nghĩa công thức tính các chỉ tiêu tài sản, nợ phải trả, vốn chủ sở hữu
5. **Drill-down**: Xem chi tiết từ báo cáo tổng hợp

### Cấu trúc bảng cân đối kế toán

Báo cáo bao gồm các phần:
1. **TÀI SẢN NGẮN HẠN** (mã số 100)
2. **TÀI SẢN DÀI HẠN** (mã số 200)
3. **TỔNG CỘNG TÀI SẢN** (mã số 270)
4. **NỢ PHẢI TRẢ** (mã số 300)
5. **VỐN CHỦ SỞ HỮU** (mã số 400)
6. **TỔNG CỘNG NỢ PHẢI TRẢ VÀ VỐN CHỦ SỞ HỮU** (mã số 440)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Tích hợp với module khai báo mẫu báo cáo (`frmGLMauBS01`)
- Tự động kiểm tra cân đối tài sản = nguồn vốn
- Hỗ trợ so sánh với số đầu năm và cuối kỳ
- Ẩn các tùy chọn tiền tệ (chỉ hiển thị VND)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn bảng cân đối kế toán - một trong 4 báo cáo tài chính bắt buộc theo chế độ kế toán Việt Nam.

---

*Ngày phân tích: 2026-03-29*
