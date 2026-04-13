# CoRptCTPBCPTT - Báo cáo chi tiết phân bổ chi phí tập trung

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CoRptCTPBCPTT.dll |
| Assembly Title | Báo cáo tồn kho cuối kỳ |
| Loại | Báo cáo |
| Framework | .NET Framework 3.5 |

## Mô tả

Module báo cáo **Chi tiết phân bổ chi phí tập trung** trong hệ thống ERP Asia Enterprise. Đây là báo cáo chi tiết các bút toán phân bổ chi phí tập trung.

## Chức năng chính

1. **Báo cáo chi tiết phân bổ**
   - Hiển thị chi tiết các bút toán phân bổ chi phí tập trung
   - Theo dõi giá trị phân bổ theo từng kỳ
   - Phân tích theo bộ phận, chi phí, tài khoản

2. **Lọc đa chiều**
   - Lọc theo bộ phận sử dụng
   - Lọc theo mã chi phí
   - Lọc theo TK phân bổ và TK chi phí
   - Lọc theo mã phí và mã SPCT

3. **Xuất dữ liệu**
   - Xem trực tiếp trên form
   - In ấn báo cáo
   - Xuất ra Excel

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| Ma_bpsd | Mã bộ phận sử dụng |
| Ma_cp | Mã chi phí |
| Tk_pb | TK phân bổ |
| Tk_cp | TK chi phí |
| Ma_phi | Mã phí |
| Ma_spct | Mã SPCT |

## Forms

- `frmCoRptCTPBCPTT`: Form báo cáo (kế thừa frmReport)

## UI Components

### Filter Controls

| Control | Mô tả |
|---------|-------|
| txtMa_bpsd | Mã bộ phận sử dụng |
| txtMa_cp | Mã chi phí |
| txtTk_pb | TK phân bổ |
| txtTk_cp | TK chi phí |
| txtMa_phi | Mã phí |
| txtMa_spct | Mã SPCT |

### Report Controls

| Control | Mô tả |
|---------|-------|
| cboKyBc | Kỳ báo cáo |
| txtNgay1 | Từ ngày |
| txtNgay2 | Đến ngày |
| cmdOk | Xem báo cáo |
| cmdExcel | Xuất Excel |

## Business Logic

### Methods

| Method | Mô tả |
|--------|-------|
| LoadData() | Lấy dữ liệu báo cáo từ database |
| GetFilterTitle() | Tạo chuỗi mô tả điều kiện lọc |

### Lookup Codes

| Control | LookupCode | Điều kiện |
|---------|------------|-----------|
| txtMa_bpsd | MA_BPSD | - |
| txtMa_cp | MA_CPTT | MODULEID = 'CO' |
| txtTk_pb | TK | - |
| txtTk_cp | TK | - |
| txtMa_phi | MA_PHI | - |
| txtMa_spct | MA_SPCT | - |

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
