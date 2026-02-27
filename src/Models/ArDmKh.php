<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-27 15:03:13
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\ArDmKh as Model;
use Diepxuan\Simba\StoredProcedures\AsGetSoDuKh;
use Illuminate\Database\Eloquent\Relations\HasMany;

class ArDmKh extends Model
{
    protected $casts = [
        'isKh'  => 'boolean',
        'isNcc' => 'boolean',
        'isNv'  => 'boolean',
    ];

    public function glCts(): HasMany
    {
        return $this->hasMany(GlCt::class, 'ma_kh', 'ma_kh');
    }

    /**
     * Gọi stored procedure AsGetSoDuKh để lấy số dư khách hàng.
     */
    public static function AsGetSoDuKh(array $params): float
    {
        return AsGetSoDuKh::call([
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_kh'  => $params['pMa_kh'] ?? ($params['pMa_Kh'] ?? null),
            'pNgay'   => $params['pNgay'] ?? null,
            'pTk'     => $params['pTk'] ?? null,
        ]);
    }

    public function getIsKhachHangAttribute(): bool
    {
        return (bool) $this->isKh;
    }

    public function getIsNhaCungCapAttribute(): bool
    {
        return (bool) $this->isNcc;
    }

    public function getIsNhanVienAttribute(): bool
    {
        return (bool) $this->isNv;
    }
}
