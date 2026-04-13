# CoRptKHCPTT - Báo cáo khai báo chi phí tập trung

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CoRptKHCPTT.dll |
| Assembly Title | Báo cáo tồn kho cuối kỳ |
| Loại | Báo cáo |
| Framework | .NET Framework 3.5 |

## Mô tả

Module báo cáo **Khai báo chi phí tập trung** trong hệ thống ERP Asia Enterprise. Đây là báo cáo danh sách các chi phí tập trung đã khai báo.

## Chức năng chính

1. **Báo cáo khai báo chi phí**
   - Hiển thị danh sách các chi phí tập trung đã khai báo
   - Theo dõi thông tin chi tiết của từng chi phí
   - Báo cáo theo bộ phận sử dụng

2. **Lọc dữ liệu**
   - Lọc theo bộ phận sử dụng
   - Lọc theo kỳ báo cáo

3. **Xuất dữ liệu**
   - Xem trực tiếp trên form
   - In ấn báo cáo
   - Xuất ra Excel

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| Ma_bpsd | Mã bộ phận sử dụng |

## Forms

- `frmCoRptKHCPTT`: Form báo cáo (kế thừa frmReport)

## UI Components

### Filter Controls

| Control | Mô tả |
|---------|-------|
| txtMa_bpsd | Mã bộ phận sử dụng |
| lblTen_bpsd | Tên bộ phận sử dụng |

### Report Controls

| Control | Mô tả |
|---------|-------|
| cboKyBc | Kỳ báo cáo |
| txtNgay1 | Từ ngày |
| txtNgay2 | Đến ngày |
| cmdOk | Xem báo cáo |
| cmdExcel | Xuất Excel |
| optVND | Tùy chọn tiền VND |
| optNt | Tùy chọn tiền ngoại tệ |

## Business Logic

### Methods

| Method | Mô tả |
|--------|-------|
| LoadData() | Lấy dữ liệu báo cáo từ database |
| GetFilterTitle() | Tạo chuỗi mô tả điều kiện lọc |

### Lookup Codes

| Control | LookupCode | Mô tả |
|---------|------------|-------|
| txtMa_bpsd | MA_BPSD | Mã bộ phận sử dụng |

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
