<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptBKX01
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptBKX01', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pNgay1'  => $paramObj->pNgay1 ?? null,
            'pNgay2'  => $paramObj->pNgay2 ?? null,
            'pGroupType'  => $paramObj->pGroupType ?? null,
            'pCtu1'  => $paramObj->pCtu1 ?? null,
            'pCtu2'  => $paramObj->pCtu2 ?? null,
            'pMa_kh'  => $paramObj->pMa_kh ?? null,
            'pMa_NhKh'  => $paramObj->pMa_NhKh ?? null,
            'pMa_PlKh1'  => $paramObj->pMa_PlKh1 ?? null,
            'pMa_PlKh2'  => $paramObj->pMa_PlKh2 ?? null,
            'pMa_PlKh3'  => $paramObj->pMa_PlKh3 ?? null,
            'pMa_Hd'  => $paramObj->pMa_Hd ?? null,
            'pMa_nx'  => $paramObj->pMa_nx ?? null,
            'pMa_kho'  => $paramObj->pMa_kho ?? null,
            'pMa_spct'  => $paramObj->pMa_spct ?? null,
            'pMa_bp'  => $paramObj->pMa_bp ?? null,
            'pLoai_px'  => $paramObj->pLoai_px ?? null,
            'pMa_Nt'  => $paramObj->pMa_Nt ?? null,
            'pMa_vt'  => $paramObj->pMa_vt ?? null,
            'ptk_vt'  => $paramObj->ptk_vt ?? null,
            'pTk_Du'  => $paramObj->pTk_Du ?? null,
            'pDVT'  => $paramObj->pDVT ?? null,
            'pMa_Cty'  => $paramObj->pMa_Cty ?? null,
            'pMa_nhkh'  => $paramObj->pMa_nhkh ?? null,
            'pMa_plkh1'  => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2'  => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3'  => $paramObj->pMa_plkh3 ?? null,
            'pMa_Kh'  => $paramObj->pMa_Kh ?? null,
            'pMa_nt'  => $paramObj->pMa_nt ?? null,
        ], $connection);
    }
}