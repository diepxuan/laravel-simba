<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 09:48:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSADelDmNguoiPhuThuoc.
 *
 * Stored procedure: asSADelDmNguoiPhuThuoc
 * Mục đích: Xóa danh mục người phụ thuộc.
 * Procedure xóa một bản ghi người phụ thuộc của nhân viên trong một kỳ (tháng/năm) cụ thể.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pThang (string, bắt buộc): Tháng (20 ký tự, lưu dạng chuỗi). Thường là số tháng (1-12).
 * - @pNam (string, bắt buộc): Năm (20 ký tự, lưu dạng chuỗi). Thường là số năm.
 * - @pMa_nv (string, bắt buộc): Mã nhân viên (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSADelDmNguoiPhuThuoc::call([
 *     'pMa_cty' => '001',
 *     'pThang' => '2',
 *     'pNam' => '2025',
 *     'pMa_nv' => 'NV001',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure thực hiện DELETE trên bảng SaDmNguoiPhuThuoc.
 * - Nếu không có bản ghi nào khớp điều kiện, DELETE không ảnh hưởng đến dòng nào, @pRet vẫn là 0 (không có lỗi SQL).
 * - Cần đảm bảo rằng không có ràng buộc khóa ngoại ngăn xóa (nếu có, @pRet sẽ là mã lỗi SQL).
 * - Người dùng cần có quyền DELETE trên bảng SaDmNguoiPhuThuoc.
 */
class AsSADelDmNguoiPhuThuoc
{
    /**
     * Gọi stored procedure asSADelDmNguoiPhuThuoc.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSADelDmNguoiPhuThuoc', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang'  => $params['pThang'] ?? null,
            'pNam'    => $params['pNam'] ?? null,
            'pMa_nv'  => $params['pMa_nv'] ?? null,
            'pRet'    => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asSADelDmNguoiPhuThuoc with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Thang = null, ?string $Nam = null, ?string $Ma_nv = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang'  => $Thang,
            'pNam'    => $Nam,
            'pMa_nv'  => $Ma_nv,
            'pRet'    => $Ret,
        ];

        return self::call($params);
    }
}
