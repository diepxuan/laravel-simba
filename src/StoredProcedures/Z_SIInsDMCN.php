<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_SIInsDMCN
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_SIInsDMCN', [
            'pmenuid'      => $params['pmenuid'] ?? '',
            'pmoduleid'    => $params['pmoduleid'] ?? '',
            'pbar'         => $params['pbar'] ?? '',
            'pbarenUS'     => $params['pbarenUS'] ?? '',
            'pdllName'     => $params['pdllName'] ?? '',
            'pcommand'     => $params['pcommand'] ?? '',
            'pcode_name'   => $params['pcode_name'] ?? '',
            'preport'      => $params['preport'] ?? false,
            'pbasicright'  => $params['pbasicright'] ?? false,
            'pform'        => $params['pform'] ?? false,
            'popt'         => $params['popt'] ?? '',
            'ppar1'        => $params['ppar1'] ?? '',
            'ppar2'        => $params['ppar2'] ?? '',
            'ppar3'        => $params['ppar3'] ?? '',
            'ppar4'        => $params['ppar4'] ?? '',
            'ppar5'        => $params['ppar5'] ?? '',
            'ppar6'        => $params['ppar6'] ?? '',
            'ppar7'        => $params['ppar7'] ?? '',
            'ppar8'        => $params['ppar8'] ?? '',
            'pstt'         => $params['pstt'] ?? '',
            'ppicture1'    => $params['ppicture1'] ?? '',
            'ppicture2'    => $params['ppicture2'] ?? '',
            'pdeveloper'   => $params['pdeveloper'] ?? '',
            'pmaintainer'  => $params['pmaintainer'] ?? '',
            'pused'        => $params['pused'] ?? false,
            'prowid'       => $params['prowid'] ?? 0,
            'pactive'      => $params['pactive'] ?? false,
        ], $connection);
    }
}