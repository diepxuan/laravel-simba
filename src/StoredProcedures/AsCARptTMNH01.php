<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCARptTMNH01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCARptTMNH01', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? SModel::CTY,
            'pTk'       => $params['pTk'] ?? '111',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2015-10-01',
            'pNgay_ct2' => $params['pNgay_ct2'] ?? '2015-10-31',
            'pMa_Nt'    => $params['pMa_Nt'] ?? '',
        ], $connection);
    }
}
