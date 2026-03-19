<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:46
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSORptBCPT05
{
    /**
     * Call stored procedure asSORptBCPT05
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBCPT05', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_Bp' => $paramObj->pMa_Bp ?? null,
            'pMa_Nvkd' => $paramObj->pMa_Nvkd ?? null,
            'pMa_Hd' => $paramObj->pMa_Hd ?? null,
            'pMa_NhHd' => $paramObj->pMa_NhHd ?? null,
            'pMa_plvt1' => $paramObj->pMa_plvt1 ?? null,
            'pMa_plvt2' => $paramObj->pMa_plvt2 ?? null,
            'pMa_plvt3' => $paramObj->pMa_plvt3 ?? null,
            'pkhuyen_mai' => $paramObj->pkhuyen_mai ?? null,
            'pTra_ck' => $paramObj->pTra_ck ?? null,
            'pHang_ban' => $paramObj->pHang_ban ?? null,
            'pTra_lai' => $paramObj->pTra_lai ?? null,
            'pMa_NT' => $paramObj->pMa_NT ?? null,
            'pSysMsg1' => $paramObj->pSysMsg1 ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_nvkd' => $paramObj->pMa_nvkd ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptBCPT05 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kho
     * @param string $Ma_Bp
     * @param string $Ma_Nvkd
     * @param string $Ma_Hd
     * @param string $Ma_NhHd
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param bool $khuyen_mai
     * @param bool $Tra_ck
     * @param bool $Hang_ban
     * @param bool $Tra_lai
     * @param string $Ma_NT
     * @param string $SysMsg1
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $Ma_nt
     * @param string $Ma_bp
     * @param string $Ma_nvkd
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_Bp = null, string $Ma_Nvkd = null, string $Ma_Hd = null, string $Ma_NhHd = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, bool $khuyen_mai = null, bool $Tra_ck = null, bool $Hang_ban = null, bool $Tra_lai = null, string $Ma_NT = null, string $SysMsg1 = null, string $ParamDefines = null, string $Ma_Cty = null, string $Ma_nt = null, string $Ma_bp = null, string $Ma_nvkd = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kho' => $Ma_kho,
            'pMa_Bp' => $Ma_Bp,
            'pMa_Nvkd' => $Ma_Nvkd,
            'pMa_Hd' => $Ma_Hd,
            'pMa_NhHd' => $Ma_NhHd,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pkhuyen_mai' => $khuyen_mai,
            'pTra_ck' => $Tra_ck,
            'pHang_ban' => $Hang_ban,
            'pTra_lai' => $Tra_lai,
            'pMa_NT' => $Ma_NT,
            'pSysMsg1' => $SysMsg1,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pMa_nt' => $Ma_nt,
            'pMa_bp' => $Ma_bp,
            'pMa_nvkd' => $Ma_nvkd
        ];

        return self::call($params);
    }
}
