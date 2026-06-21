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
use Diepxuan\Simba\SModel\SoCt6Model;

/**
 * Model SoCt6.
 *
 * Lớp Simba model trực tiếp cho bảng `SoCt6`, kế thừa schema từ `SoCt6Model`.
 */
class SoCt6 extends SoCt6Model
{
    use HasSimbaCompositeKey;

}
