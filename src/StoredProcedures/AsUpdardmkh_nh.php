<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdardmkh_nh
{
    /**
     * Call stored procedure asUpdardmkh_nh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdardmkh_nh', [
            'pStt' => $params['pStt'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_ngh' => $params['pMa_ngh'] ?? null,
            'pPhong_gd' => $params['pPhong_gd'] ?? null,
            'pSo_tk' => $params['pSo_tk'] ?? null,
            'pTinh_tp' => $params['pTinh_tp'] ?? null,
            'pDia_chi' => $params['pDia_chi'] ?? null,
            'pDien_thoai' => $params['pDien_thoai'] ?? null,
            'pEmail' => $params['pEmail'] ?? null,
            'pFax' => $params['pFax'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pNgam_dinh' => $params['pNgam_dinh'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdardmkh_nh with named parameters
     *
     * @param string $Stt
     * @param string $Ma_cty
     * @param string $Ma_kh
     * @param string $Ma_ngh
     * @param string $Phong_gd
     * @param string $So_tk
     * @param string $Tinh_tp
     * @param string $Dia_chi
     * @param string $Dien_thoai
     * @param string $Email
     * @param string $Fax
     * @param string $Ghi_chu
     * @param bool $Ngam_dinh
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Stt = null, string $Ma_cty = null, string $Ma_kh = null, string $Ma_ngh = null, string $Phong_gd = null, string $So_tk = null, string $Tinh_tp = null, string $Dia_chi = null, string $Dien_thoai = null, string $Email = null, string $Fax = null, string $Ghi_chu = null, bool $Ngam_dinh = null, int $Ret = null): Collection
    {
        $params = [
            'pStt' => $Stt,
            'pMa_cty' => $Ma_cty,
            'pMa_kh' => $Ma_kh,
            'pMa_ngh' => $Ma_ngh,
            'pPhong_gd' => $Phong_gd,
            'pSo_tk' => $So_tk,
            'pTinh_tp' => $Tinh_tp,
            'pDia_chi' => $Dia_chi,
            'pDien_thoai' => $Dien_thoai,
            'pEmail' => $Email,
            'pFax' => $Fax,
            'pGhi_chu' => $Ghi_chu,
            'pNgam_dinh' => $Ngam_dinh,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
