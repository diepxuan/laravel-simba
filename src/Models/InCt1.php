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
use Diepxuan\Simba\SModel\InCt1Model;

/**
 * Model InCt1.
 *
 * Lớp Simba model trực tiếp cho bảng `InCt1`, kế thừa schema từ `InCt1Model`.
 */
class InCt1 extends InCt1Model
{
    use HasSimbaCompositeKey;

}
