<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:18
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdQTGhiChuNV
{
    /**
     * Call stored procedure asHrUpdQTGhiChuNV
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTGhiChuNV', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtgc' => $params['pId_qtgc'] ?? null,
            'pNgay' => $params['pNgay'] ?? null,
            'pNguoi_ghi_chu' => $params['pNguoi_ghi_chu'] ?? null,
            'pNoi_dung' => $params['pNoi_dung'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQTGhiChuNV with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtgc
     * @param string $Ngay
     * @param string $Nguoi_ghi_chu
     * @param string $Noi_dung
     * @param string $Trang_thai
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtgc = null, string $Ngay = null, string $Nguoi_ghi_chu = null, string $Noi_dung = null, string $Trang_thai = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtgc' => $Id_qtgc,
            'pNgay' => $Ngay,
            'pNguoi_ghi_chu' => $Nguoi_ghi_chu,
            'pNoi_dung' => $Noi_dung,
            'pTrang_thai' => $Trang_thai,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
