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
use Diepxuan\Simba\SModel\ApPh1Model;

/**
 * Model ApPh1.
 *
 * Lớp Simba model trực tiếp cho bảng `ApPh1`, kế thừa schema từ `ApPh1Model`.
 */
class ApPh1 extends ApPh1Model
{
    use HasSimbaCompositeKey;

}
