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

class AsHrUpdQTDanhGiaPH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTDanhGiaPH', [
            'pMa_cty'     => $params['pMa_cty'] ?? SModel::CTY,
            'pId'         => $params['pId'] ?? null,
            'pId_qtdg'    => $params['pId_qtdg'] ?? null,
            'pNgay_dg'    => $params['pNgay_dg'] ?? null,
            'pNgay_bd'    => $params['pNgay_bd'] ?? null,
            'pNgay_kt'    => $params['pNgay_kt'] ?? null,
            'pMa_nvdg'    => $params['pMa_nvdg'] ?? null,
            'pMa_nhdg'    => $params['pMa_nhdg'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pKet_luan'   => $params['pKet_luan'] ?? null,
            'pGhi_chu'    => $params['pGhi_chu'] ?? null,
            'pTai_lieu'   => $params['pTai_lieu'] ?? null,
            'pLuser'      => $params['pLuser'] ?? null,
        ], $connection);
    }
}
