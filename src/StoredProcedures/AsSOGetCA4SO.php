<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSOGetCA4SO
{
    /**
     * Call stored procedure asSOGetCA4SO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetCA4SO', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pStt_rec_hd' => $paramObj->pStt_rec_hd ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetCA4SO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ct
     * @param string $Stt_rec_hd
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ct = null, string $Stt_rec_hd = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ct' => $Ma_ct,
            'pStt_rec_hd' => $Stt_rec_hd
        ];

        return self::call($params);
    }
}
