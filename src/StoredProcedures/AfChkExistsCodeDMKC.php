<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:15:54
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AfChkExistsCodeDMKC
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('afChkExistsCodeDMKC', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pMa_ct'  => $paramObj->pMa_ct ?? '',
            'pTk'     => $paramObj->pTk ?? '',
            'pTk_du'  => $paramObj->pTk_du ?? '',
        ], $connection);
    }
}
