<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiCopyVoucherBetween2SQLDB
{
    /**
     * Call stored procedure asSiCopyVoucherBetween2SQLDB
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiCopyVoucherBetween2SQLDB', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'ph_tbl_name' => $params['ph_tbl_name'] ?? null,
            'params' => $params['params'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiCopyVoucherBetween2SQLDB with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_ct
     * @param mixed $h_tbl_name
     * @param string $arams
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_ct = null, mixed $h_tbl_name = null, string $arams = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_ct' => $Ma_ct,
            'ph_tbl_name' => $h_tbl_name,
            'params' => $arams
        ];
        
        return self::call($params);
    }
}
