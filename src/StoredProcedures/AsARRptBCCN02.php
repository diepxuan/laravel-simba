<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARRptBCCN02
{
    /**
     * Call stored procedure asARRptBCCN02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN02', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pGroup1' => $params['pGroup1'] ?? null,
            'pGroup2' => $params['pGroup2'] ?? null,
            'pGroup3' => $params['pGroup3'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pSysMsg2' => $params['pSysMsg2'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asARRptBCCN02 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Tk
     * @param string $Ma_kh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_nt
     * @param string $Group1
     * @param string $Group2
     * @param string $Group3
     * @param string $SysMsg1
     * @param string $SysMsg2
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Tk = null, string $Ma_kh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_nt = null, string $Group1 = null, string $Group2 = null, string $Group3 = null, string $SysMsg1 = null, string $SysMsg2 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pTk' => $Tk,
            'pMa_kh' => $Ma_kh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_nt' => $Ma_nt,
            'pGroup1' => $Group1,
            'pGroup2' => $Group2,
            'pGroup3' => $Group3,
            'pSysMsg1' => $SysMsg1,
            'pSysMsg2' => $SysMsg2
        ];
        
        return self::call($params);
    }
}
