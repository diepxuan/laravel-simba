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

class AsGLInsmauBctc06
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsmauBctc06', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt' => $paramObj->pStt ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pGia_tri' => $paramObj->pGia_tri ?? null,
            'pRep_ref' => $paramObj->pRep_ref ?? null,
            'pMa_so_ref' => $paramObj->pMa_so_ref ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pIn_ck' => $paramObj->pIn_ck ?? null,
            'pBold' => $paramObj->pBold ?? null
        ], $connection);
    }
}
