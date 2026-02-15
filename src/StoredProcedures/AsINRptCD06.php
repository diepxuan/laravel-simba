<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptCD06
{
    /**
     * Call stored procedure asINRptCD06
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCD06', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pNgay' => $params['pNgay'] ?? null,
            'pDVT' => $params['pDVT'] ?? null,
            'pNgoai_te' => $params['pNgoai_te'] ?? null,
            'pDk_Ck' => $params['pDk_Ck'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pQuaToiThieu' => $params['pQuaToiThieu'] ?? null,
            'pQuaToiDa' => $params['pQuaToiDa'] ?? null,
            'pNam' => $params['pNam'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptCD06 with named parameters
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
