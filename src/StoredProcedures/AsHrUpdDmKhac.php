<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:22
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdDmKhac
{
    /**
     * Call stored procedure asHrUpdDmKhac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmKhac', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pCode_name' => $paramObj->pCode_name ?? null,
            'pMa' => $paramObj->pMa ?? null,
            'pTen' => $paramObj->pTen ?? null,
            'pStt' => $paramObj->pStt ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDmKhac with named parameters
     *
     * @param string $Ma_cty
     * @param string $Code_name
     * @param string $Ma
     * @param string $Ten
     * @param string $Stt
     * @param bool $Ksd
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Code_name = null, string $Ma = null, string $Ten = null, string $Stt = null, bool $Ksd = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pCode_name' => $Code_name,
            'pMa' => $Ma,
            'pTen' => $Ten,
            'pStt' => $Stt,
            'pKsd' => $Ksd,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
