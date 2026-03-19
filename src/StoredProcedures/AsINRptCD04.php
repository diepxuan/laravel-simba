<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptCD04
{
    /**
     * Call stored procedure asINRptCD04
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCD04', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pNgay' => $paramObj->pNgay ?? null,
            'pDVT' => $paramObj->pDVT ?? null,
            'pNgoai_te' => $paramObj->pNgoai_te ?? null,
            'pDk_Ck' => $paramObj->pDk_Ck ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pQuaToiThieu' => $paramObj->pQuaToiThieu ?? null,
            'pQuaToiDa' => $paramObj->pQuaToiDa ?? null,
            'pNam' => $paramObj->pNam ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptCD04 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Tk_vt
     * @param string $Ma_nhvt
     * @param string $Ngay
     * @param string $DVT
     * @param string $Ngoai_te
     * @param bool $Dk_Ck
     * @param string $Ma_lo
     * @param bool $QuaToiThieu
     * @param bool $QuaToiDa
     * @param int $Nam
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Tk_vt = null, string $Ma_nhvt = null, string $Ngay = null, string $DVT = null, string $Ngoai_te = null, bool $Dk_Ck = null, string $Ma_lo = null, bool $QuaToiThieu = null, bool $QuaToiDa = null, int $Nam = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pTk_vt' => $Tk_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pNgay' => $Ngay,
            'pDVT' => $DVT,
            'pNgoai_te' => $Ngoai_te,
            'pDk_Ck' => $Dk_Ck,
            'pMa_lo' => $Ma_lo,
            'pQuaToiThieu' => $QuaToiThieu,
            'pQuaToiDa' => $QuaToiDa,
            'pNam' => $Nam
        ];

        return self::call($params);
    }
}
