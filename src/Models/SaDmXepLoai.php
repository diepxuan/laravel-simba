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
use Diepxuan\Simba\SModel\SaDmXepLoaiModel;

/**
 * Model SaDmXepLoai.
 *
 * Lớp Simba model trực tiếp cho bảng `SaDmXepLoai`, kế thừa schema từ `SaDmXepLoaiModel`.
 */
class SaDmXepLoai extends SaDmXepLoaiModel
{
    use HasSimbaCompositeKey;

}
