<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:48:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARInsPh4
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsPh4', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pMa_ct'      => $params['pMa_ct'] ?? null,
            'pStt_rec'    => $params['pStt_rec'] ?? null,
            'pSo_ct'      => $params['pSo_ct'] ?? null,
            'pNgay_ct'    => $params['pNgay_ct'] ?? null,
            'pNgay_lct'   => $params['pNgay_lct'] ?? null,
            'pNt_ph'      => $params['pNt_ph'] ?? null,
            'pMa_nt'      => $params['pMa_nt'] ?? null,
            'pTy_gia'     => $params['pTy_gia'] ?? null,
            'pT_tien'     => $params['pT_tien'] ?? null,
            'pT_tien_nt'  => $params['pT_tien_nt'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pUser'       => $params['pUser'] ?? null,
        ], $connection);
    }
}
