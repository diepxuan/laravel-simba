# FAAdjustKHTS - Điều chỉnh khấu hao tài sản

## Mô tả

Module điều chỉnh khấu hao tài sản cố định - cho phép nhập tay giá trị KH khi cần điều chỉnh sau khi đã tính khấu hao.

## Chức năng

### 1. Chọn kỳ và tài sản (Filter)
- Form `frmFAAdjustKHTSFilter` hiển thị trước
- Chọn tháng cần điều chỉnh (qua cboKyBc)
- Chọn mã tài sản (tùy chọn, qua txtMa_Ts)
- Kiểm tra ngày kết thúc kỳ > ngày khóa sổ

### 2. Xem danh sách
- Hiển thị danh sách tài sản theo kỳ đã chọn
- GridView hiển thị thông tin tài sản và giá trị khấu hao
- Dữ liệu lấy từ `MyController.GetData()`

### 3. Điều chỉnh khấu hao (Edit)
- Button "Điều chỉnh" mở form edit
- Hiển thị thông tin: mã TS, tên TS, mã TS tăng giảm nguyên giá
- Hiển thị: Nguyên giá, giá trị đã KH, giá trị còn lại (readonly)
- Cho phép điều chỉnh giá trị khấu hao trong kỳ

### 4. Chi tiết điều chỉnh
- Checkbox "Sửa khấu hao" cho phép nhập thủ công
- Nhập giá trị KH cho từng nguồn vốn (4 nguồn)
- Tự động tính tổng KH tháng
- Tên nguồn vốn lấy từ `Commons.FAGetTenNguonVon()`

### 5. Validation
- Kiểm tra kỳ > ngày khóa sổ
- Tổng KH tháng = Tổng các nguồn vốn

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFAAdjustKHTS` | `frmDMComplexView` | Form điều chỉnh khấu hao tài sản |
| `frmFAAdjustKHTSFilter` | `frmDMFilter` | Form chọn kỳ và tài sản |
| `frmFAAdjustKHTSEdit` | `frmDMComplexEdit` | Form nhập điều chỉnh khấu hao |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ten_ts` | Tên tài sản |
| `ma_ts_tgng` | Mã tài sản tăng giảm nguyên giá |
| `t_ng_gia` | Tổng nguyên giá |
| `t_gt_da_kh` | Tổng giá trị đã khấu hao |
| `t_gt_cl` | Tổng giá trị còn lại |
| `kh_n1/2/3/4` | Khấu hao nguồn vốn 1/2/3/4 |
| `t_kh_th` | Tổng khấu hao tháng |
| `sua_kh` | Cho phép sửa khấu hao |
| `nv1/2/3/4` | Nguồn vốn 1/2/3/4 |

## Dependencies

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System.Data`
- `System.Windows.Forms`

## Xem thêm

- [FADMTS.md](../masters/FADMTS.md) - Danh mục tài sản
- [FADMNV.md](../masters/FADMNV.md) - Danh mục nguồn vốn
