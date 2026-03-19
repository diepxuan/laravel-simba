<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsARUpdCDKH
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARUpdCDKH', [
            'pMa_cty' => $paramObj->pPMa_cty ?? $paramObj->pMa_cty ?? null,
            'pTk' => $paramObj->pPTk ?? $paramObj->pTk ?? null,
            'pNam' => $paramObj->pPNam ?? $paramObj->pNam ?? null,
            'pMa_Kh' => $paramObj->pPMa_Kh ?? $paramObj->pMa_Kh ?? null,
            'pMa_SpCt' => $paramObj->pPMa_SpCt ?? $paramObj->pMa_SpCt ?? null,
            'pMa_hd' => $paramObj->pPMa_hd ?? $paramObj->pMa_hd ?? null,
            'pMa_Bp' => $paramObj->pPMa_Bp ?? $paramObj->pMa_Bp ?? null,
            'pDu_No_Nt' => $paramObj->pPDu_No_Nt ?? $paramObj->pDu_No_Nt ?? null,
            'pDu_Co_Nt' => $paramObj->pPDu_Co_Nt ?? $paramObj->pDu_Co_Nt ?? null,
            'pDu_No' => $paramObj->pPDu_No ?? $paramObj->pDu_No ?? null,
            'pDu_Co' => $paramObj->pPDu_Co ?? $paramObj->pDu_Co ?? null,
            'pUser' => $paramObj->pPUser ?? $paramObj->pUser ?? null,
            'pRet' => $paramObj->pPRet ?? $paramObj->pRet ?? null,
        ], $connection);
    }
}
