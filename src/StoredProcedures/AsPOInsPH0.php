<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOInsPH0
{
    /**
     * Call stored procedure asPOInsPH0
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOInsPH0', $params, $connection);
    }

    /**
     * Call stored procedure asPOInsPH0 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_bp
     * @param string $Nguoi_dn
     * @param string $Dien_giai
     * @param string $Ngay_ct
     * @param string $So_ct
     * @param string $Ngay_lct
     * @param string $Han_giao
     * @param float $T_so_luong
     * @param bool $Tao_tu_dhb
     * @param bool $Post2gl
     * @param string $Trang_thai
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_bp = null, string $Nguoi_dn = null, string $Dien_giai = null, string $Ngay_ct = null, string $So_ct = null, string $Ngay_lct = null, string $Han_giao = null, float $T_so_luong = null, bool $Tao_tu_dhb = null, bool $Post2gl = null, string $Trang_thai = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_bp' => $Ma_bp,
            'pNguoi_dn' => $Nguoi_dn,
            'pDien_giai' => $Dien_giai,
            'pNgay_ct' => $Ngay_ct,
            'pSo_ct' => $So_ct,
            'pNgay_lct' => $Ngay_lct,
            'pHan_giao' => $Han_giao,
            'pT_so_luong' => $T_so_luong,
            'pTao_tu_dhb' => $Tao_tu_dhb,
            'pPost2gl' => $Post2gl,
            'pTrang_thai' => $Trang_thai,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
