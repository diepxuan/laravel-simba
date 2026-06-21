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
use Diepxuan\Simba\SModel\z_codmbomModel;

/**
 * Model z_codmbom.
 *
 * Lớp Simba model trực tiếp cho bảng `z_codmbom`, kế thừa schema từ `z_codmbomModel`.
 */
class z_codmbom extends z_codmbomModel
{
    use HasSimbaCompositeKey;

}
