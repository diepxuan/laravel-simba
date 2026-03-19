<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:05
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdTDKetQua
{
    /**
     * Call stored procedure asHrUpdTDKetQua
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdTDKetQua', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_yctd' => $paramObj->pMa_yctd ?? null,
            'pVong_so' => $paramObj->pVong_so ?? null,
            'pMa_mon_thi' => $paramObj->pMa_mon_thi ?? null,
            'pDe_so' => $paramObj->pDe_so ?? null,
            'pId' => $paramObj->pId ?? null,
            'pHo_ten' => $paramObj->pHo_ten ?? null,
            'pHo_dem' => $paramObj->pHo_dem ?? null,
            'pTen' => $paramObj->pTen ?? null,
            'pNgay_sinh' => $paramObj->pNgay_sinh ?? null,
            'pGioi_tinh' => $paramObj->pGioi_tinh ?? null,
            'pSo_cmnd' => $paramObj->pSo_cmnd ?? null,
            'pNgay_hen' => $paramObj->pNgay_hen ?? null,
            'pGio_hen' => $paramObj->pGio_hen ?? null,
            'pPhut_hen' => $paramObj->pPhut_hen ?? null,
            'pKet_qua' => $paramObj->pKet_qua ?? null,
            'pXep_loai' => $paramObj->pXep_loai ?? null,
            'pNhan_xet' => $paramObj->pNhan_xet ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pTai_lieu' => $paramObj->pTai_lieu ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdTDKetQua with named parameters
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
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Vong_so = null, string $Ma_mon_thi = null, string $De_so = null, string $Id = null, string $Ho_ten = null, string $Ho_dem = null, string $Ten = null, string $Ngay_sinh = null, string $Gioi_tinh = null, string $So_cmnd = null, string $Ngay_hen = null, int $Gio_hen = null, int $Phut_hen = null, float $Ket_qua = null, string $Xep_loai = null, string $Nhan_xet = null, string $Trang_thai = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
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
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
