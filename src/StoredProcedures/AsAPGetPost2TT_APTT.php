<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:26
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPGetPost2TT_APTT
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPGetPost2TT_APTT', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pTk_pt'   => $paramObj->pTk_pt ?? '131',
            'pMa_kh'   => $paramObj->pMa_kh ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pLoai'    => $paramObj->pLoai ?? null,
        ], $connection);
    }
}
