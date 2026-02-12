<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostGlPh1_glct_1n
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostGlPh1_glct_1n', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pSTT_rec'  => $params['pSTT_rec'] ?? null,
            'pNh_dk'  => $params['pNh_dk'] ?? null,
            'pNamTC'  => $params['pNamTC'] ?? null,
            'pThangTC'  => $params['pThangTC'] ?? null,
            'pNgay_ct'  => $params['pNgay_ct'] ?? null,
            'pMa_nt0'  => $params['pMa_nt0'] ?? null,
            'pStt_rec'  => $params['pStt_rec'] ?? null,
            'pma_cty'  => $params['pma_cty'] ?? null,
            'pnh_dk'  => $params['pnh_dk'] ?? null,
            'pstt_rec'  => $params['pstt_rec'] ?? null,
        ], $connection);
    }
}