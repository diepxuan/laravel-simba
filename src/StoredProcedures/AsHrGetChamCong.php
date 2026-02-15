<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetChamCong
{
    /**
     * Call stored procedure asHrGetChamCong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetChamCong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pId' => $params['pId'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetChamCong with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param int $Thang
     * @param string $Id
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, int $Thang = null, string $Id = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pThang' => $Thang,
            'pId' => $Id
        ];
        
        return self::call($params);
    }
}
