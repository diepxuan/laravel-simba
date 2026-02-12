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

class AsINRptCTVT02_crys
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCTVT02_crys', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pNgay1'  => $params['pNgay1'] ?? null,
            'pNgay2'  => $params['pNgay2'] ?? null,
            'pXml'  => $params['pXml'] ?? null,
            'pMa_vt'  => $params['pMa_vt'] ?? null,
            'pMa_kho'  => $params['pMa_kho'] ?? null,
            'pMa_vitri'  => $params['pMa_vitri'] ?? null,
            'pMau_bc'  => $params['pMau_bc'] ?? null,
            'pMa_nt'  => $params['pMa_nt'] ?? null,
            'pSysMsg1'  => $params['pSysMsg1'] ?? null,
            'pSysMsg2'  => $params['pSysMsg2'] ?? null,
            'pSysMsg3'  => $params['pSysMsg3'] ?? null,
            'pma_vt'  => $params['pma_vt'] ?? null,
        ], $connection);
    }
}