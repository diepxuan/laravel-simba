# Báo cáo Phân tích DLL: PODMDKTT.dll

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
| Assembly Name | PODMDKTT |
| Assembly Title | Danh mục điều khoản thanh toán mua |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
PODMDKTT.dll/
├── PODMDKTT.csproj              # Project file
├── app.ico                      # Application icon
├── PODMDKTT.dll.licenses      # License file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmPODMDKTT.cs         # Main form class (danh mục view)
    └── frmPODMDKTTEdit.cs      # Edit form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPODMDKTT` | `frmDMView` | Form xem danh mục điều khoản thanh toán mua |
| `frmPODMDKTTEdit` | `frmDMEdit` | Form chỉnh sửa điều khoản thanh toán mua |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Danh mục điều khoản thanh toán mua" - Tên chức năng chính
- "Mã điều khoản" (`txtMa_tt_po`)
- "Mô tả" (`txtMo_ta`)
- "Hạn thanh toán" (`txtHan_tt`)
- "Tỷ lệ chiết khấu" (`txttl_ck`)
- "Hạn chiết khấu" (`txtHan_ck`)
- "Lãi suất quá hạn" (`txtls_qh`)

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_tt_po` | Mã điều khoản thanh toán mua |
| `mo_ta` | Mô tả điều khoản |
| `han_tt` | Hạn thanh toán (ngày) |
| `tl_ck` | Tỷ lệ chiết khấu (%) |
| `han_ck` | Hạn chiết khấu (ngày) |
| `ls_qh` | Lãi suất quá hạn |

---

## Mục đích sử dụng

**PODMDKTT.dll là module quản lý Danh mục điều khoản thanh toán mua** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý điều khoản thanh toán
- Thêm mới điều khoản thanh toán
- Chỉnh sửa thông tin điều khoản
- Xóa điều khoản không còn sử dụng
- Tìm kiếm và lọc danh mục

#### 2. Thông tin quản lý
- Mã điều khoản thanh toán (`ma_tt_po`)
- Mô tả chi tiết (`mo_ta`)
- Hạn thanh toán (`han_tt`)
- Tỷ lệ chiết khấu (`tl_ck`)
- Hạn chiết khấu (`han_ck`)
- Lãi suất quá hạn (`ls_qh`)

### Ý nghĩa nghiệp vụ

Điều khoản thanh toán mua hàng quy định các điều kiện thanh toán với nhà cung cấp:
- Thời hạn thanh toán (ví dụ: 30 ngày, 60 ngày)
- Chiết khấu thanh toán sớm (nếu thanh toán trong hạn chiết khấu)
- Lãi suất phạt nếu quá hạn thanh toán

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` và `frmDMEdit` (Framework chuẩn của Asia ERP)
- Sử dụng control `AsTextNumeric` cho các trường số
- Hỗ trợ validation dữ liệu đầu vào
- Tích hợp với hệ thống phân quyền của Asia ERP

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục điều khoản thanh toán mua - một danh mục quan trọng trong việc quản lý công nợ và thanh toán với nhà cung cấp.

---

*Ngày phân tích: 2026-03-29*
