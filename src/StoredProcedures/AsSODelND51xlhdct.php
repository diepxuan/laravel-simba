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

class AsSODelND51xlhdct
{
    /**
     * Call stored procedure asSODelND51xlhdct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSODelND51xlhdct', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tb' => $params['pMa_tb'] ?? null,
            'pKieu_xl' => $params['pKieu_xl'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSODelND51xlhdct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tb
     * @param string $Kieu_xl
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tb = null, string $Kieu_xl = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tb' => $Ma_tb,
            'pKieu_xl' => $Kieu_xl,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
