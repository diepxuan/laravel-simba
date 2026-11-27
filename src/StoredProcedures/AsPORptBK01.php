<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:57
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;
use Diepxuan\Simba\Helper\ParamHelper;
use PDO;

class AsPORptBK01
{
    /**
     * Call stored procedure asPORptBK01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptBK01', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pSoct1' => $paramObj->pSoct1 ?? null,
            'pSoct2' => $paramObj->pSoct2 ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_nvkd' => $paramObj->pMa_nvkd ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_plkh1' => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2' => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3' => $paramObj->pMa_plkh3 ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_httt' => $paramObj->pMa_httt ?? null,
            'pMa_TT' => $paramObj->pMa_TT ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pMa_plvt1' => $paramObj->pMa_plvt1 ?? null,
            'pMa_plvt2' => $paramObj->pMa_plvt2 ?? null,
            'pMa_plvt3' => $paramObj->pMa_plvt3 ?? null,
            'pMa_nhhd' => $paramObj->pMa_nhhd ?? null,
            'pMa_Phi' => $paramObj->pMa_Phi ?? null
                ], $connection);
    }

    /**
     * Call stored procedure asPORptBK01 and return BOTH report result sets.
     *
     * SP asPORptBK01 tra 2 result set (da kiem chung tren DB that, ky 2025):
     *   RS1 = chi tiet  (1.371 dong / 40 cot, co ma_vt/so_luong/gia/tien...)
     *   RS2 = danh sach phieu (366 dong / 27 cot, moi stt_rec 1 dong)
     *
     * Lien ket: RS1.stt_rec = RS2.stt_rec (366/366 stt_rec cua RS2 co trong RS1).
     *
     * Dung cho bang ke Master-Detail giong SimbaERP: bang tren = danh sach phieu,
     * bang duoi = chi tiet cua phieu duoc chon.
     *
     * @return array{ph: Collection<int, array<string, mixed>>, ct: Collection<int, array<string, mixed>>}
     */
    public static function callWithDataSets(array $params): array
    {
        $connection = (new SModel())->getConnectionName();
        $pdo        = DB::connection($connection)->getPdo();

        $stmt = $pdo->prepare(self::callSql(self::procedureParams($params)));
        $stmt->execute();

        $sets = [];
        do {
            if ($stmt->columnCount() > 0) {
                $sets[] = $stmt->fetchAll(PDO::FETCH_ASSOC) ?: [];
            }
        } while ($stmt->nextRowset());

        try {
            $stmt->closeCursor();
        } catch (\Throwable) {
            // Ignore cursor cleanup failures after all rowsets have been read.
        }

        // RS1 = chi tiet, RS2 = danh sach phieu (theo thu tu SP tra ve).
        return [
            'ct' => collect($sets[0] ?? []),
            'ph' => collect($sets[1] ?? []),
        ];
    }

    /**
     * Build EXEC statement cho ca 2 result set.
     *
     * Dung Unicode literal giong ProcedureCaller de tranh loi binding
     * tieng Viet qua PDO SQLSRV.
     *
     * @param array<string, mixed> $procedureParams
     */
    public static function callSql(array $procedureParams): string
    {
        $execParts = [];

        foreach ($procedureParams as $key => $value) {
            $execParts[] = '@' . $key . ' = ' . ProcedureCaller::toUnicodeLiteral($value);
        }

        return "SET NOCOUNT ON;\nEXECUTE [dbo].[asPORptBK01]\n    " . implode(",\n    ", $execParts);
    }

    /**
     * Map tham so dau vao -> ten tham so SP.
     *
     * @return array<string, mixed>
     */
    public static function procedureParams(array $params): array
    {
        $p = ParamHelper::fromArray($params);

        return [
            'pMa_cty'    => $p->pMa_cty ?? $p->ma_cty ?? null,
            'pNgay1'     => $p->pNgay1 ?? $p->ngay1 ?? null,
            'pNgay2'     => $p->pNgay2 ?? $p->ngay2 ?? null,
            'pTrang_thai' => $p->pTrang_thai ?? $p->trang_thai ?? null,
            'pSoct1'     => $p->pSoct1 ?? $p->soct1 ?? null,
            'pSoct2'     => $p->pSoct2 ?? $p->soct2 ?? null,
            'pMa_kh'     => $p->pMa_kh ?? $p->ma_kh ?? null,
            'pMa_nhkh'   => $p->pMa_nhkh ?? $p->ma_nhkh ?? null,
            'pMa_vt'     => $p->pMa_vt ?? $p->ma_vt ?? null,
            'pMa_nhvt'   => $p->pMa_nhvt ?? $p->ma_nhvt ?? null,
            'pMa_kho'    => $p->pMa_kho ?? $p->ma_kho ?? null,
            'pMa_vitri'  => $p->pMa_vitri ?? $p->ma_vitri ?? null,
            'pMa_nvkd'   => $p->pMa_nvkd ?? $p->ma_nvkd ?? null,
            'pMa_nt'     => $p->pMa_nt ?? $p->ma_nt ?? null,
            'pMa_hd'     => $p->pMa_hd ?? $p->ma_hd ?? null,
            'pMa_plkh1'  => $p->pMa_plkh1 ?? $p->ma_plkh1 ?? null,
            'pMa_plkh2'  => $p->pMa_plkh2 ?? $p->ma_plkh2 ?? null,
            'pMa_plkh3'  => $p->pMa_plkh3 ?? $p->ma_plkh3 ?? null,
            'pMa_ct'     => $p->pMa_ct ?? $p->ma_ct ?? null,
            'pMa_lo'     => $p->pMa_lo ?? $p->ma_lo ?? null,
            'pMa_httt'   => $p->pMa_httt ?? $p->ma_httt ?? null,
            'pMa_TT'     => $p->pMa_TT ?? $p->ma_TT ?? null,
            'pMa_bp'     => $p->pMa_bp ?? $p->ma_bp ?? null,
            'pMa_spct'   => $p->pMa_spct ?? $p->ma_spct ?? null,
            'pMa_plvt1'  => $p->pMa_plvt1 ?? $p->ma_plvt1 ?? null,
            'pMa_plvt2'  => $p->pMa_plvt2 ?? $p->ma_plvt2 ?? null,
            'pMa_plvt3'  => $p->pMa_plvt3 ?? $p->ma_plvt3 ?? null,
            'pMa_nhhd'   => $p->pMa_nhhd ?? $p->ma_nhhd ?? null,
            'pMa_Phi'    => $p->pMa_Phi ?? $p->ma_Phi ?? null,
        ];
    }

    /**
     * Call stored procedure asPORptBK01 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Trang_thai
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_nvkd
     * @param string $Ma_nt
     * @param string $Ma_hd
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_ct
     * @param string $Ma_lo
     * @param string $Ma_httt
     * @param string $Ma_TT
     * @param string $Ma_bp
     * @param string $Ma_spct
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param string $Ma_nhhd
     * @param string $Ma_Phi
     * @param mixed $Ma_phi
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $Ma_Hd
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Trang_thai = null, string $Soct1 = null, string $Soct2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_nvkd = null, string $Ma_nt = null, string $Ma_hd = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_ct = null, string $Ma_lo = null, string $Ma_httt = null, string $Ma_TT = null, string $Ma_bp = null, string $Ma_spct = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, string $Ma_nhhd = null, string $Ma_Phi = null, mixed $Ma_phi = null, string $ParamDefines = null, string $Ma_Cty = null, string $Ma_Hd = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pTrang_thai' => $Trang_thai,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_nvkd' => $Ma_nvkd,
            'pMa_nt' => $Ma_nt,
            'pMa_hd' => $Ma_hd,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_ct' => $Ma_ct,
            'pMa_lo' => $Ma_lo,
            'pMa_httt' => $Ma_httt,
            'pMa_TT' => $Ma_TT,
            'pMa_bp' => $Ma_bp,
            'pMa_spct' => $Ma_spct,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pMa_nhhd' => $Ma_nhhd,
            'pMa_Phi' => $Ma_Phi,
            'pMa_phi' => $Ma_phi,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pMa_Hd' => $Ma_Hd
        ];

        return self::call($params);
    }
}
