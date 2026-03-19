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
use Diepxuan\Simba\Helper\ParamHelper;

class Zzz_asGLRptBCTCCDTb03
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('zzz_asGLRptBCTCCDTb03', [
            'pMa_cty'   => $paramObj->pMa_cty ?? '901',
            'pNgay1'    => $paramObj->pNgay1 ?? null,
            'pNgay2'    => $paramObj->pNgay2 ?? null,
            'pTk_xl'    => $paramObj->pTk_xl ?? '1541',
            'pTk_tb'    => $paramObj->pTk_tb ?? '1542',
            'pTk_bt'    => $paramObj->pTk_bt ?? '1542',
            'pTk_ql'    => $paramObj->pTk_ql ?? '1542',
            'pTk_tv'    => $paramObj->pTk_tv ?? '1542',
            'pTk_khac'  => $paramObj->pTk_khac ?? '1543',
            'pMa_spct'  => $paramObj->pMa_spct ?? '',
        ], $connection);
    }
}