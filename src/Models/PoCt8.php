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
use Diepxuan\Simba\SModel\PoCt8Model;

/**
 * Model PoCt8.
 *
 * Lớp Simba model trực tiếp cho bảng `PoCt8`, kế thừa schema từ `PoCt8Model`.
 */
class PoCt8 extends PoCt8Model
{
    use HasSimbaCompositeKey;

}
