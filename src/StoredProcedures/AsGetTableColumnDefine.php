<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 14:12:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetTableColumnDefine
 * 
 * Stored procedure: asSIGetTableColumnDefine
 * Purpose: Lấy định nghĩa cột của một bảng (sys.tables và extended properties).
 * 
 * Tham số:
 * - @pTableName (sysname): Tên bảng cần lấy định nghĩa cột. Bắt buộc.
 * 
 * Giá trị mặc định:
 * - pTableName: null (phải cung cấp).
 * 
 * Kết quả trả về: Hai result sets: thông tin bảng và mô tả các cột.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pTableName' => 'SIDMBP',
 * ];
 * $result = AsGetTableColumnDefine::call($params);
 * ```
 */
class AsGetTableColumnDefine
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetTableColumnDefine', [
            'pTableName' => $params['pTableName'] ?? null,
        ], $connection);
    }
}
