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
use Diepxuan\Simba\SModel\GlBctcTmVI25bModel;

/**
 * Model GlBctcTmVI25b.
 *
 * Lớp Simba model trực tiếp cho bảng `GlBctcTmVI25b`, kế thừa schema từ `GlBctcTmVI25bModel`.
 */
class GlBctcTmVI25b extends GlBctcTmVI25bModel
{
    use HasSimbaCompositeKey;

}
