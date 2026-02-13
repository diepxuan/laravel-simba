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

class AsGLUpdMAUBCTCTMVI15a
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBCTCTMVI15a', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pgia_tri_dk' => $params['pgia_tri_dk'] ?? null,
            'pton_dk' => $params['pton_dk'] ?? null,
            'pps_tang' => $params['pps_tang'] ?? null,
            'pps_giam' => $params['pps_giam'] ?? null,
            'pgia_tri_ck' => $params['pgia_tri_ck'] ?? null,
            'pton_ck' => $params['pton_ck'] ?? null,
            'pIsprint' => $params['pIsprint'] ?? null,
            'pIsitalic' => $params['pIsitalic'] ?? null,
            'pBold' => $params['pBold'] ?? null,
            'pModify' => $params['pModify'] ?? null
        ], $connection);
    }
}
