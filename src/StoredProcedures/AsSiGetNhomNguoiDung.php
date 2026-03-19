<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSiGetNhomNguoiDung
{
    /**
     * Call stored procedure asSiGetNhomNguoiDung
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiGetNhomNguoiDung', $params, $connection);
    }

    /**
     * Call stored procedure asSiGetNhomNguoiDung with named parameters
     *
@return Collection
     */
    public static function callWithParams(): Collection
    {
        $params = [];

        return self::call($params);
    }
}
