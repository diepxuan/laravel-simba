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

class AsAPRptBK01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPRptBK01', [
            'pMa_cty'    => $params['pMa_cty'] ?? null,
            'pNgay1'     => $params['pNgay1'] ?? null,
            'pNgay2'     => $params['pNgay2'] ?? null,
            'pMa_kh'     => $params['pMa_kh'] ?? '',
            'pMa_vt'     => $params['pMa_vt'] ?? '',
            'pMa_nhvt'   => $params['pMa_nhvt'] ?? '',
            'pMa_kho'    => $params['pMa_kho'] ?? '',
            'pMa_lo'     => $params['pMa_lo'] ?? '',
            'pMa_phi'    => $params['pMa_phi'] ?? '',
            'pMa_spct'   => $params['pMa_spct'] ?? '',
            'pMa_bp'     => $params['pMa_bp'] ?? '',
            'pMa_nt'     => $params['pMa_nt'] ?? '',
            'pMa_hd'     => $params['pMa_hd'] ?? '',
            'pSo_PN'     => $params['pSo_PN'] ?? '',
            'pSoct1'     => $params['pSoct1'] ?? '',
            'pSoct2'     => $params['pSoct2'] ?? '',
            'pMa_plkh1'  => $params['pMa_plkh1'] ?? '',
            'pMa_plkh2'  => $params['pMa_plkh2'] ?? '',
            'pMa_plkh3'  => $params['pMa_plkh3'] ?? '',
        ], $connection);
    }
}
