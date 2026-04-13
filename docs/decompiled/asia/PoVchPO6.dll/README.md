# Báo cáo Phân tích DLL: PoVchPO6.dll

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
| Assembly Name | PoVchPO6 |
| Assembly Title | Hoá đơn mua dịch vụ |
| Assembly Company | Công ty phần mềm Asia |
| Assembly Product | Simba Accounting |
| Assembly Copyright | Copyright © 2014 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 14.1.0.0 |
| Assembly File Version | 14.1.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
PoVchPO6.dll/
├── PoVchPO6.csproj              # Project file
├── app.ico                      # Application icon
├── AsiaErp.UserInterface/
│   ├── frmPoVchPO6.cs           # Main voucher form
│   └── frmPoVchPO6Find.cs       # Search form
├── AsiaErp.UserInterface.My.Resources/
│   └── Resources.cs             # Resource manager
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── VB-AnonymousType_*.cs        # VB anonymous types (empty)
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Core | .NET Core extensions |
| System.Data.DataSetExtensions | DataSet extensions |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| POUtilities | Purchase Order utilities |

### Namespaces sử dụng

- `AsiaErp.Framework`, `AsiaErp.POUtilities`
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Linq`, `System.Runtime.InteropServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPoVchPO6` | `frmVoucher` | Form nhập liệu chứng từ PO6 |
| `frmPoVchPO6Find` | `frmVoucherFind` | Form tìm kiếm chứng từ |

---

## Controls chính trong frmPoVchPO6

### Thông tin phiếu (Header)

| Control | Loại | Mục đích |
|---------|------|----------|
| `txtSo_Seri` | TextBox | Số seri hóa đơn |
| `txtNgay_lct` | AsMaskedTextBox | Ngày lập chứng từ |
| `cboMa_NT` | AsComboBoxNT | Mã ngoại tệ |
| `txtTy_gia` | AsTextNumeric | Tỷ giá |
| `txtMa_Kh` | AsTextBox | Mã nhà cung cấp |
| `txtNguoi_Gd` | TextBox | Người giao dịch |
| `txtDia_chi` | TextBox | Địa chỉ |
| `txtMa_so_thue` | TextBox | Mã số thuế |
| `txtSo_hd` | TextBox | Số hóa đơn |
| `txtNgay_hd` | AsMaskedTextBox | Ngày hóa đơn |
| `txtMa_Httt` | AsTextBox | Hình thức thanh toán |
| `txtDien_giai` | TextBox | Diễn giải |

### Tab Chi tiết (Detail)

| Control | Loại | Mục đích |
|---------|------|----------|
| `adgvDetail` | AsInputDGV | DataGridView chi tiết |
| `dgvcMa_vt` | DataGridViewAsTextBoxColumn | Mã vật tư/dịch vụ |
| `dgvcTen_vt` | DataGridViewTextBoxColumn | Tên vật tư |
| `dgvcDvt` | DataGridViewTextBoxColumn | Đơn vị tính |
| `dgvcSo_luong` | DataGridViewAsTextNumericColumn | Số lượng |
| `dgvcGia_Nt` | DataGridViewAsTextNumericColumn | Giá ngoại tệ |
| `dgvcTien_nt` | DataGridViewAsTextNumericColumn | Tiền ngoại tệ |
| `dgvcTs_gtgt` | DataGridViewAsTextNumericColumn | Thuế suất GTGT |
| `dgvcThue_gtgt_nt` | DataGridViewAsTextNumericColumn | Thuế GTGT NT |
| `dgvcGia` | DataGridViewAsTextNumericColumn | Giá VNĐ |
| `dgvcTien` | DataGridViewAsTextNumericColumn | Tiền VNĐ |
| `dgvcThue_gtgt` | DataGridViewAsTextNumericColumn | Thuế GTGT VNĐ |
| `dgvcTk_no` | DataGridViewAsTextBoxColumn | TK nợ |

### Tab Thuế (tabTain)

| Control | Loại | Mục đích |
|---------|------|----------|
| `ctlTaIn` | ctlTaIn | Control thuế đầu vào |
| `cmdGetTaInFromDetail` | Button | Lấy thuế từ chi tiết |

### Tab Hạch toán (tabHach_toan)

| Control | Loại | Mục đích |
|---------|------|----------|
| `adgvHach_toan` | AsInputDGV | DataGridView hạch toán |
| `txtTk_pt` | AsTextBox | TK phải trả |
| `txtTk_thue` | AsTextBox | TK thuế |

### Tổng tiền

| Control | Loại | Mục đích |
|---------|------|----------|
| `txtT_Tien_nt` | AsTextNumeric | Tổng tiền ngoại tệ |
| `txtT_Thue_nt` | AsTextNumeric | Tổng thuế NT |
| `txtT_tt_nt` | AsTextNumeric | Tổng thanh toán NT |
| `txtT_Tien` | AsTextNumeric | Tổng tiền VNĐ |
| `txtT_Thue` | AsTextNumeric | Tổng thuế VNĐ |
| `txtT_tt` | AsTextNumeric | Tổng thanh toán VNĐ |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Hoá đơn mua dịch vụ" - Tên chứng từ
- "Số seri" - Số seri hóa đơn GTGT
- "Ngày lập" - Ngày lập chứng từ
- "Mã ngoại tệ", "Tỷ giá" - Thông tin ngoại tệ
- "Mã NCC" - Mã nhà cung cấp
- "Người giao dịch" - Người liên hệ
- "Số hóa đơn", "Ngày hóa đơn" - Thông tin hóa đơn VAT
- "Hình thức thanh toán" - Phương thức thanh toán
- "Diễn giải" - Mô tả nội dung

### Cột DataGridView

| Cột | Ý nghĩa |
|-----|---------|
| Mã vật tư | Mã dịch vụ/hàng hóa |
| Tên vật tư | Tên dịch vụ |
| ĐVT | Đơn vị tính |
| Số lượng | Số lượng |
| Giá NT | Giá ngoại tệ |
| Tiền NT | Thành tiền ngoại tệ |
| Thuế suất | % thuế GTGT |
| Thuế GTGT NT | Tiền thuế ngoại tệ |
| Giá | Giá VNĐ |
| Tiền | Thành tiền VNĐ |
| Thuế GTGT | Tiền thuế VNĐ |
| TK nợ | Tài khoản nợ |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ma_kh` | Mã nhà cung cấp |
| `so_hd` | Số hóa đơn |
| `ngay_hd` | Ngày hóa đơn |
| `ma_httt` | Mã hình thức thanh toán |
| `t_tien` | Tổng tiền |
| `t_thue` | Tổng thuế |
| `t_tt` | Tổng thanh toán |
| `tk_pt` | Tài khoản phải trả |
| `tk_thue` | Tài khoản thuế |

---

## Mục đích sử dụng

**PoVchPO6.dll là module quản lý chứng từ "Hóa đơn mua dịch vụ" (PO6)** trong hệ thống Simba Accounting của AsiaSoft.

### Chức năng chính

#### 1. Nhập liệu hóa đơn mua dịch vụ
- Quản lý thông tin nhà cung cấp (mã KH, tên, địa chỉ, MST)
- Quản lý thông tin hóa đơn VAT (số seri, số HĐ, ngày HĐ)
- Xử lý đa tiền tệ (tỷ giá, quy đổi)
- Chi tiết dịch vụ với TK nợ, giá, thuế

#### 2. Tính toán tự động
- Tính tổng tiền, thuế GTGT, thanh toán
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính thuế GTGT theo từng dòng

#### 3. Quản lý thuế
- Tab thuế riêng (`tabTain`)
- Tích hợp với `ctlTaIn` (control thuế đầu vào)
- Lấy thuế từ chi tiết chứng từ

#### 4. Hạch toán
- Tab hạch toán riêng (`tabHach_toan`)
- TK phải trả (TK có)
- TK thuế GTGT được khấu trừ

#### 5. Tìm kiếm
- Tìm kiếm theo nhiều tiêu chí (NCC, ngày, số tiền, vật tư...)
- Lọc theo bộ phận, phí, hợp đồng, SPCT

### Đặc điểm kỹ thuật

- Kế thừa từ `frmVoucher` và `frmVoucherFind`
- DataBinding với DataTable (PHTable, CTTable, TAINTable)
- Validation dữ liệu đầu vào (mã KH, TK, số tiền)
- Hỗ trợ nhiều loại tiền tệ
- Tích hợp với module POUtilities

### Mã chứng từ

**PO6** (Hóa đơn mua dịch vụ) - chứng từ mua dịch vụ/hàng hóa không qua kho trong kế toán.

---

## Kết luận

Đây là một module Windows Forms của hệ thống Simba Accounting, phục vụ cho việc nhập liệu, quản lý chứng từ mua dịch vụ - một loại chứng từ quan trọng trong module Purchase (PO).

---

*Ngày phân tích: 2026-03-29*
