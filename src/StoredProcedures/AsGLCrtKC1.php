<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 12:08:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLCrtKC1
 * 
 * Stored procedure: asGLCrtKC1
 * Purpose: Thực hiện thao tác tạo bút toán kết chuyển tự động (internal, được gọi bởi asGLCrtKC).
 * 
 * Tham số:
 * - @pma_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pstt (int): Số thứ tự kết chuyển (tham chiếu bảng gldmkc). Bắt buộc.
 * - @ptk (nvarchar(20)): Tài khoản nguồn. Bắt buộc.
 * - @ptk_du (nvarchar(20)): Tài khoản đích. Bắt buộc.
 * - @pten_bt (nvarchar(100)): Tên bút toán. Bắt buộc.
 * - @pkc_bp (nvarchar(1)): Kết chuyển theo bộ phận? ('0'/'1'). Bắt buộc.
 * - @pkc_hd (nvarchar(1)): Kết chuyển theo hợp đồng? ('0'/'1'). Bắt buộc.
 * - @pkc_spct (nvarchar(1)): Kết chuyển theo sản phẩm công trình? ('0'/'1'). Bắt buộc.
 * - @pkc_phi (nvarchar(1)): Kết chuyển theo phí? ('0'/'1'). Bắt buộc.
 * - @ploai_kc (nvarchar(1)): Loại kết chuyển ('1': ghi nợ, '2': ghi có, '3': kết chuyển lãi lỗ, '4': kết chuyển thuế GTGT). Bắt buộc.
 * - @pkc_dt_ps (nvarchar(1)): Kết chuyển theo đối tượng có phát sinh? ('0'/'1'). Bắt buộc.
 * - @pngay1 (smalldatetime): Ngày bắt đầu kỳ kết chuyển. Bắt buộc.
 * - @pngay2 (smalldatetime): Ngày kết thúc kỳ kết chuyển. Bắt buộc.
 * - @pstt_rec (nvarchar(20)): Số tham chiếu. Bắt buộc.
 * - @pma_ct (nvarchar(3)): Mã chứng từ. Bắt buộc.
 * - @pso_ct (nvarchar(12)): Số chứng từ. Bắt buộc.
 * - @puser (nvarchar(20)): Người dùng thực hiện. Bắt buộc.
 * 
 * Giá trị mặc định (trong class):
 * - pma_cty: mã công ty mặc định (SModel::CTY).
 * - pstt: 1.
 * - ptk: null.
 * - ptk_du: null.
 * - pten_bt: null.
 * - pkc_bp: '0'.
 * - pkc_hd: '0'.
 * - pkc_spct: '0'.
 * - pkc_phi: '0'.
 * - ploai_kc: '1'.
 * - pkc_dt_ps: '0'.
 * - pngay1: ngày đầu tháng hiện tại.
 * - pngay2: ngày cuối tháng hiện tại.
 * - pstt_rec: null.
 * - pma_ct: null.
 * - pso_ct: null.
 * - puser: null.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện tạo bút toán).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pma_cty' => '001',
 *     'pstt' => 1,
 *     'ptk' => '641',
 *     'ptk_du' => '511',
 *     'pten_bt' => 'Kc doanh thu',
 *     'pkc_bp' => '1',
 *     'pkc_hd' => '0',
 *     'pkc_spct' => '0',
 *     'pkc_phi' => '1',
 *     'ploai_kc' => '2',
 *     'pkc_dt_ps' => '0',
 *     'pngay1' => '2023-01-01',
 *     'pngay2' => '2023-01-25',
 *     'pstt_rec' => 'A01KCxxx',
 *     'pma_ct' => 'KCG',
 *     'pso_ct' => '000000KC',
 *     'puser' => 'admin',
 * ];
 * $result = AsGLCrtKC1::call($params);
 * ```
 */
class AsGLCrtKC1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        // Tính ngày đầu tháng và cuối tháng hiện tại nếu không cung cấp
        $pngay1 = $params['pngay1'] ?? date('Y-m-01');
        $pngay2 = $params['pngay2'] ?? date('Y-m-t');

        return ProcedureCaller::call('asGLCrtKC1', [
            'pma_cty'     => $params['pma_cty'] ?? SModel::CTY,
            'pstt'        => $params['pstt'] ?? 1,
            'ptk'         => $params['ptk'] ?? null,
            'ptk_du'      => $params['ptk_du'] ?? null,
            'pten_bt'     => $params['pten_bt'] ?? null,
            'pkc_bp'      => $params['pkc_bp'] ?? '0',
            'pkc_hd'      => $params['pkc_hd'] ?? '0',
            'pkc_spct'    => $params['pkc_spct'] ?? '0',
            'pkc_phi'     => $params['pkc_phi'] ?? '0',
            'ploai_kc'    => $params['ploai_kc'] ?? '1',
            'pkc_dt_ps'   => $params['pkc_dt_ps'] ?? '0',
            'pngay1'      => $pngay1,
            'pngay2'      => $pngay2,
            'pstt_rec'    => $params['pstt_rec'] ?? null,
            'pma_ct'      => $params['pma_ct'] ?? null,
            'pso_ct'      => $params['pso_ct'] ?? null,
            'puser'       => $params['puser'] ?? null,
        ], $connection);
    }
}
