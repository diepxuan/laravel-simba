<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsDTHocVien
{
    /**
     * Call stored procedure asHrInsDTHocVien
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDTHocVien', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kdt' => $params['pMa_kdt'] ?? null,
            'pMa_ldt' => $params['pMa_ldt'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pMa_nvns' => $params['pMa_nvns'] ?? null,
            'pHo_ten' => $params['pHo_ten'] ?? null,
            'pHo_dem' => $params['pHo_dem'] ?? null,
            'pTen' => $params['pTen'] ?? null,
            'pNgay_sinh' => $params['pNgay_sinh'] ?? null,
            'pGioi_tinh' => $params['pGioi_tinh'] ?? null,
            'pSo_cmnd' => $params['pSo_cmnd'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pIsCbl' => $params['pIsCbl'] ?? null,
            'pChuc_vu_cbl' => $params['pChuc_vu_cbl'] ?? null,
            'pSb_nghi_hoc' => $params['pSb_nghi_hoc'] ?? null,
            'pSb_di_muon' => $params['pSb_di_muon'] ?? null,
            'pSb_ve_som' => $params['pSb_ve_som'] ?? null,
            'pKet_qua' => $params['pKet_qua'] ?? null,
            'pXep_loai' => $params['pXep_loai'] ?? null,
            'pKet_luan' => $params['pKet_luan'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDTHocVien with named parameters
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
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kdt = null, string $Ma_ldt = null, string $Id = null, string $Ma_nvns = null, string $Ho_ten = null, string $Ho_dem = null, string $Ten = null, string $Ngay_sinh = null, string $Gioi_tinh = null, string $So_cmnd = null, string $Ma_cvcm = null, bool $IsCbl = null, string $Chuc_vu_cbl = null, float $Sb_nghi_hoc = null, float $Sb_di_muon = null, float $Sb_ve_som = null, float $Ket_qua = null, string $Xep_loai = null, string $Ket_luan = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Cuser = null, int $Ret = null): Collection
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
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
