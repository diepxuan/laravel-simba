# SO2 - Phiếu xuất kho

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Mã chứng từ** | SO2 |
| **Tên chứng từ** | Phiếu xuất kho |
| **DLL** | SOVchSO3.dll (chung với SO3) |
| **Form chính** | frmSoVchSO3 |
| **Kế thừa** | frmVoucher |

## Mô tả

Phiếu xuất kho là chứng từ ghi nhận việc xuất kho hàng hóa để giao cho khách hàng. Phiếu xuất kho có thể được lập từ đơn hàng bán (SO1) hoặc lập trực tiếp.

## Cấu trúc chứng từ

### Phần thông tin chung (Header)

| Trường | Mô tả | Loại dữ liệu |
|--------|-------|--------------|
| Ma_Kh | Mã khách hàng | Lookup (dmkh) |
| Ten_Kh | Tên khách hàng | Tự động điền |
| Dia_Chi | Địa chỉ giao hàng | Text |
| Ma_Nvkd | Mã nhân viên kinh doanh | Lookup (dmnvkd) |
| Ma_Kho | Mã kho xuất | Lookup (dmkho) |
| So_Px | Số phiếu xuất | Text |
| Ngay_Px | Ngày xuất kho | Date |
| Dien_Giai | Diễn giải | Text |
| So_Dh | Số đơn hàng tham chiếu | Text |

### Phần chi tiết (Detail)

| Cột | Mô tả | Loại dữ liệu |
|-----|-------|--------------|
| Ma_Vt | Mã vật tư | Lookup (dmvt) |
| Ten_Vt | Tên vật tư | Tự động điền |
| Dvt | Đơn vị tính | Tự động điền |
| Ma_Kho | Mã kho | Lookup (dmkho) |
| Ton | Tồn kho hiện tại | Tự động |
| So_Luong | Số lượng xuất | Numeric |
| Gia_Nt2 | Giá xuất ngoại tệ | Numeric |
| Tien_Nt2 | Tiền hàng ngoại tệ | Tự động tính |

### Tổng cộng (Footer)

| Trường | Mô tả |
|--------|-------|
| T_So_Luong | Tổng số lượng xuất |
| T_Tien_Nt2 | Tổng tiền hàng ngoại tệ |
| T_Tien2 | Tổng tiền hàng VND |

## Hạch toán kế toán

### Bút toán xuất kho

| Nợ | Có | Số tiền |
|----|----|---------|
| TK Giá vốn hàng bán | | T_Tien (giá vốn) |
| | TK Kho hàng hóa | T_Tien (giá vốn) |

## Luồng nghiệp vụ

### Từ đơn hàng
```
SO1 (Đơn hàng) ──▶ SO2 (Phiếu xuất) ──▶ SO3 (Hóa đơn)
```

### Xuất kho trực tiếp
```
SO2 (Phiếu xuất) ──▶ SO3 (Hóa đơn)
```

## Tích hợp

- **Lookup từ SO1**: Chọn đơn hàng để xuất kho
- **Cập nhật tồn kho**: Giảm tồn kho theo số lượng xuất
- **Tính giá vốn**: Tự động tính theo phương pháp định giá (FIFO, LIFO, BQ)
- **Tạo hóa đơn**: Chuyển thành SO3

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls
- AsiaErp.SOUtilities

## Ghi chú

- Phiếu xuất kho ghi nhận giá vốn, không phải giá bán
- Có thể xuất từ nhiều kho khác nhau
- Kiểm tra tồn kho trước khi cho phép xuất
- Có thể xuất một phần đơn hàng
