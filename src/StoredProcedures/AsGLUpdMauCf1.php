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

class AsGLUpdMauCf1
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMauCf1', [
            'pMau' => $paramObj->pMau ?? null,
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pQd_cdkt' => $paramObj->pQd_cdkt ?? null,
            'pStt' => $paramObj->pStt ?? null,
            'pBold' => $paramObj->pBold ?? null,
            'pIn_ck' => $paramObj->pIn_ck ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pTk_no' => $paramObj->pTk_no ?? null,
            'pTk_co' => $paramObj->pTk_co ?? null,
            'pDau' => $paramObj->pDau ?? null,
            'pTm' => $paramObj->pTm ?? null,
            'pLoai_ps' => $paramObj->pLoai_ps ?? null
        ], $connection);
    }
}
