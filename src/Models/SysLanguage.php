<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-24 21:31:35
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SysLanguage as Model;

class SysLanguage extends Model
{
    public function resx()
    {
        return $this->hasMany(SysCompanyResx::class, 'language', 'Name');
    }

    public function companies()
    {
        return $this->belongsToMany(
            SysCompany::class,
            'sysCompanyResx',
            'language',  // Foreign key on pivot (trỏ tới user)
            'ma_cty',    // Foreign key on pivot (trỏ tới company)
            'Name',  // Local key on this model
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

    /**
     * The attributes that are mass assignable.
     *
     * @var string
     */
    public static function updateCurrentCultureInfo(string $name): bool
    {
        $name ??= self::DEFAULT;

        if (self::where('Name', $name)->exists()) {
            self::where('Name', '!=', $name)->update(['selected' => 0]);
            self::where('Name', $name)->update(['selected' => 1]);
        } else {
            return false;
        }

        return true;
    }
}
