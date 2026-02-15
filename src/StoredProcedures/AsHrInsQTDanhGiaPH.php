<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsQTDanhGiaPH
{
    /**
     * Call stored procedure asHrInsQTDanhGiaPH
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsQTDanhGiaPH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtdg' => $params['pId_qtdg'] ?? null,
            'pNgay_dg' => $params['pNgay_dg'] ?? null,
            'pNgay_bd' => $params['pNgay_bd'] ?? null,
            'pNgay_kt' => $params['pNgay_kt'] ?? null,
            'pMa_nvdg' => $params['pMa_nvdg'] ?? null,
            'pMa_nhdg' => $params['pMa_nhdg'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pKet_luan' => $params['pKet_luan'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsQTDanhGiaPH with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtdg
     * @param string $Ngay_dg
     * @param string $Ngay_bd
     * @param string $Ngay_kt
     * @param string $Ma_nvdg
     * @param string $Ma_nhdg
     * @param string $Trang_thai
     * @param string $Ket_luan
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtdg = null, string $Ngay_dg = null, string $Ngay_bd = null, string $Ngay_kt = null, string $Ma_nvdg = null, string $Ma_nhdg = null, string $Trang_thai = null, string $Ket_luan = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtdg' => $Id_qtdg,
            'pNgay_dg' => $Ngay_dg,
            'pNgay_bd' => $Ngay_bd,
            'pNgay_kt' => $Ngay_kt,
            'pMa_nvdg' => $Ma_nvdg,
            'pMa_nhdg' => $Ma_nhdg,
            'pTrang_thai' => $Trang_thai,
            'pKet_luan' => $Ket_luan,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
