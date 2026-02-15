<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINInsPH9
{
    /**
     * Call stored procedure asINInsPH9
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsPH9', $params, $connection);
    }

    /**
     * Call stored procedure asINInsPH9 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_gd
     * @param string $Ngay_ct
     * @param string $Ngay_lct
     * @param string $So_ct
     * @param string $Ma_nx
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param string $Ma_kh1
     * @param string $Ma_kh2
     * @param string $Ma_kh3
     * @param string $Chuc_vu1
     * @param string $Chuc_vu2
     * @param string $Chuc_vu3
     * @param string $Dai_dien1
     * @param string $Dai_dien2
     * @param string $Dai_dien3
     * @param string $Dien_giai
     * @param float $T_sl_ton
     * @param float $T_sl_kk
     * @param float $T_sl_cl
     * @param float $T_tien_ss
     * @param string $Trang_thai
     * @param bool $Post2gl
     * @param bool $Post2in
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_gd = null, string $Ngay_ct = null, string $Ngay_lct = null, string $So_ct = null, string $Ma_nx = null, string $Ma_nt = null, float $Ty_gia = null, string $Ma_kh1 = null, string $Ma_kh2 = null, string $Ma_kh3 = null, string $Chuc_vu1 = null, string $Chuc_vu2 = null, string $Chuc_vu3 = null, string $Dai_dien1 = null, string $Dai_dien2 = null, string $Dai_dien3 = null, string $Dien_giai = null, float $T_sl_ton = null, float $T_sl_kk = null, float $T_sl_cl = null, float $T_tien_ss = null, string $Trang_thai = null, bool $Post2gl = null, bool $Post2in = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_gd' => $Ma_gd,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_lct' => $Ngay_lct,
            'pSo_ct' => $So_ct,
            'pMa_nx' => $Ma_nx,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pMa_kh1' => $Ma_kh1,
            'pMa_kh2' => $Ma_kh2,
            'pMa_kh3' => $Ma_kh3,
            'pChuc_vu1' => $Chuc_vu1,
            'pChuc_vu2' => $Chuc_vu2,
            'pChuc_vu3' => $Chuc_vu3,
            'pDai_dien1' => $Dai_dien1,
            'pDai_dien2' => $Dai_dien2,
            'pDai_dien3' => $Dai_dien3,
            'pDien_giai' => $Dien_giai,
            'pT_sl_ton' => $T_sl_ton,
            'pT_sl_kk' => $T_sl_kk,
            'pT_sl_cl' => $T_sl_cl,
            'pT_tien_ss' => $T_tien_ss,
            'pTrang_thai' => $Trang_thai,
            'pPost2gl' => $Post2gl,
            'pPost2in' => $Post2in,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
