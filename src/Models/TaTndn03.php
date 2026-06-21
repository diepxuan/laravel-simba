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
use Diepxuan\Simba\SModel\TaTndn03Model;

/**
 * Model TaTndn03.
 *
 * Lớp Simba model trực tiếp cho bảng `TaTndn03`, kế thừa schema từ `TaTndn03Model`.
 */
class TaTndn03 extends TaTndn03Model
{
    use HasSimbaCompositeKey;

}
