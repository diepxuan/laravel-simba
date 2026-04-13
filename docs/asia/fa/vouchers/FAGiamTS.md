# FAGiamTS - Khai báo giảm tài sản cố định

## Mô tả

Module quản lý "Khai báo giảm tài sản cố định" - phục vụ cho việc khai báo giảm tài sản (thanh lý, nhượng bán, điều chuyển...).

## Chức năng

### 1. Khai báo giảm tài sản
- Chọn tài sản cần giảm từ danh mục
- Nhập số chứng từ/biên bản giảm
- Nhập ngày chứng từ/biên bản
- Nhập ngày giảm tài sản
- Chọn lý do giảm (ma_giam_ts)

### 2. Thông tin tài sản
- Hiển thị tên tài sản (read-only)
- Hiển thị nguyên giá (read-only)
- Lấy thông tin từ danh mục tài sản:
  - Ngày tăng gốc
  - Ngày bắt đầu KH gốc
  - Số tháng KH gốc
  - Số lượng

### 3. Validation
- Kiểm tra mã tài sản tồn tại
- Ngày giảm phải >= ngày tăng tài sản
- Kiểm tra không giảm tài sản trùng ngày (ChkGiamTs)
- Validate các trường bắt buộc

### 4. Lookup
- MA_TS: Lookup tài sản
- MA_LDTG: Lookup lý do tăng giảm (điều kiện: tg='G' - giảm)

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFAGiamTS` | `frmDMView` | Form xem danh mục giảm tài sản |
| `frmFAGiamTSEdit` | `frmDMEdit` | Form nhập liệu giảm tài sản |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ten_ts` | Tên tài sản |
| `t_ng_gia` | Tổng nguyên giá |
| `so_ct_giam` | Số chứng từ giảm |
| `ngay_ct_giam` | Ngày chứng từ giảm |
| `ngay_giam` | Ngày giảm tài sản |
| `ma_giam_ts` | Mã lý do giảm tài sản |
| `ten_ld_giam` | Tên lý do giảm |
| `ngay_tang` | Ngày tăng tài sản (gốc) |
| `ngay_bdkh` | Ngày bắt đầu khấu hao (gốc) |
| `st_kh` | Số tháng khấu hao (gốc) |
| `so_luong` | Số lượng tài sản |

## Business Rules

- Ngày giảm phải sau ngày tăng tài sản
- Không cho phép giảm tài sản cùng ngày (tránh trùng lặp)
- Khi giảm tài sản, hệ thống sẽ:
  - Cập nhật trạng thái tài sản
  - Tính toán khấu hao đến ngày giảm
  - Tạo bút toán kế toán nếu cần

## Dependencies

- `AsiaErp.Framework`
- `AsiaERP.DataAccess`
- `System.Data`
- `System.Windows.Forms`

## Xem thêm

- [FADMTS.md](../masters/FADMTS.md) - Danh mục tài sản
- [FADMLDTS.md](../masters/FADMLDTS.md) - Danh mục lý do tăng giảm
