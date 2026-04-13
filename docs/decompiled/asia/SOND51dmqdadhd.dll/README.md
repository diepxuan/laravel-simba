# Báo cáo Phân tích DLL: SOND51dmqdadhd.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SOND51dmqdadhd |
| Assembly Title | SOQDIHD |
| Assembly Product | SOQDIHD |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 0cc1c027-27f6-4bc8-9991-c9a191cf11a4 |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51dmqdadhd.dll/
├── SOND51dmqdadhd.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOND51dmqdadhd.cs     # Main form (danh sách)
│   └── frmSOND51dmqdadhdEdit.cs # Form nhập liệu chi tiết
├── AsiaErp.UserInterface.My/
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   └── MySettingsProperty.cs
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
| System.Windows.Forms | UI framework |
| Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSOND51dmqdadhd` | `frmDMComplexView` | Form danh sách quyết định áp dụng hóa đơn |
| `frmSOND51dmqdadhdEdit` | `frmDMComplexEdit` | Form nhập liệu/sửa quyết định áp dụng hóa đơn |
| `Resources` | - | Resource manager cho localization |

---

## Các trường dữ liệu chính

### Thông tin quyết định

| Trường | Ý nghĩa |
|--------|---------|
| `ma_qd` | Số quyết định |
| `ngay_qd` | Ngày quyết định |
| `ngay_ad` | Ngày áp dụng |
| `ngay_hl` | Ngày hiệu lực |
| `ten_cty` | Tên công ty |
| `dangky_kd` | Số đăng ký kinh doanh |
| `giam_doc` | Giám đốc |
| `ma_bp` | Mã bộ phận đề nghị |
| `ten_bp` | Tên bộ phận |
| `cq_thue` | Cơ quan thuế quản lý |
| `ht_tb` | Hệ thống thiết bị |
| `ncc` | Nhà cung cấp dịch vụ kỹ thuật |
| `hdmd` | Hóa đơn mục đích sử dụng |
| `tnbp` | Trách nhiệm bộ phận |

---

## Mục đích sử dụng

**SOND51dmqdadhd.dll là module quản lý danh mục quyết định áp dụng hóa đơn** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý quyết định áp dụng hóa đơn
- Lưu trữ thông tin quyết định của cơ quan thuế về việc áp dụng hóa đơn
- Quản lý ngày quyết định, ngày áp dụng, ngày hiệu lực
- Thông tin công ty, giám đốc, bộ phận đề nghị

#### 2. Thông tin đăng ký kinh doanh
- Số đăng ký kinh doanh
- Tên công ty
- Cơ quan thuế quản lý

#### 3. Thông tin kỹ thuật
- Hệ thống thiết bị sử dụng
- Nhà cung cấp dịch vụ kỹ thuật
- Các loại hóa đơn và mục đích sử dụng
- Trách nhiệm của từng bộ phận

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với các control AsTextBox, AsMaskedTextBox
- Validation dữ liệu đầy đủ cho các trường bắt buộc
- Tự động điền thông tin công ty từ CompanyInformations
- Hỗ trợ lookup mã bộ phận (MA_BP)

### Validation

- Các trường bắt buộc: ma_qd, ngay_qd, ngay_ad, ngay_hl, ten_cty, dangky_kd, giam_doc, ma_bp, cq_thue, ht_tb, ncc, hdmd, tnbp
- Kiểm tra dữ liệu không được để trống
- Format ngày theo dd/MM/yyyy

---

## Kết luận

Đây là module Windows Forms quản lý danh mục quyết định áp dụng hóa đơn - một loại danh mục quan trọng trong việc quản lý hóa đơn theo quy định của cơ quan thuế Việt Nam.

---

*Ngày phân tích: 2026-03-29*
