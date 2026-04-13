# Báo cáo Phân tích DLL: SOND51bkhd.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |
| Chức năng | Bảng kê hóa đơn - Quản lý thông báo hóa đơn hết giá trị và gia hạn |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SOND51bkhd |
| Assembly Title | SOND51bkhd |
| Assembly Company | - |
| Assembly Product | SOND51bkhd |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2f6a81c1-6630-4468-96e2-7835a56fcac3 |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51bkhd.dll/
├── SOND51bkhd.csproj              # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOND51bkhd.cs           # Main form class (kế thừa frmDMComplexView)
│   ├── frmSOND51bkhdEdit.cs       # Edit form (kế thừa frmDMComplexEdit)
│   └── frmChonHD.cs               # Form chọn hóa đơn
├── AsiaErp.DataAccess/
│   ├── SOND51bkhdDAO.cs           # Data Access Object interface
│   └── MsSqlSOND51bkhdDAO.cs      # SQL Server implementation
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
| `frmSOND51bkhd` | `frmDMComplexView` | Form xem danh sách bảng kê hóa đơn |
| `frmSOND51bkhdEdit` | `frmDMComplexEdit` | Form nhập liệu bảng kê hóa đơn |
| `frmChonHD` | - | Form chọn hóa đơn |
| `SOND51bkhdDAO` | - | Interface DAO |
| `MsSqlSOND51bkhdDAO` | - | SQL Server DAO implementation |

---

## Các Controls chính trong frmSOND51bkhdEdit

### Input Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_tb | AsTextBox | Số thông báo |
| txtNgay_tb | AsMaskedTextBox | Ngày thông báo (dd/MM/yyyy) |
| txtMa_thue | TextBox | Mã số thuế |
| txtTen_cty | TextBox | Tên công ty |
| txtDai_dien | TextBox | Người đại diện |

### DataGridView Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| adgvHDHetHan | AsInputDGV | Danh sách hóa đơn hết giá trị sử dụng |
| adgvHDGiaHan | AsInputDGV | Danh sách hóa đơn đăng ký tiếp tục sử dụng |

### Button Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| btnChonHD1 | Button | Chọn hóa đơn hết hạn |
| btnChonHD2 | Button | Chọn hóa đơn gia hạn |
| btnXoaHD1 | Button | Xóa hóa đơn hết hạn |
| btnXoaHD2 | Button | Xóa hóa đơn gia hạn |

---

## Cột DataGridView

### adgvHDHetHan (Hóa đơn hết giá trị)

| Cột | Ý nghĩa |
|-----|---------|
| ma_ph | Mã phiếu (ẩn) |
| loai | Loại bảng kê (ẩn) |
| ten_loai | Tên loại hóa đơn |
| mau_so | Mẫu số |
| so_seri | Ký hiệu |
| tu_so | Từ số |
| den_so | Đến số |
| so_luong | Số lượng |
| so_hdin | Số HĐ in (ẩn) |
| so_hdph | Số HĐ phát hành (ẩn) |

### adgvHDGiaHan (Hóa đơn gia hạn)

| Cột | Ý nghĩa |
|-----|---------|
| ma_ph | Mã phiếu (ẩn) |
| loai | Loại bảng kê (ẩn) |
| ten_loai | Tên loại hóa đơn |
| mau_so | Mẫu số |
| so_seri | Ký hiệu |
| tu_so | Từ số |
| den_so | Đến số |
| so_luong | Số lượng |
| so_hdin | Số HĐ in (ẩn) |
| so_hdph | Số HĐ phát hành (ẩn) |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Ngày thông báo", "Số thông báo", "Mã số thuế"
- "Tên công ty", "Đại diện"
- "Hoá đơn hết giá trị sử dụng"
- "Hoá đơn đăng ký tiếp tục sử dụng"
- "&1.Chọn HĐ", "&2.Xoá HĐ", "&3.Chọn HĐ", "&4.Xoá HĐ"

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_tb` | Mã thông báo |
| `ngay_tb` | Ngày thông báo |
| `ma_thue` | Mã số thuế |
| `ten_cty` | Tên công ty |
| `dai_dien` | Người đại diện |
| `ma_ph` | Mã phiếu |
| `ten_loai` | Tên loại hóa đơn |
| `mau_so` | Mẫu số |
| `so_seri` | Số seri (ký hiệu) |
| `tu_so` | Từ số |
| `den_so` | Đến số |
| `so_luong` | Số lượng |
| `so_hdin` | Số hóa đơn in |
| `so_hdph` | Số hóa đơn phát hành |

---

## Mục đích sử dụng

**SOND51bkhd.dll là module "Bảng kê hóa đơn"** trong hệ thống ERP của Asia Software, quản lý thông báo hóa đơn hết giá trị sử dụng và đăng ký tiếp tục sử dụng.

### Chức năng chính

#### 1. Lập thông báo bảng kê hóa đơn
- Tạo thông báo với số và ngày thông báo
- Tự động điền thông tin công ty: tên, mã số thuế, người đại diện
- Format số thông báo với độ dài cố định (8 chữ số)

#### 2. Quản lý hóa đơn hết giá trị
- Chọn hóa đơn từ danh mục (frmChonHD)
- Hiển thị danh sách hóa đơn hết hạn sử dụng
- Cho phép xóa hóa đơn khỏi danh sách
- Validate từ số, đến số trong khoảng hợp lệ

#### 3. Quản lý hóa đơn gia hạn
- Chọn hóa đơn đăng ký tiếp tục sử dụng
- Hiển thị danh sách hóa đơn gia hạn
- Cho phép xóa hóa đơn khỏi danh sách
- Tự động tính số lượng từ từ số và đến số

#### 4. Validation dữ liệu
- Ngày thông báo: bắt buộc
- Số thông báo: bắt buộc, >= 1
- Tên công ty, người đại diện, mã số thuế: bắt buộc
- Từ số, đến số: bắt buộc cho mỗi hóa đơn
- Từ số <= đến số <= số HĐ phát hành
- Từ số >= số HĐ in

### Đặc điểm kỹ thuật

- Sử dụng 2 DataTable riêng cho hóa đơn hết hạn và gia hạn
- DataGridView với custom styling
- Auto-calculate số lượng từ từ số và đến số
- Validation range cho từ số/đến số
- Format số thông báo tự động (padding với số 0)
- Chỉ cho phép nhập số nguyên cho số thông báo
- Sử dụng DAO pattern cho data access
- Hỗ trợ chế độ thêm mới và chỉnh sửa

### Quy tắc validation từ số/đến số

```
1. Từ số và đến số không được để trống
2. Từ số <= đến số
3. Đến số <= Số HĐ phát hành (so_hdph)
4. Từ số >= Số HĐ in (so_hdin)
5. Nếu vi phạm sẽ hiển thị cảnh báo và reset giá trị
```

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, phục vụ cho việc quản lý bảng kê hóa đơn theo quy định của cơ quan thuế, bao gồm việc thông báo hóa đơn hết giá trị sử dụng và đăng ký tiếp tục sử dụng hóa đơn.

---

*Ngày phân tích: 2026-03-29*
