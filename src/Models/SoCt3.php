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
use Diepxuan\Simba\SModel\SoCt3Model;

/**
 * Model SoCt3.
 *
 * Lớp Simba model trực tiếp cho bảng `SoCt3`, kế thừa schema từ `SoCt3Model`.
 */
class SoCt3 extends SoCt3Model
{
    use HasSimbaCompositeKey;

}
