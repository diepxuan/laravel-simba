<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:07
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSAUpdDmThueTNCN
{
    /**
     * Call stored procedure asSAUpdDmThueTNCN
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAUpdDmThueTNCN', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pBac_thue' => $params['pBac_thue'] ?? null,
            'pDinh_muc_tu' => $params['pDinh_muc_tu'] ?? null,
            'pDinh_muc_den' => $params['pDinh_muc_den'] ?? null,
            'pThue_suat' => $params['pThue_suat'] ?? null,
            'pThue_toi_da' => $params['pThue_toi_da'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSAUpdDmThueTNCN with named parameters
     *
     * @param string $Ma_cty
     * @param string $Bac_thue
     * @param float $Dinh_muc_tu
     * @param float $Dinh_muc_den
     * @param float $Thue_suat
     * @param float $Thue_toi_da
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Bac_thue = null, float $Dinh_muc_tu = null, float $Dinh_muc_den = null, float $Thue_suat = null, float $Thue_toi_da = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pBac_thue' => $Bac_thue,
            'pDinh_muc_tu' => $Dinh_muc_tu,
            'pDinh_muc_den' => $Dinh_muc_den,
            'pThue_suat' => $Thue_suat,
            'pThue_toi_da' => $Thue_toi_da,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
