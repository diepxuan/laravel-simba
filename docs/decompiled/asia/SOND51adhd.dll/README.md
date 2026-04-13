# Báo cáo Phân tích DLL: SOND51adhd.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |
| Chức năng | Thêm hóa đơn - Quản lý quyết định áp dụng hóa đơn |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SOND51adhd |
| Assembly Title | SOQDIHD |
| Assembly Company | - |
| Assembly Product | SOQDIHD |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 0cc1c027-27f6-4bc8-9991-c9a191cf11a4 |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51adhd.dll/
├── SOND51adhd.csproj              # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOND51adhd.cs           # Main form class (kế thừa frmDMView)
│   └── frmSOND51adhdEdit.cs       # Edit form (kế thừa frmDMEdit)
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs               # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.DataAccess | Asia ERP Data Access |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSOND51adhd` | `frmDMView` | Form xem danh sách quyết định áp dụng hóa đơn |
| `frmSOND51adhdEdit` | `frmDMEdit` | Form nhập liệu quyết định áp dụng hóa đơn |

---

## Các Controls chính trong frmSOND51adhdEdit

### TextBox và Input Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_qd | AsTextBox | Mã quyết định |
| txtNgay_qd | AsMaskedTextBox | Ngày quyết định (dd/MM/yyyy) |
| txtNgay_ad | AsMaskedTextBox | Ngày áp dụng |
| txtNgay_hl | AsMaskedTextBox | Ngày hiệu lực |
| txtTen_cty | TextBox | Tên công ty |
| txtDangKy_KD | TextBox | Số đăng ký kinh doanh |
| txtGiam_doc | TextBox | Tên giám đốc |
| txtMa_bp | AsTextBox | Mã bộ phận (có AutoLookup) |
| txtCq_thue | TextBox | Cơ quan thuế quản lý |
| txtHethong_thietbi | TextBox | Hệ thống thiết bị |
| txtNhacungcap_dv | TextBox | Nhà cung cấp dịch vụ |
| txtHoadon_mucdich | TextBox (Multiline) | Các loại hóa đơn và mục đích sử dụng |
| txtTrachnhiem_bp | TextBox (Multiline) | Trách nhiệm các bộ phận |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Quyết định số", "Ngày quyết định", "Ngày áp dụng", "Ngày hiệu lực"
- "Tên đơn vị", "Số ĐKKD", "Giám đốc", "Bộ phận đề nghị"
- "CQ thuế quản lý", "Hệ thống thiết bị"
- "Các bộ phận kỹ thuật và tên nhà cung cấp dịch vụ chịu trách nhiệm về mặt kỹ thuật"
- "Các loại hoá đơn tự in và mục đích sử dụng"
- "Trách nhiệm của từng bộ phận trực thuộc liên quan"

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_qd` | Mã quyết định |
| `ngay_qd` | Ngày quyết định |
| `ngay_ad` | Ngày áp dụng |
| `ngay_hl` | Ngày hiệu lực |
| `ten_cty` | Tên công ty |
| `dangky_kd` | Đăng ký kinh doanh |
| `giam_doc` | Giám đốc |
| `ma_bp` | Mã bộ phận |
| `cq_thue` | Cơ quan thuế |
| `ht_tb` | Hệ thống thiết bị |
| `ncc` | Nhà cung cấp |
| `hdmd` | Hóa đơn mục đích |
| `tnbp` | Trách nhiệm bộ phận |

---

## Mục đích sử dụng

**SOND51adhd.dll là module quản lý "Thêm hóa đơn" (Quyết định áp dụng hóa đơn)** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý quyết định áp dụng hóa đơn
- Lập quyết định áp dụng hóa đơn tự in
- Quản lý thông tin công ty: tên, số ĐKKD, giám đốc, địa chỉ
- Quản lý thông tin cơ quan thuế quản lý
- Theo dõi ngày quyết định, ngày áp dụng, ngày hiệu lực

#### 2. Quản lý hệ thống thiết bị
- Ghi nhận hệ thống thiết bị in hóa đơn
- Theo dõi nhà cung cấp dịch vụ kỹ thuật
- Phân công trách nhiệm các bộ phận

#### 3. Phân loại hóa đơn
- Định nghĩa các loại hóa đơn tự in
- Ghi nhận mục đích sử dụng từng loại hóa đơn
- Quản lý bộ phận đề nghị

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Validation dữ liệu đầu vào bắt buộc
- Tự động điền thông tin công ty mặc định khi thêm mới
- Hỗ trợ AutoLookup cho mã bộ phận
- Mã quyết định có giới hạn độ dài theo cấu hình hệ thống

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, phục vụ cho việc quản lý quyết định áp dụng hóa đơn tự in - một chức năng quan trọng trong quản lý hóa đơn doanh nghiệp theo quy định của cơ quan thuế.

---

*Ngày phân tích: 2026-03-29*
