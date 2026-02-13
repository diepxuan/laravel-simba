<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCOInsDMNHSPCT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCOInsDMNHSPCT', [
            'pma_nhspct' => $params['pma_nhspct'] ?? null,
            'pten_nhspct' => $params['pten_nhspct'] ?? null,
            'pCap' => $params['pCap'] ?? null,
            'pStt_nhom' => $params['pStt_nhom'] ?? null,
            'pNhom_me' => $params['pNhom_me'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pCong_sl' => $params['pCong_sl'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
