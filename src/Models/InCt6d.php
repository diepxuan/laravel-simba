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
use Diepxuan\Simba\SModel\InCt6dModel;

/**
 * Model InCt6d.
 *
 * Lớp Simba model trực tiếp cho bảng `InCt6d`, kế thừa schema từ `InCt6dModel`.
 */
class InCt6d extends InCt6dModel
{
    use HasSimbaCompositeKey;

}
