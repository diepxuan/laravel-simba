# FABHCC - Báo hỏng công cụ dụng cụ

## Mô tả

Module quản lý "Báo hỏng công cụ dụng cụ" trong hệ thống ERP. Phục vụ cho việc nhập liệu và quản lý báo hỏng công cụ dụng cụ.

## Chức năng

### 1. Nhập liệu báo hỏng công cụ
- Quản lý thông tin công cụ (mã CC, tên CC, đơn vị tính)
- Nhập số lượng hỏng, đơn giá hỏng, tiền hỏng
- Quản lý ngày báo hỏng, số phiếu xuất, ngày xuất
- Thông tin bộ phận sử dụng (ma_bpsd)
- Tài khoản chi phí và tài khoản phân bổ

### 2. Kiểm tra validation
- Kiểm tra số lượng hỏng không vượt quá số lượng còn lại
- Validate mã công cụ tồn tại
- Kiểm tra tài khoản chi phí

### 3. Tính toán tự động
- Tính tiền hỏng = số lượng hỏng × đơn giá hỏng
- Lấy thông tin giá gốc, đơn vị tính từ danh mục công cụ

### 4. Tra cứu công cụ
- Hỗ trợ phím F5 tra cứu mã công cụ dụng cụ
- Auto-lookup mã công cụ với điều kiện tg=1 (đang sử dụng)

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFABHCC` | `frmDMView` | Form xem danh mục báo hỏng công cụ |
| `frmFABHCCEdit` | `frmDMEdit` | Form nhập liệu báo hỏng công cụ |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_cc` | Mã công cụ |
| `ten_cc` | Tên công cụ |
| `sl_hong` | Số lượng hỏng |
| `tien_hong` | Tiền hỏng |
| `don_gia_hong` | Đơn giá hỏng |
| `ngay_bh` | Ngày báo hỏng |
| `ngay_xuat` | Ngày xuất |
| `so_px` | Số phiếu xuất |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `tk_cp` | Tài khoản chi phí |
| `tk_cc` | Tài khoản công cụ |
| `stt_rec` | Số thứ tự record |
| `stt_rec_cc` | Số thứ tự record công cụ |

## Dependencies

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System.Data`
- `System.Windows.Forms`

## Xem thêm

- [FADMCC.md](../masters/FADMCC.md) - Danh mục công cụ
- [FADMBPSD.md](../masters/FADMBPSD.md) - Danh mục bộ phận sử dụng
