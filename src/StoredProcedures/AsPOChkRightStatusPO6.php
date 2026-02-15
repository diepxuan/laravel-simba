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

class AsPOChkRightStatusPO6
{
    /**
     * Call stored procedure asPOChkRightStatusPO6
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOChkRightStatusPO6', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOChkRightStatusPO6 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Language
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Language = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pLanguage' => $Language
        ];
        
        return self::call($params);
    }
}
