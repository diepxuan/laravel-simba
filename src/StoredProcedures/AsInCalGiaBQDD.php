<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:18
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInCalGiaBQDD
{
    /**
     * Call stored procedure asInCalGiaBQDD
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInCalGiaBQDD', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pNhom_vt' => $params['pNhom_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pTk_cl' => $params['pTk_cl'] ?? null,
            'pDk_cl' => $params['pDk_cl'] ?? null,
            'pma_ct_cl' => $params['pma_ct_cl'] ?? null,
            'pMa_ct_cl' => $params['pMa_ct_cl'] ?? null,
            'pnhom_vt' => $params['pnhom_vt'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInCalGiaBQDD with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_vt
     * @param string $Tk_vt
     * @param string $Nhom_vt
     * @param string $Ma_kho
     * @param string $Tk_cl
     * @param string $Dk_cl
     * @param mixed $ma_ct_cl
     * @param mixed $Ma_ct_cl
     * @param mixed $nhom_vt
     * @param mixed $ma_cty
     * @param mixed $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_vt = null, string $Tk_vt = null, string $Nhom_vt = null, string $Ma_kho = null, string $Tk_cl = null, string $Dk_cl = null, mixed $ma_ct_cl = null, mixed $Ma_ct_cl = null, mixed $nhom_vt = null, mixed $ma_cty = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_vt' => $Ma_vt,
            'pTk_vt' => $Tk_vt,
            'pNhom_vt' => $Nhom_vt,
            'pMa_kho' => $Ma_kho,
            'pTk_cl' => $Tk_cl,
            'pDk_cl' => $Dk_cl,
            'pma_ct_cl' => $ma_ct_cl,
            'pMa_ct_cl' => $Ma_ct_cl,
            'pnhom_vt' => $nhom_vt,
            'pma_cty' => $ma_cty,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
