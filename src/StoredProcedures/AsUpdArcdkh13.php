<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdArcdkh13
{
    /**
     * Call stored procedure asUpdArcdkh13
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdArcdkh13', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pma_kh' => $params['pma_kh'] ?? null,
            'pnam' => $params['pnam'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pNam' => $params['pNam'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdArcdkh13 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $ma_kh
     * @param int $nam
     * @param mixed $ma_cty
     * @param mixed $Ma_kh
     * @param mixed $Nam
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $ma_kh = null, int $nam = null, mixed $ma_cty = null, mixed $Ma_kh = null, mixed $Nam = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pma_kh' => $ma_kh,
            'pnam' => $nam,
            'pma_cty' => $ma_cty,
            'pMa_kh' => $Ma_kh,
            'pNam' => $Nam
        ];
        
        return self::call($params);
    }
}
