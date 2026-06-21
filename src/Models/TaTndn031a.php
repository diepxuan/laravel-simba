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
use Diepxuan\Simba\SModel\TaTndn031aModel;

/**
 * Model TaTndn031a.
 *
 * Lớp Simba model trực tiếp cho bảng `TaTndn031a`, kế thừa schema từ `TaTndn031aModel`.
 */
class TaTndn031a extends TaTndn031aModel
{
    use HasSimbaCompositeKey;

}
