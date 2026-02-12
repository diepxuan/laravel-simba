<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:28:46
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOChkRightStatusPO4
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOChkRightStatusPO4', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pStt_rec' => $params['pStt_rec'] ?? '',
            'pLanguage' => $params['pLanguage'] ?? ''
        ], $connection);
    }
}
