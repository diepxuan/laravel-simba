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
use Diepxuan\Simba\SModel\zInPh8Model;

/**
 * Model zInPh8.
 *
 * Lớp Simba model trực tiếp cho bảng `zInPh8`, kế thừa schema từ `zInPh8Model`.
 */
class zInPh8 extends zInPh8Model
{
    use HasSimbaCompositeKey;

}
