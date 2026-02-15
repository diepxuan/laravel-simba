<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSAInsDonGiaSP
{
    /**
     * Call stored procedure asSAInsDonGiaSP
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAInsDonGiaSP', $params, $connection);
    }

    /**
     * Call stored procedure asSAInsDonGiaSP with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_sanpham
     * @param float $Don_gia
     * @param string $CUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_sanpham = null, float $Don_gia = null, string $CUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_sanpham' => $Ma_sanpham,
            'pDon_gia' => $Don_gia,
            'pCUser' => $CUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
