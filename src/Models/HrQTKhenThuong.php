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
use Diepxuan\Simba\SModel\HrQTKhenThuongModel;

/**
 * Model HrQTKhenThuong.
 *
 * Lớp Simba model trực tiếp cho bảng `HrQTKhenThuong`, kế thừa schema từ `HrQTKhenThuongModel`.
 */
class HrQTKhenThuong extends HrQTKhenThuongModel
{
    use HasSimbaCompositeKey;

}
