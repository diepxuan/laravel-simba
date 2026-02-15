<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:38
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOSaveCACT4PO
{
    /**
     * Call stored procedure asPOSaveCACT4PO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOSaveCACT4PO', $params, $connection);
    }

    /**
     * Call stored procedure asPOSaveCACT4PO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Tk
     * @param float $Ps_no_nt
     * @param float $Ps_no
     * @param string $Ma_kh
     * @param string $Ma_hd
     * @param string $Ma_bp
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param string $Ma_lo
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Tk = null, float $Ps_no_nt = null, float $Ps_no = null, string $Ma_kh = null, string $Ma_hd = null, string $Ma_bp = null, string $Ma_phi = null, string $Ma_spct = null, string $Ma_lo = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pTk' => $Tk,
            'pPs_no_nt' => $Ps_no_nt,
            'pPs_no' => $Ps_no,
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
