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
use Diepxuan\Simba\SModel\InPh5Model;

/**
 * Model InPh5.
 *
 * Lớp Simba model trực tiếp cho bảng `InPh5`, kế thừa schema từ `InPh5Model`.
 */
class InPh5 extends InPh5Model
{
    use HasSimbaCompositeKey;

}
