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
use Diepxuan\Simba\SModel\sysReportDrillDownInfoModel as SModel;

/**
 * SimbaERP sysReportDrillDownInfo model.
 *
 * Source: simba-docs/tables/sysReportDrillDownInfo.md.
 *
 * Schema nằm trọn ở `sysReportDrillDownInfoModel`. Model này chỉ bổ sung
 * `HasSimbaCompositeKey` để thao tác theo composite primary key
 * (menuid, ma_mau, press_key_name) an toàn.
 */
class SysReportDrillDownInfo extends SModel
{
    use HasSimbaCompositeKey;
}