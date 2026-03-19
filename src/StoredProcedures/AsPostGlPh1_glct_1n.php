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
use Diepxuan\Simba\Helper\ParamHelper;

class AsPostGlPh1_glct_1n
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostGlPh1_glct_1n', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pSTT_rec'  => $paramObj->pSTT_rec ?? null,
            'pNh_dk'  => $paramObj->pNh_dk ?? null,
            'pNamTC'  => $paramObj->pNamTC ?? null,
            'pThangTC'  => $paramObj->pThangTC ?? null,
            'pNgay_ct'  => $paramObj->pNgay_ct ?? null,
            'pMa_nt0'  => $paramObj->pMa_nt0 ?? null,
            'pStt_rec'  => $paramObj->pStt_rec ?? null,
            'pma_cty'  => $paramObj->pma_cty ?? null,
            'pnh_dk'  => $paramObj->pnh_dk ?? null,
            'pstt_rec'  => $paramObj->pstt_rec ?? null,
        ], $connection);
    }
}