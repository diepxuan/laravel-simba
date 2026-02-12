<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:58:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARRptBCCN01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN01', [
            'ma_cty' => $params['pMa_cty'] ?? $params['ma_cty'] ?? 'GBB',
            'Ngay1'  => $params['pNgay1'] ?? $params['Ngay1'] ?? '2013-01-01',
            'Ngay2'  => $params['pNgay2'] ?? $params['Ngay2'] ?? '2013-01-01',
            'Tk'     => $params['pTk'] ?? $params['Tk'] ?? '1368',
            'ma_kh'  => $params['pMa_kh'] ?? $params['ma_kh'] ?? '00000177',
            'ma_nt'  => $params['pMa_nt'] ?? $params['ma_nt'] ?? '',
        ], $connection);
    }
}
