<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-06-21
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\sysDictionaryInfoModel as SModel;

/**
 * SimbaERP sysDictionaryInfo model.
 *
 * Source: simba-docs/tables/sysDictionaryInfo.md.
 *
 * Schema (table, primaryKey, keyType, fillable, casts, timestamps) is owned
 * by `sysDictionaryInfoModel`; this class only adds Simba-level helpers.
 */
class SysDictionaryInfo extends SModel
{
    /**
     * Lấy danh sách cột khóa chính từ cột PK (chuỗi phân tách bằng dấu phẩy).
     *
     * @return list<string>
     */
    public function primaryKeyFields(): array
    {
        return array_values(array_filter(array_map('trim', explode(',', (string) $this->PK))));
    }

    /**
     * Lấy danh sách cột carry từ cột carry_field_list.
     *
     * @return list<string>
     */
    public function carryFields(): array
    {
        return array_values(array_filter(array_map('trim', explode(',', (string) $this->carry_field_list))));
    }

    /**
     * Scope: tìm dictionary metadata theo code_name.
     *
     * @param  \Illuminate\Database\Eloquent\Builder  $query
     * @return \Illuminate\Database\Eloquent\Builder
     */
    public function scopeCodeName($query, string $codeName)
    {
        return $query->where('code_name', $codeName);
    }

    /**
     * Scope: tìm dictionary metadata theo menuid.
     *
     * @param  \Illuminate\Database\Eloquent\Builder  $query
     * @return \Illuminate\Database\Eloquent\Builder
     */
    public function scopeMenuId($query, string $menuId)
    {
        return $query->where('menuid', $menuId);
    }
}