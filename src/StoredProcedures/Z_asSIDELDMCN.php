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
use Diepxuan\Simba\Helper\ParamHelper;

class Z_asSIDELDMCN
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asSIDELDMCN', [
            'pmenuid'      => $paramObj->pmenuid ?? null,
            'pmoduleid'    => $paramObj->pmoduleid ?? null,
            'pbar'         => $paramObj->pbar ?? null,
            'pbarenUS'     => $paramObj->pbarenUS ?? null,
            'pdllName'     => $paramObj->pdllName ?? null,
            'pcommand'     => $paramObj->pcommand ?? null,
            'pcode_name'   => $paramObj->pcode_name ?? null,
            'preport'      => $paramObj->preport ?? null,
            'pbasicright'  => $paramObj->pbasicright ?? null,
            'pform'        => $paramObj->pform ?? null,
            'popt'         => $paramObj->popt ?? null,
            'ppar1'        => $paramObj->ppar1 ?? null,
            'ppar2'        => $paramObj->ppar2 ?? null,
            'ppar3'        => $paramObj->ppar3 ?? null,
            'ppar4'        => $paramObj->ppar4 ?? null,
            'ppar5'        => $paramObj->ppar5 ?? null,
            'ppar6'        => $paramObj->ppar6 ?? null,
            'ppar7'        => $paramObj->ppar7 ?? null,
            'ppar8'        => $paramObj->ppar8 ?? null,
            'ppicture1'    => $paramObj->ppicture1 ?? null,
            'ppicture2'    => $paramObj->ppicture2 ?? null,
            'pdeveloper'   => $paramObj->pdeveloper ?? null,
            'pmaintainer'  => $paramObj->pmaintainer ?? null,
            'pstt'         => $paramObj->pstt ?? null,
            'pused'        => $paramObj->pused ?? null,
            'prowid'       => $paramObj->prowid ?? null,
            'pactive'      => $paramObj->pactive ?? null,
            'pRet'         => $paramObj->pRet ?? null,
        ], $connection);
    }
}