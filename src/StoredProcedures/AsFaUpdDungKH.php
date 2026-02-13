<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsFaUpdDungKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaUpdDungKH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ts' => $params['pMa_ts'] ?? null,
            'pNgay_dung_kh' => $params['pNgay_dung_kh'] ?? null,
            'pNgay_kh_lai' => $params['pNgay_kh_lai'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
