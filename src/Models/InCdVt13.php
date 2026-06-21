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
use Diepxuan\Simba\SModel\InCdVt13Model;

/**
 * Model InCdVt13.
 *
 * Lớp Simba model trực tiếp cho bảng `InCdVt13`, kế thừa schema từ `InCdVt13Model`.
 */
class InCdVt13 extends InCdVt13Model
{
    use HasSimbaCompositeKey;

}
