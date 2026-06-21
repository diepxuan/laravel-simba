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
use Diepxuan\Simba\SModel\zpmph2Model;

/**
 * Model zpmph2.
 *
 * Lớp Simba model trực tiếp cho bảng `zpmph2`, kế thừa schema từ `zpmph2Model`.
 */
class zpmph2 extends zpmph2Model
{
    use HasSimbaCompositeKey;

}
