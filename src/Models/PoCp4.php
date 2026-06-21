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
use Diepxuan\Simba\SModel\PoCp4Model;

/**
 * Model PoCp4.
 *
 * Lớp Simba model trực tiếp cho bảng `PoCp4`, kế thừa schema từ `PoCp4Model`.
 */
class PoCp4 extends PoCp4Model
{
    use HasSimbaCompositeKey;

}
