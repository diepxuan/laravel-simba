<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsRptUpdTatndn03_dc
{
    /**
     * Call stored procedure asRptUpdTatndn03_dc
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asRptUpdTatndn03_dc', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pTien' => $params['pTien'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pRet' => $params['pRet'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asRptUpdTatndn03_dc with named parameters
     *
     * @param string $Ma_Cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Mau
     * @param string $Ma_so
     * @param float $Tien
     * @param string $Stt
     * @param int $Ret
     * @param mixed $Ma_cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_Cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Mau = null, string $Ma_so = null, float $Tien = null, string $Stt = null, int $Ret = null, mixed $Ma_cty = null): Collection
    {
        $params = [
            'pMa_Cty' => $Ma_Cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMau' => $Mau,
            'pMa_so' => $Ma_so,
            'pTien' => $Tien,
            'pStt' => $Stt,
            'pRet' => $Ret,
            'pMa_cty' => $Ma_cty
        ];
        
        return self::call($params);
    }
}
