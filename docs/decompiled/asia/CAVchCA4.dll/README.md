# Báo cáo Phân tích DLL: CAVchCA4.dll

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
| Assembly Name | CAVchCA4 |
| Assembly Title | Báo có (Ủy nhiệm chi) |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
CAVchCA4.dll/
├── CAVchCA4.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmCaVchCA4.cs           # Main form class
│   ├── frmCaVchCA4Find.cs       # Search form
│   └── frmCaVchCA4Print.cs      # Print form
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
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |
| CAVchCA2 | Related voucher module (../../../../native-apps/ASIA/CAVchCA2.dll) |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCaVchCA4` | `frmVoucher` | Form nhập liệu chính cho chứng từ Báo có/Ủy nhiệm chi |
| `frmCaVchCA4Find` | `frmVoucherFind` | Form tìm kiếm chứng từ |
| `frmCaVchCA4Print` | `frmVoucherPrint` | Form in ấn chứng từ |
| `Resources` | - | Resource manager cho localization |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo có (Ủy nhiệm chi)" - Tên chức năng chính
- "Mã khách hàng", "Tên khách hàng", "Địa chỉ", "Người giao dịch"
- "Tài khoản có", "Tên tài khoản"
- "Diễn giải", "Ngày lập"
- "Tỷ giá", "Tổng tiền", "Thuế GTGT", "Thanh toán"

### Cột DataGridView (Chi tiết chứng từ)

| Cột | Ý nghĩa |
|-----|---------|
| TK | Tài khoản |
| Tên tài khoản | Tên tài khoản |
| Ps nợ | Phát sinh nợ |
| Ps nợ VNĐ | Phát sinh nợ VNĐ |
| Mã KH | Mã khách hàng |
| Tên khách | Tên khách hàng |
| Dư | Số dư |
| Diễn giải | Diễn giải |
| B. phận | Bộ phận |
| Phí | Phí |
| H. đồng | Hợp đồng |
| Khế ước | Khế ước |
| SPCT | Sản phẩm chi tiết |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ps_no` | Phát sinh nợ |
| `ps_no_nt` | Phát sinh nợ ngoại tệ |
| `t_tien` | Tổng tiền |
| `t_thue` | Thuế |
| `t_tt` | Thanh toán |
| `tk_co` | Tài khoản có |
| `tk_cn` | Tài khoản công nợ |

### In ấn

- "Đơn vị trả tiền", "Đơn vị nhận tiền"
- "Số tài khoản", "Tại ngân hàng", "Tỉnh, thành phố"

---

## Mục đích sử dụng

**CAVchCA4.dll là module quản lý chứng từ "Báo có (Ủy nhiệm chi)"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu chứng từ Báo có/Ủy nhiệm chi
- Quản lý thông tin khách hàng (mã KH, tên, địa chỉ, người giao dịch)
- Quản lý tài khoản kế toán (TK nợ, TK có)
- Xử lý đa tiền tệ (tỷ giá, phát sinh nợ ngoại tệ/VNĐ)
- Chi tiết phát sinh với các thông tin: TK, KH, bộ phận, phí, hợp đồng, khế ước, SPCT

#### 2. Tính toán tự động
- Tính tổng tiền, thuế GTGT, thanh toán
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính dư công nợ (Du13) theo TK và KH

#### 3. Quản lý thuế
- Tab thuế riêng (`tabTax`)
- Tích hợp với `ctlTaIn` (control thuế đầu vào)
- Hỗ trợ VAT NK (nhập khẩu)

#### 4. Tìm kiếm và In ấn
- Tìm kiếm chứng từ theo nhiều tiêu chí
- In ủy nhiệm chi với thông tin ngân hàng đầy đủ

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable, TAINTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, TK, số tiền)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với module CAVchCA2 (có thể là phiên bản khác hoặc module liên quan)

### Mã chứng từ

**CA4** (Báo có/Ủy nhiệm chi) - một loại chứng từ thanh toán qua ngân hàng trong kế toán Việt Nam.

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý và in ấn chứng từ Báo có/Ủy nhiệm chi - một loại chứng từ thanh toán quan trọng trong kế toán doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
