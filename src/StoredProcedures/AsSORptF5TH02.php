<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:08
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptF5TH02
{
    /**
     * Call stored procedure asSORptF5TH02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptF5TH02', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pSo_ky' => $params['pSo_ky'] ?? null,
            'pLoai' => $params['pLoai'] ?? null,
            'pLoai_CT' => $params['pLoai_CT'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pKy' => $params['pKy'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptF5TH02 with named parameters
     *
     * @param string $ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param int $So_ky
     * @param string $Loai
     * @param string $Loai_CT
     * @param string $Ma_nt
     * @param string $Ma_vt
     * @param mixed $Ky
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, int $Thang = null, int $Nam = null, int $So_ky = null, string $Loai = null, string $Loai_CT = null, string $Ma_nt = null, string $Ma_vt = null, mixed $Ky = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pSo_ky' => $So_ky,
            'pLoai' => $Loai,
            'pLoai_CT' => $Loai_CT,
            'pMa_nt' => $Ma_nt,
            'pMa_vt' => $Ma_vt,
            'pKy' => $Ky
        ];
        
        return self::call($params);
    }
}
