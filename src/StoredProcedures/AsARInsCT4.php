<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARInsCT4
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsCT4', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pStt_rec'      => $params['pStt_rec'] ?? null,
            'pStt_rec0'     => $params['pStt_rec0'] ?? null,
            'pTk'           => $params['pTk'] ?? null,
            'pMa_nt'        => $params['pMa_nt'] ?? null,
            'pTy_gia'       => $params['pTy_gia'] ?? null,
            'pMa_kh'        => $params['pMa_kh'] ?? null,
            'pDien_giai'    => $params['pDien_giai'] ?? null,
            'pPs_co'        => $params['pPs_co'] ?? null,
            'pPs_co_nt'     => $params['pPs_co_nt'] ?? null,
            'pPs_no'        => $params['pPs_no'] ?? null,
            'pPs_no_nt'     => $params['pPs_no_nt'] ?? null,
            'pNh_dk'        => $params['pNh_dk'] ?? null,
            'pMa_bp'        => $params['pMa_bp'] ?? null,
            'pMa_phi'       => $params['pMa_phi'] ?? null,
            'pMa_hd'        => $params['pMa_hd'] ?? null,
            'pMa_spct'      => $params['pMa_spct'] ?? null,
            'pMa_lo'        => $params['pMa_lo'] ?? null,
        ], $connection);
    }
}