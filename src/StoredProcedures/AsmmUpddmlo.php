<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsmmUpddmlo
{
    /**
     * Call stored procedure asmmUpddmlo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asmmUpddmlo', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_lo_tp' => $params['pMa_lo_tp'] ?? null,
            'pTen_lo' => $params['pTen_lo'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pTen_vt' => $params['pTen_vt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pHan_dung' => $params['pHan_dung'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asmmUpddmlo with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_lo_tp
     * @param string $Ten_lo
     * @param bool $Ksd
     * @param string $Ten_vt
     * @param float $So_luong
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_vt
     * @param string $LUser
     * @param string $Han_dung
     * @param string $Trang_thai
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_lo_tp = null, string $Ten_lo = null, bool $Ksd = null, string $Ten_vt = null, float $So_luong = null, int $Thang = null, int $Nam = null, string $Ma_vt = null, string $LUser = null, string $Han_dung = null, string $Trang_thai = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_lo_tp' => $Ma_lo_tp,
            'pTen_lo' => $Ten_lo,
            'pKsd' => $Ksd,
            'pTen_vt' => $Ten_vt,
            'pSo_luong' => $So_luong,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_vt' => $Ma_vt,
            'pLUser' => $LUser,
            'pHan_dung' => $Han_dung,
            'pTrang_thai' => $Trang_thai,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
