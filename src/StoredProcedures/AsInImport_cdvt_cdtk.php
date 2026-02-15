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

class AsInImport_cdvt_cdtk
{
    /**
     * Call stored procedure asInImport_cdvt_cdtk
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInImport_cdvt_cdtk', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInImport_cdvt_cdtk with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
