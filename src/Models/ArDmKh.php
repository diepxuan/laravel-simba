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

use Diepxuan\Simba\SModel\ArDmKhModel as Model;
use Diepxuan\Simba\StoredProcedures\AsGetSoDuKh;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Relations\HasMany;

/**
 * Model ArDmKh - Danh mục khách hàng.
 *
 * Mở rộng từ ArDmKhModel với các scope và helper methods.
 */
class ArDmKh extends Model
{
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
     * Scope: Chỉ lấy khách hàng (isKh = true).
     */
    public function scopeLaKhachHang(Builder $query): Builder
    {
        return $query->where('isKh', true);
    }

    /**
     * Scope: Chỉ lấy nhà cung cấp (isNcc = true).
     */
    public function scopeLaNhaCungCap(Builder $query): Builder
    {
        return $query->where('isNcc', true);
    }

    /**
     * Scope: Chỉ lấy nhân viên (isNv = true).
     */
    public function scopeLaNhanVien(Builder $query): Builder
    {
        return $query->where('isNv', true);
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

    /**
     * Accessor: Kiểm tra có phải khách hàng không.
     */
    public function getIsKhachHangAttribute(): bool
    {
        return (bool) $this->isKh;
    }

    /**
     * Accessor: Kiểm tra có phải nhà cung cấp không.
     */
    public function getIsNhaCungCapAttribute(): bool
    {
        return (bool) $this->isNcc;
    }

    /**
     * Accessor: Kiểm tra có phải nhân viên không.
     */
    public function getIsNhanVienAttribute(): bool
    {
        return (bool) $this->isNv;
    }
}
