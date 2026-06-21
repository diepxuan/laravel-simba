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
use Diepxuan\Simba\SModel\InPh9Model;

/**
 * Model InPh9.
 *
 * Lớp Simba model trực tiếp cho bảng `InPh9`, kế thừa schema từ `InPh9Model`.
 */
class InPh9 extends InPh9Model
{
    use HasSimbaCompositeKey;

}
