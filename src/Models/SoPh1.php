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
use Diepxuan\Simba\SModel\SoPh1Model;

/**
 * Model SoPh1.
 *
 * Lớp Simba model trực tiếp cho bảng `SoPh1`, kế thừa schema từ `SoPh1Model`.
 */
class SoPh1 extends SoPh1Model
{
    use HasSimbaCompositeKey;

}
