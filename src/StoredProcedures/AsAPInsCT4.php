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

class AsAPInsCT4
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPInsCT4', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pStt_rec'    => $params['pStt_rec'] ?? null,
            'pStt_rec0'   => $params['pStt_rec0'] ?? null,
            'pTk'         => $params['pTk'] ?? null,
            'pMa_kh'      => $params['pMa_kh'] ?? null,
            'pDien_giai'  => $params['pDien_giai'] ?? '',
            'pMa_nt'      => $params['pMa_nt'] ?? null,
            'pTy_gia'     => $params['pTy_gia'] ?? 0.0,
            'pPs_co'      => $params['pPs_co'] ?? 0.0,
            'pPs_co_nt'   => $params['pPs_co_nt'] ?? 0.0,
            'pPs_no'      => $params['pPs_no'] ?? 0.0,
            'pPs_no_nt'   => $params['pPs_no_nt'] ?? 0.0,
            'pNh_dk'      => $params['pNh_dk'] ?? '',
            'pMa_lo'      => $params['pMa_lo'] ?? '',
            'pMa_bp'      => $params['pMa_bp'] ?? '',
            'pMa_hd'      => $params['pMa_hd'] ?? '',
            'pMa_phi'     => $params['pMa_phi'] ?? '',
            'pMa_spct'    => $params['pMa_spct'] ?? '',
        ], $connection);
    }
}
