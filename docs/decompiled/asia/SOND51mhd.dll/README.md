# Báo cáo Phân tích DLL: SOND51mhd.dll

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
| Assembly Name | SOND51mhd |
| Assembly Title | SOKBMHD |
| Assembly Product | SOKBMHD |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | afbc8b0d-a340-414a-a8c2-4533d4c19a12 |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51mhd.dll/
├── SOND51mhd.csproj             # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOND51mhd.cs          # Form danh sách
│   └── frmSOND51mhdEdit.cs      # Form nhập liệu chi tiết
├── AsiaErp.DataAccess/
│   ├── SOND51mhdDAO.cs          # Data access interface
│   └── MsSqlSOND51mhdDAO.cs     # SQL Server implementation
├── My/
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   └── MySettingsProperty.cs
└── My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Microsoft.VisualBasic.PowerPacks | Shape controls |
| Framework | Asia ERP Framework |
| AsiaErp.DataAccess | Data access layer |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`
- `Microsoft.VisualBasic.PowerPacks`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSOND51mhd` | `frmDMView` | Form danh sách mã hóa đơn |
| `frmSOND51mhdEdit` | `frmDMEdit` | Form nhập liệu khổ/bảng in hóa đơn |
| `SOND51mhdDAO` | - | Interface cho data access |
| `MsSqlSOND51mhdDAO` | - | Implementation SQL Server |

---

## Các trường dữ liệu chính

### Thông tin khổ in hóa đơn

| Trường | Ý nghĩa |
|--------|---------|
| `loai_hd` | Loại hóa đơn |
| `ma_loai` | Mã loại |
| `lien` | Số liên |
| `so_hd` | Số hóa đơn |
| `mau_so` | Mẫu số (tự động sinh) |
| `ten_mau` | Tên mẫu |
| `loai_in` | Loại in (T - Tự in; P - Đặt in) |
| `kh_hd` | Ký hiệu hóa đơn |
| `kh_nam` | Ký hiệu năm |
| `so_seri` | Số sê-ri (tự động sinh) |
| `so_dong` | Số dòng |
| `ghi_chu` | Ghi chú |

### Chi tiết liên (DataGridView)

| Cột | Ý nghĩa |
|-----|---------|
| `lien` | Số liên |
| `mota` | Mô tả liên (Liên 1, Liên 2, ...) |

---

## Mục đích sử dụng

**SOND51mhd.dll là module quản lý khổ/bảng in hóa đơn** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý khổ in hóa đơn
- Định nghĩa số liên của hóa đơn (2-9 liên)
- Mẫu số hóa đơn (tự động sinh từ ma_loai + lien + so_hd)
- Ký hiệu hóa đơn (kh_hd/kh_nam + loai_in)

#### 2. Quản lý thông tin in ấn
- Loại in: Tự in (T) hoặc Đặt in (P)
- Số dòng trên hóa đơn
- Tên mẫu hóa đơn

#### 3. Chi tiết các liên
- Grid hiển thị mô tả từng liên (Liên 1, Liên 2, ...)
- Liên 1 và Liên 2 là readonly (liên giao cho khách, liên lưu)
- Các liên còn lại có thể tùy chỉnh mô tả

#### 4. Tự động sinh mã
- Mẫu số: ma_loai + lien + "/" + so_hd (với leading zeros)
- Số sê-ri: kh_hd + "/" + kh_nam + loai_in

### Đặc điểm kỹ thuật

- Sử dụng ShapeContainer và LineShape để vẽ đường phân cách
- DataGridView để quản lý chi tiết liên
- Auto-generate mau_so và so_seri khi thay đổi thông tin
- Validation kiểm tra số liên (2-9)
- Validation kiểm tra mô tả liên phải bắt đầu bằng "Liên X:"

### Validation

- Số liên: 2-9 (nếu ngoài khoảng này sẽ báo lỗi 50154)
- Số hóa đơn: >= 1 (nếu < 1 báo lỗi 50153)
- Ký hiệu năm: >= 1 (nếu < 1 báo lỗi 50155)
- Mô tả liên phải bắt đầu bằng "Liên X:" (với X là số liên)
- Độ dài mô tả liên >= 8 ký tự
- Các trường bắt buộc: ten_mau, loai_in, kh_hd, kh_nam, so_dong

---

## Các sự kiện chính

| Sự kiện | Mô tả |
|---------|-------|
| `txtLien_Leave` | Kiểm tra số liên, nạp grid chi tiết |
| `txtSo_hd_Leave` | Kiểm tra số hóa đơn, format lại |
| `txtKh_nam_Leave` | Kiểm tra ký hiệu năm |
| `MauSoChanged` | Cập nhật mẫu số khi thay đổi |
| `KyHieuChanged` | Cập nhật ký hiệu khi thay đổi |

---

## Kết luận

Đây là module Windows Forms quản lý khổ/bảng in hóa đơn, cho phép định nghĩa số liên, mẫu số, ký hiệu và mô tả chi tiết từng liên của hóa đơn. Module hỗ trợ tự động sinh mã và validation đầy đủ theo quy định về hóa đơn tại Việt Nam.

---

*Ngày phân tích: 2026-03-29*
