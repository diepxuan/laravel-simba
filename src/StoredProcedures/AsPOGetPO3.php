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

    public static function callWithParams(?string $maCty = null, ?string $sttRec = null): Collection
    {
        return self::call([
            'pMa_cty'  => $maCty,
            'pStt_rec' => $sttRec,
        ]);
    }
}
