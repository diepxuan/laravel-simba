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

class AsINPostCDFIFO2CDVT
{
    /**
     * Call stored procedure asINPostCDFIFO2CDVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINPostCDFIFO2CDVT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pAction' => $paramObj->pAction ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINPostCDFIFO2CDVT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Action
     * @param int $Nam
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_nt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Action = null, int $Nam = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_nt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pAction' => $Action,
            'pNam' => $Nam,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_nt' => $Ma_nt
        ];

        return self::call($params);
    }
}
