<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINInsCDVT
{
    /**
     * Call stored procedure asINInsCDVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsCDVT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pTien_nt' => $paramObj->pTien_nt ?? null,
            'pTien' => $paramObj->pTien ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINInsCDVT with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_lo
     * @param string $Tk_vt
     * @param string $Ma_nt
     * @param float $So_luong
     * @param float $Tien_nt
     * @param float $Tien
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_lo = null, string $Tk_vt = null, string $Ma_nt = null, float $So_luong = null, float $Tien_nt = null, float $Tien = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_lo' => $Ma_lo,
            'pTk_vt' => $Tk_vt,
            'pMa_nt' => $Ma_nt,
            'pSo_luong' => $So_luong,
            'pTien_nt' => $Tien_nt,
            'pTien' => $Tien,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
