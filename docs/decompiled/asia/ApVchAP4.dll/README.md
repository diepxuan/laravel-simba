# Báo cáo Phân tích DLL: ApVchAP4.dll

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
| Assembly Name | ApVchAP4 |
| Assembly Title | Bù trừ công nợ phải trả |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | b3ad0909-50e4-4b12-a444-85ebf657072a |
| ComVisible | false |

---

## Cấu trúc File

```
ApVchAP4.dll/
├── ApVchAP4.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmApVchAP4.cs           # Main form class - Voucher bù trừ công nợ
│   └── frmApVchAP4Find.cs       # Search form
├── My/
│   ├── MyProject.cs             # VB.NET My project support
│   ├── MyComputer.cs            # VB.NET My computer support
│   ├── MySettings.cs            # Settings manager
│   ├── MySettingsProperty.cs    # Settings property
│   ├── MyApplication.cs         # Application support
│   └── InternalXmlHelper.cs     # XML helper
└── My.Resources/
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
| System.Xml.Linq | XML LINQ support |
| System.Core | .NET Core extensions |
| System.Data.DataSetExtensions | DataSet extensions |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmApVchAP4` | `frmVoucher` | Form nhập liệu chính cho chứng từ Bù trừ công nợ phải trả |
| `frmApVchAP4Find` | `frmVoucherFind` | Form tìm kiếm chứng từ |

---

## Controls và UI Components

### Controls chính (frmApVchAP4)

| Control | Loại | Mục đích |
|---------|------|----------|
| adgvDetail | AsInputDGV | DataGridView nhập liệu chi tiết |
| txtNgay_lct | AsMaskedTextBox | Ngày lập chứng từ |
| txtNgay_Ct | AsMaskedTextBox | Ngày chứng từ |
| txtSo_Ct | TextBox | Số chứng từ |
| txtT_Tien | AsTextNumeric | Tổng tiền VNĐ |
| txtT_tien_Nt | AsTextNumeric | Tổng tiền ngoại tệ |
| txtTy_gia | AsTextNumeric | Tỷ giá ngoại tệ |
| cboMa_NT | AsComboBoxNT | ComboBox mã ngoại tệ |
| chkNt_Ph | AsCheckBox | Checkbox "Ngoại tệ chung" |
| AsCheckBox2 | AsCheckBox | Checkbox "Chỉ kê, không hạch toán" |

### Cột DataGridView (Chi tiết chứng từ)

| Cột | Control Type | Ý nghĩa |
|-----|--------------|---------|
| dgvcTk | DataGridViewAsTextBoxColumn | Tài khoản (TK) |
| dgvcTen_tk | DataGridViewTextBoxColumn | Tên tài khoản |
| dgvcMa_kh | DataGridViewAsTextBoxColumn | Mã khách hàng |
| dgvcMa_nt | DataGridViewComboBoxColumn | Mã ngoại tệ |
| dgvcTy_gia | DataGridViewAsTextNumericColumn | Tỷ giá |
| dgvcPs_no_nt | DataGridViewAsTextNumericColumn | Phát sinh nợ ngoại tệ |
| dgvcPs_co_nt | DataGridViewAsTextNumericColumn | Phát sinh có ngoại tệ |
| dgvcPs_no | DataGridViewAsTextNumericColumn | Phát sinh nợ VNĐ |
| dgvcPs_co | DataGridViewAsTextNumericColumn | Phát sinh có VNĐ |
| dgvcDien_giai | DataGridViewTextBoxColumn | Diễn giải |
| dgvcMa_bp | DataGridViewAsTextBoxColumn | Mã bộ phận |
| dgvcMa_phi | DataGridViewAsTextBoxColumn | Mã phí |
| dgvcMa_hd | DataGridViewAsTextBoxColumn | Mã hợp đồng |
| dgvcMa_spct | DataGridViewAsTextBoxColumn | Mã SPCT |
| dgvcNh_dk | DataGridViewTextBoxColumn | Nhóm định khoản (ĐK) |

---

## Business Logic và Events

### Events chính

| Event | Handler | Mục đích |
|-------|---------|----------|
| chkNt_Ph.CheckedChanged | chkNt_Ph_CheckedChanged | Xử lý khi thay đổi trạng thái ngoại tệ chung |
| cboMa_NT.SelectedValueChanged | cboMa_NT_SelectedValueChanged | Cập nhật tỷ giá khi đổi ngoại tệ |
| txtTy_gia.Validated | txtTy_gia_Validated | Tính toán lại khi tỷ giá thay đổi |
| adgvDetail.CellValueChanged | adgvDetail_CellValueChanged | Xử lý thay đổi giá trị cell |
| adgvDetail.CellEnter | adgvDetail_CellEnter | Xử lý khi focus vào cell |

### Các phương thức tính toán

| Phương thức | Mô tả |
|-------------|-------|
| V_Ma_Nt() | Xử lý khi thay đổi mã ngoại tệ |
| V_Ty_gia() | Tính toán phát sinh theo tỷ giá |
| V_Ps_Co_Nt() | Xử lý phát sinh có ngoại tệ |
| V_Ps_No_Nt() | Xử lý phát sinh nợ ngoại tệ |
| V_Ps_Co() | Xử lý phát sinh có VNĐ |
| V_Ps_No() | Xử lý phát sinh nợ VNĐ |
| UpdateList() | Cập nhật tổng tiền |
| ValidData() | Kiểm tra dữ liệu hợp lệ |
| ChkNh_Dk() | Kiểm tra nhóm định khoản |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bù trừ công nợ phải trả" - Tên chức năng chính
- "Ngày lập", "Ngày chứng từ", "Số chứng từ"
- "Ngoại tệ chung" - Checkbox ngoại tệ
- "Chỉ kê, không hạch toán" - Checkbox chế độ kê
- "Tổng tiền" - Label tổng tiền

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ps_no` | Phát sinh nợ |
| `ps_no_nt` | Phát sinh nợ ngoại tệ |
| `ps_co` | Phát sinh có |
| `ps_co_nt` | Phát sinh có ngoại tệ |
| `t_tien` | Tổng tiền |
| `t_tien_nt` | Tổng tiền ngoại tệ |
| `tk` | Tài khoản |
| `ma_kh` | Mã khách hàng |
| `nh_dk` | Nhóm định khoản |

---

## Mục đích sử dụng

**ApVchAP4.dll là module quản lý chứng từ "Bù trừ công nợ phải trả"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu chứng từ bù trừ công nợ phải trả
- Quản lý thông tin chứng từ (số CT, ngày CT, ngày lập)
- Quản lý tài khoản kế toán (TK, tên TK)
- Quản lý khách hàng (mã KH, tên KH)
- Xử lý đa tiền tệ (tỷ giá, phát sinh ngoại tệ/VNĐ)
- Chi tiết phát sinh với các thông tin: TK, KH, bộ phận, phí, hợp đồng, SPCT

#### 2. Tính toán tự động
- Tính tổng tiền nợ/có theo ngoại tệ và VNĐ
- Chuyển đổi ngoại tệ theo tỷ giá
- Làm tròn số theo cấu hình hệ thống
- Tự động bù trừ nợ/có

#### 3. Kiểm tra và validation
- Kiểm tra tài khoản chi tiết (`chi_tiet=1` và `tk_cn=1`)
- Kiểm tra bắt buộc nhập mã KH cho TK công nợ
- Kiểm tra cân đối nợ có theo nhóm định khoản
- Kiểm tra điều chỉnh tỷ giá (`canh_bao_dieu_chinh`)

#### 4. Chế độ ngoại tệ
- Checkbox "Ngoại tệ chung" để áp dụng tỷ giá chung cho toàn bộ chứng từ
- Hỗ trợ nhập liệu ngoại tệ riêng cho từng dòng chi tiết
- Tự động ẩn/hiện cột ngoại tệ theo cấu hình

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, TK, số tiền)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với Framework và Helper của Asia ERP

### Mã chứng từ

**AP4** (Bù trừ công nợ phải trả) - một loại chứng từ thanh toán dùng để bù trừ công nợ giữa các bên trong kế toán doanh nghiệp.

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý chứng từ Bù trừ công nợ phải trả - một loại chứng từ quan trọng trong quản lý công nợ và thanh toán của doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
