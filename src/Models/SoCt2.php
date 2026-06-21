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
use Diepxuan\Simba\SModel\SoCt2Model;

/**
 * Model SoCt2.
 *
 * Lớp Simba model trực tiếp cho bảng `SoCt2`, kế thừa schema từ `SoCt2Model`.
 */
class SoCt2 extends SoCt2Model
{
    use HasSimbaCompositeKey;

}
