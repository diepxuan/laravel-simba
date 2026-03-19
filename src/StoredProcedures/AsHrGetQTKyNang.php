<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrGetQTKyNang
{
    /**
     * Call stored procedure asHrGetQTKyNang
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetQTKyNang', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId' => $paramObj->pId ?? null,
            'pId_qtkn' => $paramObj->pId_qtkn ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetQTKyNang with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtkn
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtkn = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtkn' => $Id_qtkn
        ];

        return self::call($params);
    }
}
