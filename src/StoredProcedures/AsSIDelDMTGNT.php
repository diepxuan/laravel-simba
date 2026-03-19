<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:11
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSIDelDMTGNT
{
    /**
     * Call stored procedure asSIDelDMTGNT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIDelDMTGNT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pNgay_tg' => $paramObj->pNgay_tg ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIDelDMTGNT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nt
     * @param string $Ngay_tg
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nt = null, string $Ngay_tg = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nt' => $Ma_nt,
            'pNgay_tg' => $Ngay_tg,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
