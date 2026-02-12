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

class AsAPRptBK02
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPRptBK02', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pNgay1'    => $params['pNgay1'] ?? null,
            'pHan_Ky1'  => $params['pHan_Ky1'] ?? '',
            'pHan_Ky2'  => $params['pHan_Ky2'] ?? '',
            'pHan_Ky3'  => $params['pHan_Ky3'] ?? '',
            'pMa_NCC'   => $params['pMa_NCC'] ?? '',
            'pMa_NhNCC' => $params['pMa_NhNCC'] ?? '',
            'pSap_xep'  => $params['pSap_xep'] ?? '',
            'pTat_toan' => $params['pTat_toan'] ?? '',
            'pMa_nt'    => $params['pMa_nt'] ?? '',
        ], $connection);
    }
}
