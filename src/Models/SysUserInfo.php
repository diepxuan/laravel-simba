<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-24 12:44:10
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SysUserInfo as Model;
use Illuminate\Database\Eloquent\Casts\Attribute;

class SysUserInfo extends Model
{
    public function companyRights()
    {
        return $this->hasMany(SysUserCompanyRight::class, 'Username', 'username');
    }

    public function companies()
    {
        return $this->belongsToMany(
            SysCompany::class,
            'sysUserCompanyRight',
            'Username',  // Foreign key on pivot (trỏ tới user)
            'Ma_cty',    // Foreign key on pivot (trỏ tới company)
            'username',  // Local key on this model
            'ma_cty'     // Local key on SysCompany
        );
    }

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
