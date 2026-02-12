<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:22:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCOUpdDMSPCT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCOUpdDMSPCT', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pMa_spct' => $params['pMa_spct'] ?? '',
            'pTen_spct' => $params['pTen_spct'] ?? '',
            'pNgay_kc' => $params['pNgay_kc'] ?? '',
            'pNgay_kt' => $params['pNgay_kt'] ?? '',
            'pDu_toan' => $params['pDu_toan'] ?? '',
            'pDu_toan_NT' => $params['pDu_toan_NT'] ?? '',
            'pDv_tc' => $params['pDv_tc'] ?? '',
            'pGhi_chu' => $params['pGhi_chu'] ?? '',
            'pDvt' => $params['pDvt'] ?? '',
            'pMa_nhspct' => $params['pMa_nhspct'] ?? '',
            'pSan_pham' => $params['pSan_pham'] ?? '',
            'pKsd' => $params['pKsd'] ?? '',
            'pLUser' => $params['pLUser'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
