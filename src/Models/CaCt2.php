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
use Diepxuan\Simba\SModel\CaCt2Model;

/**
 * Model CaCt2.
 *
 * Lớp Simba model trực tiếp cho bảng `CaCt2`, kế thừa schema từ `CaCt2Model`.
 */
class CaCt2 extends CaCt2Model
{
    use HasSimbaCompositeKey;

}
