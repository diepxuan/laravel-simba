<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:54
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrDelQTKhenThuong
{
    /**
     * Call stored procedure asHrDelQTKhenThuong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelQTKhenThuong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtktkl' => $params['pId_qtktkl'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelQTKhenThuong with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtktkl
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtktkl = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtktkl' => $Id_qtktkl,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
