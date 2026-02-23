<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLRptNKC03
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptNKC03', [
            'pMa_Cty'    => $params['pMa_Cty'] ?? SModel::CTY,
            'pNgay_Ct1'  => $params['pNgay_Ct1'] ?? '',
            'pNgay_Ct2'  => $params['pNgay_Ct2'] ?? '',
            'pTk_List'   => $params['pTk_List'] ?? '111,112',
            'pTkdu_List' => $params['pTkdu_List'] ?? '',
            'pMa_Bp'     => $params['pMa_Bp'] ?? '',
            'pMa_Nt'     => $params['pMa_Nt'] ?? 'VND',
        ], $connection);
    }
}
