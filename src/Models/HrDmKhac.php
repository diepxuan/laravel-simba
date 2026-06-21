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
use Diepxuan\Simba\SModel\HrDmKhacModel;

/**
 * Model HrDmKhac.
 *
 * Lớp Simba model trực tiếp cho bảng `HrDmKhac`, kế thừa schema từ `HrDmKhacModel`.
 */
class HrDmKhac extends HrDmKhacModel
{
    use HasSimbaCompositeKey;

}
