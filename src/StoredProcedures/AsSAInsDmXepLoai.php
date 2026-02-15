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

class AsSAInsDmXepLoai
{
    /**
     * Call stored procedure asSAInsDmXepLoai
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAInsDmXepLoai', $params, $connection);
    }

    /**
     * Call stored procedure asSAInsDmXepLoai with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_xeploai
     * @param float $He_so
     * @param string $CUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_xeploai = null, float $He_so = null, string $CUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_xeploai' => $Ma_xeploai,
            'pHe_so' => $He_so,
            'pCUser' => $CUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
