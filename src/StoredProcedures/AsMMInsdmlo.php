<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:24
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsMMInsdmlo
{
    /**
     * Call stored procedure asMMInsdmlo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asMMInsdmlo', $params, $connection);
    }

    /**
     * Call stored procedure asMMInsdmlo with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_lo_tp
     * @param string $Ten_lo
     * @param bool $Ksd
     * @param string $Ten_vt
     * @param float $So_luong
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_vt
     * @param string $LUser
     * @param string $Han_dung
     * @param string $Trang_thai
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_lo_tp = null, string $Ten_lo = null, bool $Ksd = null, string $Ten_vt = null, float $So_luong = null, int $Thang = null, int $Nam = null, string $Ma_vt = null, string $LUser = null, string $Han_dung = null, string $Trang_thai = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_lo_tp' => $Ma_lo_tp,
            'pTen_lo' => $Ten_lo,
            'pKsd' => $Ksd,
            'pTen_vt' => $Ten_vt,
            'pSo_luong' => $So_luong,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_vt' => $Ma_vt,
            'pLUser' => $LUser,
            'pHan_dung' => $Han_dung,
            'pTrang_thai' => $Trang_thai,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
