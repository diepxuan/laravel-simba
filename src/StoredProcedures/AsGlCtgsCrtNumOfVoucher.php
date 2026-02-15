<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGlCtgsCrtNumOfVoucher
{
    /**
     * Call stored procedure asGlCtgsCrtNumOfVoucher
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGlCtgsCrtNumOfVoucher', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pTen_ct_gs' => $params['pTen_ct_gs'] ?? null,
            'pSo_hieu' => $params['pSo_hieu'] ?? null,
            'pNgay_lo' => $params['pNgay_lo'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pma_ct' => $params['pma_ct'] ?? null,
            'prevLen' => $params['prevLen'] ?? null,
            'pMa_Ct' => $params['pMa_Ct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asGlCtgsCrtNumOfVoucher with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ct
     * @param string $Tk
     * @param string $Ten_ct_gs
     * @param string $So_hieu
     * @param string $Ngay_lo
     * @param string $Ngay1
     * @param mixed $ma_ct
     * @param int $revLen
     * @param mixed $Ma_Ct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ct = null, string $Tk = null, string $Ten_ct_gs = null, string $So_hieu = null, string $Ngay_lo = null, string $Ngay1 = null, mixed $ma_ct = null, int $revLen = null, mixed $Ma_Ct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ct' => $Ma_ct,
            'pTk' => $Tk,
            'pTen_ct_gs' => $Ten_ct_gs,
            'pSo_hieu' => $So_hieu,
            'pNgay_lo' => $Ngay_lo,
            'pNgay1' => $Ngay1,
            'pma_ct' => $ma_ct,
            'prevLen' => $revLen,
            'pMa_Ct' => $Ma_Ct
        ];
        
        return self::call($params);
    }
}
