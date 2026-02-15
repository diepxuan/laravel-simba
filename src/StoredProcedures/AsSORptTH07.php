<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:58
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptTH07
{
    /**
     * Call stored procedure asSORptTH07
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptTH07', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pSo_ky' => $params['pSo_ky'] ?? null,
            'pLoai' => $params['pLoai'] ?? null,
            'pLoai_CT' => $params['pLoai_CT'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'ploai' => $params['ploai'] ?? null,
            'par' => $params['par'] ?? null,
            'p2' => $params['p2'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptTH07 with named parameters
     *
     * @param string $ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param int $So_ky
     * @param string $Loai
     * @param string $Loai_CT
     * @param string $Ma_nt
     * @param mixed $loai
     * @param string $ar
     * @param string $2
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, int $Thang = null, int $Nam = null, int $So_ky = null, string $Loai = null, string $Loai_CT = null, string $Ma_nt = null, mixed $loai = null, string $ar = null, string $2 = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pSo_ky' => $So_ky,
            'pLoai' => $Loai,
            'pLoai_CT' => $Loai_CT,
            'pMa_nt' => $Ma_nt,
            'ploai' => $loai,
            'par' => $ar,
            'p2' => $2
        ];
        
        return self::call($params);
    }
}
