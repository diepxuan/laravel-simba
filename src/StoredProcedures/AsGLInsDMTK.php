<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLInsDMTK
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsDMTK', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pTen_tk' => $params['pTen_tk'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pChi_tiet' => $params['pChi_tiet'] ?? null,
            'pTk_me' => $params['pTk_me'] ?? null,
            'pBac_tk' => $params['pBac_tk'] ?? null,
            'pTk_sc' => $params['pTk_sc'] ?? null,
            'pTk_cn' => $params['pTk_cn'] ?? null,
            'pPp_tinh_tggs_no' => $params['pPp_tinh_tggs_no'] ?? null,
            'pPp_tinh_tggs_co' => $params['pPp_tinh_tggs_co'] ?? null,
            'pKieu_sd' => $params['pKieu_sd'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pMa_ngh' => $params['pMa_ngh'] ?? null,
            'pSo_tk' => $params['pSo_tk'] ?? null,
            'pTen_ngh' => $params['pTen_ngh'] ?? null,
            'pTinh_tp' => $params['pTinh_tp'] ?? null,
        ], $connection);
    }
}
