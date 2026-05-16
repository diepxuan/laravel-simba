<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-16 00:28:19
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\PoPh2Model as Model;
use Diepxuan\Simba\Traits\HasPoVoucherFilters;

class PoPh2 extends Model
{
    use HasPoVoucherFilters;
}
