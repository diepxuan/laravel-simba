# FAThoiKHTS - Khai báo tạm ngưng khấu hao tài sản

## Mô tả

Module quản lý khai báo tạm ngưng khấu hao tài sản cố định - dùng khi có tài sản tạm thời không sử dụng, chờ thanh lý, hoặc các trường hợp đặc biệt khác cần dừng trích khấu hao.

## Chức năng

### 1. Khai báo tạm ngưng khấu hao
- Nhập mã tài sản cố định cần tạm ngưng khấu hao
- Tự động lookup tên tài sản từ danh mục
- Nhập ngày dừng khấu hao (bắt buộc)
- Nhập ngày khấu hao lại (tùy chọn)
- Nhập diễn giải lý do tạm ngưng

### 2. Validation dữ liệu
- Kiểm tra mã tài sản không được rỗng
- Kiểm tra ngày dừng khấu hao phải có giá trị hợp lệ
- Kiểm tra ngày khấu hao lại >= ngày dừng khấu hao
- Kiểm tra trùng khai báo (cùng mã TS + ngày dừng KH)

### 3. Xóa khai báo
- Xác nhận trước khi xóa
- Gọi stored procedure `asFaDelDungKH` để xóa
- Cập nhật DataTable sau khi xóa thành công

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFAThoiKHTS` | `frmDMComplexView` | Form danh sách khai báo tạm ngưng khấu hao |
| `frmFAThoiKHTSEdit` | `frmDMComplexEdit` | Form chỉnh sửa khai báo tạm ngưng khấu hao |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản cố định |
| `ten_ts` | Tên tài sản |
| `ngay_dung_kh` | Ngày dừng khấu hao |
| `ngay_kh_lai` | Ngày khấu hao lại |
| `dien_giai` | Diễn giải, ghi chú |

## Stored Procedures

| SP Name | Mục đích |
|---------|----------|
| `asFAChkThoiKHTS` | Kiểm tra trùng khai báo tạm ngưng khấu hao |
| `asFaDelDungKH` | Xóa khai báo tạm ngưng khấu hao |

### Tham số Stored Procedures

**asFAChkThoiKHTS:**
- `@pMa_cty` - Mã công ty
- `@pMa_ts` - Mã tài sản
- `@pNgay_dung_kh` - Ngày dừng khấu hao
- Returns: Số lượng bản ghi trùng (int)

**asFaDelDungKH:**
- `@pMa_cty` - Mã công ty
- `@pMa_ts` - Mã tài sản
- `@pNgay_dung_kh` - Ngày dừng khấu hao
- `@pRet` - Output parameter, kết quả xóa (int)

## Business Rules

1. **Ngày dừng khấu hao**: Bắt buộc, không được để trống
2. **Ngày khấu hao lại**: Tùy chọn, nếu nhập phải >= ngày dừng khấu hao
3. **Trùng khai báo**: Không cho phép trùng mã TS + ngày dừng KH
4. **Lookup tài sản**: Tự động điền tên TS khi nhập mã TS

## Dependencies

- `AsiaErp.Framework`
- `AsiaERP.DataAccess`
- `System.Data`
- `System.Data.SqlClient`
- `System.Windows.Forms`

## Xem thêm

- [FADMTS.md](../masters/FADMTS.md) - Danh mục tài sản
- [FACalKHTS.md](FACalKHTS.md) - Tính khấu hao tài sản
