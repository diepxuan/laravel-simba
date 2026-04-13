# CoCalcCost - Tính giá thành

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CoCalcCost.dll |
| Assembly Title | CoCalcCost |
| Loại | Nghiệp vụ |
| Framework | .NET Framework 3.5 |

## Mô tả

Module **Tính giá thành sản phẩm** trong hệ thống ERP Asia Enterprise. Đây là module quan trọng để tính toán và quản lý giá thành sản phẩm.

## Chức năng chính

1. **Tính giá thành sản phẩm**
   - Tính toán giá thành cho các sản phẩm chi tiết (SPCT)
   - Dựa trên tài khoản dở dang (TK dở dang)
   - Theo kỳ tính toán (tháng/quý/năm)

2. **Cập nhật giá thành**
   - Nút "Cập nhật GT" để thực hiện tính toán và cập nhật giá thành
   - Gọi stored procedure để thực hiện tính toán trên server
   - Kiểm tra ngày khóa sổ trước khi thực hiện

3. **Xóa cập nhật giá thành**
   - Nút "Xóa cập nhật" để xóa kết quả tính giá thành đã thực hiện
   - Cho phép tính toán lại khi có sai sót

4. **Báo cáo 2 cấp (Master-Detail)**
   - DataGridView phần header: Danh sách sản phẩm chi tiết
   - DataGridView phần chi tiết: Chi tiết giá thành của SPCT được chọn
   - Tích hợp Crystal Report để in ấn báo cáo

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| TK | Tài khoản dở dang |
| ngay_ks | Ngày khóa sổ |
| ma_spct | Mã sản phẩm chi tiết |

## Forms

- `frmCoCalcCost`: Form tính giá thành (kế thừa frmReport2DGV)

## UI Components

- `dgvBCPh`: DataGridView báo cáo phần header (master)
- `dgvBCCt`: DataGridView báo cáo phần chi tiết
- `txtNgay1`, `txtNgay2`: Từ ngày/Đến ngày
- `cboKyBc`: Kỳ báo cáo/tính toán
- `txtTK`: Tài khoản dở dang
- `btnUpdate`: Nút "Cập nhật GT"
- `btnDelUpdate`: Nút "Xóa cập nhật"
- `crvReportViewer`: Crystal Report viewer

## Business Logic

### Methods

| Phương thức | Mô tả |
|-------------|-------|
| LoadData() | Tải dữ liệu báo cáo từ stored procedure |
| ValidData() | Kiểm tra dữ liệu hợp lệ trước khi thực hiện |
| btnUpdate_Click() | Xử lý cập nhật giá thành |
| btnDelUpdate_Click() | Xử lý xóa cập nhật giá thành |

### Stored Procedures

| SP Name | Mục đích |
|---------|----------|
| MyMenuInfo.par2 | Stored procedure cập nhật giá thành |
| MyMenuInfo.par3 | Stored procedure xóa cập nhật giá thành |

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
- CrystalDecisions.Windows.Forms
