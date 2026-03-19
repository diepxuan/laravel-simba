<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:54
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdDmCCTC
{
    /**
     * Call stored procedure asHrUpdDmCCTC
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmCCTC', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId_CCTC' => $paramObj->pId_CCTC ?? null,
            'pTen_CCTC' => $paramObj->pTen_CCTC ?? null,
            'pStt' => $paramObj->pStt ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null,
            'pId_parent' => $paramObj->pId_parent ?? null,
            'pStt_cay' => $paramObj->pStt_cay ?? null,
            'pBac' => $paramObj->pBac ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDmCCTC with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id_CCTC
     * @param string $Ten_CCTC
     * @param int $Stt
     * @param string $Ma_bp
     * @param string $Luser
     * @param int $Ret
     * @param string $Id_parent
     * @param string $Stt_cay
     * @param int $Bac
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id_CCTC = null, string $Ten_CCTC = null, int $Stt = null, string $Ma_bp = null, string $Luser = null, int $Ret = null, string $Id_parent = null, string $Stt_cay = null, int $Bac = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId_CCTC' => $Id_CCTC,
            'pTen_CCTC' => $Ten_CCTC,
            'pStt' => $Stt,
            'pMa_bp' => $Ma_bp,
            'pLuser' => $Luser,
            'pRet' => $Ret,
            'pId_parent' => $Id_parent,
            'pStt_cay' => $Stt_cay,
            'pBac' => $Bac
        ];

        return self::call($params);
    }
}
