<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPORptBCPT022
{
    /**
     * Call stored procedure asPORptBCPT022
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptBCPT022', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pngay1' => $params['pngay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pPOct1' => $params['pPOct1'] ?? null,
            'pPOct2' => $params['pPOct2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_nhhd' => $params['pMa_nhhd'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_plvt1' => $params['pMa_plvt1'] ?? null,
            'pMa_plvt2' => $params['pMa_plvt2'] ?? null,
            'pMa_plvt3' => $params['pMa_plvt3'] ?? null,
            'pma_tt_po' => $params['pma_tt_po'] ?? null,
            'pStatus' => $params['pStatus'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pSl_cl' => $params['pSl_cl'] ?? null,
            'pMa_vt_' => $params['pMa_vt_'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPORptBCPT022 with named parameters
     *
     * @param string $Ma_cty
     * @param string $ngay1
     * @param string $Ngay2
     * @param string $POct1
     * @param string $POct2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_hd
     * @param string $Ma_nhhd
     * @param string $Ma_NT
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param string $ma_tt_po
     * @param string $Status
     * @param mixed $Ngay1
     * @param mixed $Stt
     * @param mixed $Stt_rec
     * @param mixed $Stt_rec0
     * @param mixed $Sl_cl
     * @param mixed $Ma_vt_
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $ngay1 = null, string $Ngay2 = null, string $POct1 = null, string $POct2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_hd = null, string $Ma_nhhd = null, string $Ma_NT = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, string $ma_tt_po = null, string $Status = null, mixed $Ngay1 = null, mixed $Stt = null, mixed $Stt_rec = null, mixed $Stt_rec0 = null, mixed $Sl_cl = null, mixed $Ma_vt_ = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pngay1' => $ngay1,
            'pNgay2' => $Ngay2,
            'pPOct1' => $POct1,
            'pPOct2' => $POct2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_hd' => $Ma_hd,
            'pMa_nhhd' => $Ma_nhhd,
            'pMa_NT' => $Ma_NT,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pma_tt_po' => $ma_tt_po,
            'pStatus' => $Status,
            'pNgay1' => $Ngay1,
            'pStt' => $Stt,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pSl_cl' => $Sl_cl,
            'pMa_vt_' => $Ma_vt_
        ];
        
        return self::call($params);
    }
}
