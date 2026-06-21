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
use Diepxuan\Simba\SModel\GlMauBctcTmVI10Model;

/**
 * Model GlMauBctcTmVI10.
 *
 * Lớp Simba model trực tiếp cho bảng `GlMauBctcTmVI10`, kế thừa schema từ `GlMauBctcTmVI10Model`.
 */
class GlMauBctcTmVI10 extends GlMauBctcTmVI10Model
{
    use HasSimbaCompositeKey;

}
