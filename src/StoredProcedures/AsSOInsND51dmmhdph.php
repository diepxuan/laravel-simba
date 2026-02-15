<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsND51dmmhdph
{
    /**
     * Call stored procedure asSOInsND51dmmhdph
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51dmmhdph', $params, $connection);
    }

    /**
     * Call stored procedure asSOInsND51dmmhdph with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ten_loai
     * @param string $Ma_loai
     * @param int $So_lien
     * @param string $So_hd
     * @param string $Mau_so
     * @param string $Ten_mau
     * @param bool $Loai_in
     * @param string $Kh_hd
     * @param string $Kh_nam
     * @param string $So_seri
     * @param int $So_dong
     * @param string $Ghi_chu
     * @param bool $Mau_goc
     * @param string $Cdate
     * @param string $Cuser
     * @param string $Ldate
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ten_loai = null, string $Ma_loai = null, int $So_lien = null, string $So_hd = null, string $Mau_so = null, string $Ten_mau = null, bool $Loai_in = null, string $Kh_hd = null, string $Kh_nam = null, string $So_seri = null, int $So_dong = null, string $Ghi_chu = null, bool $Mau_goc = null, string $Cdate = null, string $Cuser = null, string $Ldate = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pTen_loai' => $Ten_loai,
            'pMa_loai' => $Ma_loai,
            'pSo_lien' => $So_lien,
            'pSo_hd' => $So_hd,
            'pMau_so' => $Mau_so,
            'pTen_mau' => $Ten_mau,
            'pLoai_in' => $Loai_in,
            'pKh_hd' => $Kh_hd,
            'pKh_nam' => $Kh_nam,
            'pSo_seri' => $So_seri,
            'pSo_dong' => $So_dong,
            'pGhi_chu' => $Ghi_chu,
            'pMau_goc' => $Mau_goc,
            'pCdate' => $Cdate,
            'pCuser' => $Cuser,
            'pLdate' => $Ldate,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
