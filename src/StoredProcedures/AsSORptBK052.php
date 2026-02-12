<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 00:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptBK052
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBK052', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pNgay1'  => $params['pNgay1'] ?? null,
            'pNgay2'  => $params['pNgay2'] ?? null,
            'pMa_kh'  => $params['pMa_kh'] ?? null,
            'pMa_nhkh'  => $params['pMa_nhkh'] ?? null,
            'pMa_vt'  => $params['pMa_vt'] ?? null,
            'pMa_nhvt'  => $params['pMa_nhvt'] ?? null,
            'pTK_VT'  => $params['pTK_VT'] ?? null,
            'pMa_kho'  => $params['pMa_kho'] ?? null,
            'pMa_bp'  => $params['pMa_bp'] ?? null,
            'pMa_nvkd'  => $params['pMa_nvkd'] ?? null,
            'pMa_nt'  => $params['pMa_nt'] ?? null,
            'pMa_hd'  => $params['pMa_hd'] ?? null,
            'pMa_Nhhd'  => $params['pMa_Nhhd'] ?? null,
            'pSo_DH'  => $params['pSo_DH'] ?? null,
            'pSoct1'  => $params['pSoct1'] ?? null,
            'pSoct2'  => $params['pSoct2'] ?? null,
            'pMa_plkh1'  => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2'  => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3'  => $params['pMa_plkh3'] ?? null,
            'pMa_plvt1'  => $params['pMa_plvt1'] ?? null,
            'pMa_plvt2'  => $params['pMa_plvt2'] ?? null,
            'pMa_plvt3'  => $params['pMa_plvt3'] ?? null,
        ], $connection);
    }
}
