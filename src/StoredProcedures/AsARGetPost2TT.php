<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARGetPost2TT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetPost2TT', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pLoai_ct'    => $params['pLoai_ct'] ?? null,
            'pSo1'        => $params['pSo1'] ?? null,
            'pSo2'        => $params['pSo2'] ?? null,
            'pNgay1'      => $params['pNgay1'] ?? null,
            'pNgay2'      => $params['pNgay2'] ?? null,
            'pMa_kh'      => $params['pMa_kh'] ?? null,
            'pTk'         => $params['pTk'] ?? null,
            'pDien_giai'  => $params['pDien_giai'] ?? null,
        ], $connection);
    }
}