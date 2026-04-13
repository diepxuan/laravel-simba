# FADGTS - Đánh giá lại tài sản cố định

## Mô tả

Module quản lý "Đánh giá lại tài sản cố định" - hỗ trợ tăng/giảm nguyên giá tài sản, quản lý linh kiện và điều chỉnh thông tin khấu hao.

## Chức năng

### 1. Tăng/Giảm nguyên giá tài sản
- Hỗ trợ tăng hoặc giảm nguyên giá tài sản cố định
- Chọn kiểu đánh giá: Tăng TS hoặc Giảm TS (RadioButton)
- Mã đánh giá (ma_ts_tgng) để theo dõi

### 2. Quản lý thông tin đánh giá
- Số chứng từ, ngày chứng từ
- Ngày tăng giảm, lý do tăng giảm
- Ngày bắt đầu KH mới, ngày GTCL mới
- Số tháng KH, tỷ lệ KH tháng
- Số lượng tăng giảm

### 3. Chi tiết nguồn vốn
- Quản lý nguyên giá theo 4 nguồn vốn
- Giá trị đã khấu hao (gt_kh)
- Giá trị còn lại (gt_cl)
- Khấu hao tháng (kh_th)
- Tổng cộng các nguồn vốn

### 4. Quản lý phụ tùng linh kiện
- Thêm/xóa linh kiện gắn với tài sản
- Quản lý mã linh kiện, tên, đơn vị tính
- Số lượng và giá trị linh kiện
- Tăng/giảm linh kiện

### 5. Thông tin tài sản
- Xem thông tin hiện tại của tài sản
- Ngày tăng, ngày GTCL hiện tại
- Số tháng KH, tỷ lệ KH hiện tại
- Tài khoản TS, KH, CP

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFADGTS` | `frmDMComplexView` | Form xem danh mục đánh giá tài sản |
| `frmFADGTSEdit` | `frmDMComplexEdit` | Form nhập liệu đánh giá tài sản |

## Tab Control

| Tab | Mục đích |
|-----|----------|
| tabTTDG | Thông tin đánh giá |
| tabPT_LK | Đánh giá phụ tùng, linh kiện |
| tabTTKH | Thông tin tài sản |

## Chi tiết nguồn vốn

| Nguồn | Trường dữ liệu |
|-------|---------------|
| Nguồn vốn 1 | ng_gia_n1, gt_kh_n1, gt_cl_n1, kh_th_n1 |
| Nguồn vốn 2 | ng_gia_n2, gt_kh_n2, gt_cl_n2, kh_th_n2 |
| Nguồn vốn 3 | ng_gia_n3, gt_kh_n3, gt_cl_n3, kh_th_n3 |
| Nguồn vốn 4 | ng_gia_n4, gt_kh_n4, gt_cl_n4, kh_th_n4 |
| Tổng cộng | t_ng_gia, t_gt_kh, t_gt_cl, t_kh_th |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ma_ts_tgng` | Mã tài sản tăng giảm nguyên giá |
| `so_ct` | Số chứng từ |
| `ngay_ct` | Ngày chứng từ |
| `ngay_tg` | Ngày tăng giảm |
| `ma_ldtg` | Mã lý do tăng giảm |
| `ngay_bdkh` | Ngày bắt đầu khấu hao |
| `ngay_gt_cl` | Ngày giá trị còn lại |
| `st_kh` | Số tháng khấu hao |
| `tl_kh` | Tỷ lệ khấu hao |
| `so_luong` | Số lượng tăng giảm |
| `sua_kh` | Sửa khấu hao |
| `ng_gia_n1-4` | Nguyên giá nguồn vốn 1-4 |
| `gt_kh_n1-4` | Giá trị đã KH nguồn vốn 1-4 |
| `gt_cl_n1-4` | Giá trị còn lại nguồn vốn 1-4 |
| `kh_th_n1-4` | Khấu hao tháng nguồn vốn 1-4 |

## Validation

- Mã tài sản: bắt buộc
- Kiểm tra không có đánh giá sau ngày chứng từ
- Ngày chứng từ, ngày tăng giảm: bắt buộc
- Lý do tăng giảm: bắt buộc
- Số tháng KH > 0
- Nguyên giá phải > 0 (khi tính KH)
- Kiểm tra mã linh kiện không trùng với mã tài sản
- Ngày GTCL >= Ngày BDKH >= Ngày tăng

## Dependencies

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System.Data`
- `System.Windows.Forms`

## Xem thêm

- [FADMTS.md](../masters/FADMTS.md) - Danh mục tài sản
- [FADMNV.md](../masters/FADMNV.md) - Danh mục nguồn vốn
