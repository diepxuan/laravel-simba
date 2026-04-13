# Báo cáo Phân tích DLL: GLVchGL1.dll

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
| Assembly Name | GLVchGL1 |
| Assembly Title | UI.GlVouchers |
| Assembly Company | Asia |
| Assembly Product | UI.GlVouchers |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 1.0.5921.28605 |
| Assembly File Version | 1.0.0.0 |
| GUID | b3ad0909-50e4-4b12-a444-85ebf657072a |
| ComVisible | false |

---

## Cấu trúc File

```
GLVchGL1.dll/
├── GLVchGL1.csproj              # Project file
├── app.ico                      # Application icon
├── VB-AnonymousType_1.cs        # VB Anonymous Type (empty)
├── VB-AnonymousType_2.cs        # VB Anonymous Type (empty)
├── VB-AnonymousType_3.cs        # VB Anonymous Type (empty)
├── VB-AnonymousType_4.cs        # VB Anonymous Type (empty)
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGlVchGL1.cs           # Main form - Voucher GL1
│   └── frmGlVchGL1Find.cs       # Find form - Tìm kiếm
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs         # VB My.Application
│   ├── MyComputer.cs            # VB My.Computer
│   ├── MyProject.cs             # VB My.Project
│   ├── MySettings.cs            # Settings
│   ├── MySettingsProperty.cs    # Settings property
│   └── InternalXmlHelper.cs     # XML Helper
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Drawing | Graphics |
| System.Linq | LINQ |
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | VB runtime |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `Microsoft.VisualBasic`
- `System`, `System.Collections`, `System.Data`, `System.Drawing`, `System.Linq`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlVchGL1` | `frmVoucher` | Form nhập liệu chứng từ ghi sổ chung |
| `frmGlVchGL1Find` | - | Form tìm kiếm chứng từ |
| `Resources` | - | Resource manager |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "UI.GlVouchers" - Tên assembly
- "Ngày LCT" - Ngày lập chứng từ
- "Tổng tiền nợ", "Tổng tiền có" - Tổng phát sinh
- "Thuế GTGT" - Thuế giá trị gia tăng

### Cột DataGridView (Chi tiết chứng từ)

| Cột | Ý nghĩa |
|-----|---------|
| TK | Tài khoản |
| Tên TK | Tên tài khoản |
| Mã KH | Mã khách hàng |
| Tên KH | Tên khách hàng |
| Mã NT | Mã ngoại tệ |
| Tỷ giá | Tỷ giá |
| Ps nợ NT | Phát sinh nợ ngoại tệ |
| Ps có NT | Phát sinh có ngoại tệ |
| Ps nợ | Phát sinh nợ |
| Ps có | Phát sinh có |
| Diễn giải | Diễn giải |
| B. phận | Bộ phận |
| Phí | Phí |
| H. đồng | Hợp đồng |
| SPCT | Sản phẩm chi tiết |
| Nh. DK | Nhóm điều khoản |

### Tab Control

| Tab | Mục đích |
|-----|----------|
| tabTaIn | Thuế GTGT đầu vào |
| tabTaOut | Thuế GTGT đầu ra |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ps_no` | Phát sinh nợ |
| `ps_co` | Phát sinh có |
| `ps_no_nt` | Phát sinh nợ ngoại tệ |
| `ps_co_nt` | Phát sinh có ngoại tệ |
| `t_tien` | Tổng tiền |
| `t_thue` | Tổng thuế |
| `t_tt` | Tổng thanh toán |
| `t_tien_nt` | Tổng tiền ngoại tệ |
| `t_thue_nt` | Tổng thuế ngoại tệ |
| `t_tt_nt` | Tổng thanh toán ngoại tệ |
| `ma_kh` | Mã khách hàng |
| `ma_bp` | Mã bộ phận |
| `ma_phi` | Mã phí |
| `ma_hd` | Mã hợp đồng |
| `ma_spct` | Mã sản phẩm chi tiết |
| `nh_dk` | Nhóm điều khoản |

---

## Mục đích sử dụng

**GLVchGL1.dll là module Voucher ghi sổ chung (General Ledger Voucher)** trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Nhập liệu chứng từ ghi sổ chung
- Nhập chứng từ phát sinh nghiệp vụ kế toán
- Quản lý thông tin: ngày, số chứng từ, diễn giải
- Xử lý đa tiền tệ (VND và ngoại tệ)

#### 2. Chi tiết phát sinh
- Nhập nhiều dòng phát sinh nợ/có
- Hỗ trợ lookup: TK, KH, BP, Phí, HĐ, SPCT
- Tính toán tự động theo tỷ giá

#### 3. Quản lý thuế GTGT
- Tab thuế đầu vào (ctlTaIn)
- Tab thuế đầu ra (ctlTaOut)
- Tính toán thuế tự động

#### 4. Tính toán tổng hợp
- Tổng phát sinh nợ/có
- Tổng tiền ngoại tệ
- Tổng thuế GTGT
- Tổng thanh toán

### Đặc điểm kỹ thuật

- Kế thừa từ `frmVoucher` - Form chứng từ chuẩn
- Sử dụng `AsInputDGV` cho nhập liệu chi tiết
- DataBinding với BindingSource
- Hỗ trợ nhiều loại tiền tệ với tỷ giá động
- Tích hợp control thuế GTGT (ctlTaIn, ctlTaOut)

### Mã chứng từ

**GL1** - Chứng từ ghi sổ chung, dùng cho các nghiệp vụ kế toán tổng hợp không thuộc các loại chứng từ chuyên biệt khác.

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý chứng từ ghi sổ chung - loại chứng từ tổng hợp cho các nghiệp vụ kế toán.

---

*Ngày phân tích: 2026-03-29*
