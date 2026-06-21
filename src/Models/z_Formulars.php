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
use Diepxuan\Simba\SModel\z_FormularsModel;

/**
 * Model z_Formulars.
 *
 * Lớp Simba model trực tiếp cho bảng `z_Formulars`, kế thừa schema từ `z_FormularsModel`.
 */
class z_Formulars extends z_FormularsModel
{
    use HasSimbaCompositeKey;

}
