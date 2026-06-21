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
use Diepxuan\Simba\SModel\ArCt4Model;

/**
 * Model ArCt4.
 *
 * Lớp Simba model trực tiếp cho bảng `ArCt4`, kế thừa schema từ `ArCt4Model`.
 */
class ArCt4 extends ArCt4Model
{
    use HasSimbaCompositeKey;

}
