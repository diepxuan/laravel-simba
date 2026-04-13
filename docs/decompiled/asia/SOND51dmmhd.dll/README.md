# Báo cáo Phân tích DLL: SOND51dmmhd.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |
| Chức năng | Danh mục mẫu hóa đơn - Quản lý mẫu hóa đơn và ký hiệu |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SOND51dmmhd |
| Assembly Title | SOKBMHD |
| Assembly Company | - |
| Assembly Product | SOKBMHD |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | afbc8b0d-a340-414a-a8c2-4533d4c19a12 |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51dmmhd.dll/
├── SOND51dmmhd.csproj             # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOND51dmmhd.cs          # Main form class (kế thừa frmDMView)
│   └── frmSOND51dmmhdEdit.cs      # Edit form (kế thừa frmDMEdit)
├── AsiaErp.DataAccess/
│   ├── SOND51dmmhdDAO.cs          # Data Access Object interface
│   └── MsSqlSOND51dmmhdDAO.cs     # SQL Server implementation
└── My.Resources/
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
| `frmSOND51dmmhd` | `frmDMView` | Form xem danh sách mẫu hóa đơn |
| `frmSOND51dmmhdEdit` | `frmDMEdit` | Form nhập liệu mẫu hóa đơn |
| `SOND51dmmhdDAO` | - | Interface DAO |
| `MsSqlSOND51dmmhdDAO` | - | SQL Server DAO implementation |

---

## Các Controls chính trong frmSOND51dmmhdEdit

### Input Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| txtTen_loai | TextBox | Tên loại hóa đơn (readonly) |
| txtMa_loai | AsTextBox | Mã loại hóa đơn (readonly) |
| txtSo_lien | AsTextNumeric | Số liên hóa đơn (1-9) |
| txtSo_hd | AsTextNumeric | Số hóa đơn (001-999) |
| lblMau_so | Label | Mẫu số (tự động tạo) |
| txtTen_mau | TextBox | Tên mẫu hóa đơn |
| chkTu_in | RadioButton | Loại in: Tự in (T) |
| chkDat_in | RadioButton | Loại in: Đặt in (P) |
| txtKh_hd | AsTextBox | Ký hiệu hóa đơn (AA, AB...) |
| txtKh_nam | AsTextNumeric | Năm ký hiệu (2 số) |
| txtLoai_in | TextBox | Loại in (T/P) - readonly |
| lblSo_seri | Label | Số seri (tự động tạo) |
| txtSo_dong | TextBox | Số dòng trên hóa đơn |
| txtGhi_chu | TextBox | Ghi chú |

### DataGridView

| Control | Loại | Mục đích |
|---------|------|----------|
| adgvLien | AsInputDGV | Danh sách các liên hóa đơn |

### Cột DataGridView

| Cột | Ý nghĩa |
|-----|---------|
| lien | Tên liên (Liên 1, Liên 2...) |
| mota | Mô tả liên (ví dụ: "Liên 2: Giao cho khách hàng") |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Loại hoá đơn", "Mẫu số", "Tên mẫu"
- "Loại in", "Ký hiệu", "Số dòng", "Ghi chú"
- "Tự in (T)", "Đặt in (P)"
- "Liên", "Mô Tả"

### Validation Messages

- Kiểm tra số liên từ 2-9
- Kiểm tra số hóa đơn >= 1
- Kiểm tra năm ký hiệu >= 1
- Mô tả liên phải bắt đầu bằng "Liên X:"

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_loai` | Mã loại hóa đơn |
| `ten_loai` | Tên loại hóa đơn |
| `so_lien` | Số liên |
| `so_hd` | Số hóa đơn |
| `mau_so` | Mẫu số (format: XXN/XXX) |
| `ten_mau` | Tên mẫu |
| `loai_in` | Loại in (T/P) |
| `kh_hd` | Ký hiệu hóa đơn |
| `kh_nam` | Năm ký hiệu |
| `so_seri` | Số seri (format: XX/XXT) |
| `so_dong` | Số dòng |
| `ghi_chu` | Ghi chú |

---

## Mục đích sử dụng

**SOND51dmmhd.dll là module "Danh mục mẫu hóa đơn"** trong hệ thống ERP của Asia Software, quản lý các mẫu hóa đơn và thông tin ký hiệu.

### Chức năng chính

#### 1. Quản lý mẫu hóa đơn
- Định nghĩa mẫu số hóa đơn theo quy định
- Quản lý tên mẫu và loại hóa đơn
- Hỗ trợ tối đa 9 liên hóa đơn
- Phân biệt hóa đơn tự in và đặt in

#### 2. Tạo mẫu số và ký hiệu tự động
- Mẫu số format: `[Mã loại][Số liên]/[Số HĐ]` (VD: 012/001)
- Ký hiệu format: `[Ký hiệu HĐ]/[Năm][Loại in]` (VD: AA/11T)
- Tự động cập nhật khi thay đổi thành phần

#### 3. Quản lý liên hóa đơn
- Định nghĩa mô tả cho từng liên
- Validate mô tả liên phải có format chuẩn
- Tối thiểu 2 liên, tối đa 9 liên
- Liên 1 và 2 mặc định readonly

#### 4. Validation dữ liệu
- Số liên: 2-9
- Số hóa đơn: >= 1
- Năm ký hiệu: >= 1
- Tên mẫu: bắt buộc
- Ký hiệu: bắt buộc
- Mô tả các liên: bắt buộc và đúng format

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- DataGridView động theo số liên
- Tự động tạo mẫu số và ký hiệu
- Validation nghiêm ngặt theo quy định
- Sử dụng DAO pattern cho data access

### Quy tắc tạo mẫu số và ký hiệu

```
Mẫu số = [Mã loại][Số liên]/[Số HĐ 3 chữ số]
Ví dụ: Mã loại=01, Số liên=2, Số HĐ=1 → 012/001

Ký hiệu = [Ký hiệu 2 ký tự]/[Năm 2 số][T hoặc P]
Ví dụ: Ký hiệu=AA, Năm=11, Loại=Tự in → AA/11T
```

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, phục vụ cho việc quản lý danh mục mẫu hóa đơn theo quy định của cơ quan thuế, bao gồm việc định nghĩa mẫu số, ký hiệu và các liên hóa đơn.

---

*Ngày phân tích: 2026-03-29*
