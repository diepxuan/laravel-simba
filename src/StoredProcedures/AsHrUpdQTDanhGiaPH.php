<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 10:58:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdQTDanhGiaPH
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTDanhGiaPH', [
            'pMa_cty'     => $paramObj->pMa_cty ?? SModel::CTY,
            'pId'         => $paramObj->pId ?? null,
            'pId_qtdg'    => $paramObj->pId_qtdg ?? null,
            'pNgay_dg'    => $paramObj->pNgay_dg ?? null,
            'pNgay_bd'    => $paramObj->pNgay_bd ?? null,
            'pNgay_kt'    => $paramObj->pNgay_kt ?? null,
            'pMa_nvdg'    => $paramObj->pMa_nvdg ?? null,
            'pMa_nhdg'    => $paramObj->pMa_nhdg ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pKet_luan'   => $paramObj->pKet_luan ?? null,
            'pGhi_chu'    => $paramObj->pGhi_chu ?? null,
            'pTai_lieu'   => $paramObj->pTai_lieu ?? null,
            'pLuser'      => $paramObj->pLuser ?? null,
        ], $connection);
    }
}
