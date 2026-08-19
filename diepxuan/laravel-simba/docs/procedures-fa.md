# Fixed Assets (asFA*) Stored Procedures

Danh sách các stored procedures thuộc nhóm Fixed Assets (asFA*) đã được chuyển đổi sang class PHP.

## Tổng quan

- **Nhóm**: Fixed Assets (Tài sản cố định)
- **Tiền tố**: asFA*
- **Số lượng procedures đã chuyển đổi**: 6 (cập nhật ngày 2026-02-11)

## Danh sách procedures

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asFAChkDTSD | AsFAChkDTSD | - pMa_cty (string, required): Mã công ty<br>- pMa_ts (string, required): Mã tài sản<br>- pNgay (datetime, required): Ngày di chuyển<br>- pLoai_dt (string, required): Loại di chuyển<br>- pRet (int, output): Kết quả (0: được phép, <>0: không được phép) | Kiểm tra có được phép chuyển tài sản không (đếm bản ghi trong fadtsd). |
| asFAChkGiamTs | AsFAChkGiamTs | - pMa_cty (string, required): Mã công ty<br>- pMa_ts (string, required): Mã tài sản<br>- pMoi_Sua (string, required): Loại thao tác (M: Mới, S: Sửa)<br>- pNgay_giam (datetime, required): Ngày giảm tài sản<br>- pRet (int, output): Kết quả (0: được phép giảm, <>0: không được phép) | Kiểm tra điều kiện giảm tài sản (kiểm tra is_Giam và khấu hao sau ngày giảm). |
| asFAChkThoiKHTS | AsFAChkThoiKHTS | - pma_cty (string, required): Mã công ty<br>- pma_ts (string, required): Mã tài sản<br>- pNgay_dung_kh (datetime, required): Ngày tạm ngừng khấu hao | Kiểm tra thông tin tạm ngừng khấu hao TSCĐ (đếm bản ghi đã giảm trước ngày tạm ngừng). |
| asFADelDMBPSD | AsFADelDMBPSD | - pMa_cty (string, required): Mã công ty<br>- pMa_bpsd (string, required): Mã bộ phận sử dụng<br>- pRet (int, output): Kết quả (0: xóa thành công, <>0: lỗi) | Xóa danh mục bộ phận sử dụng (BPSD) sau khi kiểm tra tồn tại. |
| asFADelDMLK | AsFADelDMLK | - pMa_cty (string, required): Mã công ty<br>- pMa_ts (string, required): Mã tài sản<br>- pMa_Ts_Tgng (string, required): Mã tài sản thay thế<br>- pMa_lk (string, required): Mã liên kết<br>- pRet (int, output): Kết quả (0: xóa thành công, <>0: lỗi) | Xóa danh mục liên kết (LK) của tài sản (có tham số dư thừa). |
| asFADelDMNHTS | AsFADelDMNHTS | - pMa_cty (string, required): Mã công ty<br>- pMa_nhts (string, required): Mã nhóm tài sản<br>- pLoai_nh (string, required): Loại nhóm<br>- pRet (int, output): Kết quả (0: xóa thành công, <>0: lỗi) | Xóa danh mục nhóm tài sản (NHTS) sau khi kiểm tra tồn tại. |

## Chi tiết từng procedure

### asFAChkDTSD

**File SQL**: `SimbaSql/dbo/StoredProcedures/asFAChkDTSD.sql`

**Mục đích**: Kiểm tra xem có được phép chuyển (di chuyển tài sản cố định) hay không.

**Tham số**:
- @pMa_cty NVARCHAR(3): Mã công ty
- @pMa_ts NVARCHAR(20): Mã tài sản
- @pNgay SMALLDATETIME: Ngày di chuyển
- @pLoai_dt NVARCHAR(20): Loại di chuyển
- @pRet INT OUTPUT: Kết quả (0: được phép, khác 0: không được phép)

**Giá trị trả về**: Không có resultset, chỉ output parameter @pRet.

**Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsFAChkDTSD`

**Ví dụ**:
```php
$result = AsFAChkDTSD::call([
    'pMa_cty' => '001',
    'pMa_ts' => 'TS001',
    'pNgay' => '2025-02-11',
    'pLoai_dt' => 'CHUYEN_KHO',
]);
$ret = $result['pRet'] ?? null;
```

### asFAChkGiamTs

**File SQL**: `SimbaSql/dbo/StoredProcedures/asFAChkGiamTs.sql`

**Mục đích**: Kiểm tra điều kiện giảm tài sản cố định (xác định xem có được phép giảm tài sản hay không).

**Tham số**:
- @pMa_cty NVARCHAR(3): Mã công ty
- @pMa_ts NVARCHAR(20): Mã tài sản
- @pMoi_Sua NVARCHAR(1): Loại thao tác: 'M' - Mới (tạo mới), 'S' - Sửa (chỉnh sửa)
- @pNgay_giam SMALLDATETIME: Ngày giảm tài sản
- @pRet INT OUTPUT: Kết quả (0: được phép giảm, khác 0: không được phép)

**Giá trị trả về**: Không có resultset, chỉ output parameter @pRet.

**Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsFAChkGiamTs`

**Ví dụ**:
```php
$result = AsFAChkGiamTs::call([
    'pMa_cty' => '001',
    'pMa_ts' => 'TS001',
    'pMoi_Sua' => 'M',
    'pNgay_giam' => '2025-02-11',
]);
$ret = $result['pRet'] ?? null;
```

### asFAChkThoiKHTS

**File SQL**: `SimbaSql/dbo/StoredProcedures/asFAChkThoiKHTS.sql`

**Mục đích**: Kiểm tra thông tin tạm ngừng khấu hao tài sản cố định (TSCĐ).

**Tham số**:
- @pma_cty NVARCHAR(3): Mã công ty
- @pma_ts NVARCHAR(20): Mã tài sản
- @pNgay_dung_kh SMALLDATETIME: Ngày tạm ngừng khấu hao

**Giá trị trả về**: Một resultset gồm một cột (COUNT(*)) chứa số lượng bản ghi thỏa mãn.

**Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsFAChkThoiKHTS`

**Ví dụ**:
```php
$result = AsFAChkThoiKHTS::call([
    'pma_cty' => '001',
    'pma_ts' => 'TS001',
    'pNgay_dung_kh' => '2025-02-11',
]);
// $result là mảng các đối tượng stdClass, mỗi đối tượng có một thuộc tính không tên.
// Để lấy giá trị count:
$first = current($result);
$count = $first ? (int) current(get_object_vars($first)) : 0;
```

### asFADelDMBPSD

**File SQL**: `SimbaSql/dbo/StoredProcedures/asFADelDMBPSD.sql`

**Mục đích**: Xóa danh mục Bộ phận sử dụng (BPSD) trong module Tài sản cố định.

**Tham số**:
- @pMa_cty NVARCHAR(3): Mã công ty
- @pMa_bpsd NVARCHAR(8): Mã bộ phận sử dụng
- @pRet INT OUTPUT: Kết quả (0: xóa thành công, <>0: lỗi)

**Giá trị trả về**: Không có resultset, chỉ output parameter @pRet.

**Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsFADelDMBPSD`

**Ví dụ**:
```php
$result = AsFADelDMBPSD::call([
    'pMa_cty' => '001',
    'pMa_bpsd' => 'BP001',
]);
$ret = $result['pRet'] ?? null;
```

### asFADelDMLK

**File SQL**: `SimbaSql/dbo/StoredProcedures/asFADelDMLK.sql`

**Mục đích**: Xóa danh mục liên kết (LK) của tài sản cố định.

**Tham số**:
- @pMa_cty NVARCHAR(3): Mã công ty
- @pMa_ts NVARCHAR(20): Mã tài sản
- @pMa_Ts_Tgng NVARCHAR(20): Mã tài sản thay thế (tham số dư thừa)
- @pMa_lk NVARCHAR(20): Mã liên kết
- @pRet INT OUTPUT: Kết quả (0: xóa thành công, <>0: lỗi)

**Giá trị trả về**: Không có resultset, chỉ output parameter @pRet.

**Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsFADelDMLK`

**Ví dụ**:
```php
$result = AsFADelDMLK::call([
    'pMa_cty' => '001',
    'pMa_ts' => 'TS001',
    'pMa_Ts_Tgng' => 'TS002',
    'pMa_lk' => 'LK001',
]);
$ret = $result['pRet'] ?? null;
```

## Ghi chú

- Các procedure trong nhóm này liên quan đến quản lý tài sản cố định: kiểm tra, xóa, lấy danh mục, khấu hao,...
- Output parameters hiện chưa được hỗ trợ đầy đủ trong ProcedureCaller, cần mở rộng sau.