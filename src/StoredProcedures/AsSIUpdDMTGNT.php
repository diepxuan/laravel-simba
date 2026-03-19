<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSIUpdDMTGNT
{
    /**
     * Call stored procedure asSIUpdDMTGNT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIUpdDMTGNT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pNgay_tg' => $paramObj->pNgay_tg ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIUpdDMTGNT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nt
     * @param string $Ngay_tg
     * @param float $Ty_gia
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nt = null, string $Ngay_tg = null, float $Ty_gia = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nt' => $Ma_nt,
            'pNgay_tg' => $Ngay_tg,
            'pTy_gia' => $Ty_gia,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
