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

class AsARRptBCCN04
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN04', [
            'ma_cty' => $paramObj->pMa_cty ?? $paramObj->ma_cty ?? null,
            'Ngay1' => $paramObj->pNgay1 ?? $paramObj->Ngay1 ?? null,
            'Ngay2' => $paramObj->pNgay2 ?? $paramObj->Ngay2 ?? null,
            'Tk' => $paramObj->pTk ?? $paramObj->Tk ?? null,
            'pGroup' => $paramObj->pPGroup ?? $paramObj->pGroup ?? null,
            'pDetail' => $paramObj->pPDetail ?? $paramObj->pDetail ?? null,
            'ma_hd' => $paramObj->pMa_hd ?? $paramObj->ma_hd ?? null,
            'ma_kh' => $paramObj->pMa_kh ?? $paramObj->ma_kh ?? null,
            'ma_plkh1' => $paramObj->pMa_plkh1 ?? $paramObj->ma_plkh1 ?? null,
            'ma_plkh2' => $paramObj->pMa_plkh2 ?? $paramObj->ma_plkh2 ?? null,
            'ma_plkh3' => $paramObj->pMa_plkh3 ?? $paramObj->ma_plkh3 ?? null,
            'pMa_BP' => $paramObj->pPMa_BP ?? $paramObj->pMa_BP ?? null,
            'pMa_NVKD' => $paramObj->pPMa_NVKD ?? $paramObj->pMa_NVKD ?? null,
            'pMa_SPCT' => $paramObj->pPMa_SPCT ?? $paramObj->pMa_SPCT ?? null,
            'ma_nt' => $paramObj->pMa_nt ?? $paramObj->ma_nt ?? null,
        ], $connection);
    }
}
