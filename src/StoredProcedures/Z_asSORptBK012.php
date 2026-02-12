<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_asSORptBK012
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asSORptBK012', [
            'pMa_cty'    => $params['pMa_cty'] ?? null,
            'pNgay1'     => $params['pNgay1'] ?? null,
            'pNgay2'     => $params['pNgay2'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? '',
            'pMa_kh'     => $params['pMa_kh'] ?? '',
            'pMa_nhkh'   => $params['pMa_nhkh'] ?? '',
            'pMa_vt'     => $params['pMa_vt'] ?? '',
            'pMa_nhvt'   => $params['pMa_nhvt'] ?? '',
            'pMa_kho'    => $params['pMa_kho'] ?? '',
            'pMa_bp'     => $params['pMa_bp'] ?? '',
            'pMa_nvkd'   => $params['pMa_nvkd'] ?? '',
            'pMa_hd'     => $params['pMa_hd'] ?? '',
            'pMa_nhhd'   => $params['pMa_nhhd'] ?? '',
            'pMa_nt'     => $params['pMa_nt'] ?? '',
            'pSoct1'     => $params['pSoct1'] ?? '',
            'pSoct2'     => $params['pSoct2'] ?? '',
            'pMa_plkh1'  => $params['pMa_plkh1'] ?? '',
            'pMa_plkh2'  => $params['pMa_plkh2'] ?? '',
            'pMa_plkh3'  => $params['pMa_plkh3'] ?? '',
            'pMa_plvt1'  => $params['pMa_plvt1'] ?? '',
            'pMa_plvt2'  => $params['pMa_plvt2'] ?? '',
            'pMa_plvt3'  => $params['pMa_plvt3'] ?? '',
        ], $connection);
    }
}