<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:35:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsARInsPost2TT_ARTT
 * 
 * Stored procedure: asARInsPost2TT_ARTT
 * Purpose: Thêm mới phân bổ chứng từ công nợ phải thu (bảng artt).
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu chứng từ phân bổ. Bắt buộc.
 * - @pStt_rec_hd (nvarchar(20)): Số tham chiếu hoá đơn được phân bổ. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Bắt buộc.
 * - @pNguoi_gd (nvarchar(30)): Người giao dịch. Bắt buộc.
 * - @pDien_giai (nvarchar(255)): Diễn giải. Bắt buộc.
 * - @pTk_pt (nvarchar(20)): Tài khoản phân bổ. Bắt buộc.
 * - @pMa_kh (nvarchar(20)): Mã khách hàng. Bắt buộc.
 * - @pSo_ct (nvarchar(12)): Số chứng từ. Bắt buộc.
 * - @pNgay_ct (smalldatetime): Ngày chứng từ. Bắt buộc.
 * - @pMa_nt (varchar(3)): Mã ngoại tệ. Bắt buộc.
 * - @pTy_gia (decimal(19,4)): Tỷ giá. Bắt buộc.
 * - @pT_tt (decimal(19,4)): Tổng thanh toán. Bắt buộc.
 * - @pT_tt_nt (decimal(19,4)): Tổng thanh toán ngoại tệ. Bắt buộc.
 * - @pTien_tt (decimal(19,4)): Tiền thanh toán. Bắt buộc.
 * - @pTien_tt_nt (decimal(19,4)): Tiền thanh toán ngoại tệ. Bắt buộc.
 * - @pTien_tt_qd (decimal(19,4)): Tiền thanh toán quy đổi. Bắt buộc.
 * - @pT_tien (decimal(19,4)): Tổng tiền. Bắt buộc.
 * - @pT_tien_nt (decimal(19,4)): Tổng tiền ngoại tệ. Bắt buộc.
 * - @pUser (nvarchar(20)): Người dùng thực hiện. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, 50163 nếu lỗi transaction).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện insert/update trong transaction).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pStt_rec' => '001xCA10000013757079',
 *     'pStt_rec_hd' => '001xSO30000013756868',
 *     'pMa_ct' => 'CA1',
 *     'pNguoi_gd' => 'Lê Thị Phương Hoa',
 *     'pDien_giai' => '',
 *     'pTk_pt' => '111',
 *     'pMa_kh' => '00027',
 *     'pSo_ct' => '000001',
 *     'pNgay_ct' => '2023-06-20',
 *     'pMa_nt' => 'USD',
 *     'pTy_gia' => 22000,
 *     'pT_tt' => 22000000000,
 *     'pT_tt_nt' => 1000000,
 *     'pTien_tt' => 100.0,
 *     'pTien_tt_nt' => 100.0,
 *     'pTien_tt_qd' => 100,
 *     'pT_tien' => 100.0,
 *     'pT_tien_nt' => 100,
 *     'pUser' => 'admin',
 * ];
 * $result = AsARInsPost2TT_ARTT::call($params);
 * ```
 */
class AsARInsPost2TT_ARTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsPost2TT_ARTT', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pStt_rec'      => $params['pStt_rec'] ?? null,
            'pStt_rec_hd'   => $params['pStt_rec_hd'] ?? null,
            'pMa_ct'        => $params['pMa_ct'] ?? null,
            'pNguoi_gd'     => $params['pNguoi_gd'] ?? null,
            'pDien_giai'    => $params['pDien_giai'] ?? null,
            'pTk_pt'        => $params['pTk_pt'] ?? null,
            'pMa_kh'        => $params['pMa_kh'] ?? null,
            'pSo_ct'        => $params['pSo_ct'] ?? null,
            'pNgay_ct'      => $params['pNgay_ct'] ?? null,
            'pMa_nt'        => $params['pMa_nt'] ?? null,
            'pTy_gia'       => $params['pTy_gia'] ?? null,
            'pT_tt'         => $params['pT_tt'] ?? null,
            'pT_tt_nt'      => $params['pT_tt_nt'] ?? null,
            'pTien_tt'      => $params['pTien_tt'] ?? null,
            'pTien_tt_nt'   => $params['pTien_tt_nt'] ?? null,
            'pTien_tt_qd'   => $params['pTien_tt_qd'] ?? null,
            'pT_tien'       => $params['pT_tien'] ?? null,
            'pT_tien_nt'    => $params['pT_tien_nt'] ?? null,
            'pUser'         => $params['pUser'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
