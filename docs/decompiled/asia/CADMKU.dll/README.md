# CADMKU.dll - Danh mục khế ước

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CADMKU.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCADMKU, frmCADMKUEdit |
| **Kế thừa** | frmDMView, frmDMEdit |
| **Chức năng** | Quản lý danh mục khế ước vay |

## 2. Forms chi tiết

### frmCADMKU (View Form)

**Controls:**
- Kế thừa từ frmDMView (Danh mục View)
- Các nút: Add, Edit, Del, ChgCode, Search, Print, Close

**Chức năng:**
- Hiển thị danh sách khế ước vay
- Tìm kiếm, lọc danh mục
- In danh sách

### frmCADMKUEdit (Edit Form)

**Controls:**
| Control | Type | DataField | Mô tả |
|---------|------|-----------|-------|
| txtMa_KU | TextBox | Ma_Ku | Mã khế ước (khóa chính) |
| txtTen_KU | TextBox | Ten_Ku | Tên khế ước |
| txtSo_KU | TextBox | So_Ku | Số khế ước |
| txtNgay_ky | AsMaskedTextBox | Ngay_Ky | Ngày ký |
| txtNgay_vay | AsMaskedTextBox | Ngay_vay | Ngày vay |
| txtNgay_Dh | AsMaskedTextBox | Ngay_Dh | Ngày đáo hạn |
| txtthoi_han | AsTextNumeric | Thoi_han | Thời gian vay |
| cboTinh_theo | ComboBox | Tinh_theo | Tính theo: 1-Tháng, 2-Năm |
| txtLai_Suat | AsTextNumeric | Lai_Suat | Lãi suất |
| cboPhuong_phap_tl | ComboBox | Phuong_phap | Phương pháp tính lãi |
| cboKy_Tt_goc | ComboBox | Ky_tt_goc | Kỳ thanh toán gốc |
| cboKy_Tt_lai | ComboBox | Ky_Tt_Lai | Kỳ thanh toán lãi |
| cboMa_NT | AsComboBoxNT | Ma_Nt | Mã ngoại tệ |
| txtTien_Nt | AsTextNumeric | Tien_Nt | Tiền khế ước NT |
| txtTien | AsTextNumeric | Tien | Tiền khế ước |
| txtTk_Vay | AsTextBox | Tk_Vay | TK vay |
| lblTen_Tk_Vay | Label | Ten_Tk_Vay | Tên TK vay |
| txtTk_Cp | AsTextBox | Tk_Cp | TK chi phí |
| lblTen_Tk_cp | Label | Ten_Tk_Cp | Tên TK chi phí |
| txtTk_Cp_Pt | AsTextBox | Tk_Cp_Pt | TK chi phí phải trả |
| lblTen_Tk_cp_pt | Label | Ten_Tk_Cp_Pt | Tên TK chi phí PT |
| txtMa_Hd | AsTextBox | Ma_Hd | Mã hợp đồng |
| lblTen_Hd | Label | Ten_Hd | Tên hợp đồng |
| txtGhi_chu | TextBox | Ghi_Chu | Ghi chú |
| txtLs_Qh | AsTextNumeric | Ls_Qh | Lãi suất quá hạn (ẩn) |
| chkKsd | AsCheckBox | Ksd | Không sử dụng |

**Events:**
- `frmCADMKUEdit_Load`: Set ngày mặc định khi thêm mới
- `cboTinh_theo_SelectedIndexChanged`: Cập nhật nhãn lãi suất (tháng/năm), tính ngày đáo hạn
- `txtNgay_ky_Validated`: Validate ngày ký
- `txtNgay_vay_Validated`: Validate ngày vay, tính ngày đáo hạn
- `txtthoi_han_Validating`: Validate thời hạn > 0, tính ngày đáo hạn
- `DateRange()`: Tính ngày đáo hạn dựa trên ngày vay + thời hạn
- `InitBeforeGetData()`: Khởi tạo datasource cho các combobox
- `DisableFields()`: Khóa mã KU khi sửa
- `ValidData()`: Validate bắt buộc (Mã KU, Tên KU, Số KU, Ngày vay)
- `DataBinding()`: Bind dữ liệu vào controls

**Business Logic:**
- **Phương pháp tính lãi:**
  1. Trả gốc và lãi theo dư nợ giảm dần
  2. Trả góp đều hàng tháng theo lãi suất kép
  3. Trả góp đều theo lãi suất đơn
  4. Trả góp đều, lãi tính trên dư nợ giảm dần hàng tháng
- **Kỳ thanh toán:** Hàng tháng / Hàng quý / Hàng năm / 1 lần cuối kỳ
- **Tính ngày đáo hạn:** Ngày vay + Thời hạn (tháng/năm)
- Validate: Ngày thanh toán >= Ngày ký
- Validate: Các TK phải là TK chi tiết

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Lấy danh sách khế ước |
| (Theo cấu hình Controller) | Insert/Update khế ước |

## 4. Mapping PHP

Không áp dụng (đây là form danh mục, không phải voucher).

---

**Lưu ý:** 
- Form sử dụng bảng: `DMKU` (Danh mục khế ước)
- Kế thừa từ frmDMView/frmDMEdit - framework quản lý danh mục
- Có liên kết với bảng hợp đồng (DMHD)
