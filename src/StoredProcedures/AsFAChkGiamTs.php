<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 23:41:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsFAChkGiamTs.
 *
 * Stored procedure: asFAChkGiamTs
 * Mục đích: Kiểm tra điều kiện giảm tài sản cố định (xác định xem có được phép giảm tài sản hay không).
 * Procedure thực hiện hai bước kiểm tra:
 * 1. Nếu là thao tác tạo mới (M), kiểm tra trong bảng fadmts xem tài sản đã được đánh dấu giảm (is_Giam = '1') chưa.
 * 2. Kiểm tra trong bảng fakhts (khấu hao tài sản) xem có bất kỳ bản ghi khấu hao nào sau ngày giảm (tháng/năm lớn hơn ngày giảm) không.
 * Nếu có bất kỳ bản ghi nào thỏa mãn, coi như không được phép giảm.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_ts (string, bắt buộc): Mã tài sản cố định (20 ký tự).
 * - @pMoi_Sua (string, bắt buộc): Loại thao tác: 'M' - Mới (tạo mới), 'S' - Sửa (chỉnh sửa). Chỉ kiểm tra bước 1 khi giá trị là 'M'.
 * - @pNgay_giam (datetime, bắt buộc): Ngày giảm tài sản (kiểu SMALLDATETIME).
 * - @pRet (int, output): Kết quả trả về: 0 - Được phép giảm, <>0 - không được phép giảm (số lượng bản ghi vi phạm).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsFAChkGiamTs::call([
 *     'pMa_cty' => '001',
 *     'pMa_ts' => 'TS001',
 *     'pMoi_Sua' => 'M',
 *     'pNgay_giam' => '2025-02-11',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Được phép giảm
 * } else {
 *     // Không được phép giảm
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure này thường được gọi trước khi thực hiện giảm tài sản để đảm bảo không vi phạm ràng buộc.
 * - Nếu @pMoi_Sua = 'S' (sửa), bước kiểm tra đầu tiên được bỏ qua.
 * - Điều kiện khấu hao: kiểm tra các bản ghi có (tháng > MONTH(@pNgay_giam) và cùng năm) hoặc năm > YEAR(@pNgay_giam).
 * - Giá trị @pRet là tổng số bản ghi vi phạm (COUNT).
 */
class AsFAChkGiamTs
{
    /**
     * Gọi stored procedure asFAChkGiamTs.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAChkGiamTs', [
            'pMa_cty'    => $params['pMa_cty'] ?? null,
            'pMa_ts'     => $params['pMa_ts'] ?? null,
            'pMoi_Sua'   => $params['pMoi_Sua'] ?? null,
            'pNgay_giam' => $params['pNgay_giam'] ?? null,
        ], $connection);
    }
}
