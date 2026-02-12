<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 14:10:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetModuleID
 * 
 * Stored procedure: asSIGetModuleID
 * Purpose: Lấy danh sách module ID và tên module từ bảng menu.
 * 
 * Tham số: Không có tham số.
 * 
 * Kết quả trả về: Collection các module với các cột: moduleid, modulename.
 * 
 * Example call:
 * ```php
 * $params = [];
 * $result = AsGetModuleID::call($params);
 * ```
 */
class AsGetModuleID
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetModuleID', [], $connection);
    }
}
