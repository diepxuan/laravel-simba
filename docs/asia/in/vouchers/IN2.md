# Phiếu xuất kho (IN2)

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | IN2 |
| Tên | Phiếu xuất kho |
| Assembly | INVchIN2.dll |
| Loại | Voucher - Xuất kho |
| Framework | .NET Framework 3.5 |

## Chức năng

Module quản lý phiếu xuất kho trong hệ thống ERP Asia Enterprise.

## Cấu trúc dữ liệu

### Thông tin chung (Master)

| Trường | Ý nghĩa |
|--------|---------|
| Số phiếu xuất | Số chứng từ |
| Ngày phiếu xuất | Ngày chứng từ |
| Mã khách hàng | Mã KH nhận hàng |
| Người giao dịch | Người liên hệ |
| Địa chỉ | Địa chỉ KH |
| Diễn giải | Mô tả phiếu xuất |
| Ngày lập | Ngày tạo phiếu |
| Tỷ giá | Tỷ giá ngoại tệ |
| Tiền xuất | Tổng tiền xuất |
| Loại phiếu xuất | Phân loại phiếu xuất |

### Chi tiết (Detail)

| Cột | Ý nghĩa |
|-----|---------|
| Mã hàng | Mã vật tư |
| Tên hàng | Tên vật tư |
| Đvt | Đơn vị tính |
| Kho | Mã kho xuất |
| Tồn | Số lượng tồn kho |
| Số lượng | Số lượng xuất |
| Giá | Giá xuất ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| Tk nợ | Tài khoản nợ |
| Tk có | Tài khoản có |
| Giá VND | Giá xuất VND |
| Tiền VND | Thành tiền VND |
| SPCT | Sản phẩm chi tiết |
| Hợp đồng | Mã hợp đồng |
| Phí | Mã phí |
| Bộ phận | Mã bộ phận |
| Lô | Mã lô |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ma_vt` | Mã vật tư |
| `ma_kho` | Mã kho |
| `so_luong` | Số lượng |
| `gia_nt` | Giá ngoại tệ |
| `tien_nt` | Tiền ngoại tệ |
| `gia` | Giá VND |
| `tien` | Tiền VND |
| `tk_no` | Tài khoản nợ |
| `tk_vt` | Tài khoản vật tư (có) |
| `ma_gd` | Mã giao dịch/loại phiếu |

## Tính năng đặc biệt

- **Phiếu xuất giá đích danh**: Xuất kho theo giá đích danh (FIFO, LIFO)
- **Kiểm tra tồn kho**: Kiểm tra tồn kho trước khi xuất
- **Đa tiền tệ**: Hỗ trợ nhiều loại tiền tệ với tỷ giá
- **Tích hợp kế toán**: Tự động tạo bút toán kế toán (TK nợ/có)

## Form liên quan

| Form | Mục đích |
|------|----------|
| `frmInVchIN2` | Form nhập liệu chính |
| `frmInVchIN2Find` | Form tìm kiếm |

## Dependencies

- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper
- `System.Data` - Data access
- `Microsoft.VisualBasic` - VB runtime
