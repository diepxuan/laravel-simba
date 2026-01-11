<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-01-11 22:57:58
 */

namespace Diepxuan\Simba\StoredProcedures;

use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

class ProcedureCaller
{
    /**
     * Call a stored procedure and return results as a Collection.
     *
     * @param string      $name       Stored procedure name (without EXEC)
     * @param array       $params     Named parameters in the form ['pName' => value]
     * @param null|string $connection Optional connection name
     */
    public static function call(string $name, array $params = [], ?string $connection = null): Collection
    {
        $placeholders = '';
        if (!empty($params)) {
            $pairs        = array_map(static fn ($k) => "@{$k} = :{$k}", array_keys($params));
            $placeholders = implode(",\n            ", $pairs);
        }

        $sql = 'EXEC ' . $name . ($placeholders ? "\n            " . $placeholders : '');

        $conn = $connection ? DB::connection($connection) : DB::connection();
        $rows = $conn->select($sql, $params);

        return collect($rows);
    }
}
