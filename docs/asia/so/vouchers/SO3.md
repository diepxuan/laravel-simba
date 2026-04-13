# SO3 - Hóa đơn bán hàng

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Mã chứng từ** | SO3 |
| **Tên chứng từ** | Hóa đơn bán hàng |
| **DLL** | SOVchSO3.dll / SOVchSO3_.dll |
| **Form chính** | frmSoVchSO3 |
| **Kế thừa** | frmVoucher |
| **Form tìm kiếm** | frmSoVchSO3Find |

## Mô tả

Hóa đơn bán hàng là chứng từ VAT ghi nhận doanh thu bán hàng hóa. Hóa đơn có thể được lập từ phiếu xuất kho (SO2) hoặc lập trực tiếp (kiêm phiếu xuất).

## Cấu trúc chứng từ

### Phần thông tin chung (Header)

| Trường | Mô tả | Loại dữ liệu |
|--------|-------|--------------|
| Ma_Kh | Mã khách hàng | Lookup (dmkh) |
| Ten_Kh | Tên khách hàng | Text |
| Dia_Chi_Vat | Địa chỉ xuất hóa đơn | Text |
| Nguoi_Gd | Người mua | Text |
| Ma_So_Thue | Mã số thuế KH | Text |
| So_Seri | Số seri hóa đơn | Text |
| So_Ct | Số hóa đơn | Text |
| Ngay_Ct | Ngày hóa đơn | Date |
| Ngay_Lct | Ngày lập chứng từ | Date |
| Ma_Nt | Mã ngoại tệ | Lookup (dmnt) |
| Ty_Gia | Tỷ giá | Numeric |
| Ma_Httt | Mã hình thức thanh toán | Lookup (dmhttt) |
| Tk_Pt | Tài khoản phải thu | Lookup (dmtk) |
| Tk_Thue | Tài khoản thuế GTGT | Lookup (dmtk) |
| So_Px | Số phiếu xuất kho liên quan | Text |
| Gh_No | Giới hạn công nợ | Numeric |
| Du13 | Dư hiện thời của KH | Numeric |

### Phần chi tiết (Detail)

| Cột | Mô tả | Loại dữ liệu |
|-----|-------|--------------|
| Ma_Vt | Mã vật tư | Lookup (dmvt) |
| Ten_Vt | Tên vật tư | Text |
| Dvt | Đơn vị tính | Text |
| Ma_Kho | Mã kho | Lookup (dmkho) |
| Ton | Tồn kho | Numeric |
| So_Luong | Số lượng | Numeric |
| Gia_Nt2 | Giá bán ngoại tệ | Numeric |
| Tien_Nt2 | Tiền hàng ngoại tệ | Tự động |
| Tl_Ck | Tỷ lệ chiết khấu | Percent |
| Tien_Ck_Nt | Tiền chiết khấu ngoại tệ | Tự động |
| Ts_Gtgt | Thuế suất GTGT | Percent |
| Thue_Gtgt_Nt | Thuế GTGT ngoại tệ | Tự động |
| Gia2 | Giá bán VND | Tự động |
| Tien2 | Tiền hàng VND | Tự động |
| Ma_Nvkd | Mã nhân viên KD | Lookup |
| Tk_Dt | TK doanh thu | Lookup |
| Tk_Gv | TK giá vốn | Lookup |
| Tk_Vt | TK kho | Lookup |
| Tk_Ck | TK chiết khấu | Lookup |

### Tổng cộng (Footer)

| Trường | Mô tả |
|--------|-------|
| T_So_Luong | Tổng số lượng |
| T_Tien_Nt2 | Tổng tiền hàng ngoại tệ |
| T_Tien2 | Tổng tiền hàng VND |
| T_Ck_Nt | Tổng chiết khấu ngoại tệ |
| T_Ck | Tổng chiết khấu VND |
| T_Ck_Ds_Nt | Chiết khấu doanh số ngoại tệ |
| T_Ck_Ds | Chiết khấu doanh số VND |
| T_Thue_Nt | Tổng thuế GTGT ngoại tệ |
| T_Thue | Tổng thuế GTGT VND |
| T_Tt_Nt | Tổng thanh toán ngoại tệ |
| T_Tt | Tổng thanh toán VND |

## Công thức tính toán

```
Tiền hàng = Số lượng × Giá bán
Tiền chiết khấu mặt hàng = Tiền hàng × Tỷ lệ CK / 100
Thuế GTGT = (Tiền hàng - Tiền chiết khấu) × Thuế suất / 100
Chiết khấu doanh số = Tổng tiền × Tỷ lệ CKDS / 100
Tổng thanh toán = Tiền hàng - CK - CKDS + Thuế GTGT
```

## Hạch toán kế toán

### Bút toán ghi nhận doanh thu

| Nợ | Có | Số tiền |
|----|----|---------|
| TK Phải thu KH | | T_Tt |
| | TK Doanh thu | T_Tien2 |
| | TK Thuế GTGT | T_Thue |

### Bút toán ghi nhận giá vốn

| Nợ | Có | Số tiền |
|----|----|---------|
| TK Giá vốn | | T_Tien |
| | TK Kho | T_Tien |

## Luồng nghiệp vụ

### Từ phiếu xuất kho
```
SO2 (Phiếu xuất) ──▶ SO3 (Hóa đơn)
```

### Hóa đơn kiêm phiếu xuất
```
SO3 (Hóa đơn + Xuất kho)
```

## Tích hợp

- **Lookup từ SO2**: Chọn phiếu xuất để lập hóa đơn
- **Lookup từ SO1**: Chọn đơn hàng để lập hóa đơn
- **In hóa đơn**: Tích hợp Crystal Reports
- **Kiểm tra công nợ**: Gh_No và Du13
- **Chiết khấu doanh số**: Tính theo tổng doanh thu

## Validation

- Kiểm tra giới hạn công nợ khách hàng
- Ngày hóa đơn trong năm tài chính
- Số seri và số hóa đơn không trùng

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls
- AsiaErp.SOUtilities
- CrystalDecisions.Shared

## Ghi chú

- Có thể liên kết với phiếu xuất kho (So_Px)
- Hỗ trợ in hóa đơn VAT qua Crystal Reports
- Chiết khấu doanh số được phân bổ theo từng dòng hàng
- Kiểm tra giới hạn công nợ (Gh_No) và dư hiện thời (Du13)
- Hỗ trợ hóa đơn kiêm phiếu xuất
