# SO5 - Hóa đơn bán dịch vụ

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Mã chứng từ** | SO5 |
| **Tên chứng từ** | Hóa đơn bán dịch vụ |
| **DLL** | SOVchSO5.dll |
| **Form chính** | frmSoVchSO5 |
| **Kế thừa** | frmVoucher |
| **Form tìm kiếm** | frmSoVchSO5Find |
| **Form in ấn** | frmSoVchSo5Print |

## Mô tả

Hóa đơn bán dịch vụ là chứng từ ghi nhận doanh thu từ việc cung cấp dịch vụ cho khách hàng. Khác với hóa đơn bán hàng (SO3), hóa đơn dịch vụ không qua kho và không có giá vốn.

## Cấu trúc chứng từ

### Phần thông tin chung (Header)

| Trường | Mô tả | Loại dữ liệu |
|--------|-------|--------------|
| Ma_Kh | Mã khách hàng | Lookup (dmkh) |
| Ten_Kh | Tên khách hàng | Tự động điền |
| Dia_Chi | Địa chỉ | Text |
| Nguoi_Gd | Người giao dịch | Text |
| So_Seri | Số seri hóa đơn | Text |
| Ngay_Ct | Ngày chứng từ | Date |
| Ngay_Lct | Ngày lập chứng từ | Date |
| Ma_Nt | Mã ngoại tệ | Lookup (dmnt) |
| Ty_Gia | Tỷ giá | Numeric |
| Ma_Httt | Mã hình thức thanh toán | Lookup (dmhttt) |
| Tk_Pt | Tài khoản phải thu | Lookup (dmtk) |
| Tk_Thue | Tài khoản thuế | Lookup (dmtk) |
| Dien_Giai | Diễn giải | Text |

### Phần chi tiết (Detail)

| Cột | Mô tả | Loại dữ liệu |
|-----|-------|--------------|
| Ma_Vt | Mã dịch vụ | Lookup (dmvt) |
| Ten_Vt | Tên dịch vụ | Tự động điền |
| Dvt | Đơn vị tính | Tự động điền |
| So_Luong | Số lượng | Numeric |
| Gia_Nt2 | Giá ngoại tệ 2 | Numeric |
| Tien_Nt2 | Tiền ngoại tệ 2 | Tự động |
| Tl_Ck | Tỷ lệ chiết khấu | Percent |
| Tien_Ck_Nt | Tiền chiết khấu ngoại tệ | Tự động |
| Ts_Gtgt | Thuế suất GTGT | Percent |
| Thue_Gtgt_Nt | Thuế GTGT ngoại tệ | Tự động |
| Gia2 | Giá 2 | Tự động |
| Tien2 | Tiền 2 | Tự động |
| Tien_Ck | Tiền chiết khấu | Tự động |
| Thue_Gtgt | Thuế GTGT | Tự động |
| Ma_Nvkd | Mã nhân viên KD | Lookup |

### Tab Hạch toán

| Cột | Mô tả |
|-----|-------|
| TK | Tài khoản |
| Ps_No | Phát sinh nợ |
| Ps_Co | Phát sinh có |
| Ma_Kh | Mã khách hàng |
| Ma_Vv | Mã vụ việc |
| Ma_Bp | Mã bộ phận |
| Ma_Phi | Mã phí |
| Ma_Hd | Mã hợp đồng |
| Ma_Ku | Mã khế ước |
| Ma_Spct | Mã sản phẩm chi tiết |

## Hạch toán kế toán

### Bút toán doanh thu dịch vụ

| Nợ | Có | Số tiền |
|----|----|---------|
| TK Phải thu KH | | T_Tt |
| | TK Doanh thu dịch vụ | T_Tien2 |
| | TK Thuế GTGT | T_Thue |

## Luồng nghiệp vụ

```
┌─────────────┐     ┌─────────────┐
│   SO5       │ ──▶ │     CA      │
│ Hóa đơn     │     │ Thu tiền    │
│ dịch vụ     │     │             │
└─────────────┘     └─────────────┘
```

## Điểm khác biệt với SO3

| Đặc điểm | SO3 (Hàng hóa) | SO5 (Dịch vụ) |
|-----------|----------------------|---------------------|
| Quản lý kho | Có | Không |
| Tồn kho | Có | Không |
| TK vật tư | Có | Không |
| TK giá vốn | Có | Không |
| Chiết khấu | Có | Có (sửa được) |
| Sửa thuế | Không | Có |
| Sửa chiết khấu | Không | Có |

## Tích hợp

- **Lookup dịch vụ**: Từ danh mục vật tư (loại dịch vụ)
- **In báo giá**: frmSoVchSo5Print
- **Công nợ**: Cập nhật công nợ khách hàng
- **Thuế**: Tính thuế GTGT đầu ra

## Validation

- Số lượng ≥ 0
- Giá ≥ 0
- Tỷ lệ chiết khấu 0-100%

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls
- AsiaErp.SOUtilities

## Ghi chú

- Không quản lý kho vì là dịch vụ
- Hỗ trợ sửa chiết khấu và thuế thủ công
- Có thể dùng để lập báo giá dịch vụ
- Không có giá vốn, chỉ có doanh thu
