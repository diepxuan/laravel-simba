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
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLUpdMAUBCTCTMVI15a
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBCTCTMVI15a', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pgia_tri_dk' => $paramObj->pgia_tri_dk ?? null,
            'pton_dk' => $paramObj->pton_dk ?? null,
            'pps_tang' => $paramObj->pps_tang ?? null,
            'pps_giam' => $paramObj->pps_giam ?? null,
            'pgia_tri_ck' => $paramObj->pgia_tri_ck ?? null,
            'pton_ck' => $paramObj->pton_ck ?? null,
            'pIsprint' => $paramObj->pIsprint ?? null,
            'pIsitalic' => $paramObj->pIsitalic ?? null,
            'pBold' => $paramObj->pBold ?? null,
            'pModify' => $paramObj->pModify ?? null
        ], $connection);
    }
}
