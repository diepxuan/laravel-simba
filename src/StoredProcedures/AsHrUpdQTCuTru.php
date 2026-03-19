<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:02
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdQTCuTru
{
    /**
     * Call stored procedure asHrUpdQTCuTru
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTCuTru', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId' => $paramObj->pId ?? null,
            'pId_qtct' => $paramObj->pId_qtct ?? null,
            'pNgay_bd' => $paramObj->pNgay_bd ?? null,
            'pNgay_kt' => $paramObj->pNgay_kt ?? null,
            'pNoi_o' => $paramObj->pNoi_o ?? null,
            'pNoi_o_dc' => $paramObj->pNoi_o_dc ?? null,
            'pNoi_o_xa' => $paramObj->pNoi_o_xa ?? null,
            'pNoi_o_huyen' => $paramObj->pNoi_o_huyen ?? null,
            'pNoi_o_tinh' => $paramObj->pNoi_o_tinh ?? null,
            'pQuan_he_cn' => $paramObj->pQuan_he_cn ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pTai_lieu' => $paramObj->pTai_lieu ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQTCuTru with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtct
     * @param string $Ngay_bd
     * @param string $Ngay_kt
     * @param string $Noi_o
     * @param string $Noi_o_dc
     * @param string $Noi_o_xa
     * @param string $Noi_o_huyen
     * @param string $Noi_o_tinh
     * @param string $Quan_he_cn
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtct = null, string $Ngay_bd = null, string $Ngay_kt = null, string $Noi_o = null, string $Noi_o_dc = null, string $Noi_o_xa = null, string $Noi_o_huyen = null, string $Noi_o_tinh = null, string $Quan_he_cn = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtct' => $Id_qtct,
            'pNgay_bd' => $Ngay_bd,
            'pNgay_kt' => $Ngay_kt,
            'pNoi_o' => $Noi_o,
            'pNoi_o_dc' => $Noi_o_dc,
            'pNoi_o_xa' => $Noi_o_xa,
            'pNoi_o_huyen' => $Noi_o_huyen,
            'pNoi_o_tinh' => $Noi_o_tinh,
            'pQuan_he_cn' => $Quan_he_cn,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
