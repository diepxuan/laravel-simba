<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-08-01 00:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;
use PDO;

class AsSORptBK01
{
    /**
     * Call stored procedure asSORptBK01 and return the first result set.
     *
     * @param array $params Procedure parameters
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBK01', self::procedureParams($params), $connection);
    }

    /**
     * Call stored procedure asSORptBK01 and return both report result sets.
     *
     * Source: simba-docs/asia/so/reports/SORptBK01.md (DataSet Tables[0] = ct,
     * Tables[1] = ph). Params follow frmSORptBK01.LoadData() and sysReportInfo
     * spname asSORptBK01.
     *
     * @return array{ct: Collection<int, array<string, mixed>>, ph: Collection<int, array<string, mixed>>}
     */
    public static function callWithDataSets(array $params): array
    {
        $procedureParams = self::procedureParams($params);
        $connection      = (new SModel())->getConnectionName();
        $pdo             = DB::connection($connection)->getPdo();

        $stmt = $pdo->prepare(self::callSql($procedureParams));
        $stmt->execute();

        $sets = [];
        do {
            $sets[] = $stmt->fetchAll(PDO::FETCH_ASSOC) ?: [];
        } while ($stmt->nextRowset());

        try {
            $stmt->closeCursor();
        } catch (\Throwable) {
            // Ignore cursor cleanup failures after all rowsets have been read.
        }

        return [
            'ct' => collect($sets[0] ?? []),
            'ph' => collect($sets[1] ?? []),
        ];
    }

    /**
     * Build the EXEC statement for both report result sets.
     *
     * Dùng Unicode literal giống ProcedureCaller để tránh lỗi binding
     * tiếng Việt qua PDO SQLSRV khi tham số có dấu.
     *
     * @param array<string, mixed> $procedureParams
     */
    public static function callSql(array $procedureParams): string
    {
        $execParts = [];
        foreach ($procedureParams as $key => $value) {
            $execParts[] = '@' . $key . ' = ' . ProcedureCaller::toUnicodeLiteral($value);
        }

        return "SET NOCOUNT ON;\nEXECUTE [dbo].[asSORptBK01]\n    " . implode(",\n    ", $execParts);
    }

    /**
     * @return array<string, mixed>
     */
    public static function procedureParams(array $params): array
    {
        $p = ParamHelper::fromArray($params);

        return [
            'pMa_cty'   => $p->pMa_cty ?? $p->ma_cty ?? null,
            'pNgay1'    => $p->pNgay1 ?? $p->Ngay1 ?? null,
            'pNgay2'    => $p->pNgay2 ?? $p->Ngay2 ?? null,
            'pMa_ct'    => $p->pMa_ct ?? $p->ma_ct ?? null,
            'pTrang_thai' => $p->pTrang_thai ?? $p->trang_thai ?? null,
            'pMa_kh'    => $p->pMa_kh ?? $p->ma_kh ?? null,
            'pMa_nhkh'  => $p->pMa_nhkh ?? $p->ma_nhkh ?? null,
            'pMa_vt'    => $p->pMa_vt ?? $p->ma_vt ?? null,
            'pMa_nhvt'  => $p->pMa_nhvt ?? $p->ma_nhvt ?? null,
            'pMa_kho'   => $p->pMa_kho ?? $p->ma_kho ?? null,
            'pMa_vitri' => $p->pMa_vitri ?? $p->ma_vitri ?? null,
            'pMa_lo'    => $p->pMa_lo ?? $p->ma_lo ?? null,
            'pMa_httt'  => $p->pMa_httt ?? $p->ma_httt ?? null,
            'pMa_TT'    => $p->pMa_TT ?? $p->ma_TT ?? $p->ma_tt ?? null,
            'pMa_bp'    => $p->pMa_bp ?? $p->ma_bp ?? null,
            'pMa_nvkd'  => $p->pMa_nvkd ?? $p->ma_nvkd ?? null,
            'pMa_spct'  => $p->pMa_spct ?? $p->ma_spct ?? null,
            'pMa_hd'    => $p->pMa_hd ?? $p->ma_hd ?? null,
            'pMa_nhhd'  => $p->pMa_nhhd ?? $p->ma_nhhd ?? null,
            'pMa_nt'    => $p->pMa_nt ?? $p->ma_nt ?? null,
            'pSoct1'    => $p->pSoct1 ?? $p->so_ct1 ?? null,
            'pSoct2'    => $p->pSoct2 ?? $p->so_ct2 ?? null,
            'pMa_plkh1' => $p->pMa_plkh1 ?? $p->ma_plkh1 ?? null,
            'pMa_plkh2' => $p->pMa_plkh2 ?? $p->ma_plkh2 ?? null,
            'pMa_plkh3' => $p->pMa_plkh3 ?? $p->ma_plkh3 ?? null,
            'pMa_plvt1' => $p->pMa_plvt1 ?? $p->ma_plvt1 ?? null,
            'pMa_plvt2' => $p->pMa_plvt2 ?? $p->ma_plvt2 ?? null,
            'pMa_plvt3' => $p->pMa_plvt3 ?? $p->ma_plvt3 ?? null,
        ];
    }

    /**
     * Call stored procedure asSORptBK01 with named parameters.
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Ngay1 = null,
        ?string $Ngay2 = null,
        ?string $Ma_ct = null,
        ?string $Trang_thai = null,
        ?string $Ma_kh = null,
        ?string $Ma_nhkh = null,
        ?string $Ma_vt = null,
        ?string $Ma_nhvt = null,
        ?string $Ma_kho = null,
        ?string $Ma_vitri = null,
        ?string $Ma_lo = null,
        ?string $Ma_httt = null,
        ?string $Ma_TT = null,
        ?string $Ma_bp = null,
        ?string $Ma_nvkd = null,
        ?string $Ma_spct = null,
        ?string $Ma_hd = null,
        ?string $Ma_nhhd = null,
        ?string $Ma_nt = null,
        ?string $Soct1 = null,
        ?string $Soct2 = null,
        ?string $Ma_plkh1 = null,
        ?string $Ma_plkh2 = null,
        ?string $Ma_plkh3 = null,
        ?string $Ma_plvt1 = null,
        ?string $Ma_plvt2 = null,
        ?string $Ma_plvt3 = null,
    ): Collection {
        return self::call([
            'pMa_cty'   => $Ma_cty,
            'pNgay1'    => $Ngay1,
            'pNgay2'    => $Ngay2,
            'pMa_ct'    => $Ma_ct,
            'pTrang_thai' => $Trang_thai,
            'pMa_kh'    => $Ma_kh,
            'pMa_nhkh'  => $Ma_nhkh,
            'pMa_vt'    => $Ma_vt,
            'pMa_nhvt'  => $Ma_nhvt,
            'pMa_kho'   => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_lo'    => $Ma_lo,
            'pMa_httt'  => $Ma_httt,
            'pMa_TT'    => $Ma_TT,
            'pMa_bp'    => $Ma_bp,
            'pMa_nvkd'  => $Ma_nvkd,
            'pMa_spct'  => $Ma_spct,
            'pMa_hd'    => $Ma_hd,
            'pMa_nhhd'  => $Ma_nhhd,
            'pMa_nt'    => $Ma_nt,
            'pSoct1'    => $Soct1,
            'pSoct2'    => $Soct2,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
        ]);
    }
}
