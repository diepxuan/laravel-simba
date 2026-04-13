# Báo cáo Phân tích DLL: SOND51HuyHD.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |
| Chức năng | Hủy hóa đơn - Quản lý thông báo hủy hóa đơn |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SOND51HuyHD |
| Assembly Title | SOHuyHD |
| Assembly Company | - |
| Assembly Product | SOHuyHD |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 9d339718-fb80-4608-b8a3-1b2ec6ec5801 |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51HuyHD.dll/
├── SOND51HuyHD.csproj             # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOND51HuyHD.cs          # Main form class (kế thừa frmDMComplexView)
│   ├── frmSOND51HuyHDEdit.cs      # Edit form (kế thừa frmDMComplexEdit)
│   └── frmChonHD.cs               # Form chọn hóa đơn
├── AsiaErp.DataAccess/
│   ├── SOND51HuyHDDAO.cs          # Data Access Object interface
│   └── MsSqlSOND51HuyHDDAO.cs     # SQL Server implementation
└── My.Resources/
    └── Resources.cs               # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Collections | ArrayList |
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.DataAccess | Asia ERP Data Access |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`, `System.Collections`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSOND51HuyHD` | `frmDMComplexView` | Form xem danh sách thông báo hủy hóa đơn |
| `frmSOND51HuyHDEdit` | `frmDMComplexEdit` | Form nhập liệu thông báo hủy hóa đơn |
| `frmChonHD` | - | Form chọn hóa đơn cần hủy |
| `SOND51HuyHDDAO` | - | Interface DAO |
| `MsSqlSOND51HuyHDDAO` | - | SQL Server DAO implementation |

---

## Các Controls chính trong frmSOND51HuyHDEdit

### Thông tin thông báo

| Control | Loại | Mục đích |
|---------|------|----------|
| txtNgay_tb | AsMaskedTextBox | Ngày thông báo (dd/MM/yyyy) |
| txtMa_tb | AsTextBox | Số thông báo |
| txtNoi_nhan | TextBox | Nơi nhận thông báo |

### Thông tin tổ chức

| Control | Loại | Mục đích |
|---------|------|----------|
| txtTen_tc | TextBox | Tên tổ chức, cá nhân |
| txtDai_dien | TextBox | Người đại diện |
| txtDia_chi | TextBox | Địa chỉ |
| txtMa_thue | TextBox | Mã số thuế |

### Thông tin xử lý

| Control | Loại | Mục đích |
|---------|------|----------|
| txtGhi_chu | TextBox (Multiline) | Phương pháp hủy hóa đơn |
| txtGio_xl | AsTextNumeric | Giờ xử lý (0-23) |
| txtPhut_xl | AsTextNumeric | Phút xử lý (0-59) |
| txtNgay_xl | AsMaskedTextBox | Ngày xử lý |
| chkKsd | AsCheckBox | Đã gửi CQ thuế |
| txtNgay_guicqt | AsMaskedTextBox | Ngày gửi cơ quan thuế |
| lblKieu_xl | Label | Kiểu xử lý (HUY) |

### DataGridView và Button

| Control | Loại | Mục đích |
|---------|------|----------|
| adgvHD | AsInputDGV | Danh sách hóa đơn cần hủy |
| btnChon_hd | Button | Chọn hóa đơn |

---

## Cột DataGridView (adgvHD)

| Cột | Ý nghĩa |
|-----|---------|
| ma_chung | Mã chứng từ (SCT) - ẩn |
| ten_loai | Tên loại hóa đơn |
| mau_so | Mẫu số hóa đơn |
| so_seri | Ký hiệu (số seri) |
| tu_so | Từ số |
| den_so | Đến số |
| so_luong | Số lượng |
| lien_hd | Liên số |
| ghi_chu | Ghi chú |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Ngày thông báo", "Số thông báo", "Nơi nhận thông báo"
- "Tên tổ chức, cá nhân", "Người đại diện", "Địa chỉ", "Mã số thuế"
- "Phương pháp huỷ HĐ" - Ghi chú phương pháp hủy
- "Hồi", "giờ", "Ngày" - Thời gian xử lý
- "Đã gửi CQ thuế ngày"
- "HUY" - Kiểu xử lý

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ngay_tb` | Ngày thông báo |
| `ma_tb` | Mã thông báo |
| `noi_nhan` | Nơi nhận |
| `ten_tc` | Tên tổ chức |
| `dai_dien` | Đại diện |
| `dia_chi` | Địa chỉ |
| `ma_thue` | Mã số thuế |
| `ghi_chu` | Ghi chú (phương pháp hủy) |
| `gio_xl` | Giờ xử lý |
| `phut_xl` | Phút xử lý |
| `ngay_xl` | Ngày xử lý |
| `gui_cqt` | Đã gửi cơ quan thuế |
| `ngay_guicqt` | Ngày gửi CQ thuế |
| `kieu_xl` | Kiểu xử lý (HUY) |
| `lien_hd` | Liên hóa đơn |

---

## Mục đích sử dụng

**SOND51HuyHD.dll là module "Hủy hóa đơn"** trong hệ thống ERP của Asia Software, quản lý thông báo hủy hóa đơn với cơ quan thuế.

### Chức năng chính

#### 1. Quản lý thông báo hủy hóa đơn
- Lập thông báo hủy hóa đơn gửi cơ quan thuế
- Quản lý thông tin doanh nghiệp: tên, địa chỉ, mã số thuế, người đại diện
- Theo dõi ngày thông báo và nơi nhận

#### 2. Quản lý danh sách hóa đơn hủy
- Chọn hóa đơn từ danh mục có sẵn (frmChonHD)
- Quản lý thông tin chi tiết: mẫu số, ký hiệu, từ số, đến số
- Ghi nhận liên số và ghi chú cho từng hóa đơn
- Xóa hóa đơn khỏi danh sách (phím F8)

#### 3. Theo dõi xử lý
- Ghi nhận thời gian xử lý (giờ, phút, ngày)
- Theo dõi trạng thái gửi cơ quan thuế
- Ghi nhận ngày gửi thông báo
- Validate ngày xử lý >= ngày thông báo

#### 4. Phương pháp hủy
- Ghi nhận phương pháp hủy hóa đơn
- Lưu trữ thông tin chi tiết về cách thức hủy

### Validation dữ liệu

- Ngày thông báo: bắt buộc
- Số thông báo: bắt buộc, >= 1
- Nơi nhận, tên tổ chức, đại diện, địa chỉ, mã số thuế: bắt buộc
- Ngày xử lý: >= ngày thông báo
- Ngày gửi CQ thuế: >= ngày thông báo (khi đã gửi)
- Giờ: 0-23, Phút: 0-59
- Phải có ít nhất 1 hóa đơn trong danh sách
- Liên số: bắt buộc cho mỗi hóa đơn

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Tích hợp form chọn hóa đơn (frmChonHD)
- Sử dụng DAO pattern cho data access
- Auto-fill thông tin công ty từ CompanyInformations
- Format số thông báo với độ dài cố định
- Phân biệt chế độ thêm mới và chỉnh sửa
- Kiểm soát trạng thái "Đã gửi CQ thuế"

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, phục vụ cho việc quản lý thông báo hủy hóa đơn với cơ quan thuế theo quy định pháp luật, bao gồm việc theo dõi danh sách hóa đơn hủy và trạng thái xử lý.

---

*Ngày phân tích: 2026-03-29*
