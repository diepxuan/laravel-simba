# FACalKHTS - Tính khấu hao tài sản cố định

## Mô tả

Module tính khấu hao tài sản cố định theo tháng - chức năng định kỳ trong quản lý tài sản.

## Chức năng

### 1. Tính khấu hao tài sản
- Chọn tháng cần tính khấu hao (qua cboKyBc)
- Chọn mã tài sản cụ thể (tùy chọn, để trống = tất cả)
- Thực hiện tính khấu hao cho các tài sản đủ điều kiện

### 2. Tham số tính toán
- `CompanyInformations.CompanyID` - Mã công ty
- `SystemInformations.FinancialYear` - Năm tài chính
- `cboKyBc.Text` - Tháng tính khấu hao
- `txtMa_Ts.Text` - Mã tài sản (tùy chọn)

### 3. Validation
- Kiểm tra ngày kết thúc kỳ > ngày khóa sổ (`ngay_ks`)
- Không cho tính khấu hao cho kỳ đã khóa sổ

### 4. Lưu trữ trạng thái
- Lưu tháng đã chọn vào biến public `thang1` để sử dụng lại

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFACalKHTS` | `frmCalc` | Form tính khấu hao tài sản cố định |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `thang1` | Tháng tính khấu hao |
| `ma_ts` | Mã tài sản (tùy chọn) |
| `ma_cty` | Mã công ty |
| `nam` | Năm tài chính |
| `ngay_ks` | Ngày khóa sổ |

## Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `System.Windows.Forms`
- `System.Resources`

## Xem thêm

- [FADelKHTS.md](FADelKHTS.md) - Xóa khấu hao tài sản
- [FAAdjustKHTS.md](FAAdjustKHTS.md) - Điều chỉnh khấu hao
