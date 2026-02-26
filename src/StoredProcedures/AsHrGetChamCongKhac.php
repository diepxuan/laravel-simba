<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:04:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsHrGetChamCongKhac.
 *
 * Stored procedure: asHrGetChamCongKhac
 * Mục đích: Lấy dữ liệu chấm công khác (ngoài giờ) của nhân viên theo mã công ty, năm, tháng, ngày và ID nhân viên (có thể tìm theo prefix).
 * Procedure trả về tất cả các cột từ bảng HrChamCongKhac thỏa mãn điều kiện.
 *
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định '001'): Mã công ty (NVARCHAR(3)).
 * - @pNam (int, tùy chọn, mặc định 2014): Năm chấm công (INT). Nếu NULL sẽ lấy năm hiện tại.
 * - @pThang (int, tùy chọn, mặc định 7): Tháng chấm công (INT). Nếu NULL sẽ lấy tháng hiện tại.
 * - @pNgay (int, tùy chọn, mặc định 2): Ngày chấm công (INT). Nếu NULL sẽ lấy ngày hiện tại.
 * - @pId (string, tùy chọn, mặc định ''): ID nhân viên (NVARCHAR(20)). Nếu NULL sẽ chuyển thành chuỗi rỗng.
 *   Điều kiện tìm kiếm: Id LIKE @pId + '%' (bắt đầu với @pId).
 *
 * Giá trị trả về:
 * - Procedure trả về resultset chứa các bản ghi chấm công khác thỏa mãn điều kiện.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsHrGetChamCongKhac::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2025,
 *     'pThang' => 2,
 *     'pNgay' => 15,
 *     'pId' => 'NV',
 * ]);
 * // $result là tập hợp các bản ghi chấm công khác có Id bắt đầu bằng 'NV'
 * ```
 *
 * Lưu ý:
 * - Nếu không cung cấp tham số, procedure sẽ sử dụng giá trị mặc định.
 * - Điều kiện tìm kiếm theo prefix, có thể trả về nhiều bản ghi.
 */
class AsHrGetChamCongKhac
{
    /**
     * Gọi stored procedure asHrGetChamCongKhac.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetChamCongKhac', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam'    => $params['pNam'] ?? null,
            'pThang'  => $params['pThang'] ?? null,
            'pNgay'   => $params['pNgay'] ?? null,
            'pId'     => $params['pId'] ?? null,
            'pngay'   => $params['pngay'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetChamCongKhac with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?int $Nam = null, ?int $Thang = null, ?int $Ngay = null, ?string $Id = null, mixed $ngay = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam'    => $Nam,
            'pThang'  => $Thang,
            'pNgay'   => $Ngay,
            'pId'     => $Id,
            'pngay'   => $ngay,
        ];

        return self::call($params);
    }
}
