# Báo cáo Phân tích DLL: SIDMCT.dll

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
| Assembly Name | SIDMCT |
| Assembly Title | Khai báo màn hình nhập chứng từ |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 6ee7554a-e2a0-4fbf-9f39-5427c6e3188f |
| ComVisible | false |

---

## Cấu trúc File

```
SIDMCT.dll/
├── SIDMCT.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.UserInterface/
│   ├── frmSIDMCT.cs             # Main form class - Danh mục chứng từ
│   ├── frmSIDMCTEdit.cs         # Form chỉnh sửa chứng từ
│   └── frmVoucherUpdInfo.cs     # Form cập nhật thông tin chứng từ
├── AsiaERP.DataAccess/
│   ├── MsSqlVOUCHERDAO.cs       # Data Access Object cho Voucher
│   └── VOUCHERDAO.cs            # Voucher DAO
├── My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
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
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIDMCT` | `frmDMView` | Form xem danh mục chứng từ |
| `frmSIDMCTEdit` | `frmDMEdit` | Form chỉnh sửa thông tin chứng từ |
| `frmVoucherUpdInfo` | - | Form cập nhật thông tin nâng cao cho chứng từ |
| `VOUCHERDAO` | - | Data Access Object cho bảng Voucher |
| `MsSqlVOUCHERDAO` | `VOUCHERDAO` | SQL Server implementation |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chứng từ", "Tên chứng từ"
- "Mã chứng từ mẹ", "Tên chứng từ mẹ"
- "Phân hệ"
- "Tài khoản nợ", "Tài khoản có"
- "Mã NT" (Mã ngoại tệ)
- "Số liên khi in"
- "STT nhật ký chung"
- "STT nhập trước xuất trước"

### Cấu hình số chứng từ

| Trường | Ý nghĩa |
|--------|---------|
| `vn_prefix` | Phần đầu số chứng từ |
| `vn_sequence` | Phần tự tăng |
| `vn_postfix` | Phần cuối số chứng từ |
| `vn_pattern` | Ký tự mẫu (pad character) |
| `vn_width` | Độ rộng số chứng từ |

### Các checkbox cấu hình

- "Lọc theo người sử dụng" (`loc_nsd`)
- "Sử dụng trường mã hợp đồng" (`vv`)
- "Sử dụng trường mã phí" (`phi`)
- "Sử dụng trường mã bộ phận" (`bp`)
- "Sử dụng trường mã SPCT" (`spct`)
- "Sử dụng trường mã lô" (`lo`)

### Kiểu trùng số chứng từ

| Giá trị | Ý nghĩa |
|---------|---------|
| 0 | Cho phép trùng |
| 1 | Theo tháng |
| 2 | Theo năm |

### Định dạng ngày tháng trong số chứng từ

- `{DD}` - Ngày
- `{MM}` - Tháng
- `{YY}` - Năm 2 số
- `{YYYY}` - Năm 4 số

---

## Mục đích sử dụng

**SIDMCT.dll là module quản lý Danh mục chứng từ** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục chứng từ
- Khai báo mã chứng từ (`ma_ct`)
- Khai báo tên chứng từ (`ten_ct`)
- Phân cấp chứng từ mẹ - con (`ma_ct_me`)
- Phân hệ sử dụng (`phan_he`)

#### 2. Cấu hình tài khoản kế toán
- Tài khoản nợ mặc định (`tk_no`)
- Tài khoản có mặc định (`tk_co`)
- Mã ngoại tệ (`ma_nt`)

#### 3. Cấu hình số chứng từ
- Định dạng số chứng từ tự động
- Prefix/Postfix động theo ngày/tháng/năm
- Độ rộng và ký tự đệm
- Kiểm tra trùng số chứng từ

#### 4. Cấu hình trường nhập liệu
- Bật/tắt các trường: mã bộ phận, mã phí, mã hợp đồng, mã SPCT, mã lô
- Lọc dữ liệu theo người sử dụng

#### 5. Cấu hình in ấn và sổ sách
- Số liên khi in (`so_lien`)
- Thứ tự trong nhật ký chung (`stt_nkc`)
- Thứ tự nhập trước xuất trước (`stt_ntxt`)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Hỗ trợ AutoComplete và AutoLookup cho các trường mã
- Validation dữ liệu đầu vào
- Preview số chứng từ theo thời gian thực
- Tích hợp với frmVoucherUpdInfo cho cấu hình nâng cao

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc khai báo và cấu hình danh mục chứng từ - nền tảng cho việc nhập liệu và quản lý các loại chứng từ trong hệ thống kế toán.

---

*Ngày phân tích: 2026-03-29*
