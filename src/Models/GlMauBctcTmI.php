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
use Diepxuan\Simba\SModel\GlMauBctcTmIModel;

/**
 * Model GlMauBctcTmI.
 *
 * Lớp Simba model trực tiếp cho bảng `GlMauBctcTmI`, kế thừa schema từ `GlMauBctcTmIModel`.
 */
class GlMauBctcTmI extends GlMauBctcTmIModel
{
    use HasSimbaCompositeKey;

}
