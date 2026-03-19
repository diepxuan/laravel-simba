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

class AsSOSaveCAPH4SO
{
    /**
     * Call stored procedure asSOSaveCAPH4SO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOSaveCAPH4SO', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec_hd' => $paramObj->pStt_rec_hd ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pNguoi_gd' => $paramObj->pNguoi_gd ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pT_tien_nt' => $paramObj->pT_tien_nt ?? null,
            'pT_tien' => $paramObj->pT_tien ?? null,
            'pTk_no' => $paramObj->pTk_no ?? null,
            'pUser' => $paramObj->pUser ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOSaveCAPH4SO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ct
     * @param string $Stt_rec
     * @param string $Stt_rec_hd
     * @param string $Ngay_ct
     * @param string $So_ct
     * @param string $Ma_kh
     * @param string $Dia_chi
     * @param string $Nguoi_gd
     * @param string $Dien_giai
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien_nt
     * @param float $T_tien
     * @param string $Tk_no
     * @param string $User
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ct = null, string $Stt_rec = null, string $Stt_rec_hd = null, string $Ngay_ct = null, string $So_ct = null, string $Ma_kh = null, string $Dia_chi = null, string $Nguoi_gd = null, string $Dien_giai = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien_nt = null, float $T_tien = null, string $Tk_no = null, string $User = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ct' => $Ma_ct,
            'pStt_rec' => $Stt_rec,
            'pStt_rec_hd' => $Stt_rec_hd,
            'pNgay_ct' => $Ngay_ct,
            'pSo_ct' => $So_ct,
            'pMa_kh' => $Ma_kh,
            'pDia_chi' => $Dia_chi,
            'pNguoi_gd' => $Nguoi_gd,
            'pDien_giai' => $Dien_giai,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien_nt' => $T_tien_nt,
            'pT_tien' => $T_tien,
            'pTk_no' => $Tk_no,
            'pUser' => $User
        ];

        return self::call($params);
    }
}
