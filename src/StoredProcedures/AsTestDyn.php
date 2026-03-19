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
use Diepxuan\Simba\Helper\ParamHelper;

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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTestDyn', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pTK' => $paramObj->pTK ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_nvkd' => $paramObj->pMa_nvkd ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pLoai_ps' => $paramObj->pLoai_ps ?? null,
            'pKM' => $paramObj->pKM ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pMa_httt' => $paramObj->pMa_httt ?? null,
            'pGroup' => $paramObj->pGroup ?? null,
            'pNgay_bc' => $paramObj->pNgay_bc ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pTon' => $paramObj->pTon ?? null
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
