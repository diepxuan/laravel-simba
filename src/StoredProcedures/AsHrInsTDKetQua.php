<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:48
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsTDKetQua
{
    /**
     * Call stored procedure asHrInsTDKetQua
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsTDKetQua', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_yctd' => $params['pMa_yctd'] ?? null,
            'pVong_so' => $params['pVong_so'] ?? null,
            'pMa_mon_thi' => $params['pMa_mon_thi'] ?? null,
            'pDe_so' => $params['pDe_so'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pHo_ten' => $params['pHo_ten'] ?? null,
            'pHo_dem' => $params['pHo_dem'] ?? null,
            'pTen' => $params['pTen'] ?? null,
            'pNgay_sinh' => $params['pNgay_sinh'] ?? null,
            'pGioi_tinh' => $params['pGioi_tinh'] ?? null,
            'pSo_cmnd' => $params['pSo_cmnd'] ?? null,
            'pNgay_hen' => $params['pNgay_hen'] ?? null,
            'pGio_hen' => $params['pGio_hen'] ?? null,
            'pPhut_hen' => $params['pPhut_hen'] ?? null,
            'pKet_qua' => $params['pKet_qua'] ?? null,
            'pXep_loai' => $params['pXep_loai'] ?? null,
            'pNhan_xet' => $params['pNhan_xet'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsTDKetQua with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_yctd
     * @param string $Vong_so
     * @param string $Ma_mon_thi
     * @param string $De_so
     * @param string $Id
     * @param string $Ho_ten
     * @param string $Ho_dem
     * @param string $Ten
     * @param string $Ngay_sinh
     * @param string $Gioi_tinh
     * @param string $So_cmnd
     * @param string $Ngay_hen
     * @param int $Gio_hen
     * @param int $Phut_hen
     * @param float $Ket_qua
     * @param string $Xep_loai
     * @param string $Nhan_xet
     * @param string $Trang_thai
     * @param string $Tai_lieu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Vong_so = null, string $Ma_mon_thi = null, string $De_so = null, string $Id = null, string $Ho_ten = null, string $Ho_dem = null, string $Ten = null, string $Ngay_sinh = null, string $Gioi_tinh = null, string $So_cmnd = null, string $Ngay_hen = null, int $Gio_hen = null, int $Phut_hen = null, float $Ket_qua = null, string $Xep_loai = null, string $Nhan_xet = null, string $Trang_thai = null, string $Tai_lieu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_yctd' => $Ma_yctd,
            'pVong_so' => $Vong_so,
            'pMa_mon_thi' => $Ma_mon_thi,
            'pDe_so' => $De_so,
            'pId' => $Id,
            'pHo_ten' => $Ho_ten,
            'pHo_dem' => $Ho_dem,
            'pTen' => $Ten,
            'pNgay_sinh' => $Ngay_sinh,
            'pGioi_tinh' => $Gioi_tinh,
            'pSo_cmnd' => $So_cmnd,
            'pNgay_hen' => $Ngay_hen,
            'pGio_hen' => $Gio_hen,
            'pPhut_hen' => $Phut_hen,
            'pKet_qua' => $Ket_qua,
            'pXep_loai' => $Xep_loai,
            'pNhan_xet' => $Nhan_xet,
            'pTrang_thai' => $Trang_thai,
            'pTai_lieu' => $Tai_lieu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
