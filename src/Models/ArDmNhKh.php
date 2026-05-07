<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-05 20:11:18
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\ArDmNhKhModel as BaseModel;

/**
 * Model ArDmNhKh - Danh mục nhóm khách hàng.
 *
 * Mở rộng từ ArDmNhKhModel với global scope ksd.
 */
class ArDmNhKh extends BaseModel
{
    /**
     * Scope: Tìm kiếm theo mã hoặc tên nhóm.
     *
     * @param mixed $query
     */
    public function scopeSearch($query, string $search)
    {
        return $query->where(static function ($q) use ($search): void {
            $q->where('ma_nhkh', 'like', "%{$search}%")
                ->orWhere('ten_nhkh', 'like', "%{$search}%")
            ;
        });
    }

    /**
     * Scope: Sắp xếp theo mã nhóm.
     *
     * @param mixed $query
     */
    public function scopeOrderByMaNhkh($query)
    {
        return $query->orderBy('ma_nhkh');
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
