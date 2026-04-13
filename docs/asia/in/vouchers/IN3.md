# Phiếu chuyển kho (IN3)

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | IN3 |
| Tên | Phiếu chuyển kho |
| Assembly | INVchIN3.dll |
| Loại | Voucher - Chuyển kho |
| Framework | .NET Framework 3.5 |

## Chức năng

Module quản lý phiếu chuyển kho nội bộ trong hệ thống ERP Asia Enterprise.

### Đặc điểm
- Một phiếu xuất kho tạo ra một phiếu nhập kho tương ứng
- Giá trị hàng chuyển kho không thay đổi (giá vốn)
- Kiểm tra tồn kho ở kho xuất trước khi chuyển

## Cấu trúc dữ liệu

### Thông tin chung (Master)

| Trường | Ý nghĩa |
|--------|---------|
| Số phiếu xuất | Số chứng từ xuất |
| Ngày phiếu xuất | Ngày chứng từ |
| Số phiếu nhập | Số chứng từ nhập (liên kết) |
| Mã khách hàng | Mã KH |
| Người giao dịch | Người liên hệ |
| Địa chỉ | Địa chỉ KH |
| Diễn giải | Mô tả phiếu chuyển |
| Ngày lập | Ngày tạo phiếu |
| Tỷ giá | Tỷ giá ngoại tệ |
| Tiền xuất | Tổng tiền chuyển |

### Chi tiết (Detail)

| Cột | Ý nghĩa |
|-----|---------|
| Mã hàng | Mã vật tư |
| Tên hàng | Tên vật tư |
| Đvt | Đơn vị tính |
| Kho xuất | Mã kho xuất hàng |
| Kho nhập | Mã kho nhập hàng |
| Số lượng | Số lượng chuyển |
| Giá | Giá ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| Tk nợ | Tài khoản nợ |
| Tk có | Tài khoản có |
| Giá VND | Giá VND |
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
| `ma_khox` | Mã kho xuất |
| `ma_khon` | Mã kho nhập |
| `so_luong` | Số lượng |
| `gia_nt` | Giá ngoại tệ |
| `tien_nt` | Tiền ngoại tệ |
| `gia` | Giá VND |
| `tien` | Tiền VND |
| `tk_no` | Tài khoản nợ |
| `tk_vt` | Tài khoản vật tư (có) |
| `so_pn` | Số phiếu nhập (liên kết) |

## Tính năng đặc biệt

- **Chuyển kho nội bộ**: Chuyển hàng giữa các kho trong cùng đơn vị
- **Tự động tạo phiếu nhập**: Tự động sinh phiếu nhập liên kết
- **Phiếu xuất giá đích danh**: Chuyển kho theo giá đích danh
- **Đa tiền tệ**: Hỗ trợ nhiều loại tiền tệ với tỷ giá

## Form liên quan

| Form | Mục đích |
|------|----------|
| `frmInVchIN3` | Form nhập liệu chính |
| `frmInVchIN3Find` | Form tìm kiếm |

## Dependencies

- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper
- `System.Data` - Data access
- `Microsoft.VisualBasic` - VB runtime
