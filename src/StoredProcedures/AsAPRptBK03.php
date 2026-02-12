<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:04:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPRptBK03
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPRptBK03', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pNgay1'    => $params['pNgay1'] ?? null,
            'pNgay2'    => $params['pNgay2'] ?? null,
            'pMa_gd'    => $params['pMa_gd'] ?? '',
            'pSoct1'    => $params['pSoct1'] ?? '',
            'pSoct2'    => $params['pSoct2'] ?? '',
            'pMa_kh'    => $params['pMa_kh'] ?? '',
            'pMa_nhkh'  => $params['pMa_nhkh'] ?? '',
            'pMa_plkh1' => $params['pMa_plkh1'] ?? '',
            'pMa_plkh2' => $params['pMa_plkh2'] ?? '',
            'pMa_plkh3' => $params['pMa_plkh3'] ?? '',
            'pSap_xep'  => $params['pSap_xep'] ?? '',
            'pTat_toan' => $params['pTat_toan'] ?? '',
            'pMa_NT'    => $params['pMa_NT'] ?? '',
        ], $connection);
    }
}
