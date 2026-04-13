# Phiếu lắp ráp/tháo dỡ (IN6)

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | IN6 |
| Tên | Phiếu lắp ráp/tháo dỡ |
| Assembly | INVchIN6.dll |
| Loại | Voucher - Sản xuất/Assembly |
| Framework | .NET Framework 3.5 |

## Chức năng

Module quản lý phiếu lắp ráp/tháo dỡ trong hệ thống ERP Asia Enterprise.

### Loại giao dịch

| Mã | Ý nghĩa |
|-----|---------|
| 1 | Lắp ráp (Assembly) - Xuất chi tiết, nhập thành phẩm |
| 2 | Tháo dỡ (Disassembly) - Xuất thành phẩm, nhập chi tiết |

## Cấu trúc dữ liệu

### Thông tin chung (Master)

| Trường | Ý nghĩa |
|--------|---------|
| Mã khách hàng | Mã KH |
| Người giao dịch | Người liên hệ |
| Địa chỉ | Địa chỉ |
| Diễn giải | Mô tả |
| Ngày lập | Ngày tạo phiếu |
| Tỷ giá | Tỷ giá ngoại tệ |
| Tiền xuất | Tổng tiền |
| Mã giao dịch | Phân loại lắp ráp/tháo dỡ |

### Chi tiết Master (Thành phẩm/Bộ)

| Cột | Ý nghĩa |
|-----|---------|
| Mã bộ | Mã vật tư thành phẩm/bộ |
| Tên bộ | Tên vật tư thành phẩm |
| Đvt | Đơn vị tính |
| Kho | Mã kho nhập/xuất |
| Số lượng | Số lượng thành phẩm |
| Giá | Giá ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| TK kho | Tài khoản kho |
| Mã NX | Mã nhập xuất |
| Giá VND | Giá VND |
| Tiền VND | Thành tiền VND |
| H. đồng | Hợp đồng |
| SPCT | Sản phẩm chi tiết |
| Phí | Mã phí |
| B. phận | Bộ phận |

### Chi tiết Detail (Chi tiết/Thành phần)

| Cột | Ý nghĩa |
|-----|---------|
| Mã chi tiết | Mã vật tư chi tiết |
| Tên chi tiết | Tên vật tư chi tiết |
| Đvt | Đơn vị tính |
| Kho | Mã kho |
| Số lượng | Số lượng chi tiết |
| Giá | Giá ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| TK kho | Tài khoản kho |
| Mã NX | Mã nhập xuất |
| Giá VND | Giá VND |
| Tiền VND | Thành tiền VND |
| H. đồng | Hợp đồng |
| SPCT | Sản phẩm chi tiết |
| Phí | Mã phí |
| B. phận | Bộ phận |
| Mã bộ | Liên kết mã bộ |

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
| `tk_vt` | Tài khoản kho |
| `ma_nx` | Mã nhập xuất |
| `ma_gd` | Mã giao dịch (1=Lắp ráp, 2=Tháo dỡ) |

## Tính năng đặc biệt

- **Lắp ráp (Assembly)**: Xuất chi tiết, nhập thành phẩm
- **Tháo dỡ (Disassembly)**: Xuất thành phẩm, nhập chi tiết
- **Quản lý BOM**: Tích hợp với định mức BOM, tự động lấy chi tiết
- **Tính giá trung bình**: Tính giá vốn theo phương pháp giá trung bình
- **Chỉ xem chi tiết từng bộ**: Lọc hiển thị chi tiết theo bộ
- **Đa tiền tệ**: Hỗ trợ nhiều loại tiền tệ với tỷ giá

## Kiến trúc

| Component | Mục đích |
|-----------|----------|
| `INVchIN6Controller` | Business logic controller |
| `INVchIN6DAO` | DAO interface |
| `MsSqlINVchIN6DAO` | SQL Server DAO implementation |

### Business Logic Methods

| Method | Mục đích |
|--------|----------|
| `Insert` | Thêm mới phiếu lắp ráp/tháo dỡ (PH + CT + CTD) |
| `Update` | Cập nhật phiếu lắp ráp/tháo dỡ |
| `GetBoMByMa_vt` | Lấy BOM theo mã vật tư |
| `GetPrintDataSource` | Lấy dữ liệu in ấn |
| `SearchBOM` | Tìm kiếm BOM |
| `GetDataCTD` | Đọc dữ liệu chi tiết (CTD) |
| `InsertCTD` | Thêm chi tiết CTD |
| `DeleteCTD` | Xóa chi tiết CTD |

## Form liên quan

| Form | Mục đích |
|------|----------|
| `frmInVchIN6` | Form nhập liệu chính |
| `frmInVchIN6Find` | Form tìm kiếm |

## Dependencies

- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper
- `System.Data` - Data access
- `System.Core` - LINQ
- `Microsoft.VisualBasic` - VB runtime
- `CrystalDecisions.CrystalReports.Engine` - Crystal Reports
