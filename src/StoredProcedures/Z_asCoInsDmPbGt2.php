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

class Z_asCoInsDmPbGt2
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asCoInsDmPbGt2', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pStt'        => $params['pStt'] ?? null,
            'pTen_bt'     => $params['pTen_bt'] ?? null,
            'pSo_ct'      => $params['pSo_ct'] ?? null,
            'pTk_no'      => $params['pTk_no'] ?? null,
            'pTk_co'      => $params['pTk_co'] ?? null,
            'pTk_lay_hs'  => $params['pTk_lay_hs'] ?? null,
            'pMa_pb'      => $params['pMa_pb'] ?? null,
            'pRet'        => $params['pRet'] ?? null,
        ], $connection);
    }
}