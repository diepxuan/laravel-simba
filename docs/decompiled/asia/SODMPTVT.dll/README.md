# Báo cáo Phân tích DLL: SODMPTVT.dll

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
| Assembly Name | SODMPTVT |
| Assembly Title | Danh mục phương tiện vận tải |
| Assembly Company | - |
| Assembly Product | SODMPTVT |
| Assembly Copyright | Copyright © 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 8ad27e03-afec-4e12-acc0-9c1e1b464aff |
| ComVisible | false |

---

## Cấu trúc File

```
SODMPTVT.dll/
├── SODMPTVT.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSODMPTVT.cs         # Main view form
│   └── frmSODMPTVTEdit.cs     # Edit form
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    ├── MyComputer.cs
    └── MyApplication.cs
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System | Core .NET Framework |
| System.Drawing | Graphics và UI |
| System.Windows.Forms | Windows Forms UI |
| AsiaErp.Framework | Asia ERP Framework (frmDMView, frmDMEdit) |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSODMPTVT` | `frmDMView` | Form xem danh sách phương tiện vận tải |
| `frmSODMPTVTEdit` | `frmDMEdit` | Form nhập/sửa thông tin phương tiện |

---

## Các trường dữ liệu (frmSODMPTVTEdit)

### TextBox controls
| Control | Trường DB | Mô tả |
|---------|-------------|-------|
| txtMa_pt | Ma_pt | Mã phương tiện |
| txtTen_pt | Ten_pt | Tên phương tiện |
| txtBien_so | Bien_so | Biển số xe |
| txtNguoi_dk | nguoi_dk | Người điều khiển |

### Numeric controls (AsTextNumeric)
| Control | Trường DB | Đơn vị | Mô tả |
|---------|-------------|----------|-------|
| txtCao | cao | m | Chiều cao |
| txtRong | rong | m | Chiều rộng |
| txtDai | dai | m | Chiều dài |
| txtThe_tich | the_tich | m³ | Thể tích |
| txtTrong_tai | trong_tai | tấn | Trọng tải |
| txtTG_xep | tg_xep | giờ | Thời gian xếp |
| txtTG_do | tg_do | giờ | Thời gian dỡ |

### Checkbox
| Control | Trường DB | Mô tả |
|---------|-------------|-------|
| chkKsd | ksd | Không sử dụng |

---

## Mục đích sử dụng

**SODMPTVT.dll là module quản lý Danh mục phương tiện vận tải** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý thông tin phương tiện
- Mã phương tiện (Ma_pt)
- Tên phương tiện (Ten_pt)
- Biển số xe (Bien_so)
- Người điều khiển (nguoi_dk)

#### 2. Quản lý thông số kỹ thuật
- Kích thước: Cao, Rộng, Dài (m)
- Thể tích chứa hàng (m³)
- Trọng tải (tấn)
- Thời gian xếp/dỡ hàng (giờ)

#### 3. Tính năng cơ bản
- Thêm mới, sửa, xóa phương tiện
- Kiểm tra dữ liệu bắt buộc (Mã, Tên)
- Đánh dấu không sử dụng (ksd)
- Tự động tính toán và binding dữ liệu

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` và `frmDMEdit` của Framework
- Sử dụng DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ nhập số với định dạng decimal
- Mask format: `### ### ### ###.##`

---

## Kết luận

Đây là module Windows Forms quản lý danh mục phương tiện vận tải, phục vụ cho việc theo dõi và quản lý đội xe trong hệ thống ERP. Module này lưu trữ thông tin chi tiết về phương tiện bao gồm thông số kỹ thuật và thời gian xếp/dỡ hàng.

---

*Ngày phân tích: 2026-03-29*
