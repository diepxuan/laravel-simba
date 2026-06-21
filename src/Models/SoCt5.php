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
use Diepxuan\Simba\SModel\SoCt5Model;

/**
 * Model SoCt5.
 *
 * Lớp Simba model trực tiếp cho bảng `SoCt5`, kế thừa schema từ `SoCt5Model`.
 */
class SoCt5 extends SoCt5Model
{
    use HasSimbaCompositeKey;

}
