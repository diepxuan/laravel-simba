<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;
use PDO;

/**
 * Stored procedure asSoFilt3.
 *
 * SP gốc từ SimbaSql:
 * - asSoFilt3 (@pKeyPh, @pKeyCt)
 * - Trả 2 result set: PH (danh sách header) và CT (danh sách chi tiết).
 * Dùng cho danh sách hóa đơn bán hàng SO3/SO5.
 */

class AsSoFilt3
{
    /**
     * Call stored procedure asSoFilt3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSoFilt3', [
            'pKeyPh' => $paramObj->pKeyPh ?? null,
            'pKeyCt' => $paramObj->pKeyCt ?? null,
        ], $connection);
    }

    /**
     * Gọi asSoFilt3 và trả về tất cả result set.
     *
     * @return array{ph: Collection<int, array<string, mixed>>, ct: Collection<int, array<string, mixed>>}
     */
    public static function callWithDataSets(array $params): array
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        $pdo = DB::connection($connection)->getPdo();
        $stmt = $pdo->prepare(self::callSql([
            'pKeyPh' => $paramObj->pKeyPh ?? null,
            'pKeyCt' => $paramObj->pKeyCt ?? null,
        ]));
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
            // Bỏ qua lỗi closeCursor sau khi đã đọc hết result set.
        }

        return [
            'ph' => collect($sets[0] ?? []),
            'ct' => collect($sets[1] ?? []),
        ];
    }

    /**
     * Build EXEC statement dùng Unicode literal giống ProcedureCaller.
     *
     * @param array<string, mixed> $procedureParams
     */
    public static function callSql(array $procedureParams): string
    {
        $execParts = [];
        foreach ($procedureParams as $key => $value) {
            $execParts[] = '@' . $key . ' = ' . ProcedureCaller::toUnicodeLiteral($value);
        }

        return "SET NOCOUNT ON;\nEXECUTE [dbo].[asSoFilt3]\n    " . implode(",\n    ", $execParts);
    }

    /**
     * Dựng @pKeyPh cho lọc header SO3.
     *
     * @return string
     */
    public static function keyPh(string $maCty, string $maCt, ?string $ngay1 = null, ?string $ngay2 = null, ?string $maKh = null, ?string $search = null): string
    {
        $parts = [
            "ma_cty = '" . self::escape($maCty) . "'",
            "ma_ct = '" . self::escape($maCt) . "'",
        ];

        if (null !== $ngay1 && '' !== $ngay1) {
            $parts[] = "ngay_ct >= '" . self::escape($ngay1) . "'";
        }
        if (null !== $ngay2 && '' !== $ngay2) {
            $parts[] = "ngay_ct <= '" . self::escape($ngay2) . "'";
        }
        if (null !== $maKh && '' !== $maKh) {
            $parts[] = "ma_kh like N'" . self::escape($maKh) . "%'";
        }
        if (null !== $search && '' !== $search) {
            $parts[] = "(so_ct like N'%" . self::escape($search) . "%' or so_seri like N'%" . self::escape($search) . "%' or ma_kh like N'%" . self::escape($search) . "%')";
        }

        return implode(' and ', $parts);
    }

    /**
     * Dựng @pKeyCt cho lọc chi tiết SO3.
     *
     * @return string
     */
    public static function keyCt(string $maCty, ?string $maVt = null, ?string $maKho = null): string
    {
        $parts = ["ma_cty = '" . self::escape($maCty) . "'"];

        if (null !== $maVt && '' !== $maVt) {
            $parts[] = "ma_vt = N'" . self::escape($maVt) . "'";
        }
        if (null !== $maKho && '' !== $maKho) {
            $parts[] = "ma_kho = N'" . self::escape($maKho) . "'";
        }

        return implode(' and ', $parts);
    }

    /**
     * Escape single quote cho SQL Server.
     */
    public static function escape(string $value): string
    {
        return str_replace("'", "''", $value);
    }

    /**
     * Chuẩn hóa 1 row header SO3 về payload Portal.
     *
     * @return array<string, mixed>
     */
    public static function normalizePh(mixed $row): array
    {
        $row = \is_array($row) ? $row : (array) $row;

        return [
            'ma_cty'        => (string) ($row['ma_cty'] ?? ''),
            'stt_rec'       => (string) ($row['stt_rec'] ?? ''),
            'ma_ct'         => (string) ($row['ma_ct'] ?? ''),
            'so_seri'       => (string) ($row['so_seri'] ?? ''),
            'so_ct'         => (string) ($row['so_ct'] ?? ''),
            'ngay_ct'       => $row['ngay_ct'] ?? null,
            'ngay_lct'      => $row['ngay_lct'] ?? null,
            'ma_kh'         => (string) ($row['ma_kh'] ?? ''),
            'ten_kh'        => (string) ($row['ten_kh'] ?? ''),
            'ten_kh_vat'    => (string) ($row['ten_kh_vat'] ?? ''),
            'dia_chi_vat'   => (string) ($row['dia_chi_vat'] ?? ''),
            'ma_so_thue'    => (string) ($row['ma_so_thue'] ?? ''),
            'nguoi_gd'      => (string) ($row['nguoi_gd'] ?? ''),
            'dien_giai'     => (string) ($row['dien_giai'] ?? ''),
            'ma_nt'         => (string) ($row['ma_nt'] ?? 'VND'),
            'ty_gia'        => (float) ($row['ty_gia'] ?? 1),
            'tk_pt'         => (string) ($row['tk_pt'] ?? ''),
            'tk_thue'       => (string) ($row['tk_thue'] ?? ''),
            'tk_ck_ds'      => (string) ($row['tk_ck_ds'] ?? ''),
            'ma_httt'       => (string) ($row['ma_httt'] ?? ''),
            'ten_httt'      => (string) ($row['ten_httt'] ?? ''),
            'so_px'         => (string) ($row['so_px'] ?? ''),
            'ngay_px'       => $row['ngay_px'] ?? null,
            't_tien_nt'     => (float) ($row['t_tien_nt'] ?? 0),
            't_tien'        => (float) ($row['t_tien'] ?? 0),
            't_tien_nt2'    => (float) ($row['t_tien_nt2'] ?? 0),
            't_tien2'       => (float) ($row['t_tien2'] ?? 0),
            't_thue_nt'     => (float) ($row['t_thue_nt'] ?? 0),
            't_thue'        => (float) ($row['t_thue'] ?? 0),
            'tl_ck_ds'      => (float) ($row['tl_ck_ds'] ?? 0),
            't_ck_nt'       => (float) ($row['t_ck_nt'] ?? 0),
            't_ck'          => (float) ($row['t_ck'] ?? 0),
            't_ck_ds_nt'    => (float) ($row['t_ck_ds_nt'] ?? 0),
            't_ck_ds'       => (float) ($row['t_ck_ds'] ?? 0),
            't_tt_nt'       => (float) ($row['t_tt_nt'] ?? 0),
            't_tt'          => (float) ($row['t_tt'] ?? 0),
            't_so_luong'    => (float) ($row['t_so_luong'] ?? 0),
            'trang_thai'    => (string) ($row['trang_thai'] ?? ''),
            'post2gl'       => (string) ($row['post2gl'] ?? ''),
            'post2in'       => (string) ($row['post2in'] ?? ''),
        ];
    }

    public static function callWithParams(?string $keyPh = null, ?string $keyCt = null): Collection
    {
        return self::call([
            'pKeyPh' => $keyPh,
            'pKeyCt' => $keyCt,
        ]);
    }
}
