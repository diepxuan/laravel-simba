<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:14:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLRptBCTCCR03
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCR03', [
            'pMa_Cty'    => $params['pMa_Cty'] ?? 'CR',
            'pNam'       => $params['pNam'] ?? 2013,
            'pNgay_Ct1'  => $params['pNgay_Ct1'] ?? '2013-01-01',
            'pNgay_Ct2'  => $params['pNgay_Ct2'] ?? '2013-01-31',
            'pNgay_Ct01' => $params['pNgay_Ct01'] ?? '2013-01-01',
            'pNgay_Ct02' => $params['pNgay_Ct02'] ?? '2013-01-31',
            'pMau'       => $params['pMau'] ?? '15',
            'pDest'      => $params['pDest'] ?? '',
        ], $connection);
    }
}
