<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARRptF5BCCN04
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptF5BCCN04', [
            'Ma_cty' => $params['pMa_cty'] ?? $params['Ma_cty'] ?? null,
            'Tk' => $params['pTk'] ?? $params['Tk'] ?? null,
            'Ma_kh' => $params['pMa_kh'] ?? $params['Ma_kh'] ?? null,
            'Ma_loai' => $params['pMa_loai'] ?? $params['Ma_loai'] ?? null,
            'Ma' => $params['pMa'] ?? $params['Ma'] ?? null,
            'Ngay1' => $params['pNgay1'] ?? $params['Ngay1'] ?? null,
            'Ngay2' => $params['pNgay2'] ?? $params['Ngay2'] ?? null,
            'Ma_nt' => $params['pMa_nt'] ?? $params['Ma_nt'] ?? null,
            'pMa_hd' => $params['pPMa_hd'] ?? $params['pMa_hd'] ?? null,
            'pMa_bp' => $params['pPMa_bp'] ?? $params['pMa_bp'] ?? null,
        ], $connection);
    }
}
