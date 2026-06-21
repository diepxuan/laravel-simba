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
use Diepxuan\Simba\SModel\MmDmLoModel;

/**
 * Model MmDmLo.
 *
 * Lớp Simba model trực tiếp cho bảng `MmDmLo`, kế thừa schema từ `MmDmLoModel`.
 */
class MmDmLo extends MmDmLoModel
{
    use HasSimbaCompositeKey;

}
