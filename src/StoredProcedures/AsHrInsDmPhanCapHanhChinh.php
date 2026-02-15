<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:21
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsDmPhanCapHanhChinh
{
    /**
     * Call stored procedure asHrInsDmPhanCapHanhChinh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDmPhanCapHanhChinh', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_pchc' => $params['pMa_pchc'] ?? null,
            'pTen_pchc' => $params['pTen_pchc'] ?? null,
            'pCap' => $params['pCap'] ?? null,
            'pParent' => $params['pParent'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDmPhanCapHanhChinh with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_pchc
     * @param string $Ten_pchc
     * @param int $Cap
     * @param string $Parent
     * @param string $Stt
     * @param bool $Ksd
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_pchc = null, string $Ten_pchc = null, int $Cap = null, string $Parent = null, string $Stt = null, bool $Ksd = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_pchc' => $Ma_pchc,
            'pTen_pchc' => $Ten_pchc,
            'pCap' => $Cap,
            'pParent' => $Parent,
            'pStt' => $Stt,
            'pKsd' => $Ksd,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
