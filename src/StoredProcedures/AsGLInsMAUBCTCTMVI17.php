<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLInsMAUBCTCTMVI17
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBCTCTMVI17', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pcach_tinh' => $paramObj->pcach_tinh ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pIsPrint' => $paramObj->pIsPrint ?? null,
            'pIsItalic' => $paramObj->pIsItalic ?? null,
            'pBold' => $paramObj->pBold ?? null,
            'pModify' => $paramObj->pModify ?? null,
            'pTon_CK' => $paramObj->pTon_CK ?? null,
            'pCuoi_ky' => $paramObj->pCuoi_ky ?? null,
            'pTon_DK' => $paramObj->pTon_DK ?? null,
            'pDau_ky' => $paramObj->pDau_ky ?? null,
            'pUserData' => $paramObj->pUserData ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null
        ], $connection);
    }
}
