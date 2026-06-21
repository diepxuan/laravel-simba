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
use Diepxuan\Simba\SModel\zInCt7Model;

/**
 * Model zInCt7.
 *
 * Lớp Simba model trực tiếp cho bảng `zInCt7`, kế thừa schema từ `zInCt7Model`.
 */
class zInCt7 extends zInCt7Model
{
    use HasSimbaCompositeKey;

}
