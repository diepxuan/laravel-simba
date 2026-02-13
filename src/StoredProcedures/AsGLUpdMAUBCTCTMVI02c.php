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

class AsGLUpdMAUBCTCTMVI02c
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBCTCTMVI02c', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pGia_goc_dk' => $params['pGia_goc_dk'] ?? null,
            'pGia_hl_dk' => $params['pGia_hl_dk'] ?? null,
            'pGia_dp_dk' => $params['pGia_dp_dk'] ?? null,
            'pGia_goc_ck' => $params['pGia_goc_ck'] ?? null,
            'pGia_hl_ck' => $params['pGia_hl_ck'] ?? null,
            'pGia_dp_ck' => $params['pGia_dp_ck'] ?? null,
            'pIsprint' => $params['pIsprint'] ?? null,
            'pIsitalic' => $params['pIsitalic'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pModify' => $params['pModify'] ?? null
        ], $connection);
    }
}
