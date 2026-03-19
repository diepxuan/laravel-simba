<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdDmCheDoNghi
{
    /**
     * Call stored procedure asHrUpdDmCheDoNghi
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmCheDoNghi', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_cdn' => $paramObj->pMa_cdn ?? null,
            'pTen_cdn' => $paramObj->pTen_cdn ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pTong' => $paramObj->pTong ?? null,
            'pMau_hien_thi' => $paramObj->pMau_hien_thi ?? null,
            'pY_te' => $paramObj->pY_te ?? null,
            'pCuoi_tuan' => $paramObj->pCuoi_tuan ?? null,
            'pLe_tet' => $paramObj->pLe_tet ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDmCheDoNghi with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_cdn
     * @param string $Ten_cdn
     * @param string $Dvt
     * @param float $Tong
     * @param string $Mau_hien_thi
     * @param bool $Y_te
     * @param bool $Cuoi_tuan
     * @param bool $Le_tet
     * @param bool $Ksd
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_cdn = null, string $Ten_cdn = null, string $Dvt = null, float $Tong = null, string $Mau_hien_thi = null, bool $Y_te = null, bool $Cuoi_tuan = null, bool $Le_tet = null, bool $Ksd = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_cdn' => $Ma_cdn,
            'pTen_cdn' => $Ten_cdn,
            'pDvt' => $Dvt,
            'pTong' => $Tong,
            'pMau_hien_thi' => $Mau_hien_thi,
            'pY_te' => $Y_te,
            'pCuoi_tuan' => $Cuoi_tuan,
            'pLe_tet' => $Le_tet,
            'pKsd' => $Ksd,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
