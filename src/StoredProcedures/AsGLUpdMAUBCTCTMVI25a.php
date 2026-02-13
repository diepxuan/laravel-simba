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

class AsGLUpdMAUBCTCTMVI25a
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBCTCTMVI25a', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pLoai_ps' => $params['pLoai_ps'] ?? null,
            'pNam_ps' => $params['pNam_ps'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pTk_02' => $params['pTk_02'] ?? null,
            'pTk_03' => $params['pTk_03'] ?? null,
            'pTk_04' => $params['pTk_04'] ?? null,
            'pTk_05' => $params['pTk_05'] ?? null,
            'pTk_06' => $params['pTk_06'] ?? null,
            'pTk_07' => $params['pTk_07'] ?? null,
            'pTk_08' => $params['pTk_08'] ?? null,
            'pTk_09' => $params['pTk_09'] ?? null,
            'pTk_10' => $params['pTk_10'] ?? null,
            'pTk_11' => $params['pTk_11'] ?? null,
            'pTk_12' => $params['pTk_12'] ?? null,
            'pIsPrint' => $params['pIsPrint'] ?? null,
            'pIsItalic' => $params['pIsItalic'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }
}
