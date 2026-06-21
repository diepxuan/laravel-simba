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
use Diepxuan\Simba\SModel\CaPh2Model;

/**
 * Model CaPh2.
 *
 * Lớp Simba model trực tiếp cho bảng `CaPh2`, kế thừa schema từ `CaPh2Model`.
 */
class CaPh2 extends CaPh2Model
{
    use HasSimbaCompositeKey;

}
