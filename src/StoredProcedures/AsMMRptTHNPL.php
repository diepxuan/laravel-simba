<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsMMRptTHNPL
{
    /**
     * Call stored procedure asMMRptTHNPL
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asMMRptTHNPL', [
            'pSo_lsx_dk' => $paramObj->pSo_lsx_dk ?? null,
            'pNgay' => $paramObj->pNgay ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asMMRptTHNPL with named parameters
     *
     * @param string $So_lsx_dk
     * @param string $Ngay
     * @return Collection
     */
    public static function callWithParams(string $So_lsx_dk = null, string $Ngay = null): Collection
    {
        $params = [
            'pSo_lsx_dk' => $So_lsx_dk,
            'pNgay' => $Ngay
        ];

        return self::call($params);
    }
}
