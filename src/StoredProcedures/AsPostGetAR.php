<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:06
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPostGetAR
{
    /**
     * Call stored procedure asPostGetAR
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostGetAR', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pSo_ct1' => $paramObj->pSo_ct1 ?? null,
            'pSo_ct2' => $paramObj->pSo_ct2 ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pPost2gl' => $paramObj->pPost2gl ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostGetAR with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $So_ct1
     * @param string $So_ct2
     * @param string $Ma_kh
     * @param string $Ma_ct
     * @param string $Post2gl
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $So_ct1 = null, string $So_ct2 = null, string $Ma_kh = null, string $Ma_ct = null, string $Post2gl = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pSo_ct1' => $So_ct1,
            'pSo_ct2' => $So_ct2,
            'pMa_kh' => $Ma_kh,
            'pMa_ct' => $Ma_ct,
            'pPost2gl' => $Post2gl
        ];

        return self::call($params);
    }
}
