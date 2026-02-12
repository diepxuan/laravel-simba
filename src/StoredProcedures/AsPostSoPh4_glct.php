<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:36:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPostSoPh4_glct
 * 
 * Stored procedure: asPostSoPh4_glct
 * Purpose: AsiaSoft, Sep  8 2005  9:18AM
 * 
 * Tham số:

 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [

 * ];
 * $result = AsPostSoPh4_glct::call($params);
 * ```
 */
class AsPostSoPh4_glct
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostSoPh4_glct', [

        ], $connection);
    }
}
