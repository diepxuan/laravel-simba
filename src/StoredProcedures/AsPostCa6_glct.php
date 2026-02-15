<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostCa6_glct
{
    /**
     * Call stored procedure asPostCa6_glct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostCa6_glct', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_ku' => $params['pMa_ku'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pDiengiai' => $params['pDiengiai'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostCa6_glct with named parameters
     *
     * @param mixed $Ma_cty
     * @param mixed $Thang
     * @param mixed $Nam
     * @param mixed $Ma_ct
     * @param mixed $Ma_ku
     * @param mixed $Stt_rec
     * @param mixed $Stt_rec0
     * @param mixed $So_ct
     * @param mixed $Ngay_ct
     * @param mixed $Diengiai
     * @return Collection
     */
    public static function callWithParams(mixed $Ma_cty = null, mixed $Thang = null, mixed $Nam = null, mixed $Ma_ct = null, mixed $Ma_ku = null, mixed $Stt_rec = null, mixed $Stt_rec0 = null, mixed $So_ct = null, mixed $Ngay_ct = null, mixed $Diengiai = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_ct' => $Ma_ct,
            'pMa_ku' => $Ma_ku,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pSo_ct' => $So_ct,
            'pNgay_ct' => $Ngay_ct,
            'pDiengiai' => $Diengiai
        ];
        
        return self::call($params);
    }
}
