<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsProcessCalLaiKU
{
    /**
     * Call stored procedure asProcessCalLaiKU
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asProcessCalLaiKU', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pFunction' => $params['pFunction'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_ku' => $params['pMa_ku'] ?? null,
            'pUser' => $params['pUser'] ?? null,
            'pRet' => $params['pRet'] ?? null,
            'pNgay_ks' => $params['pNgay_ks'] ?? null,
            'pNgay' => $params['pNgay'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_KU' => $params['pMa_KU'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asProcessCalLaiKU with named parameters
     *
     * @param string $Ma_cty
     * @param int $Function
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_ct
     * @param string $Ma_ku
     * @param string $User
     * @param int $Ret
     * @param string $Ngay_ks
     * @param string $Ngay
     * @param mixed $Ma_Cty
     * @param mixed $Ma_KU
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Function = null, int $Thang = null, int $Nam = null, string $Ma_ct = null, string $Ma_ku = null, string $User = null, int $Ret = null, string $Ngay_ks = null, string $Ngay = null, mixed $Ma_Cty = null, mixed $Ma_KU = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pFunction' => $Function,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_ct' => $Ma_ct,
            'pMa_ku' => $Ma_ku,
            'pUser' => $User,
            'pRet' => $Ret,
            'pNgay_ks' => $Ngay_ks,
            'pNgay' => $Ngay,
            'pMa_Cty' => $Ma_Cty,
            'pMa_KU' => $Ma_KU
        ];
        
        return self::call($params);
    }
}
