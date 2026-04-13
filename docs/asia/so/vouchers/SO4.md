# SO4 - Phiếu nhập hàng bán bị trả lại

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Mã chứng từ** | SO4 |
| **Tên chứng từ** | Phiếu nhập hàng bán bị trả lại |
| **DLL** | SOVchSO4.dll |
| **Form chính** | frmSoVchSO4 |
| **Kế thừa** | frmVoucher |
| **Form tìm kiếm** | frmSoVchSO4Find |

## Mô tả

Phiếu nhập hàng bán bị trả lại là chứng từ ghi nhận việc khách hàng trả lại hàng đã mua. Chứng từ này điều chỉnh giảm doanh thu, giảm thuế GTGT đầu ra và nhập lại kho.

## Cấu trúc chứng từ

### Phần thông tin chung (Header)

| Trường | Mô tả | Loại dữ liệu |
|--------|-------|--------------|
| Ma_Kh | Mã khách hàng | Lookup (dmkh) |
| Ten_Kh | Tên khách hàng | Tự động điền |
| Dia_Chi | Địa chỉ | Text |
| Nguoi_Gd | Người giao dịch | Text |
| Ma_So_Thue | Mã số thuế | Text |
| So_Seri | Số seri | Text |
| Ngay_Ct | Ngày chứng từ | Date |
| Ngay_Lct | Ngày lập chứng từ | Date |
| Ma_Nt | Mã ngoại tệ | Lookup (dmnt) |
| Ty_Gia | Tỷ giá | Numeric |
| Tk_Pt | Tài khoản phải trả | Lookup (dmtk) |
| Tk_Thue | Tài khoản thuế | Lookup (dmtk) |
| So_Hd | Số hóa đơn gốc | Text |
| Ngay_Hd | Ngày hóa đơn gốc | Date |
| Du13 | Dư công nợ | Numeric |

### Phần chi tiết (Detail)

| Cột | Mô tả | Loại dữ liệu |
|-----|-------|--------------|
| Ma_Vt | Mã vật tư | Lookup (dmvt) |
| Ten_Vt | Tên vật tư | Tự động điền |
| Dvt | Đơn vị tính | Tự động điền |
| Ma_Kho | Mã kho nhập | Lookup (dmkho) |
| So_Luong | Số lượng trả lại | Numeric |
| Gia_Nt2 | Giá ngoại tệ 2 | Numeric |
| Tien_Nt2 | Tiền ngoại tệ 2 | Tự động |
| Ts_Gtgt | Thuế suất GTGT | Percent |
| Thue_Gtgt_Nt | Thuế GTGT ngoại tệ | Tự động |
| Gia2 | Giá 2 | Tự động |
| Tien2 | Tiền 2 | Tự động |
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

### Bút toán giảm doanh thu

| Nợ | Có | Số tiền |
|----|----|---------|
| TK Doanh thu | | T_Tien2 |
| TK Thuế GTGT | | T_Thue |
| | TK Phải trả KH | T_Tt |

### Bút toán nhập kho

| Nợ | Có | Số tiền |
|----|----|---------|
| TK Kho | | T_Tien (giá vốn) |
| | TK Giá vốn | T_Tien (giá vốn) |

## Luồng nghiệp vụ

```
┌─────────────┐     ┌─────────────┐
│   SO3       │ ──▶ │   SO4       │
│ Hóa đơn     │     │ Phiếu nhập  │
│  gốc        │     │  trả hàng   │
└─────────────┘     └─────────────┘
                            │
                            ▼
                    ┌─────────────┐
                    │   Nhập kho  │
                    │  (tăng tồn) │
                    └─────────────┘
```

## Tích hợp

- **Lookup từ SO2**: Chọn hóa đơn SO2 gốc
- **Lookup từ SO3**: Chọn hóa đơn SO3 gốc
- **Tìm kiếm hóa đơn**: frmSoVchSo4FindSO2, frmSoVchSo4FindSO3
- **Tab thuế đầu vào**: Tích hợp ctlTaIn
- **Kiểm tra số lượng**: Không cho phép trả nhiều hơn đã bán

## Validation

- Số lượng trả lại ≤ Số lượng đã bán
- Ngày trả hàng ≥ Ngày hóa đơn gốc
- Kiểm tra công nợ khách hàng

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls
- AsiaErp.SOUtilities

## Ghi chú

- Giữ nguyên giá từ hóa đơn gốc
- Điều chỉnh giảm thuế GTGT đầu ra
- Nhập lại kho với giá vốn
- Có thể trả một phần hóa đơn
- Hỗ trợ sửa thuế và sửa tiền thủ công
