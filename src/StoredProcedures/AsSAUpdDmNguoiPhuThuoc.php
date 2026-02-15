<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSAUpdDmNguoiPhuThuoc
{
    /**
     * Call stored procedure asSAUpdDmNguoiPhuThuoc
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAUpdDmNguoiPhuThuoc', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_nv' => $params['pMa_nv'] ?? null,
            'pSo_npt' => $params['pSo_npt'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSAUpdDmNguoiPhuThuoc with named parameters
     *
     * @param string $Ma_cty
     * @param string $Thang
     * @param string $Nam
     * @param string $Ma_nv
     * @param int $So_npt
     * @param string $Ghi_chu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Thang = null, string $Nam = null, string $Ma_nv = null, int $So_npt = null, string $Ghi_chu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_nv' => $Ma_nv,
            'pSo_npt' => $So_npt,
            'pGhi_chu' => $Ghi_chu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
