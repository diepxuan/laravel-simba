<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:42
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostArPh4_glct_1c
{
    /**
     * Call stored procedure asPostArPh4_glct_1c
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostArPh4_glct_1c', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pSTT_rec' => $params['pSTT_rec'] ?? null,
            'pNh_dk' => $params['pNh_dk'] ?? null,
            'pNamTC' => $params['pNamTC'] ?? null,
            'pThangTC' => $params['pThangTC'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_ks' => $params['pNgay_ks'] ?? null,
            'pMa_nt0' => $params['pMa_nt0'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pnh_dk' => $params['pnh_dk'] ?? null,
            'pstt_rec' => $params['pstt_rec'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostArPh4_glct_1c with named parameters
     *
     * @param string $Ma_cty
     * @param string $STT_rec
     * @param string $Nh_dk
     * @param int $NamTC
     * @param int $ThangTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param string $Ma_nt0
     * @param mixed $Stt_rec
     * @param mixed $ma_cty
     * @param mixed $nh_dk
     * @param mixed $stt_rec
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $STT_rec = null, string $Nh_dk = null, int $NamTC = null, int $ThangTC = null, string $Ngay_ct = null, string $Ngay_ks = null, string $Ma_nt0 = null, mixed $Stt_rec = null, mixed $ma_cty = null, mixed $nh_dk = null, mixed $stt_rec = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pSTT_rec' => $STT_rec,
            'pNh_dk' => $Nh_dk,
            'pNamTC' => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pMa_nt0' => $Ma_nt0,
            'pStt_rec' => $Stt_rec,
            'pma_cty' => $ma_cty,
            'pnh_dk' => $nh_dk,
            'pstt_rec' => $stt_rec
        ];
        
        return self::call($params);
    }
}
