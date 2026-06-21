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
use Diepxuan\Simba\SModel\ApCt4Model;

/**
 * Model ApCt4.
 *
 * Lớp Simba model trực tiếp cho bảng `ApCt4`, kế thừa schema từ `ApCt4Model`.
 */
class ApCt4 extends ApCt4Model
{
    use HasSimbaCompositeKey;

}
