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

class AsSAInsDmCongDoan
{
    /**
     * Call stored procedure asSAInsDmCongDoan
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAInsDmCongDoan', $params, $connection);
    }

    /**
     * Call stored procedure asSAInsDmCongDoan with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_congdoan
     * @param string $Ma_sanpham
     * @param string $Ten_cd
     * @param string $CUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_congdoan = null, string $Ma_sanpham = null, string $Ten_cd = null, string $CUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_congdoan' => $Ma_congdoan,
            'pMa_sanpham' => $Ma_sanpham,
            'pTen_cd' => $Ten_cd,
            'pCUser' => $CUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
