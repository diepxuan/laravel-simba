<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLInsMauBs
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMauBs', [
            'pXtag' => $params['pXtag'] ?? null,
            'pXstt' => $params['pXstt'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pQd_cdkt' => $params['pQd_cdkt'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pIn_ck' => $params['pIn_ck'] ?? null,
            'pTs_nv' => $params['pTs_nv'] ?? null,
            'pCong_no' => $params['pCong_no'] ?? null,
            'pNgoai_bang' => $params['pNgoai_bang'] ?? null,
            'pSodu_duong' => $params['pSodu_duong'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pTien0' => $params['pTien0'] ?? null,
            'pTien' => $params['pTien'] ?? null,
            'pTien_nt0' => $params['pTien_nt0'] ?? null,
            'pTien_nt' => $params['pTien_nt'] ?? null,
            'pTm' => $params['pTm'] ?? null
        ], $connection);
    }
}
