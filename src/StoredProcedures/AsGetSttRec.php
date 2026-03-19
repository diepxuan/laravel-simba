<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-18 23:42:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGetSttRec
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        $result = ProcedureCaller::call('asGetSttRec', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_ct'   => $params['pMa_ct'] ?? null,
            'pStt_rec' => ['type' => 'NVARCHAR(20)', 'output' => true],
        ], $connection);

        \Debugbar::info('AsGetSttRec ProcedureCaller result:', $result);
        \Debugbar::info('AsGetSttRec input params:', $params);

        return $result;
    }
}
