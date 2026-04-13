# SOVchSO3

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Voucher
- **Chức năng**: Chứng từ bán hàng (Hóa đơn bán hàng kiêm phiếu xuất kho)
- **Mã chứng từ**: SO3

## Forms

### frmSoVchSO3.cs
- **Kế thừa**: frmVoucher
- **Namespace**: AsiaErp.UserInterface
- **Chức năng chính**: Form nhập liệu chứng từ bán hàng

#### Controls chính
| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtTen_kh | TextBox | Tên khách hàng |
| txtDia_chi_vat | TextBox | Địa chỉ VAT |
| txtMa_so_thue | TextBox | Mã số thuế |
| txtNguoi_Gd | TextBox | Người giao dịch |
| txtDien_giai | TextBox | Diễn giải |
| txtSo_Seri | TextBox | Số seri hóa đơn |
| txtNgay_lct | AsMaskedTextBox | Ngày liên quan (chứng từ) |
| txtNgay_Ct | AsMaskedTextBox | Ngày chứng từ |
| cboMa_NT | AsComboBoxNT | Mã ngoại tệ |
| txtTy_gia | AsTextNumeric | Tỷ giá |
| txtTk_pt | AsTextBox | TK phải thu (phương thức thanh toán) |
| txtTk_thue | AsTextBox | TK thuế GTGT |
| txtTk_ck_ds | AsTextBox | TK chiết khấu doanh số |
| txtMa_Httt | AsTextBox | Mã hình thức thanh toán |
| cboHttt | ComboBox | Hình thức thanh toán |
| chkGia_dd | AsCheckBox | Giá đặc biệt |
| chkCk_st | AsCheckBox | Chiết khấu sản thẩm |
| chkGia_st | AsCheckBox | Giá sản thẩm |
| cmdThanh_toan | Button | Button thanh toán |
| cmdChon_dh | Button | Chọn đơn hàng |

#### Grid Controls (Chi tiết)
| Control | Type | Mô tả |
|---------|------|-------|
| adgvDetail | AsInputDGV | Grid chi tiết vật tư |
| adgvHach_toan | AsInputDGV | Grid hạch toán kế toán |

#### Các cột trong adgvDetail
| Cột | Type | Mô tả |
|-----|------|-------|
| dgvcMa_vt | DataGridViewAsTextBoxColumn | Mã vật tư |
| dgvcTen_vt | DataGridViewTextBoxColumn | Tên vật tư |
| dgvcDvt | DataGridViewTextBoxColumn | Đơn vị tính |
| dgvcMa_kho | DataGridViewAsTextBoxColumn | Mã kho |
| dgvcTon | DataGridViewAsTextNumericColumn | Tồn kho |
| dgvcSo_luong | DataGridViewAsTextNumericColumn | Số lượng |
| dgvcGia_nt2 | DataGridViewAsTextNumericColumn | Giá bán ngoại tệ |
| dgvcTien_nt2 | DataGridViewAsTextNumericColumn | Tiền bán ngoại tệ |
| dgvcTl_ck | DataGridViewAsTextNumericColumn | Tỷ lệ chiết khấu |
| dgvcTien_ck_nt | DataGridViewAsTextNumericColumn | Tiền chiết khấu NT |
| dgvcTs_gtgt | DataGridViewAsTextBoxColumn | Thuế suất GTGT |
| dgvcThue_gtgt_nt | DataGridViewAsTextNumericColumn | Thuế GTGT NT |
| dgvcGia2 | DataGridViewAsTextNumericColumn | Giá bán |
| dgvcTien2 | DataGridViewAsTextNumericColumn | Tiền bán |
| dgvcTien_ck | DataGridViewAsTextNumericColumn | Tiền chiết khấu |
| dgvcThue_gtgt | DataGridViewAsTextNumericColumn | Thuế GTGT |
| dgvcGia_nt | DataGridViewAsTextNumericColumn | Giá vốn NT |
| dgvcTien_nt | DataGridViewAsTextNumericColumn | Tiền vốn NT |
| dgvcGia | DataGridViewAsTextNumericColumn | Giá vốn |
| dgvcTien | DataGridViewAsTextNumericColumn | Tiền vốn |
| dgvcMa_Nvkd | DataGridViewAsTextBoxColumn | Mã NVKD |
| dgvcTk_dt | DataGridViewAsTextBoxColumn | TK doanh thu |
| dgvcTk_gv | DataGridViewAsTextBoxColumn | TK giá vốn |
| dgvcTk_vt | DataGridViewAsTextBoxColumn | TK vật tư |
| dgvcTk_ck | DataGridViewAsTextBoxColumn | TK chiết khấu |

#### Tổng tiền Controls
| Control | Type | Mô tả |
|---------|------|-------|
| txtT_So_luong | AsTextNumeric | Tổng số lượng |
| txtT_Tien_nt2 | AsTextNumeric | Tổng tiền hàng NT |
| txtT_Tien2 | AsTextNumeric | Tổng tiền hàng |
| txtT_ck_nt | AsTextNumeric | Tổng chiết khấu NT |
| txtT_ck | AsTextNumeric | Tổng chiết khấu |
| txtT_thue_nt | AsTextNumeric | Tổng thuế GTGT NT |
| txtT_Thue | AsTextNumeric | Tổng thuế GTGT |
| txtT_tt_nt | AsTextNumeric | Tổng thanh toán NT |
| txtT_tt | AsTextNumeric | Tổng thanh toán |
| txtT_ck_ds_nt | AsTextNumeric | Chiết khấu DS NT |
| txtT_ck_ds | AsTextNumeric | Chiết khấu DS |
| txtTl_ck_ds | AsTextNumeric | Tỷ lệ CK DS |
| txtDu13 | AsTextNumeric | Dư TK 131 |
| txtGh_no | AsTextNumeric | Ghi nợ |

#### Methods chính
| Method | Mô tả |
|--------|-------|
| InitializeComponent | Khởi tạo UI components |
| InitOtherBeforeLoadData | Khởi tạo trước khi load data |
| InitOtherAfterLoadData | Khởi tạo sau khi load data |
| RefreshDGVInput | Refresh grid input |
| txtMa_Kh_AfterCodeValidating | Validate mã khách hàng |
| txtMa_Httt_AfterCodeValidating | Validate HTTT |
| txtTy_gia_ValueChanged | Xử lý thay đổi tỷ giá |
| adgvDetail_CellValidating | Validate cell chi tiết |
| adgvDetail_CellValueChanged | Xử lý thay đổi cell |
| adgvDetail_CellEnter | Xử lý enter cell |
| cmdThanh_toan_Click | Xử lý thanh toán |
| Thanh_toan | Logic thanh toán |
| V_Ma_Vt | Validate mã vật tư |
| V_Ma_Kho | Validate mã kho |
| V_So_Luong | Tính số lượng |
| V_Gia_Nt2 | Tính giá NT |
| V_Gia2 | Tính giá |
| V_Tien_Nt2 | Tính tiền NT |
| V_Tien2 | Tính tiền |
| V_Tl_Ck | Tính tỷ lệ CK |
| V_Tien_Ck_Nt | Tính tiền CK NT |
| V_Tien_Ck | Tính tiền CK |
| V_Ts_gtgt | Tính thuế suất |
| V_Thue_gtgt_nt | Tính thuế GTGT NT |
| V_Thue_gtgt | Tính thuế GTGT |
| Calc_GiaBan | Tính giá bán |
| Calc_GiaVon | Tính giá vốn |
| Calc_ChietKhau | Tính chiết khấu |
| Calc_Thue_gtgt | Tính thuế GTGT |
| Calc_ThanhToan | Tính thanh toán |
| Calc_TienHang | Tính tiền hàng |
| Calc_TienVon | Tính tiền vốn |
| Calc_Ck_ds | Tính CK doanh số |
| LookupDH | Lookup đơn hàng |
| ReCalcTonKhoTucThoi | Tính lại tồn kho |

### frmSoVchSO3Find.cs
- **Kế thừa**: frmVoucherFind
- **Chức năng**: Form tìm kiếm chứng từ

#### Controls
| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtMa_Httt | AsTextBox | Mã HTTT |
| txtTk_vt | AsTextBox | TK vật tư |
| txtMa_vt | AsTextBox | Mã vật tư |
| txtMa_Hd | AsTextBox | Mã hợp đồng |
| txtMa_Kho | AsTextBox | Mã kho |
| txtMa_Bp | AsTextBox | Mã bộ phận |
| txtTk_dt | AsTextBox | TK doanh thu |
| txtTk_gv | AsTextBox | TK giá vốn |
| txtMa_Nvkd | AsTextBox | Mã NVKD |
| txtTk_ck | AsTextBox | TK chiết khấu |

### frmSoVchSo3FindSO1.cs
- **Kế thừa**: frmAsiaRoot
- **Chức năng**: Form tìm kiếm đơn hàng SO1

#### Controls
| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtMa_Hd | AsTextBox | Mã hợp đồng |
| lblTen_Kh | Label | Tên KH |
| lblTen_Hd | Label | Tên HĐ |
| lblDien_giai | Label | Diễn giải |
| lblNguoi_Gd | Label | Người GD |

### frmSoVchSO3SeachSO1.cs
- **Kế thừa**: frmAsiaRoot
- **Chức năng**: Form xem danh sách đơn hàng SO1

#### Controls
| Control | Type | Mô tả |
|---------|------|-------|
| dgvPh | DataGridView | Grid phiếu |
| dgvCt | DataGridView | Grid chi tiết |
| cmdChon | Button | Button chọn |
| tsslCount | Label | Số lượng |
| tsslCountlbl | Label | Label count |

#### Methods
| Method | Mô tả |
|--------|-------|
| frmVoucherView_Load | Load form |
| dgvPh_CellValueChanged | Thay đổi cell PH |
| dgvCt_CellValueChanged | Thay đổi cell CT |
| dgvPh_CurrentCellChanged | Thay đổi current cell |
| FilterCt | Lọc chi tiết |
| SetStatusBar | Set status bar |

### frmSoVchSo3ViewCrystal.cs
- **Kế thừa**: Form
- **Chức năng**: Xem báo cáo Crystal

#### Methods
| Method | Mô tả |
|--------|-------|
| frmViewCrystal_Load | Load form |
| printButton_Clicked | Click print |

## Business Logic

### Luồng xử lý chính

#### 1. Nhập mới chứng từ
1. Nhập thông tin header (KH, ngày CT, diễn giải...)
2. Chọn ngoại tệ và tỷ giá
3. Nhập TK phải thu, TK thuế
4. Nhập chi tiết vật tư trên grid
5. Tính toán tự động: tiền hàng, CK, thuế, thành tiền
6. Lưu chứng từ

#### 2. Tính toán chi tiết
```
Tiền bán (NT) = Số lượng × Giá bán (NT)
Tiền CK (NT) = Tiền bán (NT) × Tỷ lệ CK
Tiền sau CK (NT) = Tiền bán (NT) - Tiền CK (NT)
Thuế GTGT (NT) = Tiền sau CK (NT) × Thuế suất
Thành tiền (NT) = Tiền sau CK (NT) + Thuế GTGT (NT)
```

#### 3. Quy đổi ngoại tệ
```
Tiền = Tiền (NT) × Tỷ giá
Giá = Giá (NT) × Tỷ giá
```

#### 4. Tính giá vốn
- Lấy giá vốn từ bảng