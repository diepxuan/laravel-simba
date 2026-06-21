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
use Diepxuan\Simba\SModel\CrPh1Model;

/**
 * Model CrPh1.
 *
 * Lớp Simba model trực tiếp cho bảng `CrPh1`, kế thừa schema từ `CrPh1Model`.
 */
class CrPh1 extends CrPh1Model
{
    use HasSimbaCompositeKey;

}
