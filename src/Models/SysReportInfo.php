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
use Diepxuan\Simba\SModel\sysReportInfoModel as SModel;

/**
 * SimbaERP sysReportInfo model.
 *
 * Source: simba-docs/tables/sysReportInfo.md.
 *
 * Schema nằm trọn ở `sysReportInfoModel`. Model này chỉ bổ sung
 * `HasSimbaCompositeKey` để thao tác theo composite primary key
 * (menuid, ma_mau) an toàn.
 */
class SysReportInfo extends SModel
{
    use HasSimbaCompositeKey;
}