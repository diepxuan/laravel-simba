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
use Diepxuan\Simba\Helper\ParamHelper;

class Z_SIInsDMCN
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_SIInsDMCN', [
            'pmenuid'      => $paramObj->pmenuid ?? '',
            'pmoduleid'    => $paramObj->pmoduleid ?? '',
            'pbar'         => $paramObj->pbar ?? '',
            'pbarenUS'     => $paramObj->pbarenUS ?? '',
            'pdllName'     => $paramObj->pdllName ?? '',
            'pcommand'     => $paramObj->pcommand ?? '',
            'pcode_name'   => $paramObj->pcode_name ?? '',
            'preport'      => $paramObj->preport ?? false,
            'pbasicright'  => $paramObj->pbasicright ?? false,
            'pform'        => $paramObj->pform ?? false,
            'popt'         => $paramObj->popt ?? '',
            'ppar1'        => $paramObj->ppar1 ?? '',
            'ppar2'        => $paramObj->ppar2 ?? '',
            'ppar3'        => $paramObj->ppar3 ?? '',
            'ppar4'        => $paramObj->ppar4 ?? '',
            'ppar5'        => $paramObj->ppar5 ?? '',
            'ppar6'        => $paramObj->ppar6 ?? '',
            'ppar7'        => $paramObj->ppar7 ?? '',
            'ppar8'        => $paramObj->ppar8 ?? '',
            'pstt'         => $paramObj->pstt ?? '',
            'ppicture1'    => $paramObj->ppicture1 ?? '',
            'ppicture2'    => $paramObj->ppicture2 ?? '',
            'pdeveloper'   => $paramObj->pdeveloper ?? '',
            'pmaintainer'  => $paramObj->pmaintainer ?? '',
            'pused'        => $paramObj->pused ?? false,
            'prowid'       => $paramObj->prowid ?? 0,
            'pactive'      => $paramObj->pactive ?? false,
        ], $connection);
    }
}