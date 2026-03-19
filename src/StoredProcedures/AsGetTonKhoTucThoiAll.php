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
use Diepxuan\Simba\Helper\ParamHelper;

class AsGetTonKhoTucThoiAll
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetTonKhoTucThoiAll', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pNgay_Ct' => $paramObj->pNgay_Ct ?? null,
            'pOn_hand' => $paramObj->pOn_hand ?? null,
            'pOn_hand_all' => $paramObj->pOn_hand_all ?? null,
            'pOn_so' => $paramObj->pOn_so ?? null,
            'pOn_so_all' => $paramObj->pOn_so_all ?? null,
            'pOn_po' => $paramObj->pOn_po ?? null,
            'pOn_po_all' => $paramObj->pOn_po_all ?? null
        ], $connection);
    }
}
