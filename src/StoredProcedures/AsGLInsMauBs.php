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

class AsGLInsMauBs
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMauBs', [
            'pXtag' => $paramObj->pXtag ?? null,
            'pXstt' => $paramObj->pXstt ?? null,
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pQd_cdkt' => $paramObj->pQd_cdkt ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pStt' => $paramObj->pStt ?? null,
            'pBold' => $paramObj->pBold ?? null,
            'pIn_ck' => $paramObj->pIn_ck ?? null,
            'pTs_nv' => $paramObj->pTs_nv ?? null,
            'pCong_no' => $paramObj->pCong_no ?? null,
            'pNgoai_bang' => $paramObj->pNgoai_bang ?? null,
            'pSodu_duong' => $paramObj->pSodu_duong ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pTien0' => $paramObj->pTien0 ?? null,
            'pTien' => $paramObj->pTien ?? null,
            'pTien_nt0' => $paramObj->pTien_nt0 ?? null,
            'pTien_nt' => $paramObj->pTien_nt ?? null,
            'pTm' => $paramObj->pTm ?? null
        ], $connection);
    }
}
