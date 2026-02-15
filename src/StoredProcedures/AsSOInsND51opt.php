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

class AsSOInsND51opt
{
    /**
     * Call stored procedure asSOInsND51opt
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51opt', $params, $connection);
    }

    /**
     * Call stored procedure asSOInsND51opt with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_opt
     * @param string $Gia_tri
     * @param bool $Ksd
     * @param string $Cuser
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_opt = null, string $Gia_tri = null, bool $Ksd = null, string $Cuser = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_opt' => $Ma_opt,
            'pGia_tri' => $Gia_tri,
            'pKsd' => $Ksd,
            'pCuser' => $Cuser,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
