<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:40
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIUpdDMHD
{
    /**
     * Call stored procedure asSIUpdDMHD
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIUpdDMHD', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pSo_hd' => $params['pSo_hd'] ?? null,
            'pMa_nhhd' => $params['pMa_nhhd'] ?? null,
            'pLoai' => $params['pLoai'] ?? null,
            'pNgay_hd' => $params['pNgay_hd'] ?? null,
            'pNgay_hh' => $params['pNgay_hh'] ?? null,
            'pTen_hd' => $params['pTen_hd'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pNoi_dung' => $params['pNoi_dung'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTien' => $params['pTien'] ?? null,
            'pTien_nt' => $params['pTien_nt'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIUpdDMHD with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_hd
     * @param string $So_hd
     * @param string $Ma_nhhd
     * @param string $Loai
     * @param string $Ngay_hd
     * @param string $Ngay_hh
     * @param string $Ten_hd
     * @param string $Ma_kh
     * @param string $Noi_dung
     * @param string $Ma_nt
     * @param float $Tien
     * @param float $Tien_nt
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_hd = null, string $So_hd = null, string $Ma_nhhd = null, string $Loai = null, string $Ngay_hd = null, string $Ngay_hh = null, string $Ten_hd = null, string $Ma_kh = null, string $Noi_dung = null, string $Ma_nt = null, float $Tien = null, float $Tien_nt = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_hd' => $Ma_hd,
            'pSo_hd' => $So_hd,
            'pMa_nhhd' => $Ma_nhhd,
            'pLoai' => $Loai,
            'pNgay_hd' => $Ngay_hd,
            'pNgay_hh' => $Ngay_hh,
            'pTen_hd' => $Ten_hd,
            'pMa_kh' => $Ma_kh,
            'pNoi_dung' => $Noi_dung,
            'pMa_nt' => $Ma_nt,
            'pTien' => $Tien,
            'pTien_nt' => $Tien_nt,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
