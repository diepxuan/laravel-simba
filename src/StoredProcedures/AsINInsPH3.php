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

class AsINInsPH3
{
    /**
     * Call stored procedure asINInsPH3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsPH3', $params, $connection);
    }

    /**
     * Call stored procedure asINInsPH3 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_gd
     * @param string $Ngay_ct
     * @param string $Ngay_lct
     * @param string $So_ct
     * @param string $so_pn
     * @param string $Ma_kh
     * @param string $Ten_kh
     * @param string $Dia_chi
     * @param string $Nguoi_gd
     * @param string $Dien_giai
     * @param string $Ma_nx
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien_nt
     * @param float $T_tien
     * @param float $T_so_luong
     * @param bool $PX_GDD
     * @param string $Trang_thai
     * @param bool $Post2gl
     * @param bool $Post2in
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_gd = null, string $Ngay_ct = null, string $Ngay_lct = null, string $So_ct = null, string $so_pn = null, string $Ma_kh = null, string $Ten_kh = null, string $Dia_chi = null, string $Nguoi_gd = null, string $Dien_giai = null, string $Ma_nx = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien_nt = null, float $T_tien = null, float $T_so_luong = null, bool $PX_GDD = null, string $Trang_thai = null, bool $Post2gl = null, bool $Post2in = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_gd' => $Ma_gd,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_lct' => $Ngay_lct,
            'pSo_ct' => $So_ct,
            'pso_pn' => $so_pn,
            'pMa_kh' => $Ma_kh,
            'pTen_kh' => $Ten_kh,
            'pDia_chi' => $Dia_chi,
            'pNguoi_gd' => $Nguoi_gd,
            'pDien_giai' => $Dien_giai,
            'pMa_nx' => $Ma_nx,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien_nt' => $T_tien_nt,
            'pT_tien' => $T_tien,
            'pT_so_luong' => $T_so_luong,
            'pPX_GDD' => $PX_GDD,
            'pTrang_thai' => $Trang_thai,
            'pPost2gl' => $Post2gl,
            'pPost2in' => $Post2in,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
