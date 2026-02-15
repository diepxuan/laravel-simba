<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdcolk
{
    /**
     * Call stored procedure asUpdcolk
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdcolk', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null,
            'pPs_no' => $params['pPs_no'] ?? null,
            'pPs_no_nt' => $params['pPs_no_nt'] ?? null,
            'pPs_co' => $params['pPs_co'] ?? null,
            'pPs_co_nt' => $params['pPs_co_nt'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdcolk with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_spct
     * @param string $Tk
     * @param string $Tk_du
     * @param float $Ps_no
     * @param float $Ps_no_nt
     * @param float $Ps_co
     * @param float $Ps_co_nt
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_spct = null, string $Tk = null, string $Tk_du = null, float $Ps_no = null, float $Ps_no_nt = null, float $Ps_co = null, float $Ps_co_nt = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_spct' => $Ma_spct,
            'pTk' => $Tk,
            'pTk_du' => $Tk_du,
            'pPs_no' => $Ps_no,
            'pPs_no_nt' => $Ps_no_nt,
            'pPs_co' => $Ps_co,
            'pPs_co_nt' => $Ps_co_nt,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
