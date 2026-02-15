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

class AsINRptBK01
{
    /**
     * Call stored procedure asINRptBK01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptBK01', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptBK01 with named parameters
     *
     * @param string $ma_cty
     * @param int $Nam
     * @param int $Thang
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param mixed $Ma_cty
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, int $Nam = null, int $Thang = null, string $Ma_vt = null, string $Ma_kho = null, mixed $Ma_cty = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pNam' => $Nam,
            'pThang' => $Thang,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_cty' => $Ma_cty
        ];
        
        return self::call($params);
    }
}
