# Phiếu xuất công cụ dụng cụ (IN5)

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | IN5 |
| Tên | Phiếu xuất công cụ dụng cụ |
| Assembly | INVchIN5.dll |
| Loại | Voucher - Xuất CCDC |
| Framework | .NET Framework 3.5 |

## Chức năng

Module quản lý phiếu xuất công cụ dụng cụ (CCDC) trong hệ thống ERP Asia Enterprise.

## Cấu trúc dữ liệu

### Thông tin chung (Master)

| Trường | Ý nghĩa |
|--------|---------|
| Số phiếu xuất | Số chứng từ |
| Ngày phiếu xuất | Ngày chứng từ |
| Mã khách hàng | Mã KH/bộ phận nhận |
| Người giao dịch | Người liên hệ |
| Địa chỉ | Địa chỉ |
| Diễn giải | Mô tả phiếu xuất |
| Ngày lập | Ngày tạo phiếu |
| Tỷ giá | Tỷ giá ngoại tệ |
| Tiền xuất | Tổng tiền xuất |

### Chi tiết (Detail)

| Cột | Ý nghĩa |
|-----|---------|
| Mã cc | Mã công cụ dụng cụ |
| Tên công cụ | Tên CCDC |
| Đvt | Đơn vị tính |
| Kho | Mã kho xuất |
| Tồn | Số lượng tồn kho |
| Số lượng | Số lượng xuất |
| Giá | Giá ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| Số kỳ PB | Số kỳ phân bổ |
| Tk pb | Tài khoản phân bổ |
| Tk cp | Tài khoản chi phí |
| Tk Cc | Tài khoản công cụ |
| Giá VND | Giá VND |
| Tiền VND | Thành tiền VND |
| Bpsd | Bộ phận sử dụng |
| SPCT | Sản phẩm chi tiết |
| Phí | Mã phí |
| Bộ phận | Mã bộ phận |
| Lô | Mã lô |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ma_vt` | Mã công cụ dụng cụ |
| `ma_kho` | Mã kho |
| `so_luong` | Số lượng |
| `so_ky` | Số kỳ phân bổ |
| `gia_nt` | Giá ngoại tệ |
| `tien_nt` | Tiền ngoại tệ |
| `gia` | Giá VND |
| `tien` | Tiền VND |
| `tk_no` | Tài khoản phân bổ (nợ) |
| `tk_cp` | Tài khoản chi phí |
| `tk_vt` | Tài khoản công cụ (có) |
| `ma_bpsd` | Mã bộ phận sử dụng |

## Tính năng đặc biệt

- **Quản lý phân bổ CCDC**: Theo dõi số kỳ phân bổ cho mỗi CCDC
- **Tự động tính chi phí**: Tự động tính chi phí phân bổ theo kỳ
- **Bộ phận sử dụng**: Quản lý bộ phận sử dụng CCDC
- **Phiếu xuất giá đích danh**: Xuất CCDC theo giá đích danh
- **Đa tiền tệ**: Hỗ trợ nhiều loại tiền tệ với tỷ giá

## Form liên quan

| Form | Mục đích |
|------|----------|
| `frmInVchIN5` | Form nhập liệu chính |
| `frmInVchIN5Find` | Form tìm kiếm |

## Dependencies

- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper
- `System.Data` - Data access
- `Microsoft.VisualBasic` - VB runtime
