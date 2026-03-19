<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSOUpdND51dmmhdph
{
    /**
     * Call stored procedure asSOUpdND51dmmhdph
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdND51dmmhdph', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_loai' => $paramObj->pMa_loai ?? null,
            'pSo_lien' => $paramObj->pSo_lien ?? null,
            'pSo_hd' => $paramObj->pSo_hd ?? null,
            'pTen_mau' => $paramObj->pTen_mau ?? null,
            'pMau_so' => $paramObj->pMau_so ?? null,
            'pLoai_in' => $paramObj->pLoai_in ?? null,
            'pKh_hd' => $paramObj->pKh_hd ?? null,
            'pKh_nam' => $paramObj->pKh_nam ?? null,
            'pSo_seri' => $paramObj->pSo_seri ?? null,
            'pSo_dong' => $paramObj->pSo_dong ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pLdate' => $paramObj->pLdate ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdND51dmmhdph with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_loai
     * @param int $So_lien
     * @param string $So_hd
     * @param string $Ten_mau
     * @param string $Mau_so
     * @param bool $Loai_in
     * @param string $Kh_hd
     * @param string $Kh_nam
     * @param string $So_seri
     * @param int $So_dong
     * @param string $Ghi_chu
     * @param string $Ldate
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_loai = null, int $So_lien = null, string $So_hd = null, string $Ten_mau = null, string $Mau_so = null, bool $Loai_in = null, string $Kh_hd = null, string $Kh_nam = null, string $So_seri = null, int $So_dong = null, string $Ghi_chu = null, string $Ldate = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_loai' => $Ma_loai,
            'pSo_lien' => $So_lien,
            'pSo_hd' => $So_hd,
            'pTen_mau' => $Ten_mau,
            'pMau_so' => $Mau_so,
            'pLoai_in' => $Loai_in,
            'pKh_hd' => $Kh_hd,
            'pKh_nam' => $Kh_nam,
            'pSo_seri' => $So_seri,
            'pSo_dong' => $So_dong,
            'pGhi_chu' => $Ghi_chu,
            'pLdate' => $Ldate,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
