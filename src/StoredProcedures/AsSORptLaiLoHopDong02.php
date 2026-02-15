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

class AsSORptLaiLoHopDong02
{
    /**
     * Call stored procedure asSORptLaiLoHopDong02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptLaiLoHopDong02', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pTk_DT' => $params['pTk_DT'] ?? null,
            'pTkDu_DT' => $params['pTkDu_DT'] ?? null,
            'pPsNc_DT' => $params['pPsNc_DT'] ?? null,
            'pTk_CP' => $params['pTk_CP'] ?? null,
            'pTkDu_CP' => $params['pTkDu_CP'] ?? null,
            'pPsNc_CP' => $params['pPsNc_CP'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptLaiLoHopDong02 with named parameters
     *
     * @param mixed $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_hd
     * @param string $Ma_kh
     * @param string $Tk_DT
     * @param string $TkDu_DT
     * @param bool $PsNc_DT
     * @param string $Tk_CP
     * @param string $TkDu_CP
     * @param bool $PsNc_CP
     * @param string $SysMsg1
     * @param mixed $ma_cty
     * @return Collection
     */
    public static function callWithParams(mixed $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_hd = null, string $Ma_kh = null, string $Tk_DT = null, string $TkDu_DT = null, bool $PsNc_DT = null, string $Tk_CP = null, string $TkDu_CP = null, bool $PsNc_CP = null, string $SysMsg1 = null, mixed $ma_cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_hd' => $Ma_hd,
            'pMa_kh' => $Ma_kh,
            'pTk_DT' => $Tk_DT,
            'pTkDu_DT' => $TkDu_DT,
            'pPsNc_DT' => $PsNc_DT,
            'pTk_CP' => $Tk_CP,
            'pTkDu_CP' => $TkDu_CP,
            'pPsNc_CP' => $PsNc_CP,
            'pSysMsg1' => $SysMsg1,
            'pma_cty' => $ma_cty
        ];
        
        return self::call($params);
    }
}
