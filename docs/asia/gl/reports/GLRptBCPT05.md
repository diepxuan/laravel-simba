# GLRptBCPT05 - Báo cáo kết quả hoạt động sản xuất kinh doanh

## Mô tả

Module báo cáo hiển thị báo cáo kết quả hoạt động sản xuất kinh doanh với khả năng nhóm và phân tích đa chiều.

## Chức năng chính

### 1. Lọc dữ liệu báo cáo
- Chọn kỳ báo cáo (từ ngày đến ngày)
- Lọc theo tài khoản
- Lọc theo mã bộ phận
- Lọc theo mã phí
- Lọc theo mã sản phẩm công trình
- Chọn loại tiền tệ (VND/ngoại tệ)

### 2. Nhóm dữ liệu đa chiều
- Hỗ trợ 4 cấp nhóm (Nhóm cấp 1 đến 4)
- Các cấp nhóm có thể chọn: Tài khoản, Bộ phận, Mã phí, Sản phẩm công trình
- Các cấp sau phụ thuộc vào cấp trước (cascade selection)

### 3. Kiểu dự toán
- 4 kiểu dự toán khác nhau
- Quyết định cách tổng hợp và hiển thị dữ liệu

### 4. Tính toán và hiển thị
- Tải dữ liệu từ database theo các tham số lọc
- Hiển thị dữ liệu trên DataGridView với nhóm đa chiều
- Xuất báo cáo ra Excel
- In báo cáo

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản |
| txtMa_Bp | AsTextBox | Mã bộ phận |
| txtMa_Phi | AsTextBox | Mã phí |
| txtMa_SPCT | AsTextBox | Mã SPCT |
| cboNhom_cap1-4 | ComboBox | Các cấp nhóm báo cáo |
| cboKieu_DT | ComboBox | Kiểu dự toán |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Từ ngày, đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Lựa chọn tiền tệ |

## Combobox Options

### cboNhom_cap1
- "Theo tài khoản"
- "Theo bộ phận"
- "Theo mã phí"
- "Theo sản phẩm công trình"

### cboKieu_DT
- "1. Theo tài khoản"
- "2. Theo tài khoản và bộ phận"
- "3. Theo tài khoản, bộ phận và mã phí"
- "4. Theo tài khoản và mã phí"

## Tham số truy vấn (Stored Procedure)

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | Year | Năm |
| 3 | tk | Tài khoản |
| 4 | ma_phi | Mã phí |
| 5 | ma_bp | Mã bộ phận |
| 6 | ma_spct | Mã sản phẩm công trình |
| 7 | Ngay1 | Ngày bắt đầu |
| 8 | Ngay2 | Ngày kết thúc |
| 9 | Nhom_cap1 | Nhóm cấp 1 |
| 10 | Nhom_cap2 | Nhóm cấp 2 |
| 11 | Nhom_cap3 | Nhóm cấp 3 |
| 12 | Nhom_cap4 | Nhóm cấp 4 |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Form báo cáo chuẩn
- Sử dụng `AsTextBox` với AutoLookup cho các mã
- Cascade selection cho các cấp nhóm
- Hỗ trợ đa tiền tệ (VND/ngoại tệ)
- Tích hợp Crystal Report cho in ấn
- Sử dụng `DictionaryEntry` cho datasource của combobox

## Xử lý cascade selection

```csharp
// Khi chọn Nhóm cấp 1 -> Cập nhật Nhóm cấp 2
// Khi chọn Nhóm cấp 2 -> Cập nhật Nhóm cấp 3
// Khi chọn Nhóm cấp 3 -> Cập nhật Nhóm cấp 4
```

## Dependencies

- AsiaErp.Framework
- System.Data
- System.Drawing
- System.Windows.Forms
- Microsoft.VisualBasic
