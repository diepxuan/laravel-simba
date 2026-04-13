# Báo cáo Phân tích DLL: SOND51mchhd.dll

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
| Assembly Name | SOND51mchhd |
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
SOND51mchhd.dll/
├── SOND51mchhd.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOND51mchhd.cs        # Form danh sách
│   ├── frmSOND51mchhdEdit.cs    # Form nhập liệu chi tiết
│   └── frmChonHD.cs             # Form chọn hóa đơn
├── AsiaErp.DataAccess/
│   ├── SOND51mchhdDAO.cs        # Data access interface
│   └── MsSqlSOND51mchhdDAO.cs   # SQL Server implementation
├── My/
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MySettingsProperty.cs
│   └── InternalXmlHelper.cs
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
| `frmSOND51mchhd` | `frmDMView` | Form danh sách mã chương trình hóa đơn |
| `frmSOND51mchhdEdit` | `frmDMEdit` | Form nhập liệu thông báo mất, cháy, hỏng hóa đơn |
| `frmChonHD` | `frmAsiaRoot` | Form chọn hóa đơn cần thông báo |
| `SOND51mchhdDAO` | - | Interface cho data access |
| `MsSqlSOND51mchhdDAO` | - | Implementation SQL Server |

---

## Các trường dữ liệu chính

### Thông tin thông báo

| Trường | Ý nghĩa |
|--------|---------|
| `ngay_tb` | Ngày thông báo |
| `ma_tb` | Số thông báo |
| `noi_nhan` | Nơi nhận thông báo |
| `ten_tc` | Tên tổ chức, cá nhân |
| `dai_dien` | Người đại diện |
| `dia_chi` | Địa chỉ |
| `ma_thue` | Mã số thuế |
| `ghi_chu` | Lý do mất, cháy, hỏng |
| `gio_xl` | Giờ xử lý |
| `phut_xl` | Phút xử lý |
| `ngay_xl` | Ngày xử lý |
| `gui_cqt` | Đã gửi cơ quan thuế (checkbox) |
| `ngay_guicqt` | Ngày gửi cơ quan thuế |

### Chi tiết hóa đơn (DataGridView)

| Cột | Ý nghĩa |
|-----|---------|
| `stt_rec` | Số thứ tự record |
| `loai_hd` | Tên loại hóa đơn |
| `mau_so` | Mẫu số |
| `ky_hieu` | Ký hiệu (so_seri) |
| `tu_so` | Từ số |
| `den_so` | Đến số |
| `so_luong` | Số lượng |
| `lien_so` | Liên số |
| `ghi_chu` | Ghi chú |

---

## Mục đích sử dụng

**SOND51mchhd.dll là module quản lý thông báo mất, cháy, hỏng hóa đơn** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Lập thông báo mất, cháy, hỏng hóa đơn
- Quản lý thông tin tổ chức/cá nhân thông báo
- Thông tin người đại diện, địa chỉ, mã số thuế
- Ngày thông báo, số thông báo, nơi nhận

#### 2. Chọn hóa đơn cần thông báo
- Form frmChonHD cho phép chọn hóa đơn theo khoảng ngày
- Hiển thị danh sách hóa đơn với checkbox để chọn
- Tự động điền thông tin vào grid chi tiết

#### 3. Quản lý chi tiết hóa đơn mất/hỏng
- Loại hóa đơn, mẫu số, ký hiệu
- Dải số (từ số - đến số)
- Số lượng, liên số
- Ghi chú cho từng hóa đơn

#### 4. Theo dõi gửi cơ quan thuế
- Checkbox đánh dấu đã gửi CQ thuế
- Ngày gửi cơ quan thuế
- Thời gian xử lý (giờ, phút, ngày)

### Đặc điểm kỹ thuật

- Sử dụng DataGridView (AsInputDGV) để hiển thị chi tiết hóa đơn
- Integration với DAO layer để lưu trữ dữ liệu
- Validation đầy đủ cho các trường bắt buộc
- Tự động format số thông báo với leading zeros
- Hỗ trợ xóa row trong grid (phím F8)

### Validation

- Các trường bắt buộc: ngay_tb, ma_tb, noi_nhan, ten_tc, dai_dien, dia_chi, ma_thue
- Kiểm tra ngày xử lý >= ngày thông báo
- Kiểm tra ngày gửi CQ thuế <= ngày thông báo (nếu đã gửi)
- Kiểm tra giờ (0-23), phút (0-59)
- Liên số không được để trống trong grid
- Số thông báo phải >= 1

---

## Kết luận

Đây là module Windows Forms phục vụ việc lập và quản lý thông báo mất, cháy, hỏng hóa đơn theo quy định của cơ quan thuế Việt Nam. Module tích hợp đầy đủ chức năng chọn hóa đơn, lập thông báo và theo dõi tình trạng gửi cơ quan thuế.

---

*Ngày phân tích: 2026-03-29*
