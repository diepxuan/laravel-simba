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
use Diepxuan\Simba\SModel\ArCt3Model;

/**
 * Model ArCt3.
 *
 * Lớp Simba model trực tiếp cho bảng `ArCt3`, kế thừa schema từ `ArCt3Model`.
 */
class ArCt3 extends ArCt3Model
{
    use HasSimbaCompositeKey;

}
