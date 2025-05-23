<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-23 15:52:04
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SysUserInfo as Model;
use Illuminate\Database\Eloquent\Casts\Attribute;

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

    /**
     * Get the Simba User Id.
     */
    protected function id(): Attribute
    {
        return Attribute::make(
            get: fn (mixed $value, array $attributes) => hash('sha256', $this->username),
        );
    }
}
