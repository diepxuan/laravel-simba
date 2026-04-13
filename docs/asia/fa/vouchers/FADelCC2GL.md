# FADelCC2GL - Xóa bút toán phân bổ công cụ dụng cụ

## Mô tả

Module xóa bút toán phân bổ công cụ dụng cụ sang General Ledger (GL).

## Chức năng

### 1. Xóa bút toán phân bổ công cụ dụng cụ
- Chọn kỳ báo cáo (tháng) cần xóa
- Hệ thống tự động lấy năm tài chính hiện tại
- Kiểm tra ngày khóa sổ trước khi thực hiện

### 2. Kiểm soát an toàn
- Kiểm tra ngày khóa sổ để tránh xóa dữ liệu đã khóa
- Validation dữ liệu đầu vào
- Thông báo kết quả rõ ràng

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFADelCC2GL` | `frmCalc` | Form xóa bút toán phân bổ công cụ dụng sang GL |

## UI Controls

| Control | Type | Mục đích |
|---------|------|----------|
| `cboKyBc` | AsComboBox | Chọn kỳ báo cáo (tháng) |
| `txtNam` | AsTextNumeric | Năm tài chính (readonly) |
| `lblThang` | Label | Nhãn "Tháng" |
| `lblNam` | Label | Nhãn "Năm" |

## Business Logic

### Tham số thực thi (Execute)

| Thứ tự | Tham số | Mô tả |
|--------|---------|-------|
| 1 | CompanyID | Mã công ty |
| 2 | par1 | Tham số menu |
| 3 | txtNam.Value | Năm tài chính |
| 4 | cboKyBc.Text | Tháng báo cáo |
| 5 | 0 | Tham số mặc định |

### Validation

- Kiểm tra ngày khóa sổ (`ngay_ks`): Không cho phép xóa dữ liệu trước ngày khóa sổ
- Sử dụng `KyBaoCao` object để lấy thông tin kỳ báo cáo

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_cty` | Mã công ty |
| `nam` | Năm tài chính |
| `thang` | Tháng báo cáo |
| `ngay_ks` | Ngày khóa sổ |

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

- [FAPostCC2GL.md](FAPostCC2GL.md) - Post phân bổ công cụ sang GL
- [FADelTS2GL.md](FADelTS2GL.md) - Xóa bút toán phân bổ tài sản
