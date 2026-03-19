<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPOInsCP3
{
    /**
     * Call stored procedure asPOInsCP3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOInsCP3', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pMa_cp' => $paramObj->pMa_cp ?? null,
            'pTen_cp' => $paramObj->pTen_cp ?? null,
            'pTt_pb' => $paramObj->pTt_pb ?? null,
            'pTien_cp_nt' => $paramObj->pTien_cp_nt ?? null,
            'pTien_cp' => $paramObj->pTien_cp ?? null,
            'pTs_gtgt' => $paramObj->pTs_gtgt ?? null,
            'pThue_gtgt_nt' => $paramObj->pThue_gtgt_nt ?? null,
            'pThue_gtgt' => $paramObj->pThue_gtgt ?? null,
            'pTt_nt' => $paramObj->pTt_nt ?? null,
            'pTt' => $paramObj->pTt ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOInsCP3 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_cp
     * @param string $Ten_cp
     * @param string $Tt_pb
     * @param float $Tien_cp_nt
     * @param float $Tien_cp
     * @param float $Ts_gtgt
     * @param float $Thue_gtgt_nt
     * @param float $Thue_gtgt
     * @param float $Tt_nt
     * @param float $Tt
     * @param string $Ma_bp
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param string $Ma_lo
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_cp = null, string $Ten_cp = null, string $Tt_pb = null, float $Tien_cp_nt = null, float $Tien_cp = null, float $Ts_gtgt = null, float $Thue_gtgt_nt = null, float $Thue_gtgt = null, float $Tt_nt = null, float $Tt = null, string $Ma_bp = null, string $Ma_phi = null, string $Ma_spct = null, string $Ma_lo = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_cp' => $Ma_cp,
            'pTen_cp' => $Ten_cp,
            'pTt_pb' => $Tt_pb,
            'pTien_cp_nt' => $Tien_cp_nt,
            'pTien_cp' => $Tien_cp,
            'pTs_gtgt' => $Ts_gtgt,
            'pThue_gtgt_nt' => $Thue_gtgt_nt,
            'pThue_gtgt' => $Thue_gtgt,
            'pTt_nt' => $Tt_nt,
            'pTt' => $Tt,
            'pMa_bp' => $Ma_bp,
            'pMa_phi' => $Ma_phi,
            'pMa_spct' => $Ma_spct,
            'pMa_lo' => $Ma_lo,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
