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
use Diepxuan\Simba\SModel\SoPh0Model;

/**
 * Model SoPh0.
 *
 * Lớp Simba model trực tiếp cho bảng `SoPh0`, kế thừa schema từ `SoPh0Model`.
 */
class SoPh0 extends SoPh0Model
{
    use HasSimbaCompositeKey;

}
