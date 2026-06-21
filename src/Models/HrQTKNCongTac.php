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
use Diepxuan\Simba\SModel\HrQTKNCongTacModel;

/**
 * Model HrQTKNCongTac.
 *
 * Lớp Simba model trực tiếp cho bảng `HrQTKNCongTac`, kế thừa schema từ `HrQTKNCongTacModel`.
 */
class HrQTKNCongTac extends HrQTKNCongTacModel
{
    use HasSimbaCompositeKey;

}
