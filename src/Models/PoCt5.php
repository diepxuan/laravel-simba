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
use Diepxuan\Simba\SModel\PoCt5Model;

/**
 * Model PoCt5.
 *
 * Lớp Simba model trực tiếp cho bảng `PoCt5`, kế thừa schema từ `PoCt5Model`.
 */
class PoCt5 extends PoCt5Model
{
    use HasSimbaCompositeKey;

}
