<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPORptBCPT03
{
    /**
     * Call stored procedure asPORptBCPT03
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptBCPT03', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_plkh1' => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2' => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3' => $paramObj->pMa_plkh3 ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_nhhd' => $paramObj->pMa_nhhd ?? null,
            'pMa_HTTT' => $paramObj->pMa_HTTT ?? null,
            'pMa_tt' => $paramObj->pMa_tt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pMa_plvt1' => $paramObj->pMa_plvt1 ?? null,
            'pMa_plvt2' => $paramObj->pMa_plvt2 ?? null,
            'pMa_plvt3' => $paramObj->pMa_plvt3 ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pTra_lai' => $paramObj->pTra_lai ?? null,
            'pMa_NT' => $paramObj->pMa_NT ?? null,
            'pGroup' => $paramObj->pGroup ?? null,
            'pDetail' => $paramObj->pDetail ?? null,
            'pSysMsg1' => $paramObj->pSysMsg1 ?? null,
            'pMa_httt' => $paramObj->pMa_httt ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pStrTL' => $paramObj->pStrTL ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPORptBCPT03 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_hd
     * @param string $Ma_nhhd
     * @param string $Ma_HTTT
     * @param string $Ma_tt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_lo
     * @param string $Ma_phi
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param string $Ma_spct
     * @param bool $Tra_lai
     * @param string $Ma_NT
     * @param string $Group
     * @param string $Detail
     * @param string $SysMsg1
     * @param mixed $Ma_httt
     * @param mixed $Ma_nt
     * @param string $StrTL
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_hd = null, string $Ma_nhhd = null, string $Ma_HTTT = null, string $Ma_tt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_lo = null, string $Ma_phi = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, string $Ma_spct = null, bool $Tra_lai = null, string $Ma_NT = null, string $Group = null, string $Detail = null, string $SysMsg1 = null, mixed $Ma_httt = null, mixed $Ma_nt = null, string $StrTL = null, string $ParamDefines = null, string $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_hd' => $Ma_hd,
            'pMa_nhhd' => $Ma_nhhd,
            'pMa_HTTT' => $Ma_HTTT,
            'pMa_tt' => $Ma_tt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_lo' => $Ma_lo,
            'pMa_phi' => $Ma_phi,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pMa_spct' => $Ma_spct,
            'pTra_lai' => $Tra_lai,
            'pMa_NT' => $Ma_NT,
            'pGroup' => $Group,
            'pDetail' => $Detail,
            'pSysMsg1' => $SysMsg1,
            'pMa_httt' => $Ma_httt,
            'pMa_nt' => $Ma_nt,
            'pStrTL' => $StrTL,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty
        ];

        return self::call($params);
    }
}
