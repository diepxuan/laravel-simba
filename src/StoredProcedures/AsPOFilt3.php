<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:29
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;
use Illuminate\Support\Facades\DB;
use PDO;

/**
 * Stored procedure asPOFilt3.
 *
 * SP gốc từ SimbaSql:
 * - asPOFilt3 (@pKeyPh, @pKeyCt)
 * - Dùng cho danh sách hóa đơn mua hàng (PO3).
 */
class AsPOFilt3
{
    /**
     * Dựng @pKeyPh cho lọc header PO3.
     */
    public static function keyPh(string $maCty, string $maCt, ?string $ngay1 = null, ?string $ngay2 = null, ?string $maKh = null, ?string $search = null): string
    {
        $parts = [
            "ma_cty = '" . self::escape($maCty) . "'",
            "ma_ct = '" . self::escape($maCt) . "'",
        ];

        if (null !== $ngay1 && '' !== $ngay1) {
            $parts[] = "ngay_ct >= '" . self::escape($ngay1) . "'";
        }
        if (null !== $ngay2 && '' !== $ngay2) {
            $parts[] = "ngay_ct <= '" . self::escape($ngay2) . "'";
        }
        if (null !== $maKh && '' !== $maKh) {
            $parts[] = "ma_kh like N'" . self::escape($maKh) . "%'";
        }
        if (null !== $search && '' !== $search) {
            $parts[] = "(so_ct like N'%" . self::escape($search) . "%' or so_hd like N'%" . self::escape($search) . "%' or ma_kh like N'%" . self::escape($search) . "%')";
        }

        return implode(' and ', $parts);
    }

    /**
     * Dựng @pKeyCt cho lọc chi tiết PO3.
     */
    public static function keyCt(string $maCty, ?string $maVt = null, ?string $maKho = null): string
    {
        $parts = ["ma_cty = '" . self::escape($maCty) . "'"];

        if (null !== $maVt && '' !== $maVt) {
            $parts[] = "ma_vt = N'" . self::escape($maVt) . "'";
        }
        if (null !== $maKho && '' !== $maKho) {
            $parts[] = "ma_kho = N'" . self::escape($maKho) . "'";
        }

        return implode(' and ', $parts);
    }

    /**
     * Escape single quote cho SQL Server.
     */
    public static function escape(string $value): string
    {
        return str_replace("'", "''", $value);
    }

    /**
     * Call stored procedure asPOFilt3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOFilt3', [
            'pKeyPh' => $paramObj->pKeyPh ?? null,
            'pKeyCt' => $paramObj->pKeyCt ?? null,
        ], $connection);
    }

    /**
     * Gọi asPOFilt3 và trả về tất cả result set.
     *
     * @return array{ph: Collection<int, array<string, mixed>>, ct: Collection<int, array<string, mixed>>}
     */
    public static function callWithDataSets(array $params): array
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        $pdo = DB::connection($connection)->getPdo();
        $stmt = $pdo->prepare(self::callSql([
            'pKeyPh' => $paramObj->pKeyPh ?? null,
            'pKeyCt' => $paramObj->pKeyCt ?? null,
        ]));
        $stmt->execute();

        $sets = [];
        do {
            if ($stmt->columnCount() > 0) {
                $sets[] = $stmt->fetchAll(PDO::FETCH_ASSOC) ?: [];
            }
        } while ($stmt->nextRowset());

        try {
            $stmt->closeCursor();
        } catch (\Throwable) {
            // Bỏ qua lỗi closeCursor sau khi đã đọc hết result set.
        }

        return [
            'ph' => collect($sets[0] ?? []),
            'ct' => collect($sets[1] ?? []),
        ];
    }

    /**
     * Build EXEC statement dùng Unicode literal giống ProcedureCaller.
     *
     * @param array<string, mixed> $procedureParams
     */
    public static function callSql(array $procedureParams): string
    {
        $execParts = [];
        foreach ($procedureParams as $key => $value) {
            $execParts[] = '@' . $key . ' = ' . ProcedureCaller::toUnicodeLiteral($value);
        }

        return "SET NOCOUNT ON;\nEXECUTE [dbo].[asPOFilt3]\n    " . implode(",\n    ", $execParts);
    }

    /**
     * Call stored procedure asPOFilt3 with named parameters
     *
     * @param string $KeyPh
     * @param string $KeyCt
     * @return Collection
     */
    public static function callWithParams(string $KeyPh = null, string $KeyCt = null): Collection
    {
        $params = [
            'pKeyPh' => $KeyPh,
            'pKeyCt' => $KeyCt
        ];

        return self::call($params);
    }
}
