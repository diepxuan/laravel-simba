<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 12:03:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLCrtKC
 * 
 * Stored procedure: asGLCrtKC
 * Purpose: Tạo bút toán kết chuyển tự động.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Mặc định: '111'.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Mặc định: ''.
 * - @pNgay1 (smalldatetime): Ngày bắt đầu kỳ kết chuyển. Mặc định: '2015-01-01'.
 * - @pNgay2 (smalldatetime): Ngày kết thúc kỳ kết chuyển. Mặc định: '2015-01-31'.
 * - @pTk (nvarchar(20)): Tài khoản nguồn. Mặc định: ''.
 * - @pTk_du (nvarchar(20)): Tài khoản đích. Mặc định: ''.
 * - @pUser (nvarchar(20)): Người dùng thực hiện. Mặc định: ''.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
 * 
 * Giá trị mặc định (trong class):
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pMa_ct: null.
 * - pNgay1: ngày đầu tháng hiện tại.
 * - pNgay2: ngày cuối tháng hiện tại.
 * - pTk: null.
 * - pTk_du: null.
 * - pUser: null.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện tạo bút toán).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'GL3',
 *     'pNgay1' => '2023-01-01',
 *     'pNgay2' => '2023-01-31',
 *     'pTk' => '1331',
 *     'pTk_du' => '33311',
 *     'pUser' => 'admin',
 * ];
 * $result = AsGLCrtKC::call($params);
 * ```
 */
class AsGLCrtKC
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        // Tính ngày đầu tháng và cuối tháng hiện tại nếu không cung cấp
        $pNgay1 = $params['pNgay1'] ?? date('Y-m-01');
        $pNgay2 = $params['pNgay2'] ?? date('Y-m-t');

        return ProcedureCaller::call('asGLCrtKC', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_ct'  => $params['pMa_ct'] ?? null,
            'pNgay1'  => $pNgay1,
            'pNgay2'  => $pNgay2,
            'pTk'     => $params['pTk'] ?? null,
            'pTk_du'  => $params['pTk_du'] ?? null,
            'pUser'   => $params['pUser'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
