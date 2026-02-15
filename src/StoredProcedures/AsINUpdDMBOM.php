<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINUpdDMBOM
{
    /**
     * Call stored procedure asINUpdDMBOM
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINUpdDMBOM', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_lk' => $params['pMa_lk'] ?? null,
            'pTen_lk' => $params['pTen_lk'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pHe_so' => $params['pHe_so'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINUpdDMBOM with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vt
     * @param string $Ma_lk
     * @param string $Ten_lk
     * @param string $Dvt
     * @param float $So_luong
     * @param float $He_so
     * @param string $Ghi_chu
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vt = null, string $Ma_lk = null, string $Ten_lk = null, string $Dvt = null, float $So_luong = null, float $He_so = null, string $Ghi_chu = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vt' => $Ma_vt,
            'pMa_lk' => $Ma_lk,
            'pTen_lk' => $Ten_lk,
            'pDvt' => $Dvt,
            'pSo_luong' => $So_luong,
            'pHe_so' => $He_so,
            'pGhi_chu' => $Ghi_chu,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
