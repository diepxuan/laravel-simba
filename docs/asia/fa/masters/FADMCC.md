# FADMCC - Danh mục công cụ dụng cụ

## Mô tả

Module quản lý danh mục công cụ dụng cụ trong hệ thống ERP. Tương tự như tài sản cố định nhưng áp dụng cho công cụ, dụng cụ phân bổ theo kỳ.

## Chức năng

### 1. Quản lý danh mục công cụ
- Xem danh sách công cụ dụng cụ
- Thêm, sửa, xóa công cụ
- Kiểm tra mã công cụ tồn tại qua `IFADMCCDAO.CheckMaCcExists()`
- Xóa công cụ qua `IFADMCCDAO.DeleteCC()`

### 2. Thông tin chi tiết công cụ
- Mã công cụ, tên công cụ, đơn vị tính
- Số lượng, đơn giá, nguyên giá (tự động tính = SL * ĐG)
- Số kỳ phân bổ, giá trị đã phân bổ, giá trị còn lại
- Giá trị phân bổ 1 kỳ (tự động tính hoặc nhập tay)
- Tài khoản phân bổ, tài khoản chi phí
- Ngày chứng từ, ngày bắt đầu phân bổ, ngày ghi nhận GTCL
- Mã phí, mã sản phẩm chi tiết, mã bộ phận sử dụng

### 3. Tính toán tự động
- Nguyên giá = Số lượng * Đơn giá
- Giá trị còn lại = Nguyên giá - Giá trị đã phân bổ
- Phân bổ 1 kỳ = Giá trị còn lại / Số kỳ (nếu không sửa)
- Hoặc tính = Nguyên giá / Số kỳ tùy cấu hình

### 4. Validation dữ liệu
- Kiểm tra mã công cụ, tên công cụ không được trống
- Kiểm tra số lượng > 0
- Kiểm tra số kỳ phân bổ > 0
- Kiểm tra nguyên giá > 0
- Kiểm tra TK phân bổ, TK chi phí không được trống
- Kiểm tra ngày bắt đầu PB, ngày GTCL, ngày CT hợp lệ

### 5. Cấu hình tính phân bổ
- Checkbox "Sửa phân bổ" cho phép nhập tay giá trị phân bổ 1 kỳ
- Cấu hình kiểu tính qua `Environment.GetFAConfiguration().kieu_tinh_kh`

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFADMCC` | `frmDMComplexView` | Form danh mục công cụ dụng cụ |
| `frmFADMCCEdit` | `frmDMComplexEdit` | Form nhập liệu chi tiết công cụ |

## Data Access

| Class | Mục đích |
|-------|----------|
| `IFADMCCDAO` | Interface truy cập dữ liệu công cụ |
| `MsSqlFADMCCDAO` | MSSQL implementation cho công cụ |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_cc` | Mã công cụ |
| `ten_cc` | Tên công cụ |
| `dvt` | Đơn vị tính |
| `so_luong` | Số lượng |
| `don_gia` | Đơn giá |
| `ng_gia` | Nguyên giá |
| `so_ky` | Số kỳ phân bổ |
| `gt_da_kh` | Giá trị đã khấu hao (phân bổ) |
| `gt_cl` | Giá trị còn lại |
| `kh_ky` | Khấu hao 1 kỳ (phân bổ 1 kỳ) |
| `tk_cc` | Tài khoản công cụ (phân bổ) |
| `tk_cp` | Tài khoản chi phí |
| `ngay_bdkh` | Ngày bắt đầu khấu hao (phân bổ) |
| `ngay_gt_cl` | Ngày ghi nhận giá trị còn lại |
| `ngay_ct` | Ngày chứng từ |
| `so_ct` | Số chứng từ |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `sua_kh` | Sửa khấu hao (sửa phân bổ) |
| `stt_rec` | Số thứ tự record |

## Dependencies

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System.Data`
- `System.Windows.Forms`

## Xem thêm

- [FABHCC.md](../vouchers/FABHCC.md) - Báo hỏng công cụ dụng cụ
- [FAPostCC2GL.md](../vouchers/FAPostCC2GL.md) - Post phân bổ công cụ sang GL
