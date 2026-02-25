# Nhóm Transfer (asChuyen*)

Nhóm stored procedures liên quan đến chuyển số dư, tồn kho sang năm tài chính tiếp theo.

## Tổng quan

- **Prefix**: `asChuyen*` (các procedure có tên bắt đầu bằng "asChuyen").
- **Số lượng procedures (ước tính)**: 2 (đã chuyển đổi toàn bộ).
- **Mục đích**: Chuyển dữ liệu cuối kỳ (số dư tài khoản, tồn kho) sang năm sau để tiếp tục hạch toán.
- **Các procedure trong nhóm**:

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| `asGLChuyenSdTk` | `AsGLChuyenSdTk` | `@pMa_cty`, `@pNgay_cnt`, `@pRet` (output) | Chuyển số dư khách hàng và tài khoản sang năm sau. |
| `asINChuyenTonKho` | `AsINChuyenTonKho` | `@pma_cty`, `@pngay_cnt`, `@pma_kho` (optional), `@pRet` (output) | Chuyển tồn kho sang năm sau. |

## Chi tiết từng procedure

### asGLChuyenSdTk

**Mục đích**: Chuyển số dư khách hàng và tài khoản sang năm sau.

**Tham số**:

| Tên | Kiểu dữ liệu | Bắt buộc | Giá trị mặc định | Ý nghĩa |
|-----|--------------|----------|------------------|---------|
| `@pMa_cty` | `NVARCHAR(3)` | Có | Không | Mã công ty. |
| `@pNgay_cnt` | `SMALLDATETIME` | Có | Không | Ngày cuối năm trước (ngày chốt sổ). |
| `@pRet` | `INT` (output) | Có | Không | Kết quả trả về: 0 thành công, khác 0 lỗi. |

**Mô tả**:
- Procedure kiểm tra ngày kế sách (`ngay_ks` trong `sisetup`). Nếu ngày đầu năm sau nhỏ hơn hoặc bằng ngày kế sách thì trả về lỗi 50012.
- Xóa dữ liệu số dư năm tiếp theo trong các bảng `arcdkh` và `glcdtk`.
- Tổng hợp số dư từ bảng `arcdkh` (số dư chi tiết khách hàng) và `glct` (phát sinh) cho các tài khoản công nợ (`Tk_cn = 1`).
- Số dư âm được chuyển thành số dư bên có.
- Chèn số dư mới vào `arcdkh` và `glcdtk` cho năm tiếp theo.
- Gọi hàm `afDuCuoiTk` để cập nhật số dư tài khoản tổng hợp.

**Ví dụ gọi**:

```php
use Diepxuan\LaravelSimba\StoredProcedures\AsGLChuyenSdTk;

$result = AsGLChuyenSdTk::call([
    'pMa_cty' => '001',
    'pNgay_cnt' => '2024-12-31 23:59:59',
]);

$ret = $result['pRet'] ?? null;
if ($ret === 0) {
    // Thành công
} else {
    // Xử lý lỗi
}
```

### asINChuyenTonKho

**Mục đích**: Chuyển tồn kho sang năm sau.

**Tham số**:

| Tên | Kiểu dữ liệu | Bắt buộc | Giá trị mặc định | Ý nghĩa |
|-----|--------------|----------|------------------|---------|
| `@pma_cty` | `NVARCHAR(3)` | Có | Không | Mã công ty. |
| `@pngay_cnt` | `SMALLDATETIME` | Có | Không | Ngày cuối năm trước. |
| `@pma_kho` | `NVARCHAR(8)` | Không | `''` | Mã kho (nếu rỗng sẽ chuyển tất cả kho). |
| `@pRet` | `INT` (output) | Có | Không | Kết quả trả về: 0 thành công, khác 0 lỗi. |

**Mô tả**:
- Kiểm tra ngày kế sách tương tự như `asGLChuyenSdTk`.
- Xóa dữ liệu tồn kho năm tiếp theo trong bảng `incdvt` với điều kiện mã kho khớp (`LIKE @pma_kho + '%'`).
- Gọi hàm `afGetTonCuoiVtAll` để lấy tồn kho cuối kỳ của tất cả vật tư, kho, vị trí, lô.
- Chèn dữ liệu tồn kho vào `incdvt` cho năm tiếp theo.

**Ví dụ gọi**:

```php
use Diepxuan\LaravelSimba\StoredProcedures\AsINChuyenTonKho;

$result = AsINChuyenTonKho::call([
    'pma_cty' => '001',
    'pngay_cnt' => '2024-12-31 23:59:59',
    'pma_kho' => 'KHO01',
]);

$ret = $result['pRet'] ?? null;
if ($ret === 0) {
    // Thành công
} else {
    // Xử lý lỗi
}
```

## Lưu ý chung

- Các procedure này thường được gọi vào cuối năm tài chính để chốt sổ.
- Đảm bảo ngày chuyển (`@pNgay_cnt`) là ngày cuối cùng của năm tài chính cũ.
- Cần kiểm tra ngày kế sách (`ngay_ks`) trước khi thực hiện chuyển.
- Output parameter `@pRet` cần được kiểm tra để xác định thành công hay thất bại.
- Procedure sử dụng các hàm hỗ trợ: `afNgay_DNTC`, `afNamTC`, `afDuCuoiTk`, `afGetTonCuoiVtAll`.

## Tiến độ

- Đã chuyển đổi toàn bộ 2 procedures trong nhóm.
- Các class PHP tương ứng đã có trong `src/StoredProcedures/`.

## Liên kết

- [Simba SQL Source](../../SimbaSql/dbo/StoredProcedures/)
- [Class AsGLChuyenSdTk](../src/StoredProcedures/AsGLChuyenSdTk.php)
- [Class AsINChuyenTonKho](../src/StoredProcedures/AsINChuyenTonKho.php)