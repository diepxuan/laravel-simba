<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:52:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARPhanBoThanhToan
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARPhanBoThanhToan', [
            'pMa_cty'   => $params['pMa_cty'] ?? '001',
            'pTk_pt'    => $params['pTk_pt'] ?? '131',
            'pMa_kh'    => $params['pMa_kh'] ?? '',
            'pNgay_ct1' => $params['pNgay_ct1'] ?? '20150401',
            'pNgay_ct2' => $params['pNgay_ct2'] ?? '20150630',
        ], $connection);
    }
}
