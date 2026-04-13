# SO1 - Đơn hàng bán

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Mã chứng từ** | SO1 |
| **Tên chứng từ** | Đơn hàng bán |
| **DLL** | SOVchSO1.dll |
| **Form chính** | frmSoVchSO1 |
| **Kế thừa** | frmVoucher |
| **Form tìm kiếm** | frmSoVchSO1Find |

## Mô tả

Đơn hàng bán là chứng từ nguồn trong module Sales Order, dùng để ghi nhận đơn đặt hàng từ khách hàng. Đơn hàng bán là cơ sở để lập phiếu xuất kho và hóa đơn bán hàng.

## Cấu trúc chứng từ

### Phần thông tin chung (Header)

| Trường | Mô tả | Loại dữ liệu |
|--------|-------|--------------|
| Ma_Kh | Mã khách hàng | Lookup (dmkh) |
| Ten_Kh | Tên khách hàng | Tự động điền |
| Dia_Chi | Địa chỉ giao hàng | Text |
| Nguoi_Gd | Người giao dịch | Text |
| Ma_Nvkd | Mã nhân viên kinh doanh | Lookup (dmnvkd) |
| Ma_Httt | Mã hình thức thanh toán | Lookup (dmhttt) |
| Ma_Tt | Mã điều khoản thanh toán | Lookup (dmtt) |
| Ngay_Hh | Ngày hết hạn giao hàng | Date |
| Dien_Giai | Diễn giải | Text |

### Phần chi tiết (Detail)

| Cột | Mô tả | Loại dữ liệu |
|-----|-------|--------------|
| Ma_Vt | Mã vật tư | Lookup (dmvt) |
| Ten_Vt | Tên vật tư | Tự động điền |
| Dvt | Đơn vị tính | Tự động điền |
| Ma_Kho | Mã kho | Lookup (dmkho) |
| Ton | Tồn kho | Tự động |
| So_Luong | Số lượng | Numeric |
| Gia_Nt2 | Giá bán ngoại tệ | Numeric |
| Tien_Nt2 | Tiền hàng ngoại tệ | Tự động tính |
| Tl_Ck | Tỷ lệ chiết khấu | Percent |
| Tien_Ck_Nt | Tiền chiết khấu | Tự động tính |
| Thue_Gtgt_Nt | Thuế GTGT | Tự động tính |
| Ma_Nvkd | NVKD phụ trách | Lookup |

### Tổng cộng (Footer)

| Trường | Mô tả |
|--------|-------|
| T_Tien_Nt2 | Tổng tiền hàng ngoại tệ |
| T_Tien_Ck_Nt | Tổng chiết khấu ngoại tệ |
| T_Thue_Gtgt_Nt | Tổng thuế GTGT ngoại tệ |
| T_Tt_Nt | Tổng thanh toán ngoại tệ |

## Trạng thái đơn hàng

| Mã | Trạng thái | Mô tả |
|----|------------|-------|
| 0 | Nháp | Đơn hàng mới tạo |
| 1 | Chờ duyệt | Đơn hàng chờ phê duyệt |
| 2 | Đã duyệt | Đơn hàng đã được duyệt |
| 3 | Đang giao hàng | Đang thực hiện giao hàng |
| 4 | Hoàn thành | Đơn hàng đã hoàn tất |
| 5 | Hủy | Đơn hàng bị hủy |

## Công thức tính toán

```
Tiền hàng = Số lượng × Giá bán
Tiền chiết khấu = Tiền hàng × Tỷ lệ CK / 100
Thuế GTGT = (Tiền hàng - Tiền chiết khấu) × Thuế suất / 100
Tổng thanh toán = Tiền hàng - Tiền chiết khấu + Thuế GTGT
```

## Luồng nghiệp vụ

```
┌─────────────┐     ┌─────────────┐     ┌─────────────┐
│   SO1       │ ──▶ │   SO2       │ ──▶ │   SO3       │
│ Đơn hàng    │     │ Phiếu xuất  │     │ Hóa đơn     │
│   bán       │     │    kho      │     │  bán hàng   │
└─────────────┘     └─────────────┘     └─────────────┘
       │                    │                    │
       │                    │                    │
       ▼                    ▼                    ▼
   Tồn kho            Giá vốn           Doanh thu
   (dự kiến)          (thực xuất)       (ghi nhận)
```

## Tích hợp

- **Lookup khách hàng**: Từ danh mục khách hàng (dmkh)
- **Lookup vật tư**: Từ danh mục vật tư (dmvt)
- **Lấy giá**: Từ danh mục giá bán (SODMGIABAN)
- **Kiểm tra tồn kho**: Real-time từ module tồn kho
- **Tạo phiếu xuất**: Chuyển thành SO2
- **Tạo hóa đơn**: Chuyển thành SO3

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls
- AsiaErp.SOUtilities

## Ghi chú

- Đơn hàng bán là chứng từ nguồn cho toàn bộ quy trình bán hàng
- Hỗ trợ đa tiền tệ với tỷ giá tự động
- Kiểm tra tồn kho tức thời khi nhập liệu
- Có thể tạo từ báo giá (nếu có module tích hợp)
