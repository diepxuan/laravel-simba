<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:06
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostCRPh1_crct_1c
{
    /**
     * Call stored procedure asPostCRPh1_crct_1c
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostCRPh1_crct_1c', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pSTT_rec' => $params['pSTT_rec'] ?? null,
            'pNh_dk' => $params['pNh_dk'] ?? null,
            'pstt_rec' => $params['pstt_rec'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pnh_dk' => $params['pnh_dk'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostCRPh1_crct_1c with named parameters
     *
     * @param string $Ma_cty
     * @param string $STT_rec
     * @param string $Nh_dk
     * @param string $stt_rec
     * @param string $ma_cty
     * @param string $nh_dk
     * @param mixed $Ma_Cty
     * @param mixed $Stt_rec
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $STT_rec = null, string $Nh_dk = null, string $stt_rec = null, string $ma_cty = null, string $nh_dk = null, mixed $Ma_Cty = null, mixed $Stt_rec = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pSTT_rec' => $STT_rec,
            'pNh_dk' => $Nh_dk,
            'pstt_rec' => $stt_rec,
            'pma_cty' => $ma_cty,
            'pnh_dk' => $nh_dk,
            'pMa_Cty' => $Ma_Cty,
            'pStt_rec' => $Stt_rec
        ];
        
        return self::call($params);
    }
}
