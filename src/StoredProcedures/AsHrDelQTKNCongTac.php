<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrDelQTKNCongTac
{
    /**
     * Call stored procedure asHrDelQTKNCongTac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelQTKNCongTac', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId' => $paramObj->pId ?? null,
            'pId_qtknct' => $paramObj->pId_qtknct ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelQTKNCongTac with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtknct
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtknct = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtknct' => $Id_qtknct,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
