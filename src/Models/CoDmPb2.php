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
use Diepxuan\Simba\SModel\CoDmPb2Model;

/**
 * Model CoDmPb2.
 *
 * Lớp Simba model trực tiếp cho bảng `CoDmPb2`, kế thừa schema từ `CoDmPb2Model`.
 */
class CoDmPb2 extends CoDmPb2Model
{
    use HasSimbaCompositeKey;

}
