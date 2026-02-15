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

class AsSOInsND51dmmhdct
{
    /**
     * Call stored procedure asSOInsND51dmmhdct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51dmmhdct', $params, $connection);
    }

    /**
     * Call stored procedure asSOInsND51dmmhdct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Mau_so
     * @param string $Mota1
     * @param string $Mota2
     * @param string $Mota3
     * @param string $Mota4
     * @param string $Mota5
     * @param string $Mota6
     * @param string $Mota7
     * @param string $Mota8
     * @param string $Mota9
     * @param bool $Mau_goc
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Mau_so = null, string $Mota1 = null, string $Mota2 = null, string $Mota3 = null, string $Mota4 = null, string $Mota5 = null, string $Mota6 = null, string $Mota7 = null, string $Mota8 = null, string $Mota9 = null, bool $Mau_goc = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMau_so' => $Mau_so,
            'pMota1' => $Mota1,
            'pMota2' => $Mota2,
            'pMota3' => $Mota3,
            'pMota4' => $Mota4,
            'pMota5' => $Mota5,
            'pMota6' => $Mota6,
            'pMota7' => $Mota7,
            'pMota8' => $Mota8,
            'pMota9' => $Mota9,
            'pMau_goc' => $Mau_goc,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
