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
use Diepxuan\Simba\SModel\ArPh4Model;

/**
 * Model ArPh4.
 *
 * Lớp Simba model trực tiếp cho bảng `ArPh4`, kế thừa schema từ `ArPh4Model`.
 */
class ArPh4 extends ArPh4Model
{
    use HasSimbaCompositeKey;

}
