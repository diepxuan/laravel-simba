<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:39:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAGetTTHU.
 *
 * Stored procedure: asCAGetTTHU
 * Mục đích: Lấy danh sách thông tin thu (TTHU) từ hệ thống Simba.
 * Procedure trả về danh sách các thông tin thu được sử dụng trong kế toán và quản lý tài chính.
 *
 * Tham số:
 * - Không có tham số đầu vào.
 *
 * Giá trị trả về:
 * - Collection chứa danh sách thông tin thu với các trường thông tin liên quan.
 *
 * Ví dụ gọi:
 * ```php
 * // Sử dụng method call()
 * $result = AsCAGetTTHU::call([]);
 *
 * // Sử dụng method callWithParams()
 * $result = AsCAGetTTHU::callWithParams();
 * ```
 *
 * Lưu ý:
 * - Procedure thuộc nhóm Get (asCAGet*), không có output parameter.
 * - Sử dụng method callWithParams() để gọi với các tham số đặt tên (nếu có trong tương lai).
 */
class AsCAGetTTHU
{
    /**
     * Gọi stored procedure asCAGetTTHU.
     *
     * @param array $params mảng tham số (hiện tại không sử dụng)
     *
     * @return Collection kết quả trả về từ procedure
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAGetTTHU', [
        ], $connection);
    }

    /**
     * Call stored procedure asCAGetTTHU with named parameters.
     *
     * @return Collection kết quả trả về từ procedure
     */
    public static function callWithParams(): Collection
    {
        return self::call([]);
    }
}
