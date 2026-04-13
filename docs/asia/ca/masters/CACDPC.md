# Phân tích DLL: CACDPC.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CACDPC.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCACDPC, frmCACDPCEdit |
| **Kế thừa** | frmOBView, frmOBEdit |
| **Chức năng** | Quản lý số dư đầu kỳ phiếu chi phân cấp |

## 2. Forms chi tiết

### frmCACDPC (View Form)

**Controls:**
- Kế thừa từ frmOBView
- Điều chỉnh vị trí các nút: Add, Edit, Del

**Events:**

| Event | Mô tả |
|-------|-------|
| GetData | Lấy dữ liệu số dư PC |

**Business Logic:**
- Parameters: CompanyID, ma_ct (par1)
- Default values: ma_nt = ma_nt0, ty_gia = 1
- Calculated fields: so_du = tien_pc - tien_da_tt

### frmCACDPCEdit (Edit Form)

**Controls:**

| Control | Type | DataField | Mô tả |
|---------|------|-----------|-------|
| txtNgay_ct | AsMaskedTextBox | ngay_ct | Ngày phiếu chi |
| txtSo_ct | TextBox | so_ct | Số phiếu chi |
| txtNgay_ct_tt | AsMaskedTextBox | ngay_ct_tt | Ngày thanh toán |
| txtSo_ct_tt | TextBox | so_ct_tt | Số chứng từ TT |
| txtMa_kh | AsTextBox | ma_kh | Mã khách hàng |
| lblTen_KH | Label | ten_kh | Tên khách hàng |
| txtTk_tu | AsTextBox | tk_tu | TK tạm ứng |
| lblTen_tk | Label | ten_tk | Tên TK |
| cboNt | AsComboBoxNT | ma_nt | Mã ngoại tệ |
| txtTy_Gia | AsTextNumeric | ty_gia | Tỷ giá |
| txtTien_pc_nt | AsTextNumeric | tien_pc_nt | Tiền PC NT |
| txtTien_pc | AsTextNumeric | tien_pc | Tiền PC |
| txtDa_tt_nt | AsTextNumeric | tien_da_tt_nt | Đã TT NT |
| txtDa_tt | AsTextNumeric | tien_da_tt | Đã TT |
| txtSo_du_nt | AsTextNumeric | so_du_nt | Số dư NT |
| txtSo_du | AsTextNumeric | so_du | Số dư |
| txtDien_giai | TextBox | dien_giai | Diễn giải |
| chk_TT | CheckBox | tat_toan | Tất toán |

**Events:**

| Event | Mô tả |
|-------|-------|
| cboNt_SelectedValueChanged | Cập nhật tỷ giá, ẩn/hiện trường VND |
| txtTien_PC_nt_Validated | Tính tiền PC VND = PC NT × Tỷ giá |
| txt_da_tt_nt_Validated | Tính tiền đã TT VND |
| txtTyGia_Validated | Cập nhật lại các giá trị VND khi tỷ giá thay đổi |
| TinhSoDu_Nt/TinhSoDu | Tính số dư = Tiền PC - Đã TT |
| txtSo_du_nt_TextChanged | Auto check tất toán nếu số dư <= 0 |
| ValidData | Kiểm tra ngày > ngày khóa sổ, validate điều chỉnh tỷ giá |
| CanhBaoDieuChinh | Cảnh báo nếu chênh lệch tỷ giá vượt ngưỡng |

**Business Logic:**

- Nếu VND: Ẩn các trường NT, chỉ nhập VND
- Nếu ngoại tệ: Nhập NT, tự động tính VND theo tỷ giá
- Tính số dư tự động: Số dư = Tiền PC - Đã TT
- Tự động check "Tất toán" khi số dư <= 0
- Validate ngày chứng từ > ngày khóa sổ

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CACDPC_GET | Lấy danh sách số dư PC |
| SP_CACDPC_INSERT | Insert số dư PC |
| SP_CACDPC_UPDATE | Update số dư PC |
| SP_CACDPC_DELETE | Delete số dư PC |

## 4. Tables

| Table | Mô tả |
|-------|-------|
| CADPC | Công nợ đầu kỳ phiếu chi |

---

**Lưu ý:** 
- Form sử dụng bảng: CADPC (Công nợ đầu kỳ phiếu chi)
- Có liên kết với chứng từ TT (thanh toán)
- Không áp dụng mapping PHP (đây là form số dư đầu kỳ, không phải voucher)
