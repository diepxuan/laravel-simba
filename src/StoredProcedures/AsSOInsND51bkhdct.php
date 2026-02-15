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

class AsSOInsND51bkhdct
{
    /**
     * Call stored procedure asSOInsND51bkhdct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51bkhdct', $params, $connection);
    }

    /**
     * Call stored procedure asSOInsND51bkhdct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tb
     * @param string $Ma_ph
     * @param string $Mau_so
     * @param bool $Loai
     * @param string $So_seri
     * @param string $Ten_loai
     * @param string $Tu_so
     * @param string $Den_so
     * @param string $So_luong
     * @param string $So_hdin
     * @param string $So_hdph
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tb = null, string $Ma_ph = null, string $Mau_so = null, bool $Loai = null, string $So_seri = null, string $Ten_loai = null, string $Tu_so = null, string $Den_so = null, string $So_luong = null, string $So_hdin = null, string $So_hdph = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tb' => $Ma_tb,
            'pMa_ph' => $Ma_ph,
            'pMau_so' => $Mau_so,
            'pLoai' => $Loai,
            'pSo_seri' => $So_seri,
            'pTen_loai' => $Ten_loai,
            'pTu_so' => $Tu_so,
            'pDen_so' => $Den_so,
            'pSo_luong' => $So_luong,
            'pSo_hdin' => $So_hdin,
            'pSo_hdph' => $So_hdph,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
