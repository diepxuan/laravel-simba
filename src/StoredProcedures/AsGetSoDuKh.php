<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-01-12 00:14:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGetSoDuKh
{
    public static function call(array $params): float
    {
        $connection = (new SModel())->getConnectionName();

        $result = ProcedureCaller::call('asGetSoDuKh', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_kh'  => $params['pMa_kh'] ?? null,
            'pNgay'   => $params['pNgay'] ?? null,
            'pTk'     => $params['pTk'] ?? null,
        ], $connection);

        if ($result instanceof Collection && $result->isNotEmpty()) {
            $firstItem = $result->first();
            if (is_object($firstItem) && property_exists($firstItem, 'SoDu')) {
                return (float) $firstItem->SoDu;
            } elseif (is_array($firstItem) && isset($firstItem['SoDu'])) {
                return (float) $firstItem['SoDu'];
            }
        }

        return 0.0;
    }
}
