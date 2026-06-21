<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 *
 * @lastupdate 2026-06-21
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\Models\Concerns\HasSimbaCompositeKey;
use Diepxuan\Simba\SModel\zInPh7Model;

/**
 * Model zInPh7.
 *
 * Lớp Simba model trực tiếp cho bảng `zInPh7`, kế thừa schema từ `zInPh7Model`.
 */
class zInPh7 extends zInPh7Model
{
    use HasSimbaCompositeKey;

}
