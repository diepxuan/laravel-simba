<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsTAUDPTNDN01A
{
    /**
     * Call stored procedure asTAUDPTNDN01A
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTAUDPTNDN01A', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pmau' => $params['pmau'] ?? null,
            'pma_so' => $params['pma_so'] ?? null,
            'pstt' => $params['pstt'] ?? null,
            'pchi_tieu' => $params['pchi_tieu'] ?? null,
            'pcach_tinh' => $params['pcach_tinh'] ?? null,
            'ptk' => $params['ptk'] ?? null,
            'pno_co' => $params['pno_co'] ?? null,
            'ptk_du' => $params['ptk_du'] ?? null,
            'pbold' => $params['pbold'] ?? null,
            'pin_ck' => $params['pin_ck'] ?? null,
            'pModify' => $params['pModify'] ?? null,
            'pUser_sort' => $params['pUser_sort'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asTAUDPTNDN01A with named parameters
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
     * @param bool $Modify
     * @param int $User_sort
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $mau = null, string $ma_so = null, string $stt = null, string $chi_tieu = null, string $cach_tinh = null, string $tk = null, string $no_co = null, string $tk_du = null, bool $bold = null, bool $in_ck = null, bool $Modify = null, int $User_sort = null, int $Ret = null): Collection
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
            'pModify' => $Modify,
            'pUser_sort' => $User_sort,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
