<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 23:51:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetSoDuKh.
 *
 * Stored procedure: asGetSoDuKh
 * Mục đích: Lấy số dư công nợ của khách hàng tại một thời điểm cụ thể.
 * Procedure thực hiện truy vấn số dư đầu kỳ và phát sinh để tính số dư hiện tại của khách hàng.
 *
 * Tham số:
 * - @pMa_Cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_kh (string, bắt buộc): Mã khách hàng (20 ký tự).
 * - @pNgay (string, bắt buộc): Ngày cần lấy số dư (định dạng yyyyMMdd).
 * - @pTk (string, bắt buộc): Tài khoản công nợ (20 ký tự).
 *
 * Giá trị trả về:
 * - Procedure trả về resultset chứa thông tin số dư công nợ.
 * - Các cột có thể bao gồm: số dư đầu kỳ, phát sinh nợ, phát sinh có, số dư cuối kỳ.
 *
 * Logic chi tiết:
 * 1. Lấy số dư đầu kỳ từ bảng số dư đầu kỳ công nợ.
 * 2. Tính tổng phát sinh nợ và có từ ngày đầu kỳ đến ngày cần kiểm tra.
 * 3. Tính số dư cuối kỳ = số dư đầu kỳ + phát sinh nợ - phát sinh có.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsGetSoDuKh::call([
 *     'pMa_Cty' => '001',
 *     'pMa_kh' => 'KH001',
 *     'pNgay' => '20241231',
 *     'pTk' => '131',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure này thường được sử dụng trong báo cáo công nợ phải thu.
 * - Cần đảm bảo tham số ngày đúng định dạng.
 * - Kết quả trả về có thể được sử dụng để hiển thị trên giao diện hoặc tính toán tiếp.
 */
class AsGetSoDuKh
{
    /**
     * Gọi stored procedure asGetSoDuKh.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return Collection kết quả trả về từ procedure
     */
    public static function call(array $params): float
    {
        $connection = (new SModel())->getConnectionName();

        $result = ProcedureCaller::call('asGetSoDuKh', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_kh'  => $params['pMa_kh'] ?? null,
            'pNgay'   => $params['pNgay'] ?? null,
            'pTk'     => $params['pTk'] ?? null,
        ], $connection);

        if ($result instanceof Collection && $result->isNotEmpty()) {
            $firstItem = $result->first();
            if (\is_object($firstItem) && property_exists($firstItem, 'SoDu')) {
                return (float) $firstItem->SoDu;
            }
            if (\is_array($firstItem) && isset($firstItem['SoDu'])) {
                return (float) $firstItem['SoDu'];
            }
        }

        return 0.0;
    }
}
