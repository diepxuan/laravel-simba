<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 14:25:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInsDMCT
 * 
 * Stored procedure: asSIInsDMCT
 * Purpose: Thêm một loại chứng từ (danh mục chứng từ) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Bắt buộc.
 * - @pPhan_he (nvarchar(3)): Phân hệ. Bắt buộc.
 * - @pMa_ct_me (nvarchar(3)): Mã chứng từ mẹ. Bắt buộc.
 * - @pTen_ct (nvarchar(30)): Tên chứng từ. Bắt buộc.
 * - @pTk_no (nvarchar(20)): Tài khoản nợ. Bắt buộc.
 * - @pTk_co (nvarchar(20)): Tài khoản có. Bắt buộc.
 * - @pMa_nt (nvarchar(3)): Mã người thu. Bắt buộc.
 * - @pSo_lien (int): Số liên. Bắt buộc.
 * - @pStt_nkc (int): Số thứ tự nhập khẩu. Bắt buộc.
 * - @pStt_ntxt (int): Số thứ tự nhập xuất. Bắt buộc.
 * - @pCt_dc (bit): Chứng từ đặc biệt? Bắt buộc.
 * - @pLoc_nsd (bit): Lọc người sử dụng? Bắt buộc.
 * - @pVv (bit): Vụ việc? Bắt buộc.
 * - @pSpct (bit): Sản phẩm chứng từ? Bắt buộc.
 * - @pPhi (bit): Phí? Bắt buộc.
 * - @pBp (bit): Bộ phận? Bắt buộc.
 * - @pLo (bit): Lô? Bắt buộc.
 * - @pSp_post (nvarchar(50)): Stored procedure post. Bắt buộc.
 * - @pSp_process (nvarchar(50)): Stored procedure process. Bắt buộc.
 * - @pPh (nvarchar(10)): Phòng? Bắt buộc.
 * - @pSd (bit): Sử dụng? Bắt buộc.
 * - @pNxt (nvarchar(1)): Next? Bắt buộc.
 * - @pMenuid (nvarchar(16)): Mã menu. Bắt buộc.
 * - @pVn_prefix (nvarchar(12)): Prefix số chứng từ. Bắt buộc.
 * - @pVn_sequence (bigint): Sequence số chứng từ. Bắt buộc.
 * - @pVn_pattern (nvarchar(1)): Pattern số chứng từ. Bắt buộc.
 * - @pVn_width (int): Độ rộng số chứng từ. Bắt buộc.
 * - @pKieu_trung_so_ct (int): Kiểu trùng số chứng từ. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
 * 
 * Giá trị mặc định: Tất cả tham số không có mặc định, phải cung cấp.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện insert).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'SI01',
 *     'pPhan_he' => 'SI',
 *     'pMa_ct_me' => '',
 *     'pTen_ct' => 'Chứng từ bán hàng',
 *     // ... cung cấp tất cả tham số
 * ];
 * $result = AsInsDMCT::call($params);
 * ```
 */
class AsInsDMCT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIInsDMCT', [
            'pMa_cty'            => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_ct'             => $params['pMa_ct'] ?? null,
            'pPhan_he'           => $params['pPhan_he'] ?? null,
            'pMa_ct_me'          => $params['pMa_ct_me'] ?? null,
            'pTen_ct'            => $params['pTen_ct'] ?? null,
            'pTk_no'             => $params['pTk_no'] ?? null,
            'pTk_co'             => $params['pTk_co'] ?? null,
            'pMa_nt'             => $params['pMa_nt'] ?? null,
            'pSo_lien'           => $params['pSo_lien'] ?? null,
            'pStt_nkc'           => $params['pStt_nkc'] ?? null,
            'pStt_ntxt'          => $params['pStt_ntxt'] ?? null,
            'pCt_dc'             => $params['pCt_dc'] ?? null,
            'pLoc_nsd'           => $params['pLoc_nsd'] ?? null,
            'pVv'                => $params['pVv'] ?? null,
            'pSpct'              => $params['pSpct'] ?? null,
            'pPhi'               => $params['pPhi'] ?? null,
            'pBp'                => $params['pBp'] ?? null,
            'pLo'                => $params['pLo'] ?? null,
            'pSp_post'           => $params['pSp_post'] ?? null,
            'pSp_process'        => $params['pSp_process'] ?? null,
            'pPh'                => $params['pPh'] ?? null,
            'pSd'                => $params['pSd'] ?? null,
            'pNxt'               => $params['pNxt'] ?? null,
            'pMenuid'            => $params['pMenuid'] ?? null,
            'pVn_prefix'         => $params['pVn_prefix'] ?? null,
            'pVn_sequence'       => $params['pVn_sequence'] ?? null,
            'pVn_pattern'        => $params['pVn_pattern'] ?? null,
            'pVn_width'          => $params['pVn_width'] ?? null,
            'pKieu_trung_so_ct'  => $params['pKieu_trung_so_ct'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
