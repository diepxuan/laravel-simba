<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOUpdDMTS
{
    /**
     * Call stored procedure asSOUpdDMTS
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdDMTS', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_thue' => $params['pMa_thue'] ?? null,
            'pTen_Thue' => $params['pTen_Thue'] ?? null,
            'pTs_gtgt' => $params['pTs_gtgt'] ?? null,
            'pKct' => $params['pKct'] ?? null,
            'pTk_thue_co' => $params['pTk_thue_co'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdDMTS with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_thue
     * @param string $Ten_Thue
     * @param float $Ts_gtgt
     * @param bool $Kct
     * @param string $Tk_thue_co
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_thue = null, string $Ten_Thue = null, float $Ts_gtgt = null, bool $Kct = null, string $Tk_thue_co = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_thue' => $Ma_thue,
            'pTen_Thue' => $Ten_Thue,
            'pTs_gtgt' => $Ts_gtgt,
            'pKct' => $Kct,
            'pTk_thue_co' => $Tk_thue_co,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
