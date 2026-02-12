<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGetInforNVL
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetInforNVL', [
            'pSo_lich_sx'  => $params['pSo_lich_sx'] ?? null,
            'pMa_vt'  => $params['pMa_vt'] ?? null,
            'pNgay'  => $params['pNgay'] ?? null,
        ], $connection);
    }
}