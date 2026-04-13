# FAChuyenTS - Chuyển tài sản

## Mô tả

Module quản lý "Chuyển tài sản" trong hệ thống ERP. Phục vụ cho việc chuyển tài sản giữa các bộ phận, sản phẩm công trình, hoặc thay đổi thông tin kế toán.

## Chức năng

### 1. Chuyển bộ phận sử dụng
- Chuyển tài sản từ bộ phận này sang bộ phận khác
- Cập nhật mã bộ phận sử dụng mới (ma_bpsd)

### 2. Chuyển sản phẩm công trình
- Gán tài sản cho sản phẩm công trình khác
- Cập nhật mã SPCT mới (ma_spct)

### 3. Chuyển mã phí
- Thay đổi mã phí theo dõi cho tài sản
- Cập nhật mã phí mới (ma_phi)

### 4. Chuyển tài khoản kế toán
- Thay đổi tài khoản tài sản (TK_TS)
- Thay đổi tài khoản khấu hao (TK_KH)
- Thay đổi tài khoản chi phí (TK_CP)

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFAChuyenTS` | `frmDMComplexView` | Form xem danh mục chuyển tài sản |
| `frmFAChuyenTSEdit` | `frmDMComplexEdit` | Form nhập liệu chuyển tài sản |

## Các loại chuyển

| Giá trị | Ý nghĩa |
|---------|---------|
| MA_BPSD | Chuyển bộ phận sử dụng |
| MA_SPCT | Chuyển sản phẩm công trình |
| MA_PHI | Chuyển mã phí |
| TK_TS | Chuyển tài khoản tài sản |
| TK_KH | Chuyển tài khoản khấu hao |
| TK_CP | Chuyển tài khoản chi phí |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ngay` | Ngày chuyển |
| `loai_dt` | Loại đối tượng chuyển |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ma_spct` | Mã sản phẩm công trình |
| `ma_phi` | Mã phí |
| `tk_ts` | Tài khoản tài sản |
| `tk_kh` | Tài khoản khấu hao |
| `tk_cp` | Tài khoản chi phí |

## Validation

- Mã tài sản: bắt buộc
- Ngày chuyển: bắt buộc
- Theo loại chuyển:
  - MA_BPSD: Mã bộ phận sử dụng bắt buộc
  - MA_SPCT: Mã SPCT bắt buộc
  - MA_PHI: Mã phí bắt buộc
  - TK_TS: Tài khoản tài sản bắt buộc
  - TK_KH: Tài khoản khấu hao bắt buộc
  - TK_CP: Tài khoản chi phí bắt buộc

## Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `System.Windows.Forms`

## Xem thêm

- [FADMTS.md](../masters/FADMTS.md) - Danh mục tài sản
- [FADMBPS