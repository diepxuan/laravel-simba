<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGetcolk
{
    /**
     * Call stored procedure asGetcolk
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetcolk', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asGetcolk with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param int $Thang
     * @param string $Ma_spct
     * @param string $Tk
     * @param string $Tk_du
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, int $Thang = null, string $Ma_spct = null, string $Tk = null, string $Tk_du = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pThang' => $Thang,
            'pMa_spct' => $Ma_spct,
            'pTk' => $Tk,
            'pTk_du' => $Tk_du
        ];
        
        return self::call($params);
    }
}
