<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-05 20:11:19
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\ArDmPlKhModel as BaseModel;

/**
 * Model ArDmPlKh - Danh mục phân loại khách hàng.
 *
 * Mở rộng từ ArDmPlKhModel với global scope ksd.
 */
class ArDmPlKh extends BaseModel
{
    /**
     * Scope: Lọc theo loại phân loại.
     *
     * @param mixed $query
     */
    public function scopeLoai($query, int $loai)
    {
        return $query->where('loai', $loai);
    }

    /**
     * Scope: Tìm kiếm theo mã hoặc tên.
     *
     * @param mixed $query
     */
    public function scopeSearch($query, string $search)
    {
        return $query->where(static function ($q) use ($search): void {
            $q->where('ma_plkh', 'like', "%{$search}%")
                ->orWhere('ten_plkh', 'like', "%{$search}%")
            ;
        });
    }

    /**
     * Scope: Sắp xếp theo mã phân loại.
     *
     * @param mixed $query
     */
    public function scopeOrderByMaPlkh($query)
    {
        return $query->orderBy('ma_plkh');
    }

    /**
     * Boot model và thêm global scopes.
     */
    protected static function booted(): void
    {
        parent::booted();

        static::addGlobalScope('ksd', static function ($query): void {
            $query->where('ksd', true);
        });
    }
}
