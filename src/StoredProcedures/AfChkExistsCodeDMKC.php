<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:14:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AfChkExistsCodeDMKC
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('afChkExistsCodeDMKC', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pMa_ct'  => $params['pMa_ct'] ?? '',
            'pTk'     => $params['pTk'] ?? '',
            'pTk_du'  => $params['pTk_du'] ?? '',
        ], $connection);
    }
}
