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

class AsINRptF5CD05
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptF5CD05', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pMa_vt' => $params['pMa_vt'] ?? '',
            'pMa_kho' => $params['pMa_kho'] ?? '',
            'pMa_vitri' => $params['pMa_vitri'] ?? '',
            'pTk_vt' => $params['pTk_vt'] ?? '',
            'pMa_nhvt' => $params['pMa_nhvt'] ?? '',
            'pNgay' => $params['pNgay'] ?? '',
            'pMa_nt' => $params['pMa_nt'] ?? '',
            'pdvt' => $params['pdvt'] ?? '',
            'pMa_lo' => $params['pMa_lo'] ?? ''
        ], $connection);
    }
}
