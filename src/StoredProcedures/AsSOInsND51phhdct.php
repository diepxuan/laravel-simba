<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsND51phhdct
{
    /**
     * Call stored procedure asSOInsND51phhdct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51phhdct', $params, $connection);
    }

    /**
     * Call stored procedure asSOInsND51phhdct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tb
     * @param string $Mau_so
     * @param string $Ma_loai
     * @param string $So_seri
     * @param string $So_hd
     * @param string $Tu_so
     * @param string $Den_so
     * @param string $So_luong
     * @param string $Ngay_sd
     * @param string $Donvi_in
     * @param string $Ma_thuedvi
     * @param string $Ngay_in
     * @param string $Ten_loai
     * @param bool $Isclose
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tb = null, string $Mau_so = null, string $Ma_loai = null, string $So_seri = null, string $So_hd = null, string $Tu_so = null, string $Den_so = null, string $So_luong = null, string $Ngay_sd = null, string $Donvi_in = null, string $Ma_thuedvi = null, string $Ngay_in = null, string $Ten_loai = null, bool $Isclose = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tb' => $Ma_tb,
            'pMau_so' => $Mau_so,
            'pMa_loai' => $Ma_loai,
            'pSo_seri' => $So_seri,
            'pSo_hd' => $So_hd,
            'pTu_so' => $Tu_so,
            'pDen_so' => $Den_so,
            'pSo_luong' => $So_luong,
            'pNgay_sd' => $Ngay_sd,
            'pDonvi_in' => $Donvi_in,
            'pMa_thuedvi' => $Ma_thuedvi,
            'pNgay_in' => $Ngay_in,
            'pTen_loai' => $Ten_loai,
            'pIsclose' => $Isclose,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
