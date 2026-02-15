<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINGetTonVtAll
{
    /**
     * Call stored procedure asINGetTonVtAll
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetTonVtAll', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINGetTonVtAll with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kho
     * @param string $Ma_lo
     * @param string $Stt_rec
     * @param string $Ma_vitri
     * @param string $Tk_vt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_lo = null, string $Stt_rec = null, string $Ma_vitri = null, string $Tk_vt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kho' => $Ma_kho,
            'pMa_lo' => $Ma_lo,
            'pStt_rec' => $Stt_rec,
            'pMa_vitri' => $Ma_vitri,
            'pTk_vt' => $Tk_vt
        ];
        
        return self::call($params);
    }
}
