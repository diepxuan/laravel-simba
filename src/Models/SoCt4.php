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
use Diepxuan\Simba\SModel\SoCt4Model;

/**
 * Model SoCt4.
 *
 * Lớp Simba model trực tiếp cho bảng `SoCt4`, kế thừa schema từ `SoCt4Model`.
 */
class SoCt4 extends SoCt4Model
{
    use HasSimbaCompositeKey;

}
