<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptBKX02
{
    /**
     * Call stored procedure asINRptBKX02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptBKX02', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pSoct1' => $params['pSoct1'] ?? null,
            'pSoct2' => $params['pSoct2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_dangnx' => $params['pMa_dangnx'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pMa_VT' => $params['pMa_VT'] ?? null,
            'pLoai_px' => $params['pLoai_px'] ?? null,
            'pSP_CT' => $params['pSP_CT'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null,
            'pMa_NhVT' => $params['pMa_NhVT'] ?? null,
            'pTK_VT' => $params['pTK_VT'] ?? null,
            'pTk_Du' => $params['pTk_Du'] ?? null,
            'pDVT' => $params['pDVT'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptBKX02 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Ma_kh
     * @param string $Ma_kho
     * @param string $Ma_bp
     * @param string $Ma_dangnx
     * @param string $Ma_Hd
     * @param string $Ma_VT
     * @param string $Loai_px
     * @param string $SP_CT
     * @param string $Ma_NT
     * @param string $Ma_NhVT
     * @param string $TK_VT
     * @param string $Tk_Du
     * @param string $DVT
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Soct1 = null, string $Soct2 = null, string $Ma_kh = null, string $Ma_kho = null, string $Ma_bp = null, string $Ma_dangnx = null, string $Ma_Hd = null, string $Ma_VT = null, string $Loai_px = null, string $SP_CT = null, string $Ma_NT = null, string $Ma_NhVT = null, string $TK_VT = null, string $Tk_Du = null, string $DVT = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pMa_kh' => $Ma_kh,
            'pMa_kho' => $Ma_kho,
            'pMa_bp' => $Ma_bp,
            'pMa_dangnx' => $Ma_dangnx,
            'pMa_Hd' => $Ma_Hd,
            'pMa_VT' => $Ma_VT,
            'pLoai_px' => $Loai_px,
            'pSP_CT' => $SP_CT,
            'pMa_NT' => $Ma_NT,
            'pMa_NhVT' => $Ma_NhVT,
            'pTK_VT' => $TK_VT,
            'pTk_Du' => $Tk_Du,
            'pDVT' => $DVT
        ];
        
        return self::call($params);
    }
}
