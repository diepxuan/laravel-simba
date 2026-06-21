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
use Diepxuan\Simba\SModel\SoPh5Model;

/**
 * Model SoPh5.
 *
 * Lớp Simba model trực tiếp cho bảng `SoPh5`, kế thừa schema từ `SoPh5Model`.
 */
class SoPh5 extends SoPh5Model
{
    use HasSimbaCompositeKey;

}
