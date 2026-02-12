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

class AsSaKhoaMoBL
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSaKhoaMoBL', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pKhoa' => $params['pKhoa'] ?? null,
            'pMatKhau1' => $params['pMatKhau1'] ?? null,
            'pMatKhau2' => $params['pMatKhau2'] ?? null,
            'pRet' => $params['pRet'] ?? null,
        ], $connection);
    }
}
