# FAPostTS2GL - Phân bổ tài sản cố định

## Mô tả

Module post khấu hao tài sản cố định sang General Ledger (GL) sau khi đã tính khấu hao.

## Chức năng

### 1. Chọn kỳ post (Filter)
- Form `frmFAPostTS2GLFilter` hiển thị trước
- Chọn tháng cần post (qua cboKyBc)
- Kiểm tra ngày kết thúc kỳ > ngày khóa sổ
- Lưu tháng đã chọn vào biến public

### 2. Xem danh sách khấu hao
- Hiển thị danh sách các tài sản cần post khấu hao
- GridView hiển thị: TK chi phí, TK khấu hao, giá trị khấu hao, mã phí, mã SPCT
- Dữ liệu lấy từ `MyController.GetData()`

### 3. Post sang GL
- Button "Phân bổ" thực hiện post
- Xóa dữ liệu post cũ qua stored procedure `asFADelPostGlCt`
- Insert dữ liệu mới qua stored procedure `asFAPost2GlCt`

### 4. Chi tiết post

```csharp
// Xóa dữ liệu cũ
asFADelPostGlCt(ma_cty, par1, nam, thang)

// Insert dữ liệu mới cho mỗi dòng
asFAPost2GlCt(ma_cty, par1, ngay, tk_cp, tk_kh, khau_hao, ma_phi, ma_spct, user_name)
```

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFAPostTS2GL` | `frmDMView` | Form post khấu hao tài sản sang GL |
| `frmFAPostTS2GLFilter` | `frmDMFilter` | Form chọn kỳ post |

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_cty` | Mã công ty |
| `nam` | Năm tài chính |
| `thang` | Tháng post |
| `tk_cp` | Tài khoản chi phí |
| `tk_kh` | Tài khoản khấu hao |
| `khau_hao` | Giá trị khấu hao |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |

## Stored Procedures

| SP | Mục đích |
|----|----------|
| `asFADelPostGlCt` | Xóa dữ liệu post cũ |
| `asFAPost2GlCt` | Insert dữ liệu post mới |

## Dependencies

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System.Data`
- `System.Windows.Forms`

## Xem thêm

- [FACalKHTS.md](FACalKHTS.md) - Tính khấu hao tài sản
- [FAPostCC2GL.md](FAPostCC2GL.md) - Post phân bổ công cụ sang GL
