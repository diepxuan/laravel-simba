<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsFaDelDungKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaDelDungKH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_Ts' => $params['pMa_Ts'] ?? null,
            'pNgay_dung_kh' => $params['pNgay_dung_kh'] ?? null,
            'pRet' => $params['pRet'] ?? null,
        ], $connection);
    }
}
