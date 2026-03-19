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

class AsARRptBK01
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBK01', [
            'pMa_cty' => $paramObj->pPMa_cty ?? $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pPNgay1 ?? $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pPNgay2 ?? $paramObj->pNgay2 ?? null,
            'pMa_kh' => $paramObj->pPMa_kh ?? $paramObj->pMa_kh ?? null,
            'pMa_vt' => $paramObj->pPMa_vt ?? $paramObj->pMa_vt ?? null,
            'pMa_nhvt' => $paramObj->pPMa_nhvt ?? $paramObj->pMa_nhvt ?? null,
            'pMa_kho' => $paramObj->pPMa_kho ?? $paramObj->pMa_kho ?? null,
            'pMa_lo' => $paramObj->pPMa_lo ?? $paramObj->pMa_lo ?? null,
            'pMa_bp' => $paramObj->pPMa_bp ?? $paramObj->pMa_bp ?? null,
            'pMa_hd' => $paramObj->pPMa_hd ?? $paramObj->pMa_hd ?? null,
            'pMa_phi' => $paramObj->pPMa_phi ?? $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pPMa_spct ?? $paramObj->pMa_spct ?? null,
            'pMa_nvkd' => $paramObj->pPMa_nvkd ?? $paramObj->pMa_nvkd ?? null,
            'pMa_nt' => $paramObj->pPMa_nt ?? $paramObj->pMa_nt ?? null,
            'pSoct1' => $paramObj->pPSoct1 ?? $paramObj->pSoct1 ?? null,
            'pSoct2' => $paramObj->pPSoct2 ?? $paramObj->pSoct2 ?? null,
            'pMa_plkh1' => $paramObj->pPMa_plkh1 ?? $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2' => $paramObj->pPMa_plkh2 ?? $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3' => $paramObj->pPMa_plkh3 ?? $paramObj->pMa_plkh3 ?? null,
        ], $connection);
    }
}
