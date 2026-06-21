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
use Diepxuan\Simba\SModel\ApPh3Model;

/**
 * Model ApPh3.
 *
 * Lớp Simba model trực tiếp cho bảng `ApPh3`, kế thừa schema từ `ApPh3Model`.
 */
class ApPh3 extends ApPh3Model
{
    use HasSimbaCompositeKey;

}
