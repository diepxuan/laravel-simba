<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:39
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPRptBK02
{
    /**
     * Call stored procedure asAPRptBK02.
     *
     * @param array $params Procedure parameters
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPRptBK02', [
            'pMa_cty'   => $paramObj->pMa_cty ?? null,
            'pNgay1'    => $paramObj->pNgay1 ?? null,
            'pHan_Ky1'  => $paramObj->pHan_Ky1 ?? null,
            'pHan_Ky2'  => $paramObj->pHan_Ky2 ?? null,
            'pHan_Ky3'  => $paramObj->pHan_Ky3 ?? null,
            'pMa_NCC'   => $paramObj->pMa_NCC ?? null,
            'pMa_NhNCC' => $paramObj->pMa_NhNCC ?? null,
            'pSap_xep'  => $paramObj->pSap_xep ?? null,
            'pTat_toan' => $paramObj->pTat_toan ?? null,
            'pMa_nt'    => $paramObj->pMa_nt ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asAPRptBK02 with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ngay1 = null, ?float $Han_Ky1 = null, ?float $Han_Ky2 = null, ?float $Han_Ky3 = null, ?string $Ma_NCC = null, ?string $Ma_NhNCC = null, ?string $Sap_xep = null, ?string $Tat_toan = null, ?string $Ma_nt = null): Collection
    {
        $params = [
            'pMa_cty'   => $Ma_cty,
            'pNgay1'    => $Ngay1,
            'pHan_Ky1'  => $Han_Ky1,
            'pHan_Ky2'  => $Han_Ky2,
            'pHan_Ky3'  => $Han_Ky3,
            'pMa_NCC'   => $Ma_NCC,
            'pMa_NhNCC' => $Ma_NhNCC,
            'pSap_xep'  => $Sap_xep,
            'pTat_toan' => $Tat_toan,
            'pMa_nt'    => $Ma_nt,
        ];

        return self::call($params);
    }
}
