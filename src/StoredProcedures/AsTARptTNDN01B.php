<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsTARptTNDN01B
{
    /**
     * Call stored procedure asTARptTNDN01B
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTARptTNDN01B', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMau' => $paramObj->pMau ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asTARptTNDN01B with named parameters
     *
     * @param string $Ma_Cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Mau
     * @return Collection
     */
    public static function callWithParams(string $Ma_Cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Mau = null): Collection
    {
        $params = [
            'pMa_Cty' => $Ma_Cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMau' => $Mau
        ];

        return self::call($params);
    }
}
