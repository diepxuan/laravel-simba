<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInCalGiaFIFO
{
    /**
     * Call stored procedure asInCalGiaFIFO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInCalGiaFIFO', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pNhom_vt' => $params['pNhom_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'px_gdd' => $params['px_gdd'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInCalGiaFIFO with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_vt
     * @param string $Nhom_vt
     * @param string $Ma_kho
     * @param string $x_gdd
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_vt = null, string $Nhom_vt = null, string $Ma_kho = null, string $x_gdd = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_vt' => $Ma_vt,
            'pNhom_vt' => $Nhom_vt,
            'pMa_kho' => $Ma_kho,
            'px_gdd' => $x_gdd
        ];
        
        return self::call($params);
    }
}
