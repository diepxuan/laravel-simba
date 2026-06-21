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
use Diepxuan\Simba\SModel\SoPh4Model;

/**
 * Model SoPh4.
 *
 * Lớp Simba model trực tiếp cho bảng `SoPh4`, kế thừa schema từ `SoPh4Model`.
 */
class SoPh4 extends SoPh4Model
{
    use HasSimbaCompositeKey;

}
