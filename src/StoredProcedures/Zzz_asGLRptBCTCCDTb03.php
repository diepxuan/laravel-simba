<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Zzz_asGLRptBCTCCDTb03
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('zzz_asGLRptBCTCCDTb03', [
            'pMa_cty'   => $params['pMa_cty'] ?? '901',
            'pNgay1'    => $params['pNgay1'] ?? null,
            'pNgay2'    => $params['pNgay2'] ?? null,
            'pTk_xl'    => $params['pTk_xl'] ?? '1541',
            'pTk_tb'    => $params['pTk_tb'] ?? '1542',
            'pTk_bt'    => $params['pTk_bt'] ?? '1542',
            'pTk_ql'    => $params['pTk_ql'] ?? '1542',
            'pTk_tv'    => $params['pTk_tv'] ?? '1542',
            'pTk_khac'  => $params['pTk_khac'] ?? '1543',
            'pMa_spct'  => $params['pMa_spct'] ?? '',
        ], $connection);
    }
}