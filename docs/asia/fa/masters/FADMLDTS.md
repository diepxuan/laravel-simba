# FADMLDTS - Danh mục lý do tăng giảm tài sản

## Mô tả

Module quản lý danh mục loại động tài sản cố định (phân loại tăng/giảm) để sử dụng trong các chứng từ biến động tài sản.

## Chức năng

### 1. Quản lý danh mục loại động tài sản
- Xem danh sách các loại động tài sản (tăng/giảm)
- Thêm, sửa, xóa loại động tài sản
- Phân loại: Tăng (tg='T') hoặc Giảm (tg='G')

### 2. Thông tin loại động tài sản
- Mã loại động tài sản
- Tên loại động tài sản
- Loại: Tăng hoặc Giảm
- Các thông tin khác theo cấu trúc danh mục chuẩn

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFADMLDTS` | `frmDMView` | Form danh mục loại động tài sản |
| `frmFADMLDTGEdit` | - | Form nhập liệu chi tiết loại động TS |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ldtg` | Mã lý do tăng giảm |
| `ten_ldtg` | Tên lý do tăng giảm |
| `tg` | Loại: T (Tăng) hoặc G (Giảm) |

## Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`
- `System.Drawing`

## Xem thêm

- [FADGTS.md](../vouchers/FADGTS.md) - Đánh giá lại tài sản (tăng/giảm nguyên giá)
- [FAGiamTS.md](../vouchers/FAGiamTS.md) - Khai báo giảm tài sản
