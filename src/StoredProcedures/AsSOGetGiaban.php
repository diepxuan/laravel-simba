<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOGetGiaban
{
    /**
     * Call stored procedure asSOGetGiaban
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetGiaban', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pKieu_lay_gia' => $params['pKieu_lay_gia'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetGiaban with named parameters
     *
     * @param string $Ma_cty
     * @param string $Kieu_lay_gia
     * @param string $Ma_vt
     * @param string $Ma_nt
     * @param string $Ngay_ct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Kieu_lay_gia = null, string $Ma_vt = null, string $Ma_nt = null, string $Ngay_ct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pKieu_lay_gia' => $Kieu_lay_gia,
            'pMa_vt' => $Ma_vt,
            'pMa_nt' => $Ma_nt,
            'pNgay_ct' => $Ngay_ct
        ];
        
        return self::call($params);
    }
}
