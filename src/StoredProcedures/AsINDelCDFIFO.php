<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:11
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINDelCDFIFO
{
    /**
     * Call stored procedure asINDelCDFIFO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINDelCDFIFO', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec_nt' => $paramObj->pStt_rec_nt ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINDelCDFIFO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec_nt
     * @param string $Stt_rec0
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec_nt = null, string $Stt_rec0 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec_nt' => $Stt_rec_nt,
            'pStt_rec0' => $Stt_rec0
        ];

        return self::call($params);
    }
}
