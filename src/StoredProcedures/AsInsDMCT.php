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
use Diepxuan\Simba\Helper\ParamHelper;
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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIInsDMCT', [
            'pMa_cty'            => $paramObj->pMa_cty ?? SModel::CTY,
            'pMa_ct'             => $paramObj->pMa_ct ?? null,
            'pPhan_he'           => $paramObj->pPhan_he ?? null,
            'pMa_ct_me'          => $paramObj->pMa_ct_me ?? null,
            'pTen_ct'            => $paramObj->pTen_ct ?? null,
            'pTk_no'             => $paramObj->pTk_no ?? null,
            'pTk_co'             => $paramObj->pTk_co ?? null,
            'pMa_nt'             => $paramObj->pMa_nt ?? null,
            'pSo_lien'           => $paramObj->pSo_lien ?? null,
            'pStt_nkc'           => $paramObj->pStt_nkc ?? null,
            'pStt_ntxt'          => $paramObj->pStt_ntxt ?? null,
            'pCt_dc'             => $paramObj->pCt_dc ?? null,
            'pLoc_nsd'           => $paramObj->pLoc_nsd ?? null,
            'pVv'                => $paramObj->pVv ?? null,
            'pSpct'              => $paramObj->pSpct ?? null,
            'pPhi'               => $paramObj->pPhi ?? null,
            'pBp'                => $paramObj->pBp ?? null,
            'pLo'                => $paramObj->pLo ?? null,
            'pSp_post'           => $paramObj->pSp_post ?? null,
            'pSp_process'        => $paramObj->pSp_process ?? null,
            'pPh'                => $paramObj->pPh ?? null,
            'pSd'                => $paramObj->pSd ?? null,
            'pNxt'               => $paramObj->pNxt ?? null,
            'pMenuid'            => $paramObj->pMenuid ?? null,
            'pVn_prefix'         => $paramObj->pVn_prefix ?? null,
            'pVn_sequence'       => $paramObj->pVn_sequence ?? null,
            'pVn_pattern'        => $paramObj->pVn_pattern ?? null,
            'pVn_width'          => $paramObj->pVn_width ?? null,
            'pKieu_trung_so_ct'  => $paramObj->pKieu_trung_so_ct ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
