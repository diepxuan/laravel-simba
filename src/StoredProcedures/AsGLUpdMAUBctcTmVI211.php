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

class AsGLUpdMAUBctcTmVI211
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBctcTmVI211', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pgia_tri_dk' => $params['pgia_tri_dk'] ?? null,
            'plai_suat_dk' => $params['plai_suat_dk'] ?? null,
            'pky_han_dk' => $params['pky_han_dk'] ?? null,
            'pgia_tri_ck' => $params['pgia_tri_ck'] ?? null,
            'plai_suat_ck' => $params['plai_suat_ck'] ?? null,
            'pky_han_ck' => $params['pky_han_ck'] ?? null,
            'pIsprint' => $params['pIsprint'] ?? null,
            'pIsitalic' => $params['pIsitalic'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pModify' => $params['pModify'] ?? null
        ], $connection);
    }
}
