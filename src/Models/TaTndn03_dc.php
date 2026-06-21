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
use Diepxuan\Simba\SModel\TaTndn03_dcModel;

/**
 * Model TaTndn03_dc.
 *
 * Lớp Simba model trực tiếp cho bảng `TaTndn03_dc`, kế thừa schema từ `TaTndn03_dcModel`.
 */
class TaTndn03_dc extends TaTndn03_dcModel
{
    use HasSimbaCompositeKey;

}
