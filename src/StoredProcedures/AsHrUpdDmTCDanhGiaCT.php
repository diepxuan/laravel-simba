<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:44
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdDmTCDanhGiaCT
{
    /**
     * Call stored procedure asHrUpdDmTCDanhGiaCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmTCDanhGiaCT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tcdg' => $params['pMa_tcdg'] ?? null,
            'pId_diem' => $params['pId_diem'] ?? null,
            'pDiem_dg' => $params['pDiem_dg'] ?? null,
            'pKy_hieu' => $params['pKy_hieu'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDmTCDanhGiaCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tcdg
     * @param string $Id_diem
     * @param float $Diem_dg
     * @param string $Ky_hieu
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tcdg = null, string $Id_diem = null, float $Diem_dg = null, string $Ky_hieu = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tcdg' => $Ma_tcdg,
            'pId_diem' => $Id_diem,
            'pDiem_dg' => $Diem_dg,
            'pKy_hieu' => $Ky_hieu,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
