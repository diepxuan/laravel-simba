<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:58:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLCrtDGTG1
 * 
 * Stored procedure: asGLCrtDGTG1
 * Purpose: Thực hiện thao tác tạo bút toán đánh giá tỷ giá (internal, được gọi bởi asGLCrtDGTG).
 * 
 * Tham số:
 * - @pma_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pstt (int): Số thứ tự đánh giá tỷ giá. Bắt buộc.
 * - @pma_nt (nvarchar(3)): Mã ngoại tệ. Mặc định: 'USD'.
 * - @ptk_dgtg (nvarchar(20)): Tài khoản đánh giá tỷ giá. Mặc định: '11221'.
 * - @ptk_lai_cltg (nvarchar(20)): Tài khoản lãi chênh lệch tỷ giá. Mặc định: '515'.
 * - @ptk_lo_cltg (nvarchar(20)): Tài khoản lỗ chênh lệch tỷ giá. Mặc định: '635'.
 * - @ptk_cltg_cn (nvarchar(20)): Tài khoản chênh lệch tỷ giá cuối năm. Mặc định: '4131'.
 * - @pten_bt (nvarchar(100)): Tên bút toán. Mặc định: 'DGTGCK'.
 * - @pdg_kh (nvarchar(1)): Đánh giá theo khách hàng? ('0'/'1'). Mặc định: '0'.
 * - @pdg_bp (nvarchar(1)): Đánh giá theo bộ phận? ('0'/'1'). Mặc định: '0'.
 * - @pdg_hd (nvarchar(1)): Đánh giá theo hợp đồng? ('0'/'1'). Mặc định: '0'.
 * - @pdg_spct (nvarchar(1)): Đánh giá theo sản phẩm công trình? ('0'/'1'). Mặc định: '0'.
 * - @pdg_phi (nvarchar(1)): Đánh giá theo phí? ('0'/'1'). Mặc định: '0'.
 * - @ploai_dg (nvarchar(1)): Loại đánh giá ('1': dư nợ, khác: dư có). Mặc định: '1'.
 * - @pngay1 (smalldatetime): Ngày bắt đầu kỳ đánh giá. Mặc định: '3/1/2011'.
 * - @pngay2 (smalldatetime): Ngày kết thúc kỳ đánh giá. Mặc định: '3/31/2011'.
 * - @pstt_rec (nvarchar(20)): Số tham chiếu. Mặc định: 'AAA'.
 * - @pma_ct (nvarchar(3)): Mã chứng từ. Mặc định: 'GL5'.
 * - @pso_ct (nvarchar(12)): Số chứng từ. Mặc định: ''.
 * - @puser (nvarchar(20)): Người dùng thực hiện. Mặc định: ''.
 * 
 * Giá trị mặc định (trong class):
 * - pma_cty: mã công ty mặc định (SModel::CTY).
 * - pstt: 1.
 * - pma_nt: 'USD'.
 * - ptk_dgtg: '11221'.
 * - ptk_lai_cltg: '515'.
 * - ptk_lo_cltg: '635'.
 * - ptk_cltg_cn: '4131'.
 * - pten_bt: 'DGTGCK'.
 * - pdg_kh: '0'.
 * - pdg_bp: '0'.
 * - pdg_hd: '0'.
 * - pdg_spct: '0'.
 * - pdg_phi: '0'.
 * - ploai_dg: '1'.
 * - pngay1: ngày đầu tháng hiện tại.
 * - pngay2: ngày cuối tháng hiện tại.
 * - pstt_rec: 'AAA'.
 * - pma_ct: 'GL5'.
 * - pso_ct: ''.
 * - puser: null.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện tạo bút toán).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pma_cty' => '001',
 *     'pstt' => 1,
 *     'pma_nt' => 'USD',
 *     'ptk_dgtg' => '11221',
 *     'ptk_lai_cltg' => '515',
 *     'ptk_lo_cltg' => '635',
 *     'ptk_cltg_cn' => '4131',
 *     'pten_bt' => 'DGTGCK',
 *     'pdg_kh' => '0',
 *     'pdg_bp' => '0',
 *     'pdg_hd' => '0',
 *     'pdg_spct' => '0',
 *     'pdg_phi' => '0',
 *     'ploai_dg' => '1',
 *     'pngay1' => '2023-03-01',
 *     'pngay2' => '2023-03-31',
 *     'pstt_rec' => 'AAA',
 *     'pma_ct' => 'GL5',
 *     'pso_ct' => '',
 *     'puser' => 'admin',
 * ];
 * $result = AsGLCrtDGTG1::call($params);
 * ```
 */
class AsGLCrtDGTG1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        // Tính ngày đầu tháng và cuối tháng hiện tại nếu không cung cấp
        $pngay1 = $params['pngay1'] ?? date('Y-m-01');
        $pngay2 = $params['pngay2'] ?? date('Y-m-t');

        return ProcedureCaller::call('asGLCrtDGTG1', [
            'pma_cty'       => $params['pma_cty'] ?? SModel::CTY,
            'pstt'          => $params['pstt'] ?? 1,
            'pma_nt'        => $params['pma_nt'] ?? 'USD',
            'ptk_dgtg'      => $params['ptk_dgtg'] ?? '11221',
            'ptk_lai_cltg'  => $params['ptk_lai_cltg'] ?? '515',
            'ptk_lo_cltg'   => $params['ptk_lo_cltg'] ?? '635',
            'ptk_cltg_cn'   => $params['ptk_cltg_cn'] ?? '4131',
            'pten_bt'       => $params['pten_bt'] ?? 'DGTGCK',
            'pdg_kh'        => $params['pdg_kh'] ?? '0',
            'pdg_bp'        => $params['pdg_bp'] ?? '0',
            'pdg_hd'        => $params['pdg_hd'] ?? '0',
            'pdg_spct'      => $params['pdg_spct'] ?? '0',
            'pdg_phi'       => $params['pdg_phi'] ?? '0',
            'ploai_dg'      => $params['ploai_dg'] ?? '1',
            'pngay1'        => $pngay1,
            'pngay2'        => $pngay2,
            'pstt_rec'      => $params['pstt_rec'] ?? 'AAA',
            'pma_ct'        => $params['pma_ct'] ?? 'GL5',
            'pso_ct'        => $params['pso_ct'] ?? '',
            'puser'         => $params['puser'] ?? null,
        ], $connection);
    }
}
