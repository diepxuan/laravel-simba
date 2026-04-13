# Báo cáo Phân tích DLL: PORptTH01.dll

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
| Assembly Name | PORptTH01 |
| Assembly Title | Báo cáo tổng hợp mua hàng 01 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
PORptTH01.dll/
├── PORptTH01.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.UserInterface/
│   ├── frmPORptTH01.cs        # Main report form
│   └── lstVoucherInfo.cs        # Voucher info list class
├── AsiaERP.UserInterface.My/
│   └── Resources/
│       └── Resources.cs         # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (native-apps/ASIA/Helper.dll) |
| System.Data | Data access |
| System.Core | LINQ support |
| System.Xml.Linq | XML LINQ support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Runtime.InteropServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPORptTH01` | `frmReport` | Form báo cáo tổng hợp mua hàng 01 |
| `lstVoucherInfo` | - | Danh sách thông tin chứng từ |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo cáo tổng hợp mua hàng 01" - Tên chức năng chính
- "Loại phiếu" (`cboLoaiPhieu`)
- "Trạng thái" (`cboTrang_Thai`)
- "Điều khoản thanh toán" (`txtMA_DKTT`)
- "Hình thức thanh toán" (`txtMA_HTTT`)
- "Mã lô" (`txtMaLo`)
- "Mã nhóm hóa đơn" (`txtMa_nhhd`)
- "Mã vị trí" (`txtMa_vtri`)
- "Mã kho" (`txtMa_kho`)
- "Mã nhóm vật tư" (`txtMa_nh_vt`)
- "Mã vật tư" (`txtMa_vt`)
- "Mã hợp đồng" (`txtMa_hd`)
- "Mã nhóm NCC" (`txtMa_nh_ncc`)
- "Mã nhà cung cấp" (`txtMa_ncc`)
- "Mã SP chi tiết" (`txtMa_spct`)
- "Mã phí" (`txtMaPhi`)
- "Phân loại NCC 1/2/3" (`txtPl_ncc1`, `txtPl_ncc2`, `txtPl_ncc3`)
- "Phân loại VT 1/2/3" (`txtMa_Plvt1`, `txtMa_Plvt2`, `txtMa_plvt3`)

### Các loại phiếu hỗ trợ

| Loại phiếu | Mã |
|-------------|-----|
| Tất cả | - |
| Phiếu đề nghị mua hàng | - |
| Đơn hàng mua | - |
| Phiếu nhập mua | - |
| Hoá đơn mua hàng | - |
| Phiếu chi phí mua hàng | - |
| Phiếu xuất trả lại NCC | - |
| Hoá đơn mua dịch vụ | - |
| Hoá đơn mua hàng nhập khẩu | - |

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_dktt` | Mã điều khoản thanh toán |
| `ma_httt` | Mã hình thức thanh toán |
| `ma_lo` | Mã lô |
| `ma_nhhd` | Mã nhóm hóa đơn |
| `ma_vtri` | Mã vị trí kho |
| `ma_kho` | Mã kho |
| `ma_nh_vt` | Mã nhóm vật tư |
| `ma_vt` | Mã vật tư |
| `ma_hd` | Mã hợp đồng |
| `ma_nh_ncc` | Mã nhóm nhà cung cấp |
| `ma_ncc` | Mã nhà cung cấp |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_phi` | Mã phí |
| `pl_ncc1/2/3` | Phân loại nhà cung cấp 1/2/3 |
| `pl_vt1/2/3` | Phân loại vật tư 1/2/3 |

---

## Mục đích sử dụng

**PORptTH01.dll là module Báo cáo tổng hợp mua hàng 01** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo tổng hợp mua hàng
- Tổng hợp dữ liệu mua hàng theo nhiều tiêu chí
- Hỗ trợ lọc theo loại phiếu (đơn hàng, hóa đơn, phiếu nhập, ...)
- Hỗ trợ lọc theo trạng thái chứng từ

#### 2. Các tiêu chí lọc báo cáo

##### Thông tin thanh toán
- Điều khoản thanh toán (`ma_dktt`)
- Hình thức thanh toán (`ma_httt`)

##### Thông tin kho
- Mã kho (`ma_kho`)
- Mã vị trí kho (`ma_vtri`)
- Mã lô (`ma_lo`)

##### Thông tin vật tư
- Mã vật tư (`ma_vt`)
- Mã nhóm vật tư (`ma_nh_vt`)
- Phân loại vật tư 1/2/3

##### Thông tin nhà cung cấp
- Mã nhà cung cấp (`ma_ncc`)
- Mã nhóm NCC (`ma_nh_ncc`)
- Phân loại NCC 1/2/3

##### Thông tin khác
- Mã hợp đồng (`ma_hd`)
- Mã nhóm hóa đơn (`ma_nhhd`)
- Mã sản phẩm chi tiết (`ma_spct`)
- Mã phí (`ma_phi`)

#### 3. Xuất báo cáo
- Hỗ trợ nhiều mẫu báo cáo (`cboMau_bc`)
- Xuất ra Crystal Report
- Xuất ra Excel
- In ấn trực tiếp

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` (Framework chuẩn của Asia ERP)
- Sử dụng `AsComboBox` cho các dropdown
- Sử dụng `AsTextBox` cho các trường nhập liệu có validation
- Tích hợp Crystal Report cho xuất báo cáo
- Hỗ trợ drill-down (xem chi tiết từ báo cáo tổng hợp)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc tạo báo cáo tổng hợp mua hàng với nhiều tiêu chí lọc linh hoạt, hỗ trợ quản lý và phân tích dữ liệu mua hàng.

---

*Ngày phân tích: 2026-03-29*
