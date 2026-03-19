<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSiAutoBackupData
{
    /**
     * Call stored procedure asSiAutoBackupData
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiAutoBackupData', [
            'pLocalDB' => $paramObj->pLocalDB ?? null,
            'pDbName' => $paramObj->pDbName ?? null,
            'pSysName' => $paramObj->pSysName ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiAutoBackupData with named parameters
     *
     * @param mixed $LocalDB
     * @param mixed $DbName
     * @param mixed $SysName
     * @return Collection
     */
    public static function callWithParams(mixed $LocalDB = null, mixed $DbName = null, mixed $SysName = null): Collection
    {
        $params = [
            'pLocalDB' => $LocalDB,
            'pDbName' => $DbName,
            'pSysName' => $SysName
        ];

        return self::call($params);
    }
}
