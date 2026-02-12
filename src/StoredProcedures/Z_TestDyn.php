<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_TestDyn
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_TestDyn', [
            'pMa_cty'   => $params['pMa_cty'] ?? '',
            'pNgay1'    => $params['pNgay1'] ?? '',
            'pNgay2'    => $params['pNgay2'] ?? '',
            'pDien_giai' => $params['pDien_giai'] ?? '',
            'pMa_ts'    => $params['pMa_ts'] ?? '',
            'pMa_vt'    => $params['pMa_vt'] ?? '',
            'pMa_phi'   => $params['pMa_phi'] ?? '',
            'pMa_spct'  => $params['pMa_spct'] ?? '',
            'pTk'       => $params['pTk'] ?? '',
        ], $connection);
    }
}