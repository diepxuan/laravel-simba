<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:20
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsDmKhac
{
    /**
     * Call stored procedure asHrInsDmKhac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDmKhac', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pCode_name' => $params['pCode_name'] ?? null,
            'pMa' => $params['pMa'] ?? null,
            'pTen' => $params['pTen'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDmKhac with named parameters
     *
     * @param string $Ma_cty
     * @param string $Code_name
     * @param string $Ma
     * @param string $Ten
     * @param string $Stt
     * @param bool $Ksd
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Code_name = null, string $Ma = null, string $Ten = null, string $Stt = null, bool $Ksd = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pCode_name' => $Code_name,
            'pMa' => $Ma,
            'pTen' => $Ten,
            'pStt' => $Stt,
            'pKsd' => $Ksd,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
