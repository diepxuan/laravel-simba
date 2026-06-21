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
use Diepxuan\Simba\SModel\CaPh1Model;

/**
 * Model CaPh1.
 *
 * Lớp Simba model trực tiếp cho bảng `CaPh1`, kế thừa schema từ `CaPh1Model`.
 */
class CaPh1 extends CaPh1Model
{
    use HasSimbaCompositeKey;

}
