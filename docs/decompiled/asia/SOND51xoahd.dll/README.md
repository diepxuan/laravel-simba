# Báo cáo Phân tích DLL: SOND51xoahd.dll

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
| Assembly Name | SOND51xoahd |
| Assembly Title | SOMCHHD |
| Assembly Product | SOMCHHD |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 4b2ec9f7-042c-422d-8649-ba65259d4cdb |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51xoahd.dll/
├── SOND51xoahd.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOND51xoahd.cs        # Form danh sách
│   ├── frmSOND51xoahdEdit.cs    # Form nhập liệu chi tiết
│   └── frmChonHD.cs             # Form chọn hóa đơn (dùng chung)
├── AsiaErp.DataAccess/
│   ├── SOND51xoahdDAO.cs        # Data access interface
│   └── MsSqlSOND51xoahdDAO.cs   # SQL Server implementation
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
| Framework | Asia ERP Framework |
| AsiaErp.DataAccess | Data access layer |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSOND51xoahd` | `frmDMComplexView` | Form danh sách xóa hóa đơn |
| `frmSOND51xoahdEdit` | `frmDMComplexEdit` | Form nhập liệu thông báo xóa hóa đơn |
| `SOND51xoahdDAO` | - | Interface cho data access |
| `MsSqlSOND51xoahdDAO` | - | Implementation SQL Server |

---

## Các trường dữ liệu chính

### Thông tin thông báo xóa

| Trường | Ý nghĩa |
|--------|---------|
| `ngay_tb` | Ngày thông báo |
| `ma_tb` | Số thông báo |
| `noi_nhan` | Nơi nhận thông báo |
| `ten_tc` | Tên tổ chức, cá nhân |
| `dai_dien` | Người đại diện |
| `dia_chi` | Địa chỉ |
| `ma_thue` | Mã số thuế |
| `ghi_chu` | Lý do xóa |
| `gio_xl` | Giờ xử lý |
| `phut_xl` | Phút xử lý |
| `ngay_xl` | Ngày xử lý |
| `gui_cqt` | Đã gửi cơ quan thuế (checkbox) |
| `ngay_guicqt` | Ngày gửi cơ quan thuế |
| `kieu_xl` | Kiểu xóa (XOA) |

### Chi tiết hóa đơn (DataGridView)

| Cột | Ý nghĩa |
|-----|---------|
| `ma_chung` | Mã chứng từ (stt_rec) |
| `ten_loai` | Tên loại hóa đơn |
| `mau_so` | Mẫu số |
| `ky_hieu` | Ký hiệu (so_seri) |
| `tu_so` | Từ số |
| `den_so` | Đến số |
| `so_luong` | Số lượng |
| `lien_hd` | Liên hóa đơn |
| `ghi_chu` | Ghi chú |

---

## Mục đích sử dụng

**SOND51xoahd.dll là module quản lý thông báo xóa hóa đơn** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Lập thông báo xóa hóa đơn
- Quản lý thông tin tổ chức/cá nhân thông báo
- Thông tin người đại diện, địa chỉ, mã số thuế
- Ngày thông báo, số thông báo, nơi nhận
- Lý do xóa hóa đơn

#### 2. Chọn hóa đơn cần xóa
- Form frmChonHD cho phép chọn hóa đơn
- Hiển thị danh sách hóa đơn để chọn
- Tự động điền thông tin vào grid chi tiết

#### 3. Quản lý chi tiết hóa đơn xóa
- Loại hóa đơn, mẫu số, ký hiệu
- Dải số (từ số - đến số)
- Số lượng, liên hóa đơn
- Ghi chú cho từng hóa đơn

#### 4. Theo dõi gửi cơ quan thuế
- Checkbox đánh dấu đã gửi CQ thuế
- Ngày gửi cơ quan thuế
- Thời gian xử lý (giờ, phút, ngày)

### Đặc điểm kỹ thuật

- Sử dụng DataGridView (AsInputDGV) để hiển thị chi tiết
- Integration với DAO layer để lưu trữ dữ liệu
- Validation đầy đủ cho các trường bắt buộc
- Tự động format số thông báo với leading zeros
- Hỗ trợ xóa row trong grid (phím F8)
- Label lblKieu_xl hiển thị "XOA" để phân biệt với thông báo mất/cháy/hỏng

### Validation

- Các trường bắt buộc: ngay_tb, ma_tb, noi_nhan, ten_tc, dai_dien, dia_chi, ma_thue
- Kiểm tra ngày xử lý >= ngày thông báo
- Kiểm tra ngày gửi CQ thuế <= ngày thông báo (nếu đã gửi)
- Kiểm tra giờ (0-23), phút (0-59)
- Liên hóa đơn không được để trống trong grid
- Số thông báo phải >= 1 (lỗi 50157)
- Grid phải có ít nhất 1 dòng (lỗi 50018)

---

## So sánh với SOND51mchhd.dll

| Điểm khác | SOND51xoahd | SOND51mchhd |
|-----------|-------------|-------------|
| Kiểu xử lý | XOA | Mất/Cháy/Hỏng |
| Label kieu_xl | "XOA" | Không có |
| Lý do | "Lý do xoá" | "Lý do mất, cháy, hỏng" |
| Message lỗi | 50157, 50182, 50183, 50184 | 50153, 50154, 50155, 50156 |

---

## Kết luận

Đây là module Windows Forms phục vụ việc lập và quản lý thông báo xóa hóa đơn theo quy định của cơ quan thuế Việt Nam. Module có cấu trúc tương tự SOND51mchhd.dll (thông báo mất/cháy/hỏng) nhưng với mục đích xóa hóa đơn và các message validation riêng.

---

*Ngày phân tích: 2026-03-29*
