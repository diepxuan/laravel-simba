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

class AsARUpdCDKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARUpdCDKH', [
            'pMa_cty' => $params['pPMa_cty'] ?? $params['pMa_cty'] ?? null,
            'pTk' => $params['pPTk'] ?? $params['pTk'] ?? null,
            'pNam' => $params['pPNam'] ?? $params['pNam'] ?? null,
            'pMa_Kh' => $params['pPMa_Kh'] ?? $params['pMa_Kh'] ?? null,
            'pMa_SpCt' => $params['pPMa_SpCt'] ?? $params['pMa_SpCt'] ?? null,
            'pMa_hd' => $params['pPMa_hd'] ?? $params['pMa_hd'] ?? null,
            'pMa_Bp' => $params['pPMa_Bp'] ?? $params['pMa_Bp'] ?? null,
            'pDu_No_Nt' => $params['pPDu_No_Nt'] ?? $params['pDu_No_Nt'] ?? null,
            'pDu_Co_Nt' => $params['pPDu_Co_Nt'] ?? $params['pDu_Co_Nt'] ?? null,
            'pDu_No' => $params['pPDu_No'] ?? $params['pDu_No'] ?? null,
            'pDu_Co' => $params['pPDu_Co'] ?? $params['pDu_Co'] ?? null,
            'pUser' => $params['pPUser'] ?? $params['pUser'] ?? null,
            'pRet' => $params['pPRet'] ?? $params['pRet'] ?? null,
        ], $connection);
    }
}
