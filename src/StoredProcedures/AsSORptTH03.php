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

class AsSORptTH03
{
    /**
     * Call stored procedure asSORptTH03
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptTH03', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMa_loai' => $paramObj->pMa_loai ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_plkh1' => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2' => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3' => $paramObj->pMa_plkh3 ?? null,
            'pMa_plvt1' => $paramObj->pMa_plvt1 ?? null,
            'pMa_plvt2' => $paramObj->pMa_plvt2 ?? null,
            'pMa_plvt3' => $paramObj->pMa_plvt3 ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_nhhd' => $paramObj->pMa_nhhd ?? null,
            'pMa_HTTT' => $paramObj->pMa_HTTT ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pMa_TKVT' => $paramObj->pMa_TKVT ?? null,
            'pHang_ban' => $paramObj->pHang_ban ?? null,
            'pkhuyen_mai' => $paramObj->pkhuyen_mai ?? null,
            'pTra_ck' => $paramObj->pTra_ck ?? null,
            'pTra_lai' => $paramObj->pTra_lai ?? null,
            'pMa_NT' => $paramObj->pMa_NT ?? null,
            'pSysMsg1' => $paramObj->pSysMsg1 ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pMa_Tkvt' => $paramObj->pMa_Tkvt ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptTH03 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_loai
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param string $Ma_hd
     * @param string $Ma_nhhd
     * @param string $Ma_HTTT
     * @param string $Ma_kho
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_TKVT
     * @param bool $Hang_ban
     * @param bool $khuyen_mai
     * @param bool $Tra_ck
     * @param bool $Tra_lai
     * @param string $Ma_NT
     * @param string $SysMsg1
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $Ma_nt
     * @param string $Ma_Tkvt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_loai = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, string $Ma_hd = null, string $Ma_nhhd = null, string $Ma_HTTT = null, string $Ma_kho = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_TKVT = null, bool $Hang_ban = null, bool $khuyen_mai = null, bool $Tra_ck = null, bool $Tra_lai = null, string $Ma_NT = null, string $SysMsg1 = null, string $ParamDefines = null, string $Ma_Cty = null, string $Ma_nt = null, string $Ma_Tkvt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_loai' => $Ma_loai,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pMa_hd' => $Ma_hd,
            'pMa_nhhd' => $Ma_nhhd,
            'pMa_HTTT' => $Ma_HTTT,
            'pMa_kho' => $Ma_kho,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_TKVT' => $Ma_TKVT,
            'pHang_ban' => $Hang_ban,
            'pkhuyen_mai' => $khuyen_mai,
            'pTra_ck' => $Tra_ck,
            'pTra_lai' => $Tra_lai,
            'pMa_NT' => $Ma_NT,
            'pSysMsg1' => $SysMsg1,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pMa_nt' => $Ma_nt,
            'pMa_Tkvt' => $Ma_Tkvt
        ];

        return self::call($params);
    }
}
