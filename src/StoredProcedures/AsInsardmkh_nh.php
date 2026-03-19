<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:44
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsInsardmkh_nh
{
    /**
     * Call stored procedure asInsardmkh_nh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsardmkh_nh', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_ngh' => $paramObj->pMa_ngh ?? null,
            'pTen_ngh' => $paramObj->pTen_ngh ?? null,
            'pPhong_gd' => $paramObj->pPhong_gd ?? null,
            'pSo_tk' => $paramObj->pSo_tk ?? null,
            'pTinh_tp' => $paramObj->pTinh_tp ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pDien_thoai' => $paramObj->pDien_thoai ?? null,
            'pEmail' => $paramObj->pEmail ?? null,
            'pFax' => $paramObj->pFax ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pNgam_dinh' => $paramObj->pNgam_dinh ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsardmkh_nh with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kh
     * @param string $Ma_ngh
     * @param string $Ten_ngh
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
    public static function callWithParams(string $Ma_cty = null, string $Ma_kh = null, string $Ma_ngh = null, string $Ten_ngh = null, string $Phong_gd = null, string $So_tk = null, string $Tinh_tp = null, string $Dia_chi = null, string $Dien_thoai = null, string $Email = null, string $Fax = null, string $Ghi_chu = null, bool $Ngam_dinh = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kh' => $Ma_kh,
            'pMa_ngh' => $Ma_ngh,
            'pTen_ngh' => $Ten_ngh,
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
