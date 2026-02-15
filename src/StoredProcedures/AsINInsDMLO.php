<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINInsDMLO
{
    /**
     * Call stored procedure asINInsDMLO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsDMLO', $params, $connection);
    }

    /**
     * Call stored procedure asINInsDMLO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_lo
     * @param string $Ten_lo
     * @param string $Han_dung
     * @param string $Trang_thai
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_lo = null, string $Ten_lo = null, string $Han_dung = null, string $Trang_thai = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_lo' => $Ma_lo,
            'pTen_lo' => $Ten_lo,
            'pHan_dung' => $Han_dung,
            'pTrang_thai' => $Trang_thai,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
