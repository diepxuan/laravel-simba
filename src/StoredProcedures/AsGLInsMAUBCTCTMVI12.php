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

class AsGLInsMAUBCTCTMVI12
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBCTCTMVI12', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pIsPrint' => $params['pIsPrint'] ?? null,
            'pIsItalic' => $params['pIsItalic'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pModify' => $params['pModify'] ?? null,
            'pDu_dau' => $params['pDu_dau'] ?? null,
            'pPs_no' => $params['pPs_no'] ?? null,
            'pPs_co' => $params['pPs_co'] ?? null,
            'pDu_cuoi' => $params['pDu_cuoi'] ?? null,
            'pUserData' => $params['pUserData'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null
        ], $connection);
    }
}
