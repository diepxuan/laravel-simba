<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:05
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsTAUDPTNDN031A
{
    /**
     * Call stored procedure asTAUDPTNDN031A
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTAUDPTNDN031A', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pmau' => $paramObj->pmau ?? null,
            'pma_so' => $paramObj->pma_so ?? null,
            'pstt' => $paramObj->pstt ?? null,
            'pchi_tieu' => $paramObj->pchi_tieu ?? null,
            'pcach_tinh' => $paramObj->pcach_tinh ?? null,
            'ptk' => $paramObj->ptk ?? null,
            'pno_co' => $paramObj->pno_co ?? null,
            'ptk_du' => $paramObj->ptk_du ?? null,
            'pbold' => $paramObj->pbold ?? null,
            'pin_ck' => $paramObj->pin_ck ?? null,
            'pUser_sort' => $paramObj->pUser_sort ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asTAUDPTNDN031A with named parameters
     *
     * @param string $Ma_cty
     * @param string $mau
     * @param string $ma_so
     * @param string $stt
     * @param string $chi_tieu
     * @param string $cach_tinh
     * @param string $tk
     * @param string $no_co
     * @param string $tk_du
     * @param bool $bold
     * @param bool $in_ck
     * @param int $User_sort
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $mau = null, string $ma_so = null, string $stt = null, string $chi_tieu = null, string $cach_tinh = null, string $tk = null, string $no_co = null, string $tk_du = null, bool $bold = null, bool $in_ck = null, int $User_sort = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pmau' => $mau,
            'pma_so' => $ma_so,
            'pstt' => $stt,
            'pchi_tieu' => $chi_tieu,
            'pcach_tinh' => $cach_tinh,
            'ptk' => $tk,
            'pno_co' => $no_co,
            'ptk_du' => $tk_du,
            'pbold' => $bold,
            'pin_ck' => $in_ck,
            'pUser_sort' => $User_sort,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
