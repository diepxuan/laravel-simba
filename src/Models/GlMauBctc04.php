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
use Diepxuan\Simba\SModel\GlMauBctc04Model;

/**
 * Model GlMauBctc04.
 *
 * Lớp Simba model trực tiếp cho bảng `GlMauBctc04`, kế thừa schema từ `GlMauBctc04Model`.
 */
class GlMauBctc04 extends GlMauBctc04Model
{
    use HasSimbaCompositeKey;

}
