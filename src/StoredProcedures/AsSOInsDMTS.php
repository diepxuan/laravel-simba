<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsDMTS
{
    /**
     * Call stored procedure asSOInsDMTS
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsDMTS', $params, $connection);
    }

    /**
     * Call stored procedure asSOInsDMTS with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_thue
     * @param string $Ten_Thue
     * @param bool $Kct
     * @param float $Ts_gtgt
     * @param string $Tk_thue_co
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_thue = null, string $Ten_Thue = null, bool $Kct = null, float $Ts_gtgt = null, string $Tk_thue_co = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_thue' => $Ma_thue,
            'pTen_Thue' => $Ten_Thue,
            'pKct' => $Kct,
            'pTs_gtgt' => $Ts_gtgt,
            'pTk_thue_co' => $Tk_thue_co,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
