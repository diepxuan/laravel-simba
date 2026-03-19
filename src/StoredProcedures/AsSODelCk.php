<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSODelCk
{
    /**
     * Call stored procedure asSODelCk
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSODelCk', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_kyck' => $paramObj->pMa_kyck ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pSl_ds' => $paramObj->pSl_ds ?? null,
            'ptl_sl_ds' => $paramObj->ptl_sl_ds ?? null,
            'pTl_gt' => $paramObj->pTl_gt ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSODelCk with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kyck
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Sl_ds
     * @param string $tl_sl_ds
     * @param string $Tl_gt
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kyck = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Sl_ds = null, string $tl_sl_ds = null, string $Tl_gt = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kyck' => $Ma_kyck,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pSl_ds' => $Sl_ds,
            'ptl_sl_ds' => $tl_sl_ds,
            'pTl_gt' => $Tl_gt,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
