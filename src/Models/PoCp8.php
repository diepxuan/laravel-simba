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
use Diepxuan\Simba\SModel\PoCp8Model;

/**
 * Model PoCp8.
 *
 * Lớp Simba model trực tiếp cho bảng `PoCp8`, kế thừa schema từ `PoCp8Model`.
 */
class PoCp8 extends PoCp8Model
{
    use HasSimbaCompositeKey;

}
