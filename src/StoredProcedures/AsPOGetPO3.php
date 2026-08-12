<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-14 09:12:32
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;
use PDO;

/**
 * Class AsPOGetPO3.
 *
 * Stored procedure: asPOGetPO3
 * Mục đích: Lấy dữ liệu hóa đơn mua hàng (PO3) theo stt_rec.
 */
class AsPOGetPO3
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOGetPO3', [
            'pMa_cty'  => $paramObj->pMa_cty ?? SModel::CTY,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
        ], $connection);
    }

    /**
     * Gọi asPOGetPO3 và trả về tất cả result set.
     *
     * @return array<int, Collection<int, array<string, mixed>>>
     */
    public static function callWithDataSets(array $params): array
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        $pdo = DB::connection($connection)->getPdo();
        $stmt = $pdo->prepare(self::callSql([
            'pMa_cty'  => $paramObj->pMa_cty ?? SModel::CTY,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
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

        return array_map(static fn (array $rows): Collection => collect($rows), $sets);
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

        return "SET NOCOUNT ON;\nEXECUTE [dbo].[asPOGetPO3]\n    " . implode(",\n    ", $execParts);
    }

    public static function callWithParams(?string $maCty = null, ?string $sttRec = null): Collection
    {
        return self::call([
            'pMa_cty'  => $maCty,
            'pStt_rec' => $sttRec,
        ]);
    }
}
