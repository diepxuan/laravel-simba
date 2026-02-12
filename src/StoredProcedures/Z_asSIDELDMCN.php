<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_asSIDELDMCN
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asSIDELDMCN', [
            'pmenuid'      => $params['pmenuid'] ?? null,
            'pmoduleid'    => $params['pmoduleid'] ?? null,
            'pbar'         => $params['pbar'] ?? null,
            'pbarenUS'     => $params['pbarenUS'] ?? null,
            'pdllName'     => $params['pdllName'] ?? null,
            'pcommand'     => $params['pcommand'] ?? null,
            'pcode_name'   => $params['pcode_name'] ?? null,
            'preport'      => $params['preport'] ?? null,
            'pbasicright'  => $params['pbasicright'] ?? null,
            'pform'        => $params['pform'] ?? null,
            'popt'         => $params['popt'] ?? null,
            'ppar1'        => $params['ppar1'] ?? null,
            'ppar2'        => $params['ppar2'] ?? null,
            'ppar3'        => $params['ppar3'] ?? null,
            'ppar4'        => $params['ppar4'] ?? null,
            'ppar5'        => $params['ppar5'] ?? null,
            'ppar6'        => $params['ppar6'] ?? null,
            'ppar7'        => $params['ppar7'] ?? null,
            'ppar8'        => $params['ppar8'] ?? null,
            'ppicture1'    => $params['ppicture1'] ?? null,
            'ppicture2'    => $params['ppicture2'] ?? null,
            'pdeveloper'   => $params['pdeveloper'] ?? null,
            'pmaintainer'  => $params['pmaintainer'] ?? null,
            'pstt'         => $params['pstt'] ?? null,
            'pused'        => $params['pused'] ?? null,
            'prowid'       => $params['prowid'] ?? null,
            'pactive'      => $params['pactive'] ?? null,
            'pRet'         => $params['pRet'] ?? null,
        ], $connection);
    }
}