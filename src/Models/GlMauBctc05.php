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
use Diepxuan\Simba\SModel\GlMauBctc05Model;

/**
 * Model GlMauBctc05.
 *
 * Lớp Simba model trực tiếp cho bảng `GlMauBctc05`, kế thừa schema từ `GlMauBctc05Model`.
 */
class GlMauBctc05 extends GlMauBctc05Model
{
    use HasSimbaCompositeKey;

}
