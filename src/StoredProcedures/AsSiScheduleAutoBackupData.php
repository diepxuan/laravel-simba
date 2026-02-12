<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiScheduleAutoBackupData
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiScheduleAutoBackupData', [
            'pLocalDB' => $params['pLocalDB'] ?? null,
            'pDbName' => $params['pDbName'] ?? null,
            'pSysName' => $params['pSysName'] ?? null,
            'pFreq_interval' => $params['pFreq_interval'] ?? null,
            'pActive_start_time' => $params['pActive_start_time'] ?? null,
        ], $connection);
    }
}
