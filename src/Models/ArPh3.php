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
use Diepxuan\Simba\SModel\ArPh3Model;

/**
 * Model ArPh3.
 *
 * Lớp Simba model trực tiếp cho bảng `ArPh3`, kế thừa schema từ `ArPh3Model`.
 */
class ArPh3 extends ArPh3Model
{
    use HasSimbaCompositeKey;

}
