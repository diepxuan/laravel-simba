<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:39:11
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAGetPH1.
 *
 * Stored procedure: asCAGetPH1
 * Mục đích: Lấy danh sách phiếu hàng 1 (PH1) từ hệ thống Simba.
 * Procedure trả về danh sách các phiếu hàng loại 1 được sử dụng trong quản lý kho.
 *
 * Tham số:
 * - Không có tham số đầu vào.
 *
 * Giá trị trả về:
 * - Collection chứa danh sách phiếu hàng 1 với các trường thông tin liên quan.
 *
 * Ví dụ gọi:
 * ```php
 * // Sử dụng method call()
 * $result = AsCAGetPH1::call([]);
 *
 * // Sử dụng method callWithParams()
 * $result = AsCAGetPH1::callWithParams();
 * ```
 *
 * Lưu ý:
 * - Procedure thuộc nhóm Get (asCAGet*), không có output parameter.
 * - Sử dụng method callWithParams() để gọi với các tham số đặt tên (nếu có trong tương lai).
 */
class AsCAGetPH1
{
    /**
     * Gọi stored procedure asCAGetPH1.
     *
     * @param array $params mảng tham số (hiện tại không sử dụng)
     *
     * @return Collection kết quả trả về từ procedure
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAGetPH1', [
        ], $connection);
    }

    /**
     * Call stored procedure asCAGetPH1 with named parameters.
     *
     * @return Collection kết quả trả về từ procedure
     */
    public static function callWithParams(): Collection
    {
        return self::call([]);
    }
}
