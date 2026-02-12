<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:12:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLRptNKC01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptNKC01', [
            'pMa_Cty'        => $params['pMa_Cty'] ?? SModel::CTY,
            'pNgay_Ct1'      => $params['pNgay_Ct1'] ?? null,
            'pNgay_Ct2'      => $params['pNgay_Ct2'] ?? null,
            'pTk'            => $params['pTk'] ?? null,
            'pMa_Nt'         => $params['pMa_Nt'] ?? '',
            'pStt_dong_nkc'  => $params['pStt_dong_nkc'] ?? 1,
        ], $connection);
    }
}
