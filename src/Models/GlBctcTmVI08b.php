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
use Diepxuan\Simba\SModel\GlBctcTmVI08bModel;

/**
 * Model GlBctcTmVI08b.
 *
 * Lớp Simba model trực tiếp cho bảng `GlBctcTmVI08b`, kế thừa schema từ `GlBctcTmVI08bModel`.
 */
class GlBctcTmVI08b extends GlBctcTmVI08bModel
{
    use HasSimbaCompositeKey;

}
