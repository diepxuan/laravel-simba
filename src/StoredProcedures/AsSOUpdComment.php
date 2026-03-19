<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSOUpdComment
{
    /**
     * Call stored procedure asSOUpdComment
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdComment', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pTable_name' => $paramObj->pTable_name ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'params' => $paramObj->params ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdComment with named parameters
     *
     * @param string $Ma_cty
     * @param mixed $Table_name
     * @param string $Stt_rec
     * @param string $Ghi_chu
     * @param string $arams
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, mixed $Table_name = null, string $Stt_rec = null, string $Ghi_chu = null, string $arams = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pTable_name' => $Table_name,
            'pStt_rec' => $Stt_rec,
            'pGhi_chu' => $Ghi_chu,
            'params' => $arams
        ];

        return self::call($params);
    }
}
