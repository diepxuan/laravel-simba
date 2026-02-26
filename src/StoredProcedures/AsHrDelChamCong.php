<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 23:57:25
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsHrDelChamCong.
 *
 * Stored procedure: asHrDelChamCong
 * Mục đích: Xóa dữ liệu chấm công nhân viên theo mã công ty, năm, tháng và ID nhân viên.
 * Procedure thực hiện DELETE từ bảng HrChamCong với điều kiện khớp các tham số.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 * - @pNam (int, bắt buộc): Năm chấm công (INT).
 * - @pThang (int, bắt buộc): Tháng chấm công (INT).
 * - @pId (string, bắt buộc): ID nhân viên (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả trả về: 0 nếu thành công, khác 0 nếu có lỗi (giá trị @@ERROR).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsHrDelChamCong::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2025,
 *     'pThang' => 2,
 *     'pId' => 'NV001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure này thực hiện DELETE trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 */
class AsHrDelChamCong
{
    /**
     * Gọi stored procedure asHrDelChamCong.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelChamCong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam'    => $params['pNam'] ?? null,
            'pThang'  => $params['pThang'] ?? null,
            'pId'     => $params['pId'] ?? null,
            'pRet'    => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelChamCong with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?int $Nam = null, ?int $Thang = null, ?string $Id = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam'    => $Nam,
            'pThang'  => $Thang,
            'pId'     => $Id,
            'pRet'    => $Ret,
        ];

        return self::call($params);
    }
}
