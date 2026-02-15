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
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIRptLogCt', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pAction' => $params['pAction'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pUser' => $params['pUser'] ?? null,
            'ph' => $params['ph'] ?? null
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
