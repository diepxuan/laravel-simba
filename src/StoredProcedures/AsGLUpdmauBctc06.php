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

class AsGLUpdmauBctc06
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdmauBctc06', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pGia_tri' => $params['pGia_tri'] ?? null,
            'pRep_ref' => $params['pRep_ref'] ?? null,
            'pMa_so_ref' => $params['pMa_so_ref'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pIn_ck' => $params['pIn_ck'] ?? null,
            'pBold' => $params['pBold'] ?? null
        ], $connection);
    }
}
