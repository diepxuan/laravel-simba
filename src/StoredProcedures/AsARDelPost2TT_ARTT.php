<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARDelPost2TT_ARTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARDelPost2TT_ARTT', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pStt_rec'      => $params['pStt_rec'] ?? null,
            'pStt_rec_hd'   => $params['pStt_rec_hd'] ?? null,
            'pTien_tt'      => $params['pTien_tt'] ?? null,
            'pTien_tt_nt'   => $params['pTien_tt_nt'] ?? null,
        ], $connection);
    }
}