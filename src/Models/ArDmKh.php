<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-11 16:15:00
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\Models\Concerns\HasSimbaCompositeKey;
use Diepxuan\Simba\SModel\ArDmKhModel as Model;
use Diepxuan\Simba\StoredProcedures\AsGetSoDuKh;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Relations\HasMany;

/**
 * Model ArDmKh - Danh mục khách hàng.
 *
 * Mở rộng từ ArDmKhModel với:
 * - Global scope ksd.
 * - Scope search/order theo field Simba.
 * - Quan hệ glCts, stored procedure AsGetSoDuKh.
 *
 * Phân loại KH/NCC/NV đã được tách sang
 * `Diepxuan\Catalog\Models\ArDmKh` (dùng `HasArDmKhCategories`).
 */
class ArDmKh extends Model
{
    use HasSimbaCompositeKey;

    /**
     * Boot model và thêm global scopes.
     */
    protected static function booted(): void
    {
        parent::booted();

        // Global scope: mặc định chỉ lấy các bản ghi đang sử dụng (ksd = true)
        static::addGlobalScope('ksd', static function (Builder $query): void {
            $query->where('ksd', true);
        });
    }

    /**
     * Scope: Tìm kiếm theo mã khách hàng hoặc tên.
     */
    public function scopeSearch(Builder $query, string $search): Builder
    {
        return $query->where(static function (Builder $q) use ($search): void {
            $q->where('ma_kh', 'like', "%{$search}%")
                ->orWhere('ten_kh', 'like', "%{$search}%")
                ->orWhere('dia_chi', 'like', "%{$search}%")
                ->orWhere('tel', 'like', "%{$search}%");
        });
    }

    /**
     * Scope: Sắp xếp theo mã khách hàng.
     */
    public function scopeOrderByMaKh(Builder $query): Builder
    {
        return $query->orderBy('ma_kh');
    }

    /**
     * Quan hệ với GlCt (chi tiết sổ cái).
     */
    public function glCts(): HasMany
    {
        return $this->hasMany(GlCt::class, 'ma_kh', 'ma_kh');
    }

    /**
     * Gọi stored procedure AsGetSoDuKh để lấy số dư khách hàng.
     *
     * @param array $params Tham số: pMa_Cty, pMa_kh/pMa_Kh, pNgay, pTk
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
}
