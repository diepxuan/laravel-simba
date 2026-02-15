<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSaGetbangluong
{
    /**
     * Call stored procedure asSaGetbangluong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSaGetbangluong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pId_nv' => $params['pId_nv'] ?? null,
            'pMa_nv' => $params['pMa_nv'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSaGetbangluong with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_bp
     * @param string $Id_nv
     * @param string $Ma_nv
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_bp = null, string $Id_nv = null, string $Ma_nv = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_bp' => $Ma_bp,
            'pId_nv' => $Id_nv,
            'pMa_nv' => $Ma_nv
        ];
        
        return self::call($params);
    }
}
