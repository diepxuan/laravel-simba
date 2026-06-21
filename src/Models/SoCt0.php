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
use Diepxuan\Simba\SModel\SoCt0Model;

/**
 * Model SoCt0.
 *
 * Lớp Simba model trực tiếp cho bảng `SoCt0`, kế thừa schema từ `SoCt0Model`.
 */
class SoCt0 extends SoCt0Model
{
    use HasSimbaCompositeKey;

}
