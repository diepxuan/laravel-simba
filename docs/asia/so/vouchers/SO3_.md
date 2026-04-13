# SO3_ - Phiếu xuất kho (mở rộng)

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Mã chứng từ** | SO3_ |
| **Tên chứng từ** | Phiếu xuất kho (mở rộng) |
| **DLL** | SOVchSO3_.dll |
| **Form chính** | frmSoVchSO3 |
| **Kế thừa** | frmVoucher |

## Mô tả

Phiếu xuất kho mở rộng (SO3_) là phiên bản nâng cao của phiếu xuất kho, hỗ trợ thêm tính năng quét mã vạch (barcode) để nhập liệu nhanh. Đây là phiên bản đặc biệt của SO3 với các tính năng bổ sung cho việc xuất kho.

## Điểm khác biệt với SO3

| Tính năng | SO3 | SO3_ |
|-----------|-----|------|
| Quét mã vạch | Không | Có |
| Giao diện | Cơ bản | Mở rộng |
| Tích hợp barcode | Không | Có |

## Cấu trúc chứng từ

Tương tự SO3 nhưng bổ sung:

### Controls bổ sung

| Control | Mô tả |
|---------|-------|
| Barcode scanner | Quét mã vạch sản phẩm |
| Quick input | Nhập nhanh bằng mã vạch |
| Batch processing | Xử lý hàng loạt |

## Tích hợp barcode

### Quy trình quét mã vạch

1. Quét mã vạch sản phẩm
2. Tự động tìm mã vật tư
3. Điền thông tin sản phẩm
4. Nhập số lượng
5. Thêm vào danh sách

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls
- AsiaErp.SOUtilities

## Ghi chú

- Phiên bản này được sử dụng cho các kho có hệ thống barcode
- Tăng tốc độ nhập liệu đáng kể
- Giảm sai sót do nhập liệu thủ công
