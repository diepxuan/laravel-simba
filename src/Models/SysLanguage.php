<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-20 11:43:30
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SysLanguage as Model;

class SysLanguage extends Model
{
    /**
     * is Enable scope.
     *
     * @param mixed $query
     */
    public function scopeIsEnable($query)
    {
        return $query->where('ksd', 0);
    }

    /**
     * Current scope.
     *
     * @param mixed $query
     */
    public function scopeCurrent($query)
    {
        return $query->where('Selected', 1);
    }
}
