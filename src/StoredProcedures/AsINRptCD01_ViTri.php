<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:22:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptCD01_ViTri
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCD01_ViTri', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pNgay1' => $paramObj->pNgay1 ?? '',
            'pNgay2' => $paramObj->pNgay2 ?? '',
            'pLoai_bc' => $paramObj->pLoai_bc ?? '',
            'pMa_vt' => $paramObj->pMa_vt ?? '',
            'pTk_vt' => $paramObj->pTk_vt ?? '',
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? '',
            'pMa_kho' => $paramObj->pMa_kho ?? '',
            'pMa_vitri' => $paramObj->pMa_vitri ?? '',
            'pma_plvt1' => $paramObj->pma_plvt1 ?? '',
            'pma_plvt2' => $paramObj->pma_plvt2 ?? '',
            'pma_plvt3' => $paramObj->pma_plvt3 ?? '',
            'group1' => $paramObj->group1 ?? '',
            'group2' => $paramObj->group2 ?? '',
            'group3' => $paramObj->group3 ?? '',
            'pDVT' => $paramObj->pDVT ?? '',
            'pPSDC' => $paramObj->pPSDC ?? '',
            'pNgoai_te' => $paramObj->pNgoai_te ?? ''
        ], $connection);
    }
}
