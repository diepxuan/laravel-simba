# Báo cáo Phân tích DLL: POVchPO5.dll

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
| Assembly Name | POVchPO5 |
| Assembly Title | Voucher trả lại hàng mua |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
POVchPO5.dll/
├── POVchPO5.csproj              # Project file
├── app.ico                      # Application icon
├── AsiaErp.UserInterface.frmPOVchPO5FindPO3PO7.resx   # Resource file
├── AsiaErp.UserInterface.frmPOVchPO5SeachPO2PO3PO7.resx # Resource file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmPOVchPO5.cs         # Main voucher form
    ├── frmPOVchPO5Find.cs     # Find form
    ├── frmPOVchPO5FindPO3PO7.cs  # Find PO3/PO7 form
    └── frmPOVchPO5SeachPO2PO3PO7.cs # Search multi-PO form
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

### Namespaces sử dụng

- `AsiaErp.Framework`, `AsiaErp.POUtilities`
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPOVchPO5` | `frmVoucher` | Form nhập liệu phiếu trả lại hàng mua |
| `frmPOVchPO5Find` | `frmVoucherFind` | Form tìm kiếm chứng từ |
| `frmPOVchPO5FindPO3PO7` | - | Form tìm kiếm từ hóa đơn/phiếu nhập |
| `frmPOVchPO5SeachPO2PO3PO7` | - | Form tìm kiếm nâng cao |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Phiếu trả lại hàng mua" - Tên chức năng chính
- "Mã nhà cung cấp" (`txtMa_Kh`)
- "Tên nhà cung cấp" (`lblTen_Kh`)
- "Người giao dịch" (`txtNguoi_Gd`)
- "Diễn giải" (`txtDien_giai`)
- "Địa chỉ" (`txtDia_chi`)
- "Mã số thuế" (`txtMa_so_thue`)
- "Tỷ giá" (`txtTy_gia`)
- "Mã ngoại tệ" (`cboMa_NT`)
- "Số seri" (`txtSo_Seri`)
- "Số seri mua hóa đơn" (`txtSo_seri_mhd`)
- "Chọn phiếu nhập" (`cmdChon_Pn`)

### Tab Pages

| Tab | Mục đích |
|-----|----------|
| `tabHach_toan` | Hạch toán kế toán |

### Cột DataGridView (Chi tiết trả lại)

| Cột | Ý nghĩa |
|-----|---------|
| `dgvcMa_vt` | Mã vật tư |
| `dgvcTen_vt` | Tên vật tư |
| `dgvcDvt` | Đơn vị tính |
| `dgvcMa_kho` | Mã kho |
| `dgvcTon` | Tồn kho |
| `dgvcSo_luong` | Số lượng trả |
| `dgvcGia_nt` | Giá ngoại tệ |
| `dgvcTien_nt` | Tiền ngoại tệ |
| `dgvcTs_gtgt` | Thuế suất GTGT |
| `dgvcThue_gtgt_nt` | Thuế GTGT NT |
| `dgvcGia` | Giá |
| `dgvcTien` | Tiền |
| `dgvcThue_gtgt` | Thuế GTGT |
| `dgvcSo_hd` | Số hóa đơn gốc |
| `dgvcTk_vt` | Tài khoản vật tư |
| `dgvcTk_pt` | Tài khoản phải trả |
| `dgvcMa_vt_ht` | Mã vật tư hạch toán |

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_kh` | Mã nhà cung cấp |
| `so_seri` | Số seri chứng từ |
| `so_seri_mhd` | Số seri mua hóa đơn gốc |
| `ma_httt` | Mã hình thức thanh toán |
| `t_tien_nt` | Tổng tiền hàng NT |
| `t_tien` | Tổng tiền hàng |
| `t_thue_nt` | Tổng thuế NT |
| `t_thue` | Tổng thuế |
| `t_tt_nt` | Tổng thanh toán NT |
| `t_tt` | Tổng thanh toán |
| `t_so_luong` | Tổng số lượng |
| `tk_thue` | Tài khoản thuế |
| `tk_pt` | Tài khoản phải trả |
| `gia_dd` | Giá đã định (checkbox) |

---

## Mục đích sử dụng

**POVchPO5.dll là module quản lý Voucher trả lại hàng mua (PO5)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu phiếu trả lại hàng mua
- Quản lý thông tin nhà cung cấp
- Nhập thông tin phiếu trả lại hàng
- Quản lý số seri chứng từ và số seri hóa đơn gốc
- Nhập chi tiết hàng hóa/vật tư trả lại

#### 2. Chọn từ phiếu nhập/hóa đơn
- Nút "Chọn phiếu nhập" (`cmdChon_Pn`)
- Lấy dữ liệu từ phiếu nhập kho (PO4)
- Lấy dữ liệu từ hóa đơn mua (PO3)
- Tự động điền thông tin chi tiết từ chứng từ gốc

#### 3. Quản lý số lượng trả
- Kiểm tra tồn kho (`dgvcTon`)
- Nhập số lượng trả lại
- Giữ nguyên giá từ chứng từ gốc
- Checkbox "Giá đã định" (`chkGia_dd`)

#### 4. Hạch toán kế toán
- Tab hạch toán (`tabHach_toan`)
- Tài khoản phải trả (`tk_pt`)
- Tài khoản thuế (`tk_thue`)
- Tài khoản vật tư (`dgvcTk_vt`)
- Giảm trừ công nợ nhà cung cấp

#### 5. Tính toán tự động
- Tính tổng tiền hàng trả
- Tính thuế GTGT giảm trừ
- Tính tổng thanh toán giảm
- Cập nhật tồn kho (giảm)

#### 6. Liên kết chứng từ
- Liên kết với phiếu nhập kho (PO4)
- Liên kết với hóa đơn mua (PO3)
- Kiểm tra số lượng trả không vượt quá số lượng nhập

### Đặc điểm kỹ thuật

- Kế thừa từ `frmVoucher` (Framework chuẩn của Asia ERP)
- Sử dụng `AsInputDGV` cho nhập liệu chi tiết
- Tích hợp `POUtilities` cho các hàm chung
- SplitContainer cho phân chia màn hình hạch toán
- Hỗ trợ chọn dữ liệu từ nhiều nguồn (PO2, PO3, PO7)
- Validation số lượng trả không vượt quá tồn kho

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý phiếu trả lại hàng mua - chứng từ ghi nhận hàng hóa trả lại nhà cung cấp, giảm trừ công nợ và cập nhật tồn kho.

---

*Ngày phân tích: 2026-03-29*
