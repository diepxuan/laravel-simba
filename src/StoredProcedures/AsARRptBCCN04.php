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

class AsARRptBCCN04
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN04', [
            'ma_cty' => $params['pMa_cty'] ?? $params['ma_cty'] ?? null,
            'Ngay1' => $params['pNgay1'] ?? $params['Ngay1'] ?? null,
            'Ngay2' => $params['pNgay2'] ?? $params['Ngay2'] ?? null,
            'Tk' => $params['pTk'] ?? $params['Tk'] ?? null,
            'pGroup' => $params['pPGroup'] ?? $params['pGroup'] ?? null,
            'pDetail' => $params['pPDetail'] ?? $params['pDetail'] ?? null,
            'ma_hd' => $params['pMa_hd'] ?? $params['ma_hd'] ?? null,
            'ma_kh' => $params['pMa_kh'] ?? $params['ma_kh'] ?? null,
            'ma_plkh1' => $params['pMa_plkh1'] ?? $params['ma_plkh1'] ?? null,
            'ma_plkh2' => $params['pMa_plkh2'] ?? $params['ma_plkh2'] ?? null,
            'ma_plkh3' => $params['pMa_plkh3'] ?? $params['ma_plkh3'] ?? null,
            'pMa_BP' => $params['pPMa_BP'] ?? $params['pMa_BP'] ?? null,
            'pMa_NVKD' => $params['pPMa_NVKD'] ?? $params['pMa_NVKD'] ?? null,
            'pMa_SPCT' => $params['pPMa_SPCT'] ?? $params['pMa_SPCT'] ?? null,
            'ma_nt' => $params['pMa_nt'] ?? $params['ma_nt'] ?? null,
        ], $connection);
    }
}
