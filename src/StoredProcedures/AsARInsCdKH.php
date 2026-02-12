<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:25:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsARInsCdKH
 * 
 * Stored procedure: asARInsCdKH
 * Purpose: Chèn dữ liệu vào bảng arcdkh (công nợ chi tiết khách hàng) và đồng bộ sang glcdtk (công nợ chi tiết tài khoản).
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pNam (int): Năm. Bắt buộc.
 * - @pTk (nvarchar(20)): Tài khoản. Bắt buộc.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Bắt buộc.
 * - @pMa_kh (nvarchar(20)): Mã khách hàng. Bắt buộc.
 * - @pMa_bp (nvarchar(20)): Mã bộ phận. Bắt buộc.
 * - @pMa_hd (nvarchar(20)): Mã hợp đồng. Bắt buộc.
 * - @pMa_spct (nvarchar(20)): Mã sản phẩm chi tiết. Bắt buộc.
 * - @pDu_no (decimal(19,4)): Dư nợ. Bắt buộc.
 * - @pDu_co (decimal(19,4)): Dư có. Bắt buộc.
 * - @pDu_no_nt (decimal(19,4)): Dư nợ ngoại tệ. Bắt buộc.
 * - @pDu_co_nt (decimal(19,4)): Dư có ngoại tệ. Bắt buộc.
 * - @pUser (nvarchar(20)): Người dùng thực hiện. Bắt buộc.
 * - @pRet (int output): Tham số output trả về kết quả (không được xử lý bởi ProcedureCaller hiện tại).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện insert/update).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pNam' => 2023,
 *     'pTk' => '131',
 *     'pMa_nt' => 'USD',
 *     'pMa_kh' => 'KH001',
 *     'pMa_bp' => 'BP01',
 *     'pMa_hd' => 'HD001',
 *     'pMa_spct' => 'SPCT01',
 *     'pDu_no' => 1000.00,
 *     'pDu_co' => 0.00,
 *     'pDu_no_nt' => 1000.00,
 *     'pDu_co_nt' => 0.00,
 *     'pUser' => 'admin',
 * ];
 * $result = AsARInsCdKH::call($params);
 * ```
 */
class AsARInsCdKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsCdKH', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pNam'      => $params['pNam'] ?? null,
            'pTk'       => $params['pTk'] ?? null,
            'pMa_nt'    => $params['pMa_nt'] ?? null,
            'pMa_kh'    => $params['pMa_kh'] ?? null,
            'pMa_bp'    => $params['pMa_bp'] ?? null,
            'pMa_hd'    => $params['pMa_hd'] ?? null,
            'pMa_spct'  => $params['pMa_spct'] ?? null,
            'pDu_no'    => $params['pDu_no'] ?? null,
            'pDu_co'    => $params['pDu_co'] ?? null,
            'pDu_no_nt' => $params['pDu_no_nt'] ?? null,
            'pDu_co_nt' => $params['pDu_co_nt'] ?? null,
            'pUser'     => $params['pUser'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
