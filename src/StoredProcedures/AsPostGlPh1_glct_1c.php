<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:57
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostGlPh1_glct_1c
{
    /**
     * Call stored procedure asPostGlPh1_glct_1c
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostGlPh1_glct_1c', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pNh_dk' => $params['pNh_dk'] ?? null,
            'pNamTC' => $params['pNamTC'] ?? null,
            'pThangTC' => $params['pThangTC'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pMa_nt0' => $params['pMa_nt0'] ?? null,
            'pSTT_rec' => $params['pSTT_rec'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pnh_dk' => $params['pnh_dk'] ?? null,
            'pstt_rec' => $params['pstt_rec'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostGlPh1_glct_1c with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Nh_dk
     * @param int $NamTC
     * @param int $ThangTC
     * @param string $Ngay_ct
     * @param mixed $Ma_nt0
     * @param mixed $STT_rec
     * @param mixed $ma_cty
     * @param mixed $nh_dk
     * @param mixed $stt_rec
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Nh_dk = null, int $NamTC = null, int $ThangTC = null, string $Ngay_ct = null, mixed $Ma_nt0 = null, mixed $STT_rec = null, mixed $ma_cty = null, mixed $nh_dk = null, mixed $stt_rec = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pNh_dk' => $Nh_dk,
            'pNamTC' => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
            'pMa_nt0' => $Ma_nt0,
            'pSTT_rec' => $STT_rec,
            'pma_cty' => $ma_cty,
            'pnh_dk' => $nh_dk,
            'pstt_rec' => $stt_rec
        ];
        
        return self::call($params);
    }
}
