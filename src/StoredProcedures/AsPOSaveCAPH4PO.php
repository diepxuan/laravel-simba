<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:02
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOSaveCAPH4PO
{
    /**
     * Call stored procedure asPOSaveCAPH4PO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOSaveCAPH4PO', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec_hd' => $params['pStt_rec_hd'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pDia_chi' => $params['pDia_chi'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pT_tien_nt' => $params['pT_tien_nt'] ?? null,
            'pT_tien' => $params['pT_tien'] ?? null,
            'pTk_co' => $params['pTk_co'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pUser' => $params['pUser'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOSaveCAPH4PO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ct
     * @param string $Stt_rec
     * @param string $Stt_rec_hd
     * @param string $Ngay_ct
     * @param string $So_ct
     * @param string $Dia_chi
     * @param string $Nguoi_gd
     * @param string $Dien_giai
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien_nt
     * @param float $T_tien
     * @param string $Tk_co
     * @param string $Ma_kh
     * @param string $User
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ct = null, string $Stt_rec = null, string $Stt_rec_hd = null, string $Ngay_ct = null, string $So_ct = null, string $Dia_chi = null, string $Nguoi_gd = null, string $Dien_giai = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien_nt = null, float $T_tien = null, string $Tk_co = null, string $Ma_kh = null, string $User = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ct' => $Ma_ct,
            'pStt_rec' => $Stt_rec,
            'pStt_rec_hd' => $Stt_rec_hd,
            'pNgay_ct' => $Ngay_ct,
            'pSo_ct' => $So_ct,
            'pDia_chi' => $Dia_chi,
            'pNguoi_gd' => $Nguoi_gd,
            'pDien_giai' => $Dien_giai,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien_nt' => $T_tien_nt,
            'pT_tien' => $T_tien,
            'pTk_co' => $Tk_co,
            'pMa_kh' => $Ma_kh,
            'pUser' => $User
        ];
        
        return self::call($params);
    }
}
