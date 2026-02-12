<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 00:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSysCopyDatabaseCompany
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSysCopyDatabaseCompany', [
            'SourceDB'  => $params['SourceDB'] ?? null,
            'DestDB'  => $params['DestDB'] ?? null,
            'Ma_CTy'  => $params['Ma_CTy'] ?? null,
        ], $connection);
    }
}
