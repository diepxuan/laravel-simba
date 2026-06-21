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
use Diepxuan\Simba\SModel\InPh1Model;

/**
 * Model InPh1.
 *
 * Lớp Simba model trực tiếp cho bảng `InPh1`, kế thừa schema từ `InPh1Model`.
 */
class InPh1 extends InPh1Model
{
    use HasSimbaCompositeKey;

}
