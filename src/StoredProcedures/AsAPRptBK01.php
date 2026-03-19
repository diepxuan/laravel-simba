<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:37
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPRptBK01
{
    /**
     * Call stored procedure asAPRptBK01.
     *
     * @param array $params Procedure parameters
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPRptBK01', [
            'pMa_cty'   => $paramObj->pMa_cty ?? null,
            'pNgay1'    => $paramObj->pNgay1 ?? null,
            'pNgay2'    => $paramObj->pNgay2 ?? null,
            'pMa_kh'    => $paramObj->pMa_kh ?? null,
            'pMa_vt'    => $paramObj->pMa_vt ?? null,
            'pMa_nhvt'  => $paramObj->pMa_nhvt ?? null,
            'pMa_kho'   => $paramObj->pMa_kho ?? null,
            'pMa_lo'    => $paramObj->pMa_lo ?? null,
            'pMa_phi'   => $paramObj->pMa_phi ?? null,
            'pMa_spct'  => $paramObj->pMa_spct ?? null,
            'pMa_bp'    => $paramObj->pMa_bp ?? null,
            'pMa_nt'    => $paramObj->pMa_nt ?? null,
            'pMa_hd'    => $paramObj->pMa_hd ?? null,
            'pSo_PN'    => $paramObj->pSo_PN ?? null,
            'pSoct1'    => $paramObj->pSoct1 ?? null,
            'pSoct2'    => $paramObj->pSoct2 ?? null,
            'pMa_plkh1' => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2' => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3' => $paramObj->pMa_plkh3 ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asAPRptBK01 with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ngay1 = null, ?string $Ngay2 = null, ?string $Ma_kh = null, ?string $Ma_vt = null, ?string $Ma_nhvt = null, ?string $Ma_kho = null, ?string $Ma_lo = null, ?string $Ma_phi = null, ?string $Ma_spct = null, ?string $Ma_bp = null, ?string $Ma_nt = null, ?string $Ma_hd = null, ?string $So_PN = null, ?string $Soct1 = null, ?string $Soct2 = null, ?string $Ma_plkh1 = null, ?string $Ma_plkh2 = null, ?string $Ma_plkh3 = null): Collection
    {
        $params = [
            'pMa_cty'   => $Ma_cty,
            'pNgay1'    => $Ngay1,
            'pNgay2'    => $Ngay2,
            'pMa_kh'    => $Ma_kh,
            'pMa_vt'    => $Ma_vt,
            'pMa_nhvt'  => $Ma_nhvt,
            'pMa_kho'   => $Ma_kho,
            'pMa_lo'    => $Ma_lo,
            'pMa_phi'   => $Ma_phi,
            'pMa_spct'  => $Ma_spct,
            'pMa_bp'    => $Ma_bp,
            'pMa_nt'    => $Ma_nt,
            'pMa_hd'    => $Ma_hd,
            'pSo_PN'    => $So_PN,
            'pSoct1'    => $Soct1,
            'pSoct2'    => $Soct2,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
        ];

        return self::call($params);
    }
}
