<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:46
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINUpdDMKHO
{
    /**
     * Call stored procedure asINUpdDMKHO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINUpdDMKHO', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pTen_kho' => $paramObj->pTen_kho ?? null,
            'pKho_dl' => $paramObj->pKho_dl ?? null,
            'pTk_dl' => $paramObj->pTk_dl ?? null,
            'pStt_ntxt' => $paramObj->pStt_ntxt ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pNguoi_lh' => $paramObj->pNguoi_lh ?? null,
            'pTel' => $paramObj->pTel ?? null,
            'pFax' => $paramObj->pFax ?? null,
            'pEmail' => $paramObj->pEmail ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINUpdDMKHO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kho
     * @param string $Ten_kho
     * @param bool $Kho_dl
     * @param string $Tk_dl
     * @param int $Stt_ntxt
     * @param string $Dia_chi
     * @param string $Nguoi_lh
     * @param string $Tel
     * @param string $Fax
     * @param string $Email
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kho = null, string $Ten_kho = null, bool $Kho_dl = null, string $Tk_dl = null, int $Stt_ntxt = null, string $Dia_chi = null, string $Nguoi_lh = null, string $Tel = null, string $Fax = null, string $Email = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kho' => $Ma_kho,
            'pTen_kho' => $Ten_kho,
            'pKho_dl' => $Kho_dl,
            'pTk_dl' => $Tk_dl,
            'pStt_ntxt' => $Stt_ntxt,
            'pDia_chi' => $Dia_chi,
            'pNguoi_lh' => $Nguoi_lh,
            'pTel' => $Tel,
            'pFax' => $Fax,
            'pEmail' => $Email,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
