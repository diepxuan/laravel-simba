<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-08-09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Stored procedure asSOGetPH3.
 *
 * SP gốc từ SimbaSql:
 * - asSOGetPH3 (@pMa_cty, @pStt_rec, @pMa_ct)
 * - Lấy top 1 header của hóa đơn bán hàng (SO3/SO5) để mở form edit.
 * Danh sách chứng từ dùng `asSoFilt3` (AsSoFilt3) chứ không dùng SP này.
 */

class AsSOGetPH3
{
    /**
     * Call stored procedure asSOGetPH3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetPH3', [
            'pMa_cty'  => $paramObj->pMa_cty ?? SModel::CTY,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_ct'   => $paramObj->pMa_ct ?? '',
        ], $connection);
    }

    /**
     * Chuẩn hóa 1 row header SO3 về payload Portal.
     *
     * @return array<string, mixed>
     */
    public static function normalizeHeader(mixed $row): array
    {
        $row = \is_array($row) ? $row : (array) $row;

        return [
            'ma_cty'        => (string) ($row['ma_cty'] ?? ''),
            'stt_rec'       => (string) ($row['stt_rec'] ?? ''),
            'ma_ct'         => (string) ($row['ma_ct'] ?? ''),
            'ma_gd'         => (string) ($row['ma_gd'] ?? ''),
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
            'httt'          => (string) ($row['httt'] ?? ''),
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
            'tao_tu_px'     => (bool) ($row['tao_tu_px'] ?? false),
            'trang_thai'    => (string) ($row['trang_thai'] ?? ''),
            'post2gl'       => (string) ($row['post2gl'] ?? ''),
            'post2in'       => (string) ($row['post2in'] ?? ''),
        ];
    }

    public static function callWithParams(?string $maCty = null, ?string $sttRec = null, ?string $maCt = null): Collection
    {
        return self::call([
            'pMa_cty'  => $maCty,
            'pStt_rec' => $sttRec,
            'pMa_ct'   => $maCt,
        ]);
    }
}
