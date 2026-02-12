<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 12:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLDKCTGS
 * 
 * Stored procedure: asGLDKCTGS
 * Purpose: Đăng ký chứng từ ghi sổ.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pThang (int): Tháng đăng ký. Bắt buộc.
 * - @pNam (int): Năm đăng ký. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Bắt buộc.
 * - @pTk (nvarchar(20)): Tài khoản. Bắt buộc.
 * - @pTen_ctgs (nvarchar(50)): Tên chứng từ ghi sổ. Bắt buộc.
 * - @pSo_hieu (nvarchar(3)): Số hiệu. Bắt buộc.
 * - @pNgay (int): Số ngày tập hợp (ví dụ: 30 = theo tháng). Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pThang: tháng hiện tại.
 * - pNam: năm hiện tại.
 * - pNgay: 30 (tập hợp theo tháng).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện đăng ký).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pThang' => 12,
 *     'pNam' => 2023,
 *     'pMa_ct' => 'GL1',
 *     'pTk' => '111',
 *     'pTen_ctgs' => 'Chứng từ ghi sổ tháng 12',
 *     'pSo_hieu' => 'CT1',
 *     'pNgay' => 30,
 * ];
 * $result = AsGLDKCTGS::call($params);
 * ```
 */
class AsGLDKCTGS
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLDKCTGS', [
            'pMa_cty'    => $params['pMa_cty'] ?? SModel::CTY,
            'pThang'     => $params['pThang'] ?? (int) date('m'),
            'pNam'       => $params['pNam'] ?? (int) date('Y'),
            'pMa_ct'     => $params['pMa_ct'] ?? null,
            'pTk'        => $params['pTk'] ?? null,
            'pTen_ctgs'  => $params['pTen_ctgs'] ?? null,
            'pSo_hieu'   => $params['pSo_hieu'] ?? null,
            'pNgay'      => $params['pNgay'] ?? 30,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
