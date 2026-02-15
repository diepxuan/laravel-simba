<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsTestDyn
{
    /**
     * Call stored procedure asTestDyn
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTestDyn', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pTK' => $params['pTK'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_nvkd' => $params['pMa_nvkd'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pLoai_ps' => $params['pLoai_ps'] ?? null,
            'pKM' => $params['pKM'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pMa_httt' => $params['pMa_httt'] ?? null,
            'pGroup' => $params['pGroup'] ?? null,
            'pNgay_bc' => $params['pNgay_bc'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pTon' => $params['pTon'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asTestDyn with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $TK
     * @param string $Ma_kh
     * @param string $Ma_bp
     * @param string $Ma_nvkd
     * @param string $Dien_giai
     * @param string $Loai_ps
     * @param bool $KM
     * @param string $Ghi_chu
     * @param string $Ma_httt
     * @param string $Group
     * @param string $Ngay_bc
     * @param int $So_luong
     * @param float $Ton
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $TK = null, string $Ma_kh = null, string $Ma_bp = null, string $Ma_nvkd = null, string $Dien_giai = null, string $Loai_ps = null, bool $KM = null, string $Ghi_chu = null, string $Ma_httt = null, string $Group = null, string $Ngay_bc = null, int $So_luong = null, float $Ton = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pTK' => $TK,
            'pMa_kh' => $Ma_kh,
            'pMa_bp' => $Ma_bp,
            'pMa_nvkd' => $Ma_nvkd,
            'pDien_giai' => $Dien_giai,
            'pLoai_ps' => $Loai_ps,
            'pKM' => $KM,
            'pGhi_chu' => $Ghi_chu,
            'pMa_httt' => $Ma_httt,
            'pGroup' => $Group,
            'pNgay_bc' => $Ngay_bc,
            'pSo_luong' => $So_luong,
            'pTon' => $Ton
        ];
        
        return self::call($params);
    }
}
