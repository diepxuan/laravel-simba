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
use Diepxuan\Simba\SModel\PoCp2Model;

/**
 * Model PoCp2.
 *
 * Lớp Simba model trực tiếp cho bảng `PoCp2`, kế thừa schema từ `PoCp2Model`.
 */
class PoCp2 extends PoCp2Model
{
    use HasSimbaCompositeKey;

}
