<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:21
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIDelDMHTTT
{
    /**
     * Call stored procedure asSIDelDMHTTT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIDelDMHTTT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_httt' => $params['pMa_httt'] ?? null,
            'pModuleid' => $params['pModuleid'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIDelDMHTTT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_httt
     * @param string $Moduleid
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_httt = null, string $Moduleid = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_httt' => $Ma_httt,
            'pModuleid' => $Moduleid,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
