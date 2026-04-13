# Báo cáo Phân tích DLL: POVchPO7.dll

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
| Assembly Name | POVchPO7 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
POVchPO7.dll/
├── POVchPO7.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmPOVchPO7.cs           # Main form class
└── AsiaErp.UserInterface.My.Resources/
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
| Helper | Asia ERP Helper |
| POUtilities | Tiện ích PO module |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.POUtilities`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPOVchPO7` | `frmVoucher` | Form nhập liệu chính cho chứng từ nhập kho nội bộ PO7 |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã NCC" - Mã nhà cung cấp
- "Người bán" - Người giao dịch
- "Diễn giải" - Mô tả chứng từ
- "Ngày lập" - Ngày lập chứng từ
- "Tỷ giá" - Tỷ giá ngoại tệ
- "Mã thanh toán" - Phương thức thanh toán
- "Ngày hoá đơn" - Ngày trên hóa đơn
- "Số hoá đơn" - Số hóa đơn
- "Mẫu hoá đơn" - Loại mẫu hóa đơn
- "Địa chỉ" - Địa chỉ nhà cung cấp
- "Mã số thuế" - MST nhà cung cấp

### Tab pages

| Tab | Ý nghĩa |
|-----|---------|
| Chi tiết | Chi tiết vật tư nhập kho |
| Chi phí nhập khẩu | Chi phí liên quan nhập khẩu |
| Hạch toán | Thông tin hạch toán kế toán |
| Thuế GTGT | Thông tin thuế giá trị gia tăng |

### Cột DataGridView (Chi tiết chứng từ)

| Cột | Ý nghĩa |
|-----|---------|
| Mã hàng | Mã vật tư |
| Tên hàng | Tên vật tư |
| Đvt | Đơn vị tính |
| Kho | Mã kho nhập |
| Tồn | Số lượng tồn kho |
| Số lượng | Số lượng nhập |
| Đơn giá | Giá nhập ngoại tệ |
| Thành tiền | Tiền hàng ngoại tệ |
| Chi phí | Chi phí ngoại tệ |
| %NK | Thuế suất nhập khẩu |
| Thuế NK | Thuế nhập khẩu |
| %TTĐB | Thuế suất tiêu thụ đặc biệt |
| Thuế TTĐB | Thuế tiêu thụ đặc biệt |
| %VAT | Thuế suất GTGT |
| VAT | Thuế GTGT |
| Đơn giá VND | Giá VND |
| Tiền VND | Thành tiền VND |
| CP VND | Chi phí VND |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `tien_nt0` | Tiền hàng ngoại tệ |
| `tien0` | Tiền hàng VND |
| `thue_nk` | Thuế nhập khẩu |
| `thue_ttdb` | Thuế tiêu thụ đặc biệt |
| `thue_gtgt` | Thuế GTGT |
| `tk_vt` | Tài khoản kho |
| `tk_pt` | Tài khoản phải trả |
| `ma_kho` | Mã kho |
| `ma_vt` | Mã vật tư |

---

## Mục đích sử dụng

**POVchPO7.dll là module quản lý chứng từ "Phiếu nhập kho nội bộ"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu chứng từ nhập kho
- Quản lý thông tin nhà cung cấp (mã NCC, tên, địa chỉ, MST, người bán)
- Quản lý thông tin hóa đơn (số HĐ, ngày HĐ, mẫu HĐ)
- Xử lý đa tiền tệ (tỷ giá, phát sinh ngoại tệ/VNĐ)
- Quản lý phương thức thanh toán

#### 2. Chi tiết nhập kho
- Nhập liệu vật tư: mã hàng, tên hàng, đvt, kho, số lượng
- Tính toán giá và thành tiền (ngoại tệ và VND)
- Quản lý chi phí nhập khẩu
- Theo dõi tồn kho tức thời

#### 3. Quản lý thuế
- Thuế nhập khẩu (%NK)
- Thuế tiêu thụ đặc biệt (%TTĐB)
- Thuế GTGT (%VAT)
- Tích hợp với `ctlTaIn` (control thuế đầu vào)

#### 4. Chi phí nhập khẩu
- Tab riêng quản lý chi phí nhập khẩu
- Phân bổ chi phí cho các mặt hàng
- Quản lý NCC chi phí, TK phải trả

#### 5. Hạch toán
- Tab hạch toán tự động
- TK kho, TK thuế NK, TK thuế TTDB, TK có
- Tổng hợp tiền hàng, thuế, chi phí

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable, CPTable, TAINTable)
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình
- Tích hợp với module POUtilities
- Tính toán tự động tổng tiền, thuế, thanh toán

### Mã chứng từ

**PO7** (Phiếu nhập kho nội bộ) - một loại chứng từ nhập kho trong module Purchasing (PO).

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý chứng từ nhập kho nội bộ với đầy đủ các tính năng: nhập liệu vật tư, tính toán thuế, chi phí nhập khẩu và hạch toán kế toán.

---

*Ngày phân tích: 2026-03-29*
