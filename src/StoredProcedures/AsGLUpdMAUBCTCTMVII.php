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

class AsGLUpdMAUBCTCTMVII
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBCTCTMVII', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pLoai_ps' => $paramObj->pLoai_ps ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pIsPrint' => $paramObj->pIsPrint ?? null,
            'pIsItalic' => $paramObj->pIsItalic ?? null,
            'pBold' => $paramObj->pBold ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }
}
