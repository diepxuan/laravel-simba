<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIMaintain05
{
    /**
     * Call stored procedure asSIMaintain05
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIMaintain05', $params, $connection);
    }

    /**
     * Call stored procedure asSIMaintain05 with named parameters
     *
     * @param string $Path
     * @param string $DBData
     * @param string $DBSys
     * @param string $PathData
     * @param string $PathSys
     * @return Collection
     */
    public static function callWithParams(string $Path = null, string $DBData = null, string $DBSys = null, string $PathData = null, string $PathSys = null): Collection
    {
        $params = [
            'pPath' => $Path,
            'pDBData' => $DBData,
            'pDBSys' => $DBSys,
            'pPathData' => $PathData,
            'pPathSys' => $PathSys
        ];
        
        return self::call($params);
    }
}
