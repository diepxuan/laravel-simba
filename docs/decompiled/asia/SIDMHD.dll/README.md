# Báo cáo Phân tích DLL: SIDMHD.dll

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
| Assembly Name | SIDMHD |
| Assembly Title | Danh mục hợp đồng |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
SIDMHD.dll/
├── SIDMHD.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmSIDMHD.cs             # Main form class - Danh mục hợp đồng
    └── frmSIDMHDEdit.cs         # Form chỉnh sửa hợp đồng
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Drawing | Graphics |
| System.Windows.Forms | Windows Forms |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIDMHD` | `frmDMView` | Form xem danh mục hợp đồng |
| `frmSIDMHDEdit` | `frmDMEdit` | Form chỉnh sửa thông tin hợp đồng |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Loại hợp đồng" (`loai`) - Mua/Bán
- "Mã hợp đồng" (`ma_hd`)
- "Tên hợp đồng" (`ten_hd`)
- "Số hợp đồng" (`so_hd`)
- "Nhóm hợp đồng" (`ma_nhhd`)
- "Mã khách hàng" (`ma_kh`)
- "Tên khách hàng" (`ten_kh`)
- "Mã phòng" (`ma_bp`)
- "Tên phòng/bộ phận" (`ten_bp`)
- "Ngày hợp đồng" (`ngay_hd`)
- "Ngày hết hạn" (`ngay_hh`)
- "Mã ngoại tệ" (`ma_nt`)
- "Tiền hợp đồng" (`tien`)
- "Tiền hợp đồng Nt" (`tien_nt`)
- "Nội dung" (`noi_dung`)

### Loại hợp đồng

| Giá trị | Ý nghĩa |
|---------|---------|
| 1 | Bán |
| 2 | Mua |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_hd` | Mã hợp đồng |
| `ten_hd` | Tên hợp đồng |
| `so_hd` | Số hợp đồng |
| `ma_nhhd` | Mã nhóm hợp đồng |
| `ma_kh` | Mã khách hàng |
| `ngay_hd` | Ngày hợp đồng |
| `ngay_hh` | Ngày hết hạn |
| `ma_nt` | Mã ngoại tệ |
| `tien` | Tiền hợp đồng (VNĐ) |
| `tien_nt` | Tiền hợp đồng ngoại tệ |
| `noi_dung` | Nội dung hợp đồng |
| `ksd` | Không sử dụng |

---

## Mục đích sử dụng

**SIDMHD.dll là module quản lý Danh mục hợp đồng** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục hợp đồng
- Khai báo mã hợp đồng (`ma_hd`)
- Khai báo tên hợp đồng (`ten_hd`)
- Số hợp đồng (`so_hd`)
- Phân loại hợp đồng Mua/Bán (`loai`)

#### 2. Thông tin đối tác
- Liên kết với khách hàng (`ma_kh`, `ten_kh`)
- Liên kết với bộ phận/phòng ban (`ma_bp`, `ten_bp`)
- Phân nhóm hợp đồng (`ma_nhhd`)

#### 3. Thông tin thời hạn
- Ngày hợp đồng (`ngay_hd`)
- Ngày hết hạn (`ngay_hh`)
- Validation: Ngày hết hạn phải lớn hơn ngày hợp đồng

#### 4. Thông tin tài chính
- Mã ngoại tệ (`ma_nt`)
- Giá trị hợp đồng VNĐ (`tien`)
- Giá trị hợp đồng ngoại tệ (`tien_nt`)

#### 5. Nội dung hợp đồng
- Mô tả chi tiết (`noi_dung`)
- Trạng thái sử dụng (`ksd`)

### Đặc điểm kỹ thuật

- Sử dụng `frmDMView`/`frmDMEdit` cơ bản
- DataBinding với DataTable
- AutoLookup cho các trường: Khách hàng, Nhóm hợp đồng, Bộ phận
- Validation dữ liệu đầu vào
- Hỗ trợ trạng thái sử dụng (`ksd`)
- MaskTextBox cho định dạng ngày tháng
- Định dạng số tiền theo cấu hình hệ thống

### Tích hợp

- Sử dụng trong các module chứng từ để lookup hợp đồng
- Liên kết với SIDMNHHD.dll (nhóm hợp đồng)
- Liên kết với ARDMKH.dll (danh mục khách hàng)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục hợp đồng - theo dõi các hợp đồng mua/bán với khách hàng và nhà cung cấp.

---

*Ngày phân tích: 2026-03-29*
