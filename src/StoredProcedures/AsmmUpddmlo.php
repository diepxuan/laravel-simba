<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsmmUpddmlo
{
    /**
     * Call stored procedure asmmUpddmlo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asmmUpddmlo', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_lo_tp' => $paramObj->pMa_lo_tp ?? null,
            'pTen_lo' => $paramObj->pTen_lo ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pTen_vt' => $paramObj->pTen_vt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pHan_dung' => $paramObj->pHan_dung ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asmmUpddmlo with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_lo_tp
     * @param string $Ten_lo
     * @param bool $Ksd
     * @param string $Ten_vt
     * @param float $So_luong
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_vt
     * @param string $LUser
     * @param string $Han_dung
     * @param string $Trang_thai
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_lo_tp = null, string $Ten_lo = null, bool $Ksd = null, string $Ten_vt = null, float $So_luong = null, int $Thang = null, int $Nam = null, string $Ma_vt = null, string $LUser = null, string $Han_dung = null, string $Trang_thai = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_lo_tp' => $Ma_lo_tp,
            'pTen_lo' => $Ten_lo,
            'pKsd' => $Ksd,
            'pTen_vt' => $Ten_vt,
            'pSo_luong' => $So_luong,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_vt' => $Ma_vt,
            'pLUser' => $LUser,
            'pHan_dung' => $Han_dung,
            'pTrang_thai' => $Trang_thai,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
