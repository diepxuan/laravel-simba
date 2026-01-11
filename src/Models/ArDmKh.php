<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-01-11 23:01:59
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\ArDmKh as Model;
use Diepxuan\Simba\StoredProcedures\AsGetSoDuKh;
use Illuminate\Database\Eloquent\Relations\HasMany;
use Illuminate\Support\Collection;

class ArDmKh extends Model
{
    public function glCts(): HasMany
    {
        return $this->hasMany(GlCt::class, 'ma_kh', 'ma_kh');
    }

    /**
     * Gọi stored procedure asGetSoDuKh để lấy số dư khách hàng.
     *
     * @return array
     */
    public static function getGetSoDuKh(array $params): Collection
    {
        return AsGetSoDuKh::call([
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_kh'  => $params['pMa_kh'] ?? ($params['pMa_Kh'] ?? null),
            'pNgay'   => $params['pNgay'] ?? null,
            'pTk'     => $params['pTk'] ?? null,
        ]);
    }
}
