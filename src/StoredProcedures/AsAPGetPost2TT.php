<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:04:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPGetPost2TT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPGetPost2TT', [
            'pMa_cty'    => $params['pMa_cty'] ?? null,
            'pLoai_ct'   => $params['pLoai_ct'] ?? '',
            'pSo1'       => $params['pSo1'] ?? '',
            'pSo2'       => $params['pSo2'] ?? '',
            'pNgay1'     => $params['pNgay1'] ?? null,
            'pNgay2'     => $params['pNgay2'] ?? null,
            'pMa_kh'     => $params['pMa_kh'] ?? '',
            'pTk'        => $params['pTk'] ?? '',
            'pDien_giai' => $params['pDien_giai'] ?? '',
        ], $connection);
    }
}
