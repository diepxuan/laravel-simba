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
use Diepxuan\Simba\Helper\ParamHelper;

class AsARGetPost2TT_ARTT
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetPost2TT_ARTT', [
            'pMa_cty'   => $paramObj->pMa_cty ?? null,
            'pStt_rec'  => $paramObj->pStt_rec ?? null,
            'pTk_pt'    => $paramObj->pTk_pt ?? '131',
            'pMa_kh'    => $paramObj->pMa_kh ?? null,
            'pNgay_ct'  => $paramObj->pNgay_ct ?? null,
            'pLoai'     => $paramObj->pLoai ?? null,
        ], $connection);
    }
}