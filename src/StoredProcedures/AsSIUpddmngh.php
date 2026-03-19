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
use Diepxuan\Simba\Helper\ParamHelper;

class AsSIUpddmngh
{
    /**
     * Call stored procedure asSIUpddmngh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIUpddmngh', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ngh' => $paramObj->pMa_ngh ?? null,
            'pTen_ngh' => $paramObj->pTen_ngh ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pkSd' => $paramObj->pkSd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIUpddmngh with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ngh
     * @param string $Ten_ngh
     * @param string $Ghi_chu
     * @param bool $kSd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ngh = null, string $Ten_ngh = null, string $Ghi_chu = null, bool $kSd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ngh' => $Ma_ngh,
            'pTen_ngh' => $Ten_ngh,
            'pGhi_chu' => $Ghi_chu,
            'pkSd' => $kSd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
