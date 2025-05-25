<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-24 12:41:49
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SysUserCompanyRight as Model;

class SysUserCompanyRight extends Model
{
    public function user()
    {
        return $this->belongsTo(SysUserInfo::class, 'Username', 'username');
    }

    public function company()
    {
        return $this->belongsTo(SysCompany::class, 'Ma_cty', 'ma_cty');
    }
}
