<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-14 09:12:28
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPODeletePO3.
 *
 * Stored procedure: asPODeletePO3
 * Mục đích: Xóa hóa đơn mua hàng (PO3).
 */
class AsPODeletePO3
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPODeletePO3', [
            'pMa_cty'  => $paramObj->pMa_cty ?? SModel::CTY,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pRet'     => ['type' => 'INT', 'output' => true],
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
