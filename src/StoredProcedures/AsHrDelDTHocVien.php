<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 23:58:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsHrDelDTHocVien.
 *
 * Stored procedure: asHrDelDTHocVien
 * Mục đích: Xóa nhân viên tham gia lớp đào tạo (học viên) khỏi bảng HrDTHocVien dựa trên mã công ty, mã khóa đào tạo, mã lớp đào tạo và ID nhân viên (có thể tìm theo prefix).
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 * - @pMa_kdt (string, bắt buộc): Mã khóa đào tạo (NVARCHAR(20)).
 * - @pMa_ldt (string, bắt buộc): Mã lớp đào tạo (NVARCHAR(20)).
 * - @pId (string, bắt buộc): ID nhân viên (NVARCHAR(20)). Nếu NULL sẽ chuyển thành chuỗi rỗng.
 *   Điều kiện xóa: Id LIKE @pId + '%' (bắt đầu với @pId), có thể xóa nhiều bản ghi.
 * - @pRet (int, output): Kết quả trả về: 0 nếu thành công, khác 0 nếu có lỗi (giá trị @@ERROR).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsHrDelDTHocVien::call([
 *     'pMa_cty' => '001',
 *     'pMa_kdt' => 'KDT001',
 *     'pMa_ldt' => 'LDT001',
 *     'pId' => 'NV',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure này thực hiện DELETE trực tiếp, có thể xóa nhiều bản ghi nếu @pId là prefix.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 */
class AsHrDelDTHocVien
{
    /**
     * Gọi stored procedure asHrDelDTHocVien.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelDTHocVien', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kdt' => $params['pMa_kdt'] ?? null,
            'pMa_ldt' => $params['pMa_ldt'] ?? null,
            'pId'     => $params['pId'] ?? null,
            'pRet'    => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelDTHocVien with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_kdt = null, ?string $Ma_ldt = null, ?string $Id = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kdt' => $Ma_kdt,
            'pMa_ldt' => $Ma_ldt,
            'pId'     => $Id,
            'pRet'    => $Ret,
        ];

        return self::call($params);
    }
}
