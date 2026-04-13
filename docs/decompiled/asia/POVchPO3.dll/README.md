# Báo cáo Phân tích DLL: POVchPO3.dll

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
| Assembly Name | POVchPO3 |
| Assembly Title | Voucher hóa đơn mua hàng |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
POVchPO3.dll/
├── POVchPO3.csproj              # Project file
├── app.ico                      # Application icon
├── AsiaErp.UserInterface.frmPOVchPO3.resx      # Resource file
├── AsiaErp.UserInterface.frmPOVchPO3SeachPO1.resx # Resource file
├── AsiaErp.UserInterface.frmPoVchPo3FindPO1.resx   # Resource file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmPOVchPO3.cs         # Main voucher form
│   ├── frmPOVchPO3Find.cs     # Find form
│   ├── frmPoVchPo3FindPO1.cs  # Find PO1 form
│   └── frmPOVchPO3SeachPO1.cs # Search PO1 form
├── AsiaErp.UserInterface.My/
│   └── Resources/
│       └── Resources.cs         # Resource manager
└── VB-AnonymousType_*.cs      # VB anonymous types (empty)
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (native-apps/ASIA/Helper.dll) |
| POUtilities | Purchase Order Utilities (native-apps/ASIA/POUtilities.dll) |
| System.Data | Data access |
| System.Core | LINQ support |
| System.Xml.Linq | XML LINQ support |
| System.Data.DataSetExtensions | DataSet extensions |

### Namespaces sử dụng

- `AsiaErp.Framework`, `AsiaErp.POUtilities`
- `System`, `System.Collections`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Linq`, `System.Runtime.CompilerServices`, `System.Runtime.InteropServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPOVchPO3` | `frmVoucher` | Form nhập liệu hóa đơn mua hàng |
| `frmPOVchPO3Find` | `frmVoucherFind` | Form tìm kiếm chứng từ |
| `frmPoVchPo3FindPO1` | - | Form tìm kiếm đơn đặt hàng |
| `frmPOVchPO3SeachPO1` | - | Form tìm kiếm nâng cao |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Hóa đơn mua hàng" - Tên chức năng chính
- "Mã nhà cung cấp" (`txtMa_Kh`)
- "Tên nhà cung cấp" (`lblTen_Kh`)
- "Người giao dịch" (`txtNguoi_Gd`)
- "Diễn giải" (`txtDien_giai`)
- "Địa chỉ" (`txtDia_chi`)
- "Mã số thuế" (`txtMa_so_thue`)
- "Số hóa đơn" (`txtSo_hd`)
- "Ngày hóa đơn" (`txtNgay_hd`)
- "Tỷ giá" (`txtTy_gia`)
- "Mã ngoại tệ" (`cboMa_NT`)
- "Hình thức thanh toán" (`txtMa_Httt`)

### Tab Pages

| Tab | Mục đích |
|-----|----------|
| `tabChi_phi` | Chi phí mua hàng |
| `tabHach_toan` | Hạch toán kế toán |
| `tabTain` | Thuế đầu vào (TaIn) |

### Cột DataGridView (Chi tiết hóa đơn)

| Cột | Ý nghĩa |
|-----|---------|
| `dgvcMa_vt` | Mã vật tư |
| `dgvcTen_vt` | Tên vật tư |
| `dgvcDvt` | Đơn vị tính |
| `dgvcMa_kho` | Mã kho |
| `dgvcSo_luong` | Số lượng |
| `dgvcGia_nt0` | Giá ngoại tệ |
| `dgvcTien_nt0` | Tiền ngoại tệ |
| `dgvcTs_gtgt` | Thuế suất GTGT |
| `dgvcThue_Gtgt_nt` | Thuế GTGT NT |
| `dgvcGia0` | Giá |
| `dgvcTien0` | Tiền |
| `dgvcThue_gtgt` | Thuế GTGT |
| `dgvcMa_bp` | Mã bộ phận |
| `dgvcMa_phi` | Mã phí |
| `dgvcMa_spct` | Mã SP chi tiết |
| `dgvcMa_Lo` | Mã lô |

### Cột DataGridView (Chi phí)

| Cột | Ý nghĩa |
|-----|---------|
| `dgvcMa_chiphi` | Mã chi phí |
| `dgvcTen_chi_phi` | Tên chi phí |
| `dgvcTT_PB` | Thông tin phân bổ |
| `dgvcTien_cp_nt_cp` | Tiền chi phí NT |
| `dgvcTs_gtgt_cp` | Thuế suất chi phí |
| `dgvcThue_gtgt_nt_cp` | Thuế GTGT chi phí NT |
| `dgvcTt_nt_Cp` | Tổng tiền chi phí NT |
| `dgvcTien_cp_cp` | Tiền chi phí |
| `dgvcThue_gtgt_cp` | Thuế GTGT chi phí |
| `dgvcTt_Cp` | Tổng tiền chi phí |

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_kh` | Mã nhà cung cấp |
| `so_hd` | Số hóa đơn |
| `ngay_hd` | Ngày hóa đơn |
| `ma_httt` | Mã hình thức thanh toán |
| `t_tien_nt0` | Tổng tiền hàng NT |
| `t_tien0` | Tổng tiền hàng |
| `t_cp_nt` | Tổng chi phí NT |
| `t_cp` | Tổng chi phí |
| `t_thue_nt` | Tổng thuế NT |
| `t_thue` | Tổng thuế |
| `t_ck_nt` | Tổng chiết khấu NT |
| `t_ck` | Tổng chiết khấu |
| `t_tt_nt` | Tổng thanh toán NT |
| `t_tt` | Tổng thanh toán |
| `tk_thue` | Tài khoản thuế |
| `tk_pt` | Tài khoản phải trả |

---

## Mục đích sử dụng

**POVchPO3.dll là module quản lý Voucher hóa đơn mua hàng (PO3)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu hóa đơn mua hàng
- Quản lý thông tin nhà cung cấp
- Nhập thông tin hóa đơn (số HĐ, ngày HĐ)
- Quản lý hình thức thanh toán
- Nhập chi tiết hàng hóa/vật tư mua

#### 2. Quản lý chi phí mua hàng
- Tab chi phí riêng (`tabChi_phi`)
- Phân bổ chi phí mua hàng cho các mặt hàng
- Tính toán chi phí nhập khẩu (nếu có)

#### 3. Hạch toán kế toán
- Tab hạch toán (`tabHach_toan`)
- Tài khoản phải trả (`tk_pt`)
- Tài khoản thuế GTGT (`tk_thue`)
- Control `ctlTaIn` cho thuế đầu vào

#### 4. Tính toán tự động
- Tính tổng tiền hàng
- Tính chi phí mua hàng
- Tính thuế GTGT
- Tính chiết khấu thanh toán
- Tính tổng thanh toán
- Phân bổ chi phí (`cmdPhan_bo`)

#### 5. Liên kết chứng từ
- Lấy dữ liệu từ đơn đặt hàng (PO1)
- Kiểm tra khớp đơn hàng với hóa đơn

### Đặc điểm kỹ thuật

- Kế thừa từ `frmVoucher` (Framework chuẩn của Asia ERP)
- Sử dụng Multi-Tab (Chi tiết, Chi phí, Hạch toán, Thuế)
- Tích hợp `ctlTaIn` cho quản lý thuế đầu vào
- SplitContainer cho phân chia màn hình chi phí
- Hỗ trợ nhập khẩu với các loại thuế đặc biệt

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý hóa đơn mua hàng - chứng từ quan trọng trong quy trình mua hàng, kết nối với đơn đặt hàng và phiếu nhập kho.

---

*Ngày phân tích: 2026-03-29*
