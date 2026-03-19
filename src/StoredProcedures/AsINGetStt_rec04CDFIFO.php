<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINGetStt_rec04CDFIFO
{
    /**
     * Call stored procedure asINGetStt_rec04CDFIFO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetStt_rec04CDFIFO', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINGetStt_rec04CDFIFO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay_ct
     * @param string $So_ct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay_ct = null, string $So_ct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay_ct' => $Ngay_ct,
            'pSo_ct' => $So_ct
        ];

        return self::call($params);
    }
}
