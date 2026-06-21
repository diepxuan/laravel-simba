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
use Diepxuan\Simba\SModel\InCt2Model;

/**
 * Model InCt2.
 *
 * Lớp Simba model trực tiếp cho bảng `InCt2`, kế thừa schema từ `InCt2Model`.
 */
class InCt2 extends InCt2Model
{
    use HasSimbaCompositeKey;

}
