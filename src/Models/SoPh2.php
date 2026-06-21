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
use Diepxuan\Simba\SModel\SoPh2Model;

/**
 * Model SoPh2.
 *
 * Lớp Simba model trực tiếp cho bảng `SoPh2`, kế thừa schema từ `SoPh2Model`.
 */
class SoPh2 extends SoPh2Model
{
    use HasSimbaCompositeKey;

}
