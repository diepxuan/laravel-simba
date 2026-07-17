<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-07-14 09:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARRptBCCN01SL
{
    /**
     * Call stored procedure asARRptBCCN01SL
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN01SL', self::procedureParams($params), $connection);
    }

    /**
     * Normalize parameter keys for asARRptBCCN01SL.
     *
     * Tham so gom 6 field theo DLL `ARRptBCCN01.dll` decompile (`frmARRptBCCN01.LoadData`):
     *   ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt
     * Vi `asARRptBCCN01SL` cung DLL, cung Form, chi khac report `ARBCCN012.rpt` (style 02),
     * nen dung chung tap tham so nay.
     *
     * @return array<string,mixed>
     */
    public static function procedureParams(array $params): array
    {
        $paramObj = ParamHelper::fromArray($params);

        return [
            'ma_cty' => $paramObj->ma_cty ?? $paramObj->pMa_cty ?? $paramObj->pCompanyID ?? null,
            'Ngay1'  => $paramObj->Ngay1  ?? $paramObj->pNgay1  ?? null,
            'Ngay2'  => $paramObj->Ngay2  ?? $paramObj->pNgay2  ?? null,
            'Tk'     => $paramObj->Tk     ?? $paramObj->pTk     ?? null,
            'ma_kh'  => $paramObj->ma_kh  ?? $paramObj->pMa_kh  ?? null,
            'ma_nt'  => $paramObj->ma_nt  ?? $paramObj->pMa_nt  ?? null,
        ];
    }

    /**
     * Call stored procedure asARRptBCCN01SL with named parameters
     *
     * @param null|string $ma_cty
     * @param null|string $Ngay1
     * @param null|string $Ngay2
     * @param null|string $Tk
     * @param null|string $ma_kh
     * @param null|string $ma_nt
     * @return Collection
     */
    public static function callWithParams(
        ?string $ma_cty = null,
        ?string $Ngay1 = null,
        ?string $Ngay2 = null,
        ?string $Tk = null,
        ?string $ma_kh = null,
        ?string $ma_nt = null,
    ): Collection {
        $params = [
            'ma_cty' => $ma_cty,
            'Ngay1'  => $Ngay1,
            'Ngay2'  => $Ngay2,
            'Tk'     => $Tk,
            'ma_kh'  => $ma_kh,
            'ma_nt'  => $ma_nt,
        ];

        return self::call($params);
    }
}
