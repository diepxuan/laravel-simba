<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:05
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOSaveCACT4SO
{
    /**
     * Call stored procedure asSOSaveCACT4SO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOSaveCACT4SO', $params, $connection);
    }

    /**
     * Call stored procedure asSOSaveCACT4SO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Tk
     * @param float $Ps_co_nt
     * @param float $Ps_co
     * @param string $Ma_kh
     * @param string $Ma_hd
     * @param string $Ma_bp
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param string $Ma_lo
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Tk = null, float $Ps_co_nt = null, float $Ps_co = null, string $Ma_kh = null, string $Ma_hd = null, string $Ma_bp = null, string $Ma_phi = null, string $Ma_spct = null, string $Ma_lo = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pTk' => $Tk,
            'pPs_co_nt' => $Ps_co_nt,
            'pPs_co' => $Ps_co,
            'pMa_kh' => $Ma_kh,
            'pMa_hd' => $Ma_hd,
            'pMa_bp' => $Ma_bp,
            'pMa_phi' => $Ma_phi,
            'pMa_spct' => $Ma_spct,
            'pMa_lo' => $Ma_lo,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
