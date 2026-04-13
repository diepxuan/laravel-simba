# Báo cáo Phân tích DLL: PORptBK01.dll

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
| Assembly Name | PORptBK01 |
| Assembly Title | Bảng kê chứng từ mua hàng |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
PORptBK01.dll/
├── PORptBK01.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.UserInterface/
│   ├── frmPORptBK01.cs        # Main report form
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
- `System`, `System.Collections`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPORptBK01` | `frmReport2DGV` | Form bảng kê chứng từ mua hàng |
| `lstVoucherInfo` | - | Danh sách thông tin chứng từ |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng kê chứng từ mua hàng" - Tên chức năng chính
- "Loại phiếu" (`cboLoaiPhieu`)
- "Trạng thái" (`cboTrang_Thai`)
- "Số chứng từ từ/đến" (`txtCT1`, `txtCT2`)
- "Nhân viên kinh doanh" (`txtNv_kd`)
- "Nhóm theo" (`chkNh_Ncc`)
- "Mã bộ phận" (`txtMa_bp`)
- "Mã nhóm hóa đơn" (`txtMa_nhhd`)
- "Mã hợp đồng" (`txtMa_hd`)
- "Điều khoản thanh toán" (`txtMA_DKTT`)
- "Hình thức thanh toán" (`txtMA_HTTT`)
- "Mã nhóm vật tư" (`txtMa_nh_vt`)
- "Mã vật tư" (`txtMa_vt`)
- "Mã lô" (`txtMaLo`)
- "Mã kho" (`txtMa_kho`)
- "Mã nhóm NCC" (`txtMa_nh_ncc`)
- "Mã nhà cung cấp" (`txtMa_ncc`)
- "Mã vị trí" (`txtMa_vtri`)
- "Mã phí" (`txtMaPhi`)
- "Mã SP chi tiết" (`txtMa_spct`)
- "Phân loại NCC 1/2/3" (`txtPl_ncc1`, `txtPl_ncc2`, `txtPl_ncc3`)
- "Phân loại VT 1/2/3" (`txtMa_Plvt1`, `txtMa_Plvt2`, `txtMa_plvt3`)

### Các loại phiếu hỗ trợ

| Loại phiếu |
|-------------|
| Tất cả |
| Phiếu đề nghị mua hàng |
| Đơn hàng mua |
| Phiếu nhập mua |
| Hoá đơn mua hàng |
| Phiếu chi phí mua hàng |
| Phiếu xuất trả lại NCC |
| Hoá đón mua dịch vụ |
| Hoá đơn mua hàng nhập khẩu |

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `so_ct1` | Số chứng từ từ |
| `so_ct2` | Số chứng từ đến |
| `nv_kd` | Nhân viên kinh doanh |
| `nh_ncc` | Nhóm theo nhà cung cấp |
| `ma_bp` | Mã bộ phận |
| `ma_nhhd` | Mã nhóm hóa đơn |
| `ma_hd` | Mã hợp đồng |
| `ma_dktt` | Mã điều khoản thanh toán |
| `ma_httt` | Mã hình thức thanh toán |
| `ma_nh_vt` | Mã nhóm vật tư |
| `ma_vt` | Mã vật tư |
| `ma_lo` | Mã lô |
| `ma_kho` | Mã kho |
| `ma_nh_ncc` | Mã nhóm nhà cung cấp |
| `ma_ncc` | Mã nhà cung cấp |
| `ma_vtri` | Mã vị trí kho |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `pl_ncc1/2/3` | Phân loại nhà cung cấp 1/2/3 |
| `pl_vt1/2/3` | Phân loại vật tư 1/2/3 |

---

## Mục đích sử dụng

**PORptBK01.dll là module Bảng kê chứng từ mua hàng** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Bảng kê chứng từ mua hàng
- Liệt kê các chứng từ mua hàng theo nhiều tiêu chí
- Hiển thị dưới dạng 2 DataGridView (Master-Detail)
- Hỗ trợ xem tổng quan và chi tiết

#### 2. Các tiêu chí lọc báo cáo

##### Thông tin chứng từ
- Loại phiếu (đơn hàng, hóa đơn, phiếu nhập, ...)
- Trạng thái chứng từ
- Số chứng từ (từ - đến)
- Ngày chứng từ

##### Thông tin nhân viên
- Nhân viên kinh doanh (`nv_kd`)

##### Thông tin tổ chức
- Mã bộ phận (`ma_bp`)

##### Thông tin thanh toán
- Điều khoản thanh toán (`ma_dktt`)
- Hình thức thanh toán (`ma_httt`)

##### Thông tin hợp đồng
- Mã hợp đồng (`ma_hd`)
- Mã nhóm hóa đơn (`ma_nhhd`)

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
- Checkbox "Nhóm theo NCC" (`chkNh_Ncc`)

##### Thông tin khác
- Mã sản phẩm chi tiết (`ma_spct`)
- Mã phí (`ma_phi`)

#### 3. Nhóm dữ liệu
- Hỗ trợ nhóm theo nhà cung cấp
- Hiển thị tổng hợp theo nhóm

#### 4. Xuất báo cáo
- Hỗ trợ nhiều mẫu báo cáo (`cboMau_bc`)
- Xuất ra Crystal Report
- Xuất ra Excel
- In ấn trực tiếp

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport2DGV` (Báo cáo với 2 DataGridView)
- 2 DataGridView: Master (chứng từ) và Detail (chi tiết)
- Sử dụng `AsComboBox` cho các dropdown
- Sử dụng `AsTextBox` cho các trường nhập liệu có validation
- Sử dụng `AsCheckBox` cho các tùy chọn
- Tích hợp Crystal Report cho xuất báo cáo

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc tạo bảng kê chứng từ mua hàng với khả năng hiển thị 2 cấp độ (tổng hợp và chi tiết), hỗ trợ quản lý và tra cứu thông tin chứng từ mua hàng.

---

*Ngày phân tích: 2026-03-29*
