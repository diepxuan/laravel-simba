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
use Diepxuan\Simba\SModel\GlMauBctcTmVIIIModel;

/**
 * Model GlMauBctcTmVIII.
 *
 * Lớp Simba model trực tiếp cho bảng `GlMauBctcTmVIII`, kế thừa schema từ `GlMauBctcTmVIIIModel`.
 */
class GlMauBctcTmVIII extends GlMauBctcTmVIIIModel
{
    use HasSimbaCompositeKey;

}
