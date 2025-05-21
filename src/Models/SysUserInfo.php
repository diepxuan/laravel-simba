<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-20 12:22:05
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SysUserInfo as Model;

class SysUserInfo extends Model
{
    /**
     * is Enable scope.
     *
     * @param mixed $query
     */
    public function scopeIsEnable($query)
    {
        return $query->where('disabled', 0);
    }

    /**
     * Current scope.
     *
     * @param mixed $query
     */
    public function scopeIsAdmin($query)
    {
        return $query->where('isadmin', 1);
    }

    /**
     * Current scope.
     *
     * @param mixed $query
     */
    public function scopeIsGrand($query)
    {
        return $query->where('grand', 1);
    }
}
