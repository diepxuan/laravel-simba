# Phiếu nhập kho (IN1)

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | IN1 |
| Tên | Phiếu nhập kho |
| Assembly | INVchIN1.dll |
| Loại | Voucher - Nhập kho |
| Framework | .NET Framework 3.5 |

## Chức năng

Module quản lý phiếu nhập kho trong hệ thống ERP Asia Enterprise.

### Loại phiếu nhập

| Mã | Ý nghĩa |
|-----|---------|
| 1 | Phiếu nhập thành phẩm |
| 2 | Phiếu nhập khác |

## Cấu trúc dữ liệu

### Thông tin chung (Master)

| Trường | Ý nghĩa |
|--------|---------|
| Số phiếu nhập | Số chứng từ |
| Ngày phiếu nhập | Ngày chứng từ |
| Mã khách hàng | Mã KH giao hàng |
| Người giao dịch | Người liên hệ |
| Địa chỉ | Địa chỉ KH |
| Diễn giải | Mô tả phiếu nhập |
| Ngày lập | Ngày tạo phiếu |
| Tỷ giá | Tỷ giá ngoại tệ |
| Tiền nhập | Tổng tiền nhập |
| Loại phiếu nhập | Phân loại phiếu nhập |

### Chi tiết (Detail)

| Cột | Ý nghĩa |
|-----|---------|
| Mã hàng | Mã vật tư |
| Tên hàng | Tên vật tư |
| Đvt | Đơn vị tính |
| Kho | Mã kho nhập |
| Tồn | Số lượng tồn kho |
| Số lượng | Số lượng nhập |
| Giá | Giá nhập ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| Tk nợ | Tài khoản nợ |
| Tk có | Tài khoản có |
| Giá VND | Giá nhập VND |
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
| `tk_co` | Tài khoản có |
| `ma_gd` | Mã giao dịch/loại phiếu |

## Tính năng đặc biệt

- **Phiếu nhập giá trung bình**: Tính giá xuất kho theo phương pháp giá trung bình
- **Tự động cập nhật giá**: Tự động cập nhật giá vốn
- **Đa tiền tệ**: Hỗ trợ nhiều loại tiền tệ với tỷ giá
- **Tích hợp kế toán**: Tự động tạo bút toán kế toán (TK nợ/có)

## Form liên quan

| Form | Mục đích |
|------|----------|
| `frmInVchIN1` | Form nhập liệu chính |
| `frmInVchIN1Find` | Form tìm kiếm |

## Dependencies

- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper
- `System.Data` - Data access
- `Microsoft.VisualBasic` - VB runtime
