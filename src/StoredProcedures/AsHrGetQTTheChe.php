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

class AsHrGetQTTheChe
{
    /**
     * Call stored procedure asHrGetQTTheChe
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetQTTheChe', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qttc' => $params['pId_qttc'] ?? null,
            'pMa_the_che' => $params['pMa_the_che'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetQTTheChe with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qttc
     * @param string $Ma_the_che
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qttc = null, string $Ma_the_che = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qttc' => $Id_qttc,
            'pMa_the_che' => $Ma_the_che
        ];
        
        return self::call($params);
    }
}
