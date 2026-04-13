# Báo cáo Phân tích DLL: INDMKHO.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | INDMKHO |
| Assembly Title | Danh mục kho - IN Input |
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
INDMKHO.dll/
├── INDMKHO.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmINDMKHO.cs            # Main form class (danh mục view)
    └── frmINDMKHOEdit.cs        # Edit form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`
- `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINDMKHO` | `frmDMView` | Form xem danh mục kho |
| `frmINDMKHOEdit` | `frmDMEdit` | Form nhập liệu/chỉnh sửa kho |

---

## Chi tiết Form frmINDMKHOEdit

### Các trường dữ liệu chính

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| txtMa_Kho | Ma_Kho | Mã kho |
| txtTen_Kho | Ten_Kho | Tên kho |
| chkKho_dl | Kho_dl | Checkbox kho đại lý |
| txtTk_Dl | Tk_Dl | Tài khoản đại lý |
| txtStt_Ntxt | Stt_Ntxt | Số thứ tự NTXT |
| txtDia_Chi | Dia_Chi | Địa chỉ |
| txtNguoi_Lh | Nguoi_Lh | Người liên hệ |
| txttTel | Tel | Điện thoại |
| txtFax | Fax | Fax |
| txtEmail | Email | Email |
| chkKsd | Ksd | Không sử dụng |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã kho" - Mã định danh kho
- "Tên kho" - Tên kho
- "Kho đại lý" - Loại kho đại lý
- "Tk đại lý" - Tài khoản đại lý
- "Stt NTXT" - Số thứ tự NTXT
- "Địa chỉ" - Địa chỉ kho
- "Người liên hệ" - Người liên hệ
- "Điện thoại" - Số điện thoại
- "Fax" - Số fax
- "Email" - Địa chỉ email

---

## Mục đích sử dụng

**INDMKHO.dll là module quản lý danh mục kho** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý thông tin kho
- Mã kho, tên kho
- Địa chỉ kho
- Thông tin liên hệ (người LH, điện thoại, fax, email)

#### 2. Quản lý kho đại lý
- Checkbox đánh dấu kho đại lý
- Tài khoản đại lý riêng
- Kích hoạt/vô hiệu hóa TK đại lý theo checkbox

#### 3. Thông tin bổ sung
- Số thứ tự NTXT
- Trạng thái sử dụng (KSD)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Lookup tự động cho TK đại lý (chi_tiet=1)
- Validation dữ liệu đầu vào
- Xử lý sự kiện CheckedChanged cho kho đại lý
- Sử dụng MaskedTextBox cho Tel, Fax

### Xử lý sự kiện

| Sự kiện | Mô tả |
|---------|-------|
| `chkKho_dl_CheckedChanged` | Kích hoạt/vô hiệu hóa TK đại lý |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục kho - chức năng cơ bản trong module Inventory (IN).

---

*Ngày phân tích: 2026-03-29*
