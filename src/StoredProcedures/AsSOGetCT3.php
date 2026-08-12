<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Stored procedure asSOGetCT3.
 *
 * SP gốc từ SimbaSql:
 * - asSOGetCT3 (@pMa_cty, @pStt_rec, @pStruct)
 * - Lấy danh sách chi tiết hóa đơn bán hàng (SOCT3).
 */

class AsSOGetCT3
{
    /**
     * Call stored procedure asSOGetCT3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetCT3', [
            'pMa_cty' => $paramObj->pMa_cty ?? SModel::CTY,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStruct' => $paramObj->pStruct ?? '0',
        ], $connection);
    }

    /**
     * Chuẩn hóa 1 row chi tiết SO3 về payload Portal.
     *
     * @return array<string, mixed>
     */
    public static function normalizeDetail(mixed $row): array
    {
        $row = \is_array($row) ? $row : (array) $row;

        return [
            'ma_cty'        => (string) ($row['ma_cty'] ?? ''),
            'stt_rec'       => (string) ($row['stt_rec'] ?? ''),
            'stt_rec0'      => (string) ($row['stt_rec0'] ?? ''),
            'stt_rec_dh'    => (string) ($row['stt_rec_dh'] ?? ''),
            'stt_rec0_dh'   => (string) ($row['stt_rec0_dh'] ?? ''),
            'stt_rec_px'    => (string) ($row['stt_rec_px'] ?? ''),
            'stt_rec0_px'   => (string) ($row['stt_rec0_px'] ?? ''),
            'so_dh'         => (string) ($row['so_dh'] ?? ''),
            'so_px'         => (string) ($row['so_px'] ?? ''),
            'ma_vt'         => (string) ($row['ma_vt'] ?? ''),
            'ten_vt'        => (string) ($row['ten_vt'] ?? ''),
            'dvt'           => (string) ($row['dvt'] ?? ''),
            'ton_kho'       => (float) ($row['ton_kho'] ?? 0),
            'ma_kho'        => (string) ($row['ma_kho'] ?? ''),
            'ten_kho'       => (string) ($row['ten_kho'] ?? ''),
            'so_luong'      => (float) ($row['so_luong'] ?? 0),
            'so_luong_qd'   => (float) ($row['so_luong_qd'] ?? 0),
            'gia_nt2'       => (float) ($row['gia_nt2'] ?? 0),
            'gia2'          => (float) ($row['gia2'] ?? 0),
            'tien_nt2'      => (float) ($row['tien_nt2'] ?? 0),
            'tien2'         => (float) ($row['tien2'] ?? 0),
            'tl_ck'         => (float) ($row['tl_ck'] ?? 0),
            'tien_ck_nt'    => (float) ($row['tien_ck_nt'] ?? 0),
            'tien_ck'       => (float) ($row['tien_ck'] ?? 0),
            'ck_ds_nt'      => (float) ($row['ck_ds_nt'] ?? 0),
            'ck_ds'         => (float) ($row['ck_ds'] ?? 0),
            'ma_thue'       => (string) ($row['ma_thue'] ?? ''),
            'ts_gtgt'       => (float) ($row['ts_gtgt'] ?? 0),
            'thue_gtgt_nt'  => (float) ($row['thue_gtgt_nt'] ?? 0),
            'thue_gtgt'     => (float) ($row['thue_gtgt'] ?? 0),
            'tt_nt'         => (float) ($row['tt_nt'] ?? 0),
            'tt'            => (float) ($row['tt'] ?? 0),
            'tk_pt'         => (string) ($row['tk_pt'] ?? ''),
            'tk_thue'       => (string) ($row['tk_thue'] ?? ''),
            'tk_dt'         => (string) ($row['tk_dt'] ?? ''),
            'ten_tk_dt'     => (string) ($row['ten_tk_dt'] ?? ''),
            'tk_gv'         => (string) ($row['tk_gv'] ?? ''),
            'ten_tk_gv'     => (string) ($row['ten_tk_gv'] ?? ''),
            'tk_vt'         => (string) ($row['tk_vt'] ?? ''),
            'ten_tk_vt'     => (string) ($row['ten_tk_vt'] ?? ''),
            'tk_ck'         => (string) ($row['tk_ck'] ?? ''),
            'ten_tk_ck'     => (string) ($row['ten_tk_ck'] ?? ''),
            'tk_tl'         => (string) ($row['tk_tl'] ?? ''),
            'tk_km'         => (string) ($row['tk_km'] ?? ''),
            'gia_nt'        => (float) ($row['gia_nt'] ?? 0),
            'gia'           => (float) ($row['gia'] ?? 0),
            'tien_nt'       => (float) ($row['tien_nt'] ?? 0),
            'tien'          => (float) ($row['tien'] ?? 0),
            'khuyen_mai'    => (bool) ($row['khuyen_mai'] ?? false),
            'tra_ck'        => (bool) ($row['tra_ck'] ?? false),
            'sl_xuat'       => (float) ($row['sl_xuat'] ?? 0),
            'sl_xuat_qd'    => (float) ($row['sl_xuat_qd'] ?? 0),
            'ma_nvkd'       => (string) ($row['ma_nvkd'] ?? ''),
            'ten_nvkd'      => (string) ($row['ten_nvkd'] ?? ''),
            'ma_vitri'      => (string) ($row['ma_vitri'] ?? ''),
            'ma_lo'         => (string) ($row['ma_lo'] ?? ''),
            'ma_bp'         => (string) ($row['ma_bp'] ?? ''),
            'ma_hd'         => (string) ($row['ma_hd'] ?? ''),
            'ma_phi'        => (string) ($row['ma_phi'] ?? ''),
            'ma_spct'       => (string) ($row['ma_spct'] ?? ''),
        ];
    }

    public static function callWithParams(?string $maCty = null, ?string $sttRec = null, ?string $struct = null): Collection
    {
        return self::call([
            'pMa_cty'  => $maCty,
            'pStt_rec' => $sttRec,
            'pStruct'  => $struct,
        ]);
    }
}
