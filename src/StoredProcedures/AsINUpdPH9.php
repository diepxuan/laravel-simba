<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:40
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINUpdPH9
{
    /**
     * Call stored procedure asINUpdPH9
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINUpdPH9', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pMa_gd' => $paramObj->pMa_gd ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_lct' => $paramObj->pNgay_lct ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pMa_nx' => $paramObj->pMa_nx ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pMa_kh1' => $paramObj->pMa_kh1 ?? null,
            'pMa_kh2' => $paramObj->pMa_kh2 ?? null,
            'pMa_kh3' => $paramObj->pMa_kh3 ?? null,
            'pChuc_vu1' => $paramObj->pChuc_vu1 ?? null,
            'pChuc_vu2' => $paramObj->pChuc_vu2 ?? null,
            'pChuc_vu3' => $paramObj->pChuc_vu3 ?? null,
            'pDai_dien1' => $paramObj->pDai_dien1 ?? null,
            'pDai_dien2' => $paramObj->pDai_dien2 ?? null,
            'pDai_dien3' => $paramObj->pDai_dien3 ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pT_sl_ton' => $paramObj->pT_sl_ton ?? null,
            'pT_sl_kk' => $paramObj->pT_sl_kk ?? null,
            'pT_sl_cl' => $paramObj->pT_sl_cl ?? null,
            'pT_tien_ss' => $paramObj->pT_tien_ss ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pPost2gl' => $paramObj->pPost2gl ?? null,
            'pPost2in' => $paramObj->pPost2in ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINUpdPH9 with named parameters
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
