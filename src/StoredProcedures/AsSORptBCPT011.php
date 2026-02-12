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

class AsSORptBCPT011
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBCPT011', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pNgay1' => $params['pNgay1'] ?? '',
            'pNgay2' => $params['pNgay2'] ?? '',
            'pSoct1' => $params['pSoct1'] ?? '',
            'pSoct2' => $params['pSoct2'] ?? '',
            'pMa_kh' => $params['pMa_kh'] ?? '',
            'pMa_nhkh' => $params['pMa_nhkh'] ?? '',
            'pMa_plkh1' => $params['pMa_plkh1'] ?? '',
            'pMa_plkh2' => $params['pMa_plkh2'] ?? '',
            'pMa_plkh3' => $params['pMa_plkh3'] ?? '',
            'pMa_hd' => $params['pMa_hd'] ?? '',
            'pMa_nhhd' => $params['pMa_nhhd'] ?? '',
            'pMa_NT' => $params['pMa_NT'] ?? '',
            'pMa_vt' => $params['pMa_vt'] ?? '',
            'pMa_nhvt' => $params['pMa_nhvt'] ?? '',
            'pMa_plvt1' => $params['pMa_plvt1'] ?? '',
            'pMa_plvt2' => $params['pMa_plvt2'] ?? '',
            'pMa_plvt3' => $params['pMa_plvt3'] ?? '',
            'pMa_bp' => $params['pMa_bp'] ?? '',
            'pMa_nvkd' => $params['pMa_nvkd'] ?? '',
            'pMa_TT' => $params['pMa_TT'] ?? '',
            'pStatus' => $params['pStatus'] ?? ''
        ], $connection);
    }
}
