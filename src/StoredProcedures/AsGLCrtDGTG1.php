<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 23:55:07
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLCrtDGTG1.
 *
 * Stored procedure: asGLCrtDGTG1
 * Mục đích: Thực hiện thao tác tạo bút toán đánh giá tỷ giá chi tiết (đánh giá lại chênh lệch tỷ giá) dựa trên thông tin danh mục và khoảng thời gian.
 * Procedure này tính toán số dư ngoại tệ, chênh lệch tỷ giá và tạo các bút toán đánh giá tỷ giá chi tiết cho từng tài khoản, đối tượng (bộ phận, hợp đồng, sản phẩm công trình, phí) tùy theo cấu hình.
 *
 * Tham số:
 * - @pma_cty (string, bắt buộc): Mã công ty (nvarchar(3)). Không có giá trị mặc định.
 * - @pstt (int, bắt buộc): Số thứ tự danh mục đánh giá tỷ giá (stt trong bảng gldmdgtg). Không có giá trị mặc định.
 * - @pma_nt (string, bắt buộc): Mã ngoại tệ (nvarchar(3)). Không có giá trị mặc định.
 * - @tk_dgtg (string, bắt buộc): Tài khoản đánh giá tỷ giá (nvarchar(20)). Không có giá trị mặc định.
 * - @tk_lai_cltg (string, bắt buộc): Tài khoản lãi chênh lệch tỷ giá (nvarchar(20)). Không có giá trị mặc định.
 * - @tk_lo_cltg (string, bắt buộc): Tài khoản lỗ chênh lệch tỷ giá (nvarchar(20)). Không có giá trị mặc định.
 * - @tk_cltg_cn (string, bắt buộc): Tài khoản chênh lệch tỷ giá chưa xác định (nvarchar(20)). Không có giá trị mặc định.
 * - @ten_bt (string, bắt buộc): Tên bút toán (nvarchar(100)). Không có giá trị mặc định.
 * - @dg_kh (string, bắt buộc): Cờ đánh giá theo khách hàng (nvarchar(1)). '1' có, '0' không. Không có giá trị mặc định.
 * - @dg_bp (string, bắt buộc): Cờ đánh giá theo bộ phận (nvarchar(1)). '1' có, '0' không. Không có giá trị mặc định.
 * - @dg_hd (string, bắt buộc): Cờ đánh giá theo hợp đồng (nvarchar(1)). '1' có, '0' không. Không có giá trị mặc định.
 * - @dg_spct (string, bắt buộc): Cờ đánh giá theo sản phẩm công trình (nvarchar(1)). '1' có, '0' không. Không có giá trị mặc định.
 * - @dg_phi (string, bắt buộc): Cờ đánh giá theo phí (nvarchar(1)). '1' có, '0' không. Không có giá trị mặc định.
 * - @loai_dg (string, bắt buộc): Loại đánh giá (nvarchar(1)). Có thể là '1' (đánh giá theo số dư), '2' (đánh giá theo phát sinh), '3' (đánh giá lại lỗ), '4' (đánh giá lại lãi). Không có giá trị mặc định.
 * - @pngay1 (datetime, bắt buộc): Ngày bắt đầu kỳ đánh giá (smalldatetime). Không có giá trị mặc định.
 * - @pngay2 (datetime, bắt buộc): Ngày kết thúc kỳ đánh giá (smalldatetime). Không có giá trị mặc định.
 * - @stt_rec (string, bắt buộc): Số chứng từ (20 ký tự). Không có giá trị mặc định.
 * - @pma_ct (string, bắt buộc): Mã chứng từ (nvarchar(3)). Không có giá trị mặc định.
 * - @pso_ct (string, bắt buộc): Số chứng từ (12 ký tự). Không có giá trị mặc định.
 * - @puser (string, bắt buộc): Người thực hiện (nvarchar(20)). Không có giá trị mặc định.
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
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Không có output parameter.
 * - Tác động: tạo các bút toán đánh giá tỷ giá trong bảng glct.
 *
 * Logic chi tiết:
 * 1. Lấy tháng và năm kế toán từ ngày kết thúc.
 * 2. Tạo bảng tạm #slkc để lưu kết quả tính toán chênh lệch tỷ giá theo tài khoản và đối tượng.
 * 3. Tính số dư đầu kỳ và phát sinh trong kỳ của các tài khoản ngoại tệ (có mã ngoại tệ = @pma_nt).
 * 4. Nhóm dữ liệu theo các trường đối tượng tùy theo cờ đánh giá (bộ phận, hợp đồng, sản phẩm công trình, phí).
 * 5. Áp dụng loại đánh giá để xác định số tiền chênh lệch (lãi/lỗ).
 * 6. Duyệt qua từng dòng trong bảng tạm, tạo bút toán đánh giá tỷ giá:
 *    - Bút toán xuôi: ghi nợ tài khoản đánh giá tỷ giá / ghi có tài khoản lãi/lỗ chênh lệch.
 *    - Bút toán đảo: ghi nợ tài khoản lãi/lỗ chênh lệch / ghi có tài khoản đánh giá tỷ giá.
 * 7. Mỗi cặp bút toán có cùng stt_rec0 (mã phân biệt) được sinh tự động theo thứ tự AAA, AAB, ...
 * 8. Cập nhật các thông tin khác như diễn giải, ngày chứng từ, người tạo.
 *
 * Ví dụ gọi:
 * ```php
 * AsGLCrtDGTG1::call([
 *     'pma_cty' => '001',
 *     'pstt' => 1,
 *     'pma_nt' => 'USD',
 *     'tk_dgtg' => '635',
 *     'tk_lai_cltg' => '711',
 *     'tk_lo_cltg' => '811',
 *     'tk_cltg_cn' => '3387',
 *     'ten_bt' => 'Đánh giá tỷ giá USD cuối kỳ',
 *     'dg_kh' => '1',
 *     'dg_bp' => '0',
 *     'dg_hd' => '1',
 *     'dg_spct' => '0',
 *     'dg_phi' => '0',
 *     'loai_dg' => '1',
 *     'pngay1' => '2023-01-01',
 *     'pngay2' => '2023-01-31',
 *     'stt_rec' => '001WGL5000101232023',
 *     'pma_ct' => 'GL5',
 *     'pso_ct' => '000001',
 *     'puser' => 'admin',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure này được gọi bởi asGLCrtDGTG, không nên gọi trực tiếp trừ khi có đầy đủ thông tin danh mục.
 * - Việc tính toán chênh lệch tỷ giá dựa trên số dư và phát sinh ngoại tệ, cần đảm bảo dữ liệu đã được cập nhật đúng.
 * - Các bút toán được tạo ra sẽ ảnh hưởng đến sổ cái và báo cáo tài chính.
 * - Bảng tạm và cursor được sử dụng có thể ảnh hưởng hiệu năng với dữ liệu lớn.
 */
class AsGLCrtDGTG1
{
    /**
     * Gọi stored procedure asGLCrtDGTG1.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (không có resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        // Tính ngày đầu tháng và cuối tháng hiện tại nếu không cung cấp
        $pngay1 = $params['pngay1'] ?? date('Y-m-01');
        $pngay2 = $params['pngay2'] ?? date('Y-m-t');

        return ProcedureCaller::call('asGLCrtDGTG1', [
            'pma_cty'      => $params['pma_cty'] ?? SModel::CTY,
            'pstt'         => $params['pstt'] ?? 1,
            'pma_nt'       => $params['pma_nt'] ?? 'USD',
            'ptk_dgtg'     => $params['ptk_dgtg'] ?? '11221',
            'ptk_lai_cltg' => $params['ptk_lai_cltg'] ?? '515',
            'ptk_lo_cltg'  => $params['ptk_lo_cltg'] ?? '635',
            'ptk_cltg_cn'  => $params['ptk_cltg_cn'] ?? '4131',
            'pten_bt'      => $params['pten_bt'] ?? 'DGTGCK',
            'pdg_kh'       => $params['pdg_kh'] ?? '0',
            'pdg_bp'       => $params['pdg_bp'] ?? '0',
            'pdg_hd'       => $params['pdg_hd'] ?? '0',
            'pdg_spct'     => $params['pdg_spct'] ?? '0',
            'pdg_phi'      => $params['pdg_phi'] ?? '0',
            'ploai_dg'     => $params['ploai_dg'] ?? '1',
            'pngay1'       => $pngay1,
            'pngay2'       => $pngay2,
            'pstt_rec'     => $params['pstt_rec'] ?? 'AAA',
            'pma_ct'       => $params['pma_ct'] ?? 'GL5',
            'pso_ct'       => $params['pso_ct'] ?? '',
            'puser'        => $params['puser'] ?? null,
        ], $connection);
    }
}
