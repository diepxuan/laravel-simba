<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:22:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrDelQTDanhGiaCT
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelQTDanhGiaCT', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pId' => $paramObj->pId ?? '',
            'pId_qtdg' => $paramObj->pId_qtdg ?? '',
            'pMa_tcdg' => $paramObj->pMa_tcdg ?? '',
            'pRet' => $paramObj->pRet ?? ''
        ], $connection);
    }
}
