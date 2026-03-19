<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsCOInsDMNHSPCT
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCOInsDMNHSPCT', [
            'pma_nhspct' => $paramObj->pma_nhspct ?? null,
            'pten_nhspct' => $paramObj->pten_nhspct ?? null,
            'pCap' => $paramObj->pCap ?? null,
            'pStt_nhom' => $paramObj->pStt_nhom ?? null,
            'pNhom_me' => $paramObj->pNhom_me ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pCong_sl' => $paramObj->pCong_sl ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
