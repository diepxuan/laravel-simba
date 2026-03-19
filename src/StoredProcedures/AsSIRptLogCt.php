<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSIRptLogCt
{
    /**
     * Call stored procedure asSIRptLogCt
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIRptLogCt', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pAction' => $paramObj->pAction ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'ph' => $paramObj->ph ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIRptLogCt with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Action
     * @param string $Ma_ct
     * @param string $User
     * @param string $h
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Action = null, string $Ma_ct = null, string $User = null, string $h = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pAction' => $Action,
            'pMa_ct' => $Ma_ct,
            'pUser' => $User,
            'ph' => $h
        ];

        return self::call($params);
    }
}
