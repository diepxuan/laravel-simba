<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOInsCP2
{
    /**
     * Call stored procedure asPOInsCP2
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOInsCP2', $params, $connection);
    }

    /**
     * Call stored procedure asPOInsCP2 with named parameters
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
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_cp = null, string $Ten_cp = null, string $Tt_pb = null, float $Tien_cp_nt = null, float $Tien_cp = null, float $Ts_gtgt = null, float $Thue_gtgt_nt = null, float $Thue_gtgt = null, float $Tt_nt = null, float $Tt = null, int $Ret = null): Collection
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
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
