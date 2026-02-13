<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLUpdMauCf1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMauCf1', [
            'pMau' => $params['pMau'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pQd_cdkt' => $params['pQd_cdkt'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pIn_ck' => $params['pIn_ck'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pTk_no' => $params['pTk_no'] ?? null,
            'pTk_co' => $params['pTk_co'] ?? null,
            'pDau' => $params['pDau'] ?? null,
            'pTm' => $params['pTm'] ?? null,
            'pLoai_ps' => $params['pLoai_ps'] ?? null
        ], $connection);
    }
}
