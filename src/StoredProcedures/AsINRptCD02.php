<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-07-05 23:13:32
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptCD02
{
    /**
     * Call stored procedure asINRptCD02.
     *
     * @param array $params Procedure parameters
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCD02', self::procedureParams($params), $connection);
    }

    /**
     * @return array<string,mixed>
     */
    public static function procedureParams(array $params): array
    {
        $paramObj = ParamHelper::fromArray($params);

        return [
            'pMa_cty'      => $paramObj->pMa_cty ?? $paramObj->pMa_Cty ?? null,
            'pMa_vt'       => $paramObj->pMa_vt ?? $paramObj->ma_vt ?? null,
            'pMa_kho'      => $paramObj->pMa_kho ?? $paramObj->ma_kho ?? null,
            'pMa_vitri'    => $paramObj->pMa_vitri ?? $paramObj->ma_vitri ?? null,
            'pTk_vt'       => $paramObj->pTk_vt ?? $paramObj->tk_vt ?? null,
            'pMa_nhvt'     => $paramObj->pMa_nhvt ?? $paramObj->pNh_vt ?? $paramObj->nh_vt ?? null,
            'pNgay'        => $paramObj->pNgay ?? $paramObj->ngay ?? null,
            'pDVT'         => $paramObj->pDVT ?? $paramObj->dvt ?? null,
            'pNgoai_te'    => $paramObj->pNgoai_te ?? $paramObj->ngoai_te ?? null,
            'pDk_Ck'       => $paramObj->pDk_Ck ?? $paramObj->dk_ck ?? null,
            'pMa_lo'       => $paramObj->pMa_lo ?? $paramObj->ma_lo ?? null,
            'pQuaToiThieu' => $paramObj->pQuaToiThieu ?? $paramObj->qua_toi_thieu ?? null,
            'pQuaToiDa'    => $paramObj->pQuaToiDa ?? $paramObj->qua_toi_da ?? null,
        ];
    }

    /**
     * Call stored procedure asINRptCD02 with named parameters.
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Ma_vt = null,
        ?string $Ma_kho = null,
        ?string $Ma_vitri = null,
        ?string $Tk_vt = null,
        ?string $Ma_nhvt = null,
        ?string $Ngay = null,
        ?string $DVT = null,
        ?string $Ngoai_te = null,
        ?bool $Dk_Ck = null,
        ?string $Ma_lo = null,
        ?bool $QuaToiThieu = null,
        ?bool $QuaToiDa = null,
    ): Collection {
        $params = [
            'pMa_cty'      => $Ma_cty,
            'pMa_vt'       => $Ma_vt,
            'pMa_kho'      => $Ma_kho,
            'pMa_vitri'    => $Ma_vitri,
            'pTk_vt'       => $Tk_vt,
            'pMa_nhvt'     => $Ma_nhvt,
            'pNgay'        => $Ngay,
            'pDVT'         => $DVT,
            'pNgoai_te'    => $Ngoai_te,
            'pDk_Ck'       => $Dk_Ck,
            'pMa_lo'       => $Ma_lo,
            'pQuaToiThieu' => $QuaToiThieu,
            'pQuaToiDa'    => $QuaToiDa,
        ];

        return self::call($params);
    }
}
