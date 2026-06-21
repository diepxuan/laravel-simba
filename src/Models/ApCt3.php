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
use Diepxuan\Simba\SModel\ApCt3Model;

/**
 * Model ApCt3.
 *
 * Lớp Simba model trực tiếp cho bảng `ApCt3`, kế thừa schema từ `ApCt3Model`.
 */
class ApCt3 extends ApCt3Model
{
    use HasSimbaCompositeKey;

}
