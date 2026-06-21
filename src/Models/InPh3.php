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
use Diepxuan\Simba\SModel\InPh3Model;

/**
 * Model InPh3.
 *
 * Lớp Simba model trực tiếp cho bảng `InPH3`, kế thừa schema từ `InPh3Model`.
 */
class InPh3 extends InPh3Model
{
    use HasSimbaCompositeKey;

}
