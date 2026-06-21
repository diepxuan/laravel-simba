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
use Diepxuan\Simba\SModel\GlBctcTmVI02bModel;

/**
 * Model GlBctcTmVI02b.
 *
 * Lớp Simba model trực tiếp cho bảng `GlBctcTmVI02b`, kế thừa schema từ `GlBctcTmVI02bModel`.
 */
class GlBctcTmVI02b extends GlBctcTmVI02bModel
{
    use HasSimbaCompositeKey;

}
