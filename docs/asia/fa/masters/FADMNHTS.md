# FADMNHTS - Danh mục phân nhóm tài sản cố định

## Mô tả

Module quản lý danh mục phân nhóm tài sản cố định (3 cấp) để phân loại và quản lý tài sản theo nhóm.

## Chức năng

### 1. Quản lý danh mục nhóm tài sản
- Xem danh sách nhóm tài sản (3 cấp: loai_nh=1,2,3)
- Thêm, sửa, xóa nhóm tài sản
- Phân cấp nhóm: Nhóm 1, Nhóm 2, Nhóm 3

### 2. Thông tin nhóm tài sản
- Mã nhóm tài sản (ma_nhts)
- Tên nhóm tài sản
- Loại nhóm (loai_nh): 1, 2, hoặc 3
- Các thông tin khác theo cấu trúc danh mục phức tạp

### 3. Sử dụng trong danh mục tài sản
- Trong FADMTS: txtMa_nhts1, txtMa_nhts2, txtMa_nhts3
- Lookup với điều kiện: loai_nh=1, loai_nh=2, loai_nh=3

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFADMNHTS` | `frmDMComplexView` | Form danh mục nhóm tài sản |
| `frmFADMNHTSEdit` | - | Form nhập liệu chi tiết nhóm TS |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nhts` | Mã nhóm tài sản |
| `ten_nhts` | Tên nhóm tài sản |
| `loai_nh` | Loại nhóm: 1, 2, hoặc 3 |

## Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`
- `System.Drawing`

## Xem thêm

- [FADMTS.md](FADMTS.md) - Danh mục tài sản cố định
