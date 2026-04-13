# Báo cáo Phân tích DLL: POVchPO4.dll

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
| Assembly Name | POVchPO4 |
| Assembly Title | Voucher phiếu nhập kho |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
POVchPO4.dll/
├── POVchPO4.csproj              # Project file
├── app.ico                      # Application icon
├── AsiaErp.UserInterface.frmPOVchPO4.resx      # Resource file
├── AsiaErp.UserInterface.frmPOVchPO4SeachPO2PO3PO7.resx # Resource file
├── AsiaErp.UserInterface.frmPOVchPO4FindPO2PO3PO7.resx   # Resource file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmPOVchPO4.cs         # Main voucher form
│   ├── frmPOVchPO4Find.cs     # Find form
│   ├── frmPOVchPO4FindPO2PO3PO7.cs  # Find multi-PO form
│   └── frmPOVchPO4SeachPO2PO3PO7.cs # Search multi-PO form
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
| `frmPOVchPO4` | `frmVoucher` | Form nhập liệu phiếu nhập kho |
| `frmPOVchPO4Find` | `frmVoucherFind` | Form tìm kiếm chứng từ |
| `frmPOVchPO4FindPO2PO3PO7` | - | Form tìm kiếm từ đơn hàng/hóa đơn |
| `frmPOVchPO4SeachPO2PO3PO7` | - | Form tìm kiếm nâng cao |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Phiếu nhập kho" - Tên chức năng chính
- "Mã nhà cung cấp" (`txtMa_Kh`)
- "Tên nhà cung cấp" (`lblTen_Kh`)
- "Người giao dịch" (`txtNguoi_Gd`)
- "Diễn giải" (`txtDien_giai`)
- "Địa chỉ" (`txtDia_chi`)
- "Mã số thuế" (`txtMa_so_thue`)
- "Tỷ giá" (`txtTy_gia`)
- "Mã ngoại tệ" (`cboMa_NT`)
- "Hình thức thanh toán" (`txtMa_Httt`)
- "Chọn đơn hàng" (`cmdChon_dh`)

### Tab Pages

| Tab | Mục đích |
|-----|----------|
| `tabChi_phi` | Chi phí nhập kho |
| `tabHach_toan` | Hạch toán kế toán |
| `tabTain` | Thuế đầu vào |

### Cột DataGridView (Chi tiết nhập kho)

| Cột | Ý nghĩa |
|-----|---------|
| `dgvcMa_vt` | Mã vật tư |
| `dgvcTen_vt` | Tên vật tư |
| `dgvcDvt` | Đơn vị tính |
| `dgvcMa_kho` | Mã kho |
| `dgvcSo_luong` | Số lượng nhập |
| `dgvcMa_nt` | Mã ngoại tệ |
| `dgvcTien_nt0` | Tiền ngoại tệ |
| `dgvcCp_nt` | Chi phí ngoại tệ |
| `dgvcTien0` | Tiền |
| `dgvcCp` | Chi phí |
| `dgvcTk_vt` | Tài khoản vật tư |
| `dgvcTk_co` | Tài khoản có |
| `dgvSo_pn` | Số phiếu nhập |

### Cột DataGridView (Chi phí)

| Cột | Ý nghĩa |
|-----|---------|
| `dgvcMa_chiphi` | Mã chi phí |
| `dgvcTT_PB` | Thông tin phân bổ |
| `dgvcTen_chi_phi` | Tên chi phí |
| `dgvcTien_cp_nt_cp` | Tiền chi phí NT |
| `dgvcTs_Gtgt` | Thuế suất GTGT |
| `dgvcThue_gtgt_nt_cp` | Thuế GTGT NT |
| `dgvcTt_nt_cp` | Tổng tiền NT |
| `dgvcTien_cp_cp` | Tiền chi phí |
| `dgvcThue_gtgt_cp` | Thuế GTGT |
| `dgvcTt_Cp` | Tổng tiền |

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_kh` | Mã nhà cung cấp |
| `ma_httt` | Mã hình thức thanh toán |
| `t_tien_nt0` | Tổng tiền hàng NT |
| `t_tien0` | Tổng tiền hàng |
| `t_cp_nt` | Tổng chi phí NT |
| `t_cp` | Tổng chi phí |
| `tien_cp_pb_nt` | Tiền chi phí phân bổ NT |
| `tien_cp_pb` | Tiền chi phí phân bổ |
| `t_thue_nt` | Tổng thuế NT |
| `t_thue` | Tổng thuế |
| `t_tt_nt` | Tổng thanh toán NT |
| `t_tt` | Tổng thanh toán |
| `tk_pt` | Tài khoản phải trả |
| `tk_thue` | Tài khoản thuế |

---

## Mục đích sử dụng

**POVchPO4.dll là module quản lý Voucher phiếu nhập kho (PO4)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu phiếu nhập kho
- Quản lý thông tin nhà cung cấp
- Nhập thông tin phiếu nhập kho
- Quản lý hình thức thanh toán
- Nhập chi tiết hàng hóa/vật tư nhập kho

#### 2. Chọn từ đơn hàng/hóa đơn
- Nút "Chọn đơn hàng" (`cmdChon_dh`)
- Lấy dữ liệu từ đơn đặt hàng (PO1)
- Lấy dữ liệu từ hóa đơn mua (PO3)
- Tự động điền thông tin chi tiết

#### 3. Quản lý chi phí nhập kho
- Tab chi phí (`tabChi_phi`)
- Phân bổ chi phí nhập kho cho các mặt hàng
- Tính toán chi phí vận chuyển, bốc xếp, ...

#### 4. Hạch toán kế toán
- Tab hạch toán (`tabHach_toan`)
- Tài khoản phải trả (`tk_pt`)
- Tài khoản thuế (`tk_thue`)
- Tài khoản vật tư (`dgvcTk_vt`)
- Control `ctlTaIn` cho thuế đầu vào

#### 5. Tính toán tự động
- Tính tổng tiền hàng nhập
- Tính chi phí nhập kho
- Tính thuế GTGT
- Tính tổng thanh toán
- Phân bổ chi phí (`cmdPhan_bo`)

#### 6. Liên kết chứng từ
- Liên kết với đơn đặt hàng (PO1)
- Liên kết với hóa đơn mua (PO3)
- Kiểm tra khớp số lượng nhập với đơn hàng

### Đặc điểm kỹ thuật

- Kế thừa từ `frmVoucher` (Framework chuẩn của Asia ERP)
- Sử dụng Multi-Tab (Chi tiết, Chi phí, Hạch toán, Thuế)
- Tích hợp `ctlTaIn` cho quản lý thuế đầu vào
- SplitContainer cho phân chia màn hình chi phí
- Hỗ trợ chọn dữ liệu từ nhiều nguồn (PO1, PO3, PO7)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý phiếu nhập kho - chứng từ ghi nhận hàng hóa nhập về kho, kết nối với đơn đặt hàng và hóa đơn mua.

---

*Ngày phân tích: 2026-03-29*
