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
use Diepxuan\Simba\SModel\GlBctcTmVI01Model;

/**
 * Model GlBctcTmVI01.
 *
 * Lớp Simba model trực tiếp cho bảng `GlBctcTmVI01`, kế thừa schema từ `GlBctcTmVI01Model`.
 */
class GlBctcTmVI01 extends GlBctcTmVI01Model
{
    use HasSimbaCompositeKey;

}
