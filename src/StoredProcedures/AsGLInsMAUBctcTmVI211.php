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

class AsGLInsMAUBctcTmVI211
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBctcTmVI211', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pcach_tinh' => $params['pcach_tinh'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pIsPrint' => $params['pIsPrint'] ?? null,
            'pIsItalic' => $params['pIsItalic'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pModify' => $params['pModify'] ?? null,
            'pgia_tri_dk' => $params['pgia_tri_dk'] ?? null,
            'plai_suat_dk' => $params['plai_suat_dk'] ?? null,
            'pky_han_dk' => $params['pky_han_dk'] ?? null,
            'pgia_tri_ck' => $params['pgia_tri_ck'] ?? null,
            'plai_suat_ck' => $params['plai_suat_ck'] ?? null,
            'pky_han_ck' => $params['pky_han_ck'] ?? null,
            'pUserData' => $params['pUserData'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null
        ], $connection);
    }
}
