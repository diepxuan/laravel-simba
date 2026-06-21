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
use Diepxuan\Simba\SModel\ArCdKh13Model;

/**
 * Model ArCdKh13.
 *
 * Lớp Simba model trực tiếp cho bảng `ArCdKh13`, kế thừa schema từ `ArCdKh13Model`.
 */
class ArCdKh13 extends ArCdKh13Model
{
    use HasSimbaCompositeKey;

}
