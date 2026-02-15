<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetChamCongKhac
{
    /**
     * Call stored procedure asHrGetChamCongKhac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetChamCongKhac', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNgay' => $params['pNgay'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pngay' => $params['pngay'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetChamCongKhac with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param int $Thang
     * @param int $Ngay
     * @param string $Id
     * @param mixed $ngay
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, int $Thang = null, int $Ngay = null, string $Id = null, mixed $ngay = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pThang' => $Thang,
            'pNgay' => $Ngay,
            'pId' => $Id,
            'pngay' => $ngay
        ];
        
        return self::call($params);
    }
}
