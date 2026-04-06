<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 18:46:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAGetDMKU.
 *
 * Stored procedure: asCAGetDMKU
 * Mục đích: Lấy danh sách đơn mã kho (DMKU) từ hệ thống Simba.
 * Procedure trả về danh sách các đơn mã kho được sử dụng trong quản lý kho và vật tư.
 *
 * Tham số:
 * - Không có tham số đầu vào.
 *
 * Giá trị trả về:
 * - Collection chứa danh sách đơn mã kho với các trường thông tin liên quan.
 *
 * Ví dụ gọi:
 * ```php
 * // Sử dụng method call()
 * $result = AsCAGetDMKU::call([]);
 *
 * // Sử dụng method callWithParams()
 * $result = AsCAGetDMKU::callWithParams();
 * ```
 *
 * Lưu ý:
 * - Procedure thuộc nhóm Get (asCAGet*), không có output parameter.
 * - Sử dụng method callWithParams() để gọi với các tham số đặt tên (nếu có trong tương lai).
 */
class AsCAGetDMKU
{
    /**
     * Gọi stored procedure asCAGetDMKU.
     *
     * @param array $params mảng tham số (hiện tại không sử dụng)
     *
     * @return Collection kết quả trả về từ procedure
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAGetDMKU', [
        ], $connection);
    }

    /**
     * Call stored procedure asCAGetDMKU with named parameters.
     *
     * @return Collection kết quả trả về từ procedure
     */
    public static function callWithParams(): Collection
    {
        return self::call([]);
    }
}
