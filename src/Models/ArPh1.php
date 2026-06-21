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
use Diepxuan\Simba\SModel\ArPh1Model;

/**
 * Model ArPh1.
 *
 * Lớp Simba model trực tiếp cho bảng `ArPh1`, kế thừa schema từ `ArPh1Model`.
 */
class ArPh1 extends ArPh1Model
{
    use HasSimbaCompositeKey;

}
