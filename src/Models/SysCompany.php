<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-06-22
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\sysCompanyModel as Model;
use Illuminate\Database\Eloquent\Relations\BelongsToMany;

/**
 * SysCompany - danh sách công ty.
 *
 * Helper nghiệp vụ `resxByLanguage()` đã được tách sang
 * `Diepxuan\Catalog\Models\Concerns\HasSysCompanyLocalizedResx`
 * và gắn vào `Diepxuan\Catalog\Models\SysCompany`.
 *
 * Còn giữ ở đây:
 * - Quan hệ Simba-Simba: userRights, resx, users.
 */
class SysCompany extends Model
{
    public function userRights()
    {
        return $this->hasMany(SysUserCompanyRight::class, 'Ma_cty', 'ma_cty');
    }

    public function resx()
    {
        return $this->hasMany(SysCompanyResx::class, 'ma_cty', 'ma_cty');
    }

    /**
     * Get the users associated with the company.
     */
    public function users(): BelongsToMany
    {
        return $this->belongsToMany(
            SysUserInfo::class,
            'sysUserCompanyRight',
            'Ma_cty',      // Foreign key on pivot (trỏ tới company)
            'Username',    // Foreign key on pivot (trỏ tới user)
            'ma_cty',      // Local key on this model
            'username'     // Local key on SysUserInfo
        );
    }
}