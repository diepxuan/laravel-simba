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
use Diepxuan\Simba\SModel\GlMauBctcTmVI01Model;

/**
 * Model GlMauBctcTmVI01.
 *
 * Lớp Simba model trực tiếp cho bảng `GlMauBctcTmVI01`, kế thừa schema từ `GlMauBctcTmVI01Model`.
 */
class GlMauBctcTmVI01 extends GlMauBctcTmVI01Model
{
    use HasSimbaCompositeKey;

}
