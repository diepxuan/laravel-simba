<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsARInsPH1
 * 
 * Stored procedure: asARInsPH1
 * Purpose: Thêm mới phiếu công nợ phải thu (bảng ARPH1).
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Bắt buộc.
 * - @pSo_ct (nvarchar(12)): Số chứng từ. Bắt buộc.
 * - @pStt_rec_dh (nvarchar(20)): Số tham chiếu đơn hàng. Bắt buộc.
 * - @pSo_dh (nvarchar(12)): Số đơn hàng. Bắt buộc.
 * - @pNgay_ct (smalldatetime): Ngày chứng từ. Bắt buộc.
 * - @pNgay_lct (smalldatetime): Ngày lập chứng từ. Bắt buộc.
 * - @pMa_kh (nvarchar(20)): Mã khách hàng. Bắt buộc.
 * - @pDia_chi (nvarchar(255)): Địa chỉ. Bắt buộc.
 * - @pNguoi_gd (nvarchar(30)): Người giao dịch. Bắt buộc.
 * - @pDien_giai (nvarchar(255)): Diễn giải. Bắt buộc.
 * - @pTk_no (nvarchar(20)): Tài khoản nợ. Bắt buộc.
 * - @pMa_gd (nvarchar(1)): Mã giao dịch. Bắt buộc.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Bắt buộc.
 * - @pTy_gia (decimal(19,4)): Tỷ giá. Bắt buộc.
 * - @pT_tien_nt (decimal(19,4)): Tổng tiền ngoại tệ. Bắt buộc.
 * - @pT_tien (decimal(19,4)): Tổng tiền. Bắt buộc.
 * - @pDu (decimal(19,4)): Dư. Bắt buộc.
 * - @pDu_nt (decimal(19,4)): Dư ngoại tệ. Bắt buộc.
 * - @pTrang_thai (nvarchar(1)): Trạng thái. Bắt buộc.
 * - @pPost2gl (nvarchar(1)): Đã post sang GL. Bắt buộc.
 * - @pLUser (nvarchar(20)): Người dùng thực hiện. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (@@error).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện insert).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'AR20230001',
 *     'pMa_ct' => 'AR1',
 *     'pSo_ct' => '000001',
 *     'pStt_rec_dh' => 'DH001',
 *     'pSo_dh' => 'DH0001',
 *     'pNgay_ct' => '2023-01-15',
 *     'pNgay_lct' => '2023-01-15',
 *     'pMa_kh' => 'KH001',
 *     'pDia_chi' => '123 Đường ABC',
 *     'pNguoi_gd' => 'Nguyễn Văn B',
 *     'pDien_giai' => 'Thanh toán tiền hàng',
 *     'pTk_no' => '131',
 *     'pMa_gd' => '1',
 *     'pMa_nt' => 'VND',
 *     'pTy_gia' => 1.0,
 *     'pT_tien_nt' => 1000000,
 *     'pT_tien' => 1000000,
 *     'pDu' => 1000000,
 *     'pDu_nt' => 1000000,
 *     'pTrang_thai' => '1',
 *     'pPost2gl' => '0',
 *     'pLUser' => 'admin',
 * ];
 * $result = AsARInsPH1::call($params);
 * ```
 */
class AsARInsPH1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsPH1', [
            'pMa_cty'      => $params['pMa_cty'] ?? null,
            'pStt_rec'     => $params['pStt_rec'] ?? null,
            'pMa_ct'       => $params['pMa_ct'] ?? null,
            'pSo_ct'       => $params['pSo_ct'] ?? null,
            'pStt_rec_dh'  => $params['pStt_rec_dh'] ?? null,
            'pSo_dh'       => $params['pSo_dh'] ?? null,
            'pNgay_ct'     => $params['pNgay_ct'] ?? null,
            'pNgay_lct'    => $params['pNgay_lct'] ?? null,
            'pMa_kh'       => $params['pMa_kh'] ?? null,
            'pDia_chi'     => $params['pDia_chi'] ?? null,
            'pNguoi_gd'    => $params['pNguoi_gd'] ?? null,
            'pDien_giai'   => $params['pDien_giai'] ?? null,
            'pTk_no'       => $params['pTk_no'] ?? null,
            'pMa_gd'       => $params['pMa_gd'] ?? null,
            'pMa_nt'       => $params['pMa_nt'] ?? null,
            'pTy_gia'      => $params['pTy_gia'] ?? null,
            'pT_tien_nt'   => $params['pT_tien_nt'] ?? null,
            'pT_tien'      => $params['pT_tien'] ?? null,
            'pDu'          => $params['pDu'] ?? null,
            'pDu_nt'       => $params['pDu_nt'] ?? null,
            'pTrang_thai'  => $params['pTrang_thai'] ?? null,
            'pPost2gl'     => $params['pPost2gl'] ?? null,
            'pLUser'       => $params['pLUser'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
