<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSORptTH02
{
    /**
     * Call stored procedure asSORptTH02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptTH02', [
            'pma_cty' => $paramObj->pma_cty ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pSo_ky' => $paramObj->pSo_ky ?? null,
            'pLoai' => $paramObj->pLoai ?? null,
            'pLoai_CT' => $paramObj->pLoai_CT ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pIs_NT' => $paramObj->pIs_NT ?? null,
            'ploai' => $paramObj->ploai ?? null,
            'par' => $paramObj->par ?? null,
            'p2' => $paramObj->p2 ?? null,
            'pSoLoai' => $paramObj->pSoLoai ?? null,
            'pSoQuy' => $paramObj->pSoQuy ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptTH02 with named parameters
     *
     * @param string $ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param int $So_ky
     * @param string $Loai
     * @param string $Loai_CT
     * @param string $Ma_nt
     * @param bool $Is_NT
     * @param mixed $loai
     * @param string $ar
     * @param string $2
     * @param string $SoLoai
     * @param string $SoQuy
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, int $Thang = null, int $Nam = null, int $So_ky = null, string $Loai = null, string $Loai_CT = null, string $Ma_nt = null, bool $Is_NT = null, mixed $loai = null, string $ar = null, string $2 = null, string $SoLoai = null, string $SoQuy = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pSo_ky' => $So_ky,
            'pLoai' => $Loai,
            'pLoai_CT' => $Loai_CT,
            'pMa_nt' => $Ma_nt,
            'pIs_NT' => $Is_NT,
            'ploai' => $loai,
            'par' => $ar,
            'p2' => $2,
            'pSoLoai' => $SoLoai,
            'pSoQuy' => $SoQuy
        ];

        return self::call($params);
    }
}
