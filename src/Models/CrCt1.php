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
use Diepxuan\Simba\SModel\CrCt1Model;

/**
 * Model CrCt1.
 *
 * Lớp Simba model trực tiếp cho bảng `CrCt1`, kế thừa schema từ `CrCt1Model`.
 */
class CrCt1 extends CrCt1Model
{
    use HasSimbaCompositeKey;

}
