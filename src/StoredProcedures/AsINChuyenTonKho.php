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

class AsINChuyenTonKho
{
    /**
     * Call stored procedure asINChuyenTonKho
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINChuyenTonKho', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pngay_cnt' => $params['pngay_cnt'] ?? null,
            'pma_kho' => $params['pma_kho'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINChuyenTonKho with named parameters
     *
     * @param string $ma_cty
     * @param string $ngay_cnt
     * @param string $ma_kho
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, string $ngay_cnt = null, string $ma_kho = null, int $Ret = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pngay_cnt' => $ngay_cnt,
            'pma_kho' => $ma_kho,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
