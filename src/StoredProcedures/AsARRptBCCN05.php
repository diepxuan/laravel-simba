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

class AsARRptBCCN05
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN05', [
            'pMa_cty' => $paramObj->pPMa_cty ?? $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pPNgay1 ?? $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pPNgay2 ?? $paramObj->pNgay2 ?? null,
            'pTk' => $paramObj->pPTk ?? $paramObj->pTk ?? null,
            'pMa_kh' => $paramObj->pPMa_kh ?? $paramObj->pMa_kh ?? null,
            'pMa_nt' => $paramObj->pPMa_nt ?? $paramObj->pMa_nt ?? null,
        ], $connection);
    }
}
