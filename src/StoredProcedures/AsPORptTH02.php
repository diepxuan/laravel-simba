<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPORptTH02
{
    /**
     * Call stored procedure asPORptTH02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptTH02', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pLoai' => $params['pLoai'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pSo_ky' => $params['pSo_ky'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pIs_nt' => $params['pIs_nt'] ?? null,
            'par' => $params['par'] ?? null,
            'par1' => $params['par1'] ?? null,
            'pSoLoai' => $params['pSoLoai'] ?? null,
            'pSoQuy' => $params['pSoQuy'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPORptTH02 with named parameters
     *
     * @param string $ma_cty
     * @param string $Loai
     * @param string $Ma_ct
     * @param int $Thang
     * @param int $Nam
     * @param int $So_ky
     * @param string $Ma_nt
     * @param bool $Is_nt
     * @param string $ar
     * @param string $ar1
     * @param string $SoLoai
     * @param string $SoQuy
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, string $Loai = null, string $Ma_ct = null, int $Thang = null, int $Nam = null, int $So_ky = null, string $Ma_nt = null, bool $Is_nt = null, string $ar = null, string $ar1 = null, string $SoLoai = null, string $SoQuy = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pLoai' => $Loai,
            'pMa_ct' => $Ma_ct,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pSo_ky' => $So_ky,
            'pMa_nt' => $Ma_nt,
            'pIs_nt' => $Is_nt,
            'par' => $ar,
            'par1' => $ar1,
            'pSoLoai' => $SoLoai,
            'pSoQuy' => $SoQuy
        ];
        
        return self::call($params);
    }
}
