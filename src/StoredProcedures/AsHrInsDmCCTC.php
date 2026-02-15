<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsDmCCTC
{
    /**
     * Call stored procedure asHrInsDmCCTC
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDmCCTC', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId_CCTC' => $params['pId_CCTC'] ?? null,
            'pTen_CCTC' => $params['pTen_CCTC'] ?? null,
            'pId_Parent' => $params['pId_Parent'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pBac' => $params['pBac'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null,
            'pStt_cay' => $params['pStt_cay'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDmCCTC with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id_CCTC
     * @param string $Ten_CCTC
     * @param string $Id_Parent
     * @param int $Stt
     * @param int $Bac
     * @param string $Ma_bp
     * @param string $Cuser
     * @param int $Ret
     * @param string $Stt_cay
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id_CCTC = null, string $Ten_CCTC = null, string $Id_Parent = null, int $Stt = null, int $Bac = null, string $Ma_bp = null, string $Cuser = null, int $Ret = null, string $Stt_cay = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId_CCTC' => $Id_CCTC,
            'pTen_CCTC' => $Ten_CCTC,
            'pId_Parent' => $Id_Parent,
            'pStt' => $Stt,
            'pBac' => $Bac,
            'pMa_bp' => $Ma_bp,
            'pCuser' => $Cuser,
            'pRet' => $Ret,
            'pStt_cay' => $Stt_cay
        ];
        
        return self::call($params);
    }
}
