<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGetTonKhoTucThoiAll
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetTonKhoTucThoiAll', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pNgay_Ct' => $params['pNgay_Ct'] ?? null,
            'pOn_hand' => $params['pOn_hand'] ?? null,
            'pOn_hand_all' => $params['pOn_hand_all'] ?? null,
            'pOn_so' => $params['pOn_so'] ?? null,
            'pOn_so_all' => $params['pOn_so_all'] ?? null,
            'pOn_po' => $params['pOn_po'] ?? null,
            'pOn_po_all' => $params['pOn_po_all'] ?? null
        ], $connection);
    }
}
