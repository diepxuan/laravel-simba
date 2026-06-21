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
use Diepxuan\Simba\SModel\GlBctcTmVI02cModel;

/**
 * Model GlBctcTmVI02c.
 *
 * Lớp Simba model trực tiếp cho bảng `GlBctcTmVI02c`, kế thừa schema từ `GlBctcTmVI02cModel`.
 */
class GlBctcTmVI02c extends GlBctcTmVI02cModel
{
    use HasSimbaCompositeKey;

}
