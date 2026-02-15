<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetQTKNCongTac
{
    /**
     * Call stored procedure asHrGetQTKNCongTac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetQTKNCongTac', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtknct' => $params['pId_qtknct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetQTKNCongTac with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtknct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtknct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtknct' => $Id_qtknct
        ];
        
        return self::call($params);
    }
}
