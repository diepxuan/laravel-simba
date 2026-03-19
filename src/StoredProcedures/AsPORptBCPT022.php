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
use Diepxuan\Simba\Helper\ParamHelper;

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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptBCPT022', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pngay1' => $paramObj->pngay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pPOct1' => $paramObj->pPOct1 ?? null,
            'pPOct2' => $paramObj->pPOct2 ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_plkh1' => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2' => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3' => $paramObj->pMa_plkh3 ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_nhhd' => $paramObj->pMa_nhhd ?? null,
            'pMa_NT' => $paramObj->pMa_NT ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pMa_plvt1' => $paramObj->pMa_plvt1 ?? null,
            'pMa_plvt2' => $paramObj->pMa_plvt2 ?? null,
            'pMa_plvt3' => $paramObj->pMa_plvt3 ?? null,
            'pma_tt_po' => $paramObj->pma_tt_po ?? null,
            'pStatus' => $paramObj->pStatus ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pStt' => $paramObj->pStt ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pSl_cl' => $paramObj->pSl_cl ?? null,
            'pMa_vt_' => $paramObj->pMa_vt_ ?? null
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
