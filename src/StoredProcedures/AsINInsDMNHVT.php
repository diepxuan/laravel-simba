<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:06
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINInsDMNHVT
{
    /**
     * Call stored procedure asINInsDMNHVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsDMNHVT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pTen_nhvt' => $params['pTen_nhvt'] ?? null,
            'pCap' => $params['pCap'] ?? null,
            'pStt_nhom' => $params['pStt_nhom'] ?? null,
            'pNhom_me' => $params['pNhom_me'] ?? null,
            'pCong_sl' => $params['pCong_sl'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pTk_dt' => $params['pTk_dt'] ?? null,
            'pTk_dtnb' => $params['pTk_dtnb'] ?? null,
            'pTk_gv' => $params['pTk_gv'] ?? null,
            'pTk_tl' => $params['pTk_tl'] ?? null,
            'pTk_ck' => $params['pTk_ck'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINInsDMNHVT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nhvt
     * @param string $Ten_nhvt
     * @param int $Cap
     * @param string $Stt_nhom
     * @param string $Nhom_me
     * @param bool $Cong_sl
     * @param string $Tk_vt
     * @param string $Tk_dt
     * @param string $Tk_dtnb
     * @param string $Tk_gv
     * @param string $Tk_tl
     * @param string $Tk_ck
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nhvt = null, string $Ten_nhvt = null, int $Cap = null, string $Stt_nhom = null, string $Nhom_me = null, bool $Cong_sl = null, string $Tk_vt = null, string $Tk_dt = null, string $Tk_dtnb = null, string $Tk_gv = null, string $Tk_tl = null, string $Tk_ck = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nhvt' => $Ma_nhvt,
            'pTen_nhvt' => $Ten_nhvt,
            'pCap' => $Cap,
            'pStt_nhom' => $Stt_nhom,
            'pNhom_me' => $Nhom_me,
            'pCong_sl' => $Cong_sl,
            'pTk_vt' => $Tk_vt,
            'pTk_dt' => $Tk_dt,
            'pTk_dtnb' => $Tk_dtnb,
            'pTk_gv' => $Tk_gv,
            'pTk_tl' => $Tk_tl,
            'pTk_ck' => $Tk_ck,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
