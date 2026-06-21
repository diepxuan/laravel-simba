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
use Diepxuan\Simba\SModel\InPh6Model;

/**
 * Model InPh6.
 *
 * Lớp Simba model trực tiếp cho bảng `InPh6`, kế thừa schema từ `InPh6Model`.
 */
class InPh6 extends InPh6Model
{
    use HasSimbaCompositeKey;

}
