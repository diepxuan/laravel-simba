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
use Diepxuan\Simba\SModel\GlMauBctcTmVI08bModel;

/**
 * Model GlMauBctcTmVI08b.
 *
 * Lớp Simba model trực tiếp cho bảng `GlMauBctcTmVI08b`, kế thừa schema từ `GlMauBctcTmVI08bModel`.
 */
class GlMauBctcTmVI08b extends GlMauBctcTmVI08bModel
{
    use HasSimbaCompositeKey;

}
