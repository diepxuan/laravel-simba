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

class AsARRptBCCN06
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN06', [
            'pMa_cty' => $paramObj->pPMa_cty ?? $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pPNgay1 ?? $paramObj->pNgay1 ?? null,
            'pHan_Ky1' => $paramObj->pPHan_Ky1 ?? $paramObj->pHan_Ky1 ?? null,
            'pHan_Ky2' => $paramObj->pPHan_Ky2 ?? $paramObj->pHan_Ky2 ?? null,
            'pHan_Ky3' => $paramObj->pPHan_Ky3 ?? $paramObj->pHan_Ky3 ?? null,
            'pMa_NCC' => $paramObj->pPMa_NCC ?? $paramObj->pMa_NCC ?? null,
            'pMa_NhNCC' => $paramObj->pPMa_NhNCC ?? $paramObj->pMa_NhNCC ?? null,
            'pMa_nt' => $paramObj->pPMa_nt ?? $paramObj->pMa_nt ?? null,
            'pMa_TT' => $paramObj->pPMa_TT ?? $paramObj->pMa_TT ?? null,
        ], $connection);
    }
}
