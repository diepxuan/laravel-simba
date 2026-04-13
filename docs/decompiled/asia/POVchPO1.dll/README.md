# Báo cáo Phân tích DLL: POVchPO1.dll

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
| Assembly Name | POVchPO1 |
| Assembly Title | Voucher đơn đặt hàng mua |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
POVchPO1.dll/
├── POVchPO1.csproj              # Project file
├── app.ico                      # Application icon
├── AsiaErp.UserInterface.frmPOVchPO1FindPO0.resx  # Resource file
├── AsiaErp.UserInterface.frmPOVchPO1SeachPO0.resx # Resource file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmPOVchPO1.cs         # Main voucher form
    ├── frmPOVchPO1Find.cs     # Find form
    ├── frmPOVchPO1FindPO0.cs  # Find PO0 form
    └── frmPOVchPO1SeachPO0.cs # Search PO0 form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |
| POUtilities | Purchase Order Utilities (../../../../native-apps/ASIA/POUtilities.dll) |
| System.Data | Data access |

### Namespaces sử dụng

- `AsiaErp.Framework`, `AsiaErp.POUtilities`
- `System`, `System.Collections`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Runtime.InteropServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPOVchPO1` | `frmVoucher` | Form nhập liệu đơn đặt hàng mua |
| `frmPOVchPO1Find` | `frmVoucherFind` | Form tìm kiếm chứng từ |
| `frmPOVchPO1FindPO0` | - | Form tìm kiếm đơn hàng gốc |
| `frmPOVchPO1SeachPO0` | - | Form tìm kiếm nâng cao |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Đơn đặt hàng mua" - Tên chức năng chính
- "Mã nhà cung cấp" (`txtMa_Kh`)
- "Tên nhà cung cấp" (`lblTen_Kh`)
- "Người giao dịch" (`txtNguoi_Gd`)
- "Diễn giải" (`txtDien_giai`)
- "Địa chỉ" (`txtDia_chi`)
- "Mã số thuế" (`txtMa_so_thue`)
- "Tỷ giá" (`txtTy_gia`)
- "Mã ngoại tệ" (`cboMa_NT`)

### Cột DataGridView (Chi tiết đơn hàng)

| Cột | Ý nghĩa |
|-----|---------|
| `dgvcMa_vt` | Mã vật tư |
| `dgvcTen_vt` | Tên vật tư |
| `dgvcDvt` | Đơn vị tính |
| `dgvcMa_kho` | Mã kho |
| `dgvcMa_Vitri` | Mã vị trí kho |
| `dgvcTon` | Tồn kho |
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
| `dgvcMa_spct` | Mã sản phẩm chi tiết |
| `dgvcMa_Lo` | Mã lô |
| `dgvSo_dh` | Số đơn hàng |

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_kh` | Mã nhà cung cấp |
| `nguoi_gd` | Người giao dịch |
| `dien_giai` | Diễn giải |
| `ty_gia` | Tỷ giá |
| `ma_nt` | Mã ngoại tệ |
| `t_tien_nt0` | Tổng tiền ngoại tệ |
| `t_tien0` | Tổng tiền |
| `t_thue_nt` | Tổng thuế ngoại tệ |
| `t_thue` | Tổng thuế |
| `t_tt_nt` | Tổng thanh toán ngoại tệ |
| `t_tt` | Tổng thanh toán |
| `t_ck_nt` | Tổng chiết khấu ngoại tệ |
| `t_ck` | Tổng chiết khấu |
| `trang_thai` | Trạng thái đơn hàng |

---

## Mục đích sử dụng

**POVchPO1.dll là module quản lý Voucher đơn đặt hàng mua (PO1)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu đơn đặt hàng mua
- Quản lý thông tin nhà cung cấp (mã KH, tên, địa chỉ, người giao dịch, mã số thuế)
- Quản lý thông tin đơn hàng (diễn giải, tỷ giá, ngoại tệ)
- Nhập chi tiết vật tư/hàng hóa cần mua

#### 2. Quản lý chi tiết đơn hàng
- Mã vật tư, tên vật tư, đơn vị tính
- Số lượng đặt hàng
- Giá và thành tiền (ngoại tệ và VNĐ)
- Thuế GTGT
- Thông tin kho, vị trí kho
- Thông tin bộ phận, phí, sản phẩm chi tiết

#### 3. Tính toán tự động
- Tính tổng tiền hàng
- Tính thuế GTGT
- Tính chiết khấu
- Tính tổng thanh toán
- Chuyển đổi ngoại tệ theo tỷ giá

#### 4. Quản lý trạng thái
- Trạng thái đơn hàng (chờ duyệt, đã duyệt, đã nhận, ...)
- Kiểm tra tồn kho (`dgvcTon`)

#### 5. Tìm kiếm và liên kết
- Tìm kiếm đơn hàng theo nhiều tiêu chí
- Liên kết với đơn hàng gốc (PO0)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmVoucher` (Framework chuẩn của Asia ERP)
- Sử dụng `AsInputDGV` cho nhập liệu chi tiết
- Tích hợp `POUtilities` cho các hàm chung của module PO
- Hỗ trợ đa tiền tệ với tỷ giá linh hoạt
- Validation dữ liệu đầu vào (mã KH, mã vật tư, số lượng)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý đơn đặt hàng mua - chứng từ đầu tiên trong quy trình mua hàng.

---

*Ngày phân tích: 2026-03-29*
