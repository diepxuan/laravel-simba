<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:59
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSaRptPhieuLuong
{
    /**
     * Call stored procedure asSaRptPhieuLuong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSaRptPhieuLuong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_nv' => $params['pMa_nv'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSaRptPhieuLuong with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_bp
     * @param string $Ma_nv
     * @param mixed $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_bp = null, string $Ma_nv = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_bp' => $Ma_bp,
            'pMa_nv' => $Ma_nv,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
