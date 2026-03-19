<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSORptF5BCPT06
{
    /**
     * Call stored procedure asSORptF5BCPT06
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptF5BCPT06', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_plkh1' => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2' => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3' => $paramObj->pMa_plkh3 ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_Bp' => $paramObj->pMa_Bp ?? null,
            'pMa_Nvkd' => $paramObj->pMa_Nvkd ?? null,
            'pMa_Hd' => $paramObj->pMa_Hd ?? null,
            'pMa_Httt' => $paramObj->pMa_Httt ?? null,
            'pkhuyen_mai' => $paramObj->pkhuyen_mai ?? null,
            'pTra_ck' => $paramObj->pTra_ck ?? null,
            'pHang_ban' => $paramObj->pHang_ban ?? null,
            'pTra_lai' => $paramObj->pTra_lai ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pDvt' => $paramObj->pDvt ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptF5BCPT06 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_ct
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Tk_vt
     * @param string $Ma_kho
     * @param string $Ma_Bp
     * @param string $Ma_Nvkd
     * @param string $Ma_Hd
     * @param string $Ma_Httt
     * @param string $khuyen_mai
     * @param string $Tra_ck
     * @param string $Hang_ban
     * @param string $Tra_lai
     * @param string $Ma_nt
     * @param string $Dvt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_ct = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Tk_vt = null, string $Ma_kho = null, string $Ma_Bp = null, string $Ma_Nvkd = null, string $Ma_Hd = null, string $Ma_Httt = null, string $khuyen_mai = null, string $Tra_ck = null, string $Hang_ban = null, string $Tra_lai = null, string $Ma_nt = null, string $Dvt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_ct' => $Ma_ct,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pTk_vt' => $Tk_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_Bp' => $Ma_Bp,
            'pMa_Nvkd' => $Ma_Nvkd,
            'pMa_Hd' => $Ma_Hd,
            'pMa_Httt' => $Ma_Httt,
            'pkhuyen_mai' => $khuyen_mai,
            'pTra_ck' => $Tra_ck,
            'pHang_ban' => $Hang_ban,
            'pTra_lai' => $Tra_lai,
            'pMa_nt' => $Ma_nt,
            'pDvt' => $Dvt
        ];

        return self::call($params);
    }
}
