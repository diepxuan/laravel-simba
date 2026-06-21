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
use Diepxuan\Simba\SModel\GlMauBctc03Model;

/**
 * Model GlMauBctc03.
 *
 * Lớp Simba model trực tiếp cho bảng `GlMauBctc03`, kế thừa schema từ `GlMauBctc03Model`.
 */
class GlMauBctc03 extends GlMauBctc03Model
{
    use HasSimbaCompositeKey;

}
