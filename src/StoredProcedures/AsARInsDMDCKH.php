<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:01:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsARInsDMDCKH
 * 
 * Stored procedure: asARInsDMDCKH
 * Purpose: Thêm mới địa chỉ khách hàng (danh mục địa chỉ khách hàng).
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_kh (nvarchar(20)): Mã khách hàng. Bắt buộc.
 * - @pMa_dckh (nvarchar(1)): Mã địa chỉ khách hàng. Bắt buộc.
 * - @pTen_kh (nvarchar(100)): Tên khách hàng. Bắt buộc.
 * - @pDia_chi (nvarchar(255)): Địa chỉ. Bắt buộc.
 * - @pTel (nvarchar(30)): Số điện thoại. Bắt buộc.
 * - @pFax (nvarchar(30)): Số fax. Bắt buộc.
 * - @pNguoi_gd (nvarchar(30)): Người giao dịch. Bắt buộc.
 * - @pKsd (bit): Kích hoạt sử dụng. Bắt buộc.
 * - @pDc_md (bit): Địa chỉ mặc định. Bắt buộc.
 * - @pLUser (nvarchar(20)): Người dùng thực hiện. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (50011 nếu đã tồn tại, @@error nếu có lỗi).
 * 
 * Giá trị mặc định: pMa_cty mặc định lấy từ SModel::CTY.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện insert).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_kh' => 'KH001',
 *     'pMa_dckh' => '1',
 *     'pTen_kh' => 'Công ty ABC',
 *     'pDia_chi' => '123 Đường XYZ',
 *     'pTel' => '0987654321',
 *     'pFax' => '0432123456',
 *     'pNguoi_gd' => 'Nguyễn Văn A',
 *     'pKsd' => true,
 *     'pDc_md' => false,
 *     'pLUser' => 'admin',
 * ];
 * $result = AsARInsDMDCKH::call($params);
 * ```
 */
class AsARInsDMDCKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsDMDCKH', [
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_kh'    => $params['pMa_kh'] ?? null,
            'pMa_dckh'  => $params['pMa_dckh'] ?? null,
            'pTen_kh'   => $params['pTen_kh'] ?? null,
            'pDia_chi'  => $params['pDia_chi'] ?? null,
            'pTel'      => $params['pTel'] ?? null,
            'pFax'      => $params['pFax'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pKsd'      => $params['pKsd'] ?? null,
            'pDc_md'    => $params['pDc_md'] ?? null,
            'pLUser'    => $params['pLUser'] ?? null,
        ], $connection);
    }
}
