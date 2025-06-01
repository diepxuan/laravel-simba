<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-06-01 19:56:38
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\ArDmKh as Model;
use Illuminate\Database\Eloquent\Relations\HasMany;

class ArDmKh extends Model
{
    public function glCts(): HasMany
    {
        return $this->hasMany(GlCt::class, 'ma_kh', 'ma_kh');
    }
}
