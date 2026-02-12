<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:22:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdDmNhomDanhGiaCT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmNhomDanhGiaCT', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pMa_nhdg' => $params['pMa_nhdg'] ?? '',
            'pMa_tcdg' => $params['pMa_tcdg'] ?? '',
            'pTen_tcdg' => $params['pTen_tcdg'] ?? '',
            'pDiem_toi_da' => $params['pDiem_toi_da'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
