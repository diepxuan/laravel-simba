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
use Diepxuan\Simba\SModel\InCt3Model;

/**
 * Model InCt3.
 *
 * Lớp Simba model trực tiếp cho bảng `InCt3`, kế thừa schema từ `InCt3Model`.
 */
class InCt3 extends InCt3Model
{
    use HasSimbaCompositeKey;

}
