<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-05-24 19:23:27
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SysCompanyResx as Model;

class SysCompanyResx extends Model
{
    public function language()
    {
        return $this->belongsTo(SysLanguage::class, 'language', 'Name');
    }

    public function company()
    {
        return $this->belongsTo(SysCompany::class, 'ma_cty', 'ma_cty');
    }
}
