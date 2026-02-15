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
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmCCTC', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId_CCTC' => $params['pId_CCTC'] ?? null,
            'pTen_CCTC' => $params['pTen_CCTC'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null,
            'pId_parent' => $params['pId_parent'] ?? null,
            'pStt_cay' => $params['pStt_cay'] ?? null,
            'pBac' => $params['pBac'] ?? null
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
