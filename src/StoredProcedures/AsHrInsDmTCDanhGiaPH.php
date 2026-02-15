<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsDmTCDanhGiaPH
{
    /**
     * Call stored procedure asHrInsDmTCDanhGiaPH
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDmTCDanhGiaPH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tcdg' => $params['pMa_tcdg'] ?? null,
            'pTen_tcdg' => $params['pTen_tcdg'] ?? null,
            'pDiem_toi_da' => $params['pDiem_toi_da'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDmTCDanhGiaPH with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tcdg
     * @param string $Ten_tcdg
     * @param float $Diem_toi_da
     * @param string $Ghi_chu
     * @param bool $Ksd
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tcdg = null, string $Ten_tcdg = null, float $Diem_toi_da = null, string $Ghi_chu = null, bool $Ksd = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tcdg' => $Ma_tcdg,
            'pTen_tcdg' => $Ten_tcdg,
            'pDiem_toi_da' => $Diem_toi_da,
            'pGhi_chu' => $Ghi_chu,
            'pKsd' => $Ksd,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
