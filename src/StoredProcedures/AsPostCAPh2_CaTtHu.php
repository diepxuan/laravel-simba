<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:11
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostCAPh2_CaTtHu
{
    /**
     * Call stored procedure asPostCAPh2_CaTtHu
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostCAPh2_CaTtHu', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pNamTC' => $params['pNamTC'] ?? null,
            'pThangTC' => $params['pThangTC'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_ks' => $params['pNgay_ks'] ?? null,
            'pTk_tu' => $params['pTk_tu'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostCAPh2_CaTtHu with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param int $NamTC
     * @param int $ThangTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param mixed $Tk_tu
     * @param mixed $ma_cty
     * @param mixed $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, int $NamTC = null, int $ThangTC = null, string $Ngay_ct = null, string $Ngay_ks = null, mixed $Tk_tu = null, mixed $ma_cty = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pNamTC' => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pTk_tu' => $Tk_tu,
            'pma_cty' => $ma_cty,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
