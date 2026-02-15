<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdTDVongThi
{
    /**
     * Call stored procedure asHrUpdTDVongThi
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdTDVongThi', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_yctd' => $params['pMa_yctd'] ?? null,
            'pVong_so' => $params['pVong_so'] ?? null,
            'pTen_vong' => $params['pTen_vong'] ?? null,
            'pSo_nguoi_lh' => $params['pSo_nguoi_lh'] ?? null,
            'pSo_nguoi_tg' => $params['pSo_nguoi_tg'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdTDVongThi with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_yctd
     * @param string $Vong_so
     * @param string $Ten_vong
     * @param int $So_nguoi_lh
     * @param int $So_nguoi_tg
     * @param string $Ghi_chu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Vong_so = null, string $Ten_vong = null, int $So_nguoi_lh = null, int $So_nguoi_tg = null, string $Ghi_chu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_yctd' => $Ma_yctd,
            'pVong_so' => $Vong_so,
            'pTen_vong' => $Ten_vong,
            'pSo_nguoi_lh' => $So_nguoi_lh,
            'pSo_nguoi_tg' => $So_nguoi_tg,
            'pGhi_chu' => $Ghi_chu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
