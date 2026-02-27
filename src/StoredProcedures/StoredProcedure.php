<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-27 21:46:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;

class StoredProcedure
{
    public const NAME = 'StoredProcedureName';

    /**
     * Gọi stored procedure StoredProcedureName.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params)
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call(static::NAME, $params, $connection);
    }
}
