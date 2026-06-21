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
use Diepxuan\Simba\SModel\ApPh4Model;

/**
 * Model ApPh4.
 *
 * Lớp Simba model trực tiếp cho bảng `ApPh4`, kế thừa schema từ `ApPh4Model`.
 */
class ApPh4 extends ApPh4Model
{
    use HasSimbaCompositeKey;

}
