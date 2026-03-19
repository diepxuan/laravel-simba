<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AssoUpddmhhkm
{
    /**
     * Call stored procedure assoUpddmhhkm
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('assoUpddmhhkm', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_km' => $paramObj->pMa_km ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pLoai_km' => $paramObj->pLoai_km ?? null,
            'pSl_km' => $paramObj->pSl_km ?? null,
            'pMuc_km' => $paramObj->pMuc_km ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure assoUpddmhhkm with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_km
     * @param string $Ma_vt
     * @param string $Loai_km
     * @param float $Sl_km
     * @param float $Muc_km
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_km = null, string $Ma_vt = null, string $Loai_km = null, float $Sl_km = null, float $Muc_km = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_km' => $Ma_km,
            'pMa_vt' => $Ma_vt,
            'pLoai_km' => $Loai_km,
            'pSl_km' => $Sl_km,
            'pMuc_km' => $Muc_km,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
