# FADelKHTS - Xóa khấu hao tài sản cố định

## Mô tả

Module xóa khấu hao của một tài sản cố định cụ thể trong một kỳ nhất định.

## Chức năng

### 1. Xóa khấu hao tài sản cố định
- Chọn kỳ báo cáo (tháng) cần xóa khấu hao
- Nhập mã tài sản cụ thể cần xóa khấu hao
- Hệ thống tự động hiển thị tên tài sản (lookup)
- Kiểm tra ngày khóa sổ trước khi thực hiện

### 2. Kiểm soát an toàn
- Kiểm tra ngày khóa sổ để tránh xóa dữ liệu đã khóa
- Validation dữ liệu đầu vào
- Thông báo kết quả rõ ràng

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFADelKHTS` | `frmCalc` | Form xóa khấu hao tài sản cố định |

## UI Controls

| Control | Type | Mục đích |
|---------|------|----------|
| `cboKyBc` | AsComboBox | Chọn kỳ báo cáo (tháng) |
| `txtMa_Ts` | AsTextBox | Nhập mã tài sản |
| `lblThang` | Label | Nhãn "Tháng" |
| `lblMa_ts` | Label | Nhãn "Mã tài sản" |
| `lblTen_TS` | Label | Hiển thị tên tài sản |

## Business Logic

### Tham số thực thi (Execute)

| Thứ tự | Tham số | Mô tả |
|--------|---------|-------|
| 1 | CompanyID | Mã công ty |
| 2 | FinancialYear | Năm tài chính |
| 3 | cboKyBc.Text | Tháng báo cáo |
| 4 | txtMa_Ts.Text | Mã tài sản |
| 5 | par1 | Tham số menu |

### Validation

- Kiểm tra ngày khóa sổ (`ngay_ks`): Không cho phép xóa dữ liệu trước ngày khóa sổ
- Kiểm tra mã tài sản hợp lệ (thông qua LookupCodeName = "MA_TS")

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_cty` | Mã công ty |
| `nam` | Năm tài chính |
| `thang` | Tháng báo cáo |
| `ma_ts` | Mã tài sản |
| `ngay_ks` | Ngày khóa sổ |

## Lookup

| Code | Mô tả |
|------|-------|
| MA_TS | Mã tài sản - tự động lookup tên tài sản |

## Mã thông báo

| Mã | Ý nghĩa |
|----|---------|
| 50010 | Thông báo lỗi |
| 50015 | Thông báo thành công |
| 50136 | Lỗi ngày khóa sổ |

## Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`

## Xem thêm

- [FACalKHTS.md](FACalKHTS.md) - Tính khấu hao tài sản
- [FAAdjustKHTS.md](FAAdjustKHTS.md) - Điều chỉnh khấu hao
