# FADMTS - Danh mục tài sản cố định

## Mô tả

Module quản lý danh mục tài sản cố định - module cốt lõi trong quản lý tài sản doanh nghiệp.

## Chức năng

### 1. Quản lý danh mục tài sản
- Xem danh sách tài sản cố định
- Thêm, sửa, xóa tài sản
- Kiểm tra mã tài sản tồn tại qua `IFADMTSDAO.CheckMaTSExists()`

### 2. Thông tin chi tiết tài sản (3 tab)

#### Tab 1: Thông tin chung
- Mã TS, tên TS, đơn vị tính
- Nhà cung cấp, nước sản xuất, công suất
- Năm sản xuất, số lượng
- Ngày đưa vào SD, ngày tăng, lý do tăng
- Nhóm TS (3 cấp), bộ phận SD, sản phẩm CT, phí

#### Tab 2: Thông tin khấu hao
- Số tháng KH, tỷ lệ KH
- Tính KH, sửa KH (checkbox)
- Tài khoản tài sản, TK khấu hao, TK chi phí
- Chi tiết nguyên giá theo 4 nguồn vốn
- Giá trị đã KH, giá trị còn lại, giá trị KH 1 tháng

#### Tab 3: Phụ tùng linh kiện
- Quản lý danh sách linh kiện thuộc tài sản
- Mã linh kiện, tên, đơn vị tính
- Số lượng, giá trị, trạng thái KSD

### 3. Tính toán tự động
- Tính tổng nguyên giá từ 4 nguồn vốn
- Tính tổng giá trị đã khấu hao
- Tính tổng giá trị còn lại
- Tính tổng khấu hao tháng
- Tính giá trị khấu hao 1 tháng theo tỷ lệ
- Tính giá trị còn lại = Nguyên giá - Giá trị đã KH

### 4. Validation dữ liệu
- Kiểm tra ngày tăng, ngày bắt đầu KH, ngày ghi nhận GTCL hợp lệ
- Kiểm tra ràng buộc ngày: ngay_gt_cl >= ngay_bdkh >= ngay_tang
- Kiểm tra số tháng KH > 0 khi tính KH
- Kiểm tra TK tài sản, TK khấu hao, TK chi phí không được trống

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFADMTS` | `frmDMView` | Form danh mục tài sản cố định |
| `frmFADMTSEdit` | `frmDMEdit` | Form nhập liệu chi tiết tài sản |

## Data Access

| Class | Mục đích |
|-------|----------|
| `IFADMTSDAO` | Interface truy cập dữ liệu tài sản |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ten_ts` | Tên tài sản |
| `dvt` | Đơn vị tính |
| `ma_nhts1/2/3` | Mã nhóm tài sản 1/2/3 |
| `ma_tg_ts` | Mã lý do tăng tài sản |
| `tk_ts` | Tài khoản tài sản |
| `tk_kh` | Tài khoản khấu hao |
| `tk_cp` | Tài khoản chi phí |
| `st_kh` | Số tháng khấu hao |
| `tl_kh` | Tỷ lệ khấu hao |
| `ngay_bdkh` | Ngày bắt đầu khấu hao |
| `ngay_gt_cl` | Ngày ghi nhận giá trị còn lại |
| `ngay_dc` | Ngày đình chỉ |
| `ld_dc` | Lý do đình chỉ |
| `ng_gia_n1/2/3/4` | Nguyên giá nguồn vốn 1/2/3/4 |
| `gt_kh_n1/2/3/4` | Giá trị khấu hao nguồn vốn 1/2/3/4 |
| `gt_cl_n1/2/3/4` | Giá trị còn lại nguồn vốn 1/2/3/4 |
| `kh_th_n1/2/3/4` | Khấu hao tháng nguồn vốn 1/2/3/4 |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_phi` | Mã phí |

## GridView Linh kiện

| Cột | Ý nghĩa |
|-----|---------|
| ma_cty | Mã công ty |
| ma_ts | Mã tài sản |
| ma_lk | Mã linh kiện |
| ten_lk | Tên linh kiện |
| dvt | Đơn vị tính |
| so_luong | Số lượng |
| gia_tri | Giá trị |
| KSD | Không sử dụng |

## Dependencies

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System.Data`
- `System.Windows.Forms`

## Xem thêm

- [FADGTS.md](../vouchers/FADGTS.md) - Đánh giá lại tài sản
- [FAGiamTS.md](../vouchers/FAGiamTS.md) - Khai báo giảm tài sản
- [FAChuyenTS.md](../vouchers/FAChuyenTS.md) - Chuyển tài sản
