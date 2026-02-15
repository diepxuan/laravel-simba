<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:22
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSADelDmCongDoan
{
    /**
     * Call stored procedure asSADelDmCongDoan
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSADelDmCongDoan', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_congdoan' => $params['pMa_congdoan'] ?? null,
            'pMa_sanpham' => $params['pMa_sanpham'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSADelDmCongDoan with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_congdoan
     * @param string $Ma_sanpham
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_congdoan = null, string $Ma_sanpham = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_congdoan' => $Ma_congdoan,
            'pMa_sanpham' => $Ma_sanpham,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
