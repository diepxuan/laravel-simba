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
use Diepxuan\Simba\SModel\sysUserGroupModel;

/**
 * Model sysUserGroup.
 *
 * Lớp Simba model trực tiếp cho bảng `sysUserGroup`, kế thừa schema từ `sysUserGroupModel`.
 */
class sysUserGroup extends sysUserGroupModel
{
    use HasSimbaCompositeKey;

}
