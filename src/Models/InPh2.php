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
use Diepxuan\Simba\SModel\InPh2Model;

/**
 * Model InPh2.
 *
 * Lớp Simba model trực tiếp cho bảng `InPh2`, kế thừa schema từ `InPh2Model`.
 */
class InPh2 extends InPh2Model
{
    use HasSimbaCompositeKey;

}
