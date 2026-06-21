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
use Diepxuan\Simba\SModel\MmPh3Model;

/**
 * Model MmPh3.
 *
 * Lớp Simba model trực tiếp cho bảng `MmPh3`, kế thừa schema từ `MmPh3Model`.
 */
class MmPh3 extends MmPh3Model
{
    use HasSimbaCompositeKey;

}
