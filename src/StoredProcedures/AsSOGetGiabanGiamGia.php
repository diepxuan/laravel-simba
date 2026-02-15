<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOGetGiabanGiamGia
{
    /**
     * Call stored procedure asSOGetGiabanGiamGia
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetGiabanGiamGia', $params, $connection);
    }

    /**
     * Call stored procedure asSOGetGiabanGiamGia with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vt
     * @param string $Ma_kh
     * @param string $Ma_nt
     * @param float $So_luong
     * @param string $Tl_gt
     * @param float $Gg
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vt = null, string $Ma_kh = null, string $Ma_nt = null, float $So_luong = null, string $Tl_gt = null, float $Gg = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vt' => $Ma_vt,
            'pMa_kh' => $Ma_kh,
            'pMa_nt' => $Ma_nt,
            'pSo_luong' => $So_luong,
            'pTl_gt' => $Tl_gt,
            'pGg' => $Gg
        ];
        
        return self::call($params);
    }
}
