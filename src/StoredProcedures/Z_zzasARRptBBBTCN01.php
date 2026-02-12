<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:32:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_zzasARRptBBBTCN01
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_zzasARRptBBBTCN01', [
            'ma_cty'  => $params['ma_cty'] ?? null,
            'Ngay1'  => $params['Ngay1'] ?? null,
            'Ngay2'  => $params['Ngay2'] ?? null,
            'Tk'  => $params['Tk'] ?? null,
            'ma_kh'  => $params['ma_kh'] ?? null,
            'ma_nt'  => $params['ma_nt'] ?? null,
        ], $connection);
    }
}
