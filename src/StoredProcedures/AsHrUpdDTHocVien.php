<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdDTHocVien
{
    /**
     * Call stored procedure asHrUpdDTHocVien
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDTHocVien', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_kdt' => $paramObj->pMa_kdt ?? null,
            'pMa_ldt' => $paramObj->pMa_ldt ?? null,
            'pId' => $paramObj->pId ?? null,
            'pMa_nvns' => $paramObj->pMa_nvns ?? null,
            'pHo_ten' => $paramObj->pHo_ten ?? null,
            'pHo_dem' => $paramObj->pHo_dem ?? null,
            'pTen' => $paramObj->pTen ?? null,
            'pNgay_sinh' => $paramObj->pNgay_sinh ?? null,
            'pGioi_tinh' => $paramObj->pGioi_tinh ?? null,
            'pSo_cmnd' => $paramObj->pSo_cmnd ?? null,
            'pMa_cvcm' => $paramObj->pMa_cvcm ?? null,
            'pIsCbl' => $paramObj->pIsCbl ?? null,
            'pChuc_vu_cbl' => $paramObj->pChuc_vu_cbl ?? null,
            'pSb_nghi_hoc' => $paramObj->pSb_nghi_hoc ?? null,
            'pSb_di_muon' => $paramObj->pSb_di_muon ?? null,
            'pSb_ve_som' => $paramObj->pSb_ve_som ?? null,
            'pKet_qua' => $paramObj->pKet_qua ?? null,
            'pXep_loai' => $paramObj->pXep_loai ?? null,
            'pKet_luan' => $paramObj->pKet_luan ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pTai_lieu' => $paramObj->pTai_lieu ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDTHocVien with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kdt
     * @param string $Ma_ldt
     * @param string $Id
     * @param string $Ma_nvns
     * @param string $Ho_ten
     * @param string $Ho_dem
     * @param string $Ten
     * @param string $Ngay_sinh
     * @param string $Gioi_tinh
     * @param string $So_cmnd
     * @param string $Ma_cvcm
     * @param bool $IsCbl
     * @param string $Chuc_vu_cbl
     * @param float $Sb_nghi_hoc
     * @param float $Sb_di_muon
     * @param float $Sb_ve_som
     * @param float $Ket_qua
     * @param string $Xep_loai
     * @param string $Ket_luan
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kdt = null, string $Ma_ldt = null, string $Id = null, string $Ma_nvns = null, string $Ho_ten = null, string $Ho_dem = null, string $Ten = null, string $Ngay_sinh = null, string $Gioi_tinh = null, string $So_cmnd = null, string $Ma_cvcm = null, bool $IsCbl = null, string $Chuc_vu_cbl = null, float $Sb_nghi_hoc = null, float $Sb_di_muon = null, float $Sb_ve_som = null, float $Ket_qua = null, string $Xep_loai = null, string $Ket_luan = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kdt' => $Ma_kdt,
            'pMa_ldt' => $Ma_ldt,
            'pId' => $Id,
            'pMa_nvns' => $Ma_nvns,
            'pHo_ten' => $Ho_ten,
            'pHo_dem' => $Ho_dem,
            'pTen' => $Ten,
            'pNgay_sinh' => $Ngay_sinh,
            'pGioi_tinh' => $Gioi_tinh,
            'pSo_cmnd' => $So_cmnd,
            'pMa_cvcm' => $Ma_cvcm,
            'pIsCbl' => $IsCbl,
            'pChuc_vu_cbl' => $Chuc_vu_cbl,
            'pSb_nghi_hoc' => $Sb_nghi_hoc,
            'pSb_di_muon' => $Sb_di_muon,
            'pSb_ve_som' => $Sb_ve_som,
            'pKet_qua' => $Ket_qua,
            'pXep_loai' => $Xep_loai,
            'pKet_luan' => $Ket_luan,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
