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

class Z_asCoUpdDmHsPb1
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asCoUpdDmHsPb1', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pThang'  => $params['pThang'] ?? null,
            'pNam'  => $params['pNam'] ?? null,
            'pMa_sp'  => $params['pMa_sp'] ?? null,
            'pTk'  => $params['pTk'] ?? null,
            'pTen_sp'  => $params['pTen_sp'] ?? null,
            'pHeso_621'  => $params['pHeso_621'] ?? null,
            'pHeso_622'  => $params['pHeso_622'] ?? null,
            'pHeso_td'  => $params['pHeso_td'] ?? null,
            'pThs_621'  => $params['pThs_621'] ?? null,
            'pThs_622'  => $params['pThs_622'] ?? null,
            'pThs_td'  => $params['pThs_td'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
