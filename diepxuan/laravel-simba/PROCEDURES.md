# Stored Procedures Migration - Tổng hợp

Dự án chuyển đổi stored procedures từ Simba SQL Server sang class PHP để sử dụng trong Laravel Simba.

## Tổng quan

- **Tổng số procedures đã chuyển đổi**: 343 (cập nhật 2026-02-11)
- **Tổng số procedures ước tính**: 1831 (theo số file as*.sql).
- **Nhóm đã hoàn thành một phần**: Accounts Payable (asAP*), Accounts Receivable (asAR*), General Ledger (asGL*), Sales & Inventory (asSI*), Inventory (asIN*), Purchase Order (asPO*), Human Resources (asHR*), Fixed Assets (asFA*), Cost Accounting (asCA*), Banking (asBN*).

## Danh sách nhóm

| Nhóm | Prefix | Số lượng procedures (ước) | Đã chuyển đổi | Tài liệu chi tiết |
|------|--------|----------------------------|---------------|-------------------|
| Accounts Payable | `asAP*` | ~200 | 18 | [procedures-ap.md](docs/procedures-ap.md) |
| Accounts Receivable | `asAR*` | ~150 | 11 | [procedures-ar.md](docs/procedures-ar.md) |
| General Ledger | `asGL*` | ~180 | 17 | [procedures-gl.md](docs/procedures-gl.md) |
| Sales & Inventory | `asSI*` | ~120 | 22 | [procedures-si.md](docs/procedures-si.md) |
| Inventory | `asIN*` | ~100 | 20 | [procedures-in.md](docs/procedures-in.md) |
| Purchase Order | `asPO*` | ~100 | 14 | [procedures-po.md](docs/procedures-po.md) |
| Human Resources | `asHR*` | ~172 | 10 | [procedures-hr.md](docs/procedures-hr.md) |
| Fixed Assets | `asFA*` | ~80 | 6 | [procedures-fa.md](docs/procedures-fa.md) |
| Cost Accounting | `asCA*` | 53 | 7 | [procedures-ca.md](docs/procedures-ca.md) |
| Banking | `asBN*` | ? | 0 | [procedures-bn.md](docs/procedures-bn.md) |
| Production (Cost) | `asCO*` | 36 | 19 | [procedures-co.md](docs/procedures-co.md) |
| Sales | `asSA*` | 22 | 22 | [procedures-sa.md](docs/procedures-sa.md) |
| Posting | `asPost*` | ~86 | 10 | [procedures-post.md](docs/procedures-post.md) |
| System & Tools | `asSys*`, `asTool*` | ? | 0 | (chưa có) |
| Get Data | `asGet*` | 92 | 17 | [procedures-get.md](docs/procedures-get.md) |
| Other (asCT, asDM, ...) | various | ? | 16 | (tổng hợp) |
| Delete | `asDel*` | 25 | 30 | [procedures-del.md](docs/procedures-del.md) |
| Update | `asUpd*` | 37 | 16 | [procedures-upd.md](docs/procedures-upd.md) |
| Reports | `asRpt*` | 2 | 2 | [procedures-rpt.md](docs/procedures-rpt.md) |
| Insert | `asIns*` | 32 | 24 | [procedures-ins.md](docs/procedures-ins.md) |
| Calculate | `asCal*` | 1 | 1 | [procedures-cal.md](docs/procedures-cal.md) |
| Copy | `*Copy*` | 5 | 5 | [procedures-copy.md](docs/procedures-copy.md) |
| Create | `asCrt*` | ~5 | 5 | [procedures-crt.md](docs/procedures-crt.md) |
| Transfer | `asChuyen*` | 2 | 2 | [procedures-chuyen.md](docs/procedures-chuyen.md) |
| Filter | `asFilt*` | ~32 | 9 | [procedures-filt.md](docs/procedures-filt.md) |
| Recalculate | `asReCal*` | 17 | 17 | [procedures-recal.md](docs/procedures-recal.md) |
| Check | `asCheck*` | 2 | 2 | [procedures-check.md](docs/procedures-check.md) |
| Check (asChk*) | `asChk*` | 5 | 5 | [procedures-chk.md](docs/procedures-chk.md) |
| Remaining (other) | various | ? | 6 | [procedures-remaining-1.md](docs/procedures-remaining-1.md) |

## Cấu trúc class

Tất cả các class được đặt trong namespace `Diepxuan\LaravelSimba\StoredProcedures` và tuân theo mẫu:

```php
<?php
namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

class AsXxxYyy
{
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asXxxYyy', $params);
    }
}
```

Mỗi class đều có comment chi tiết về mục đích, tham số, giá trị trả về và ví dụ sử dụng.

## Hướng dẫn sử dụng

1. **Import class**:
   ```php
   use Diepxuan\LaravelSimba\StoredProcedures\AsPoGetCt0;
   ```

2. **Gọi procedure**:
   ```php
   $result = AsPoGetCt0::call([
       'pMa_cty' => '001',
       'pStt_rec' => 'PO202500001',
   ]);
   ```

3. **Xử lý kết quả**:
   - Với procedure trả về resultset: `$result` là collection/array.
   - Với procedure có output parameter: `$result['pRet']` chứa giá trị output.

## Tiến độ và kế hoạch

- Ưu tiên các nhóm thường dùng: HR, AP, AR, IN, GL.
- Mỗi nhóm có tài liệu riêng trong thư mục `docs/`.
- Cập nhật tổng hợp sau mỗi phiên làm việc.

## Đóng góp

Khi chuyển đổi thêm procedure, cần:

1. Tạo class PHP trong `src/StoredProcedures/` với đầy đủ comment.
2. Cập nhật tài liệu nhóm tương ứng trong `docs/`.
3. Cập nhật số lượng đã chuyển đổi trong file này.
4. Đảm bảo code style nhất quán.

## Liên kết

- [Simba SQL Source](../SimbaSql/dbo/StoredProcedures/)
- [Stored Procedures Classes](./src/StoredProcedures/)
- [Documentation](./docs/)