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

use Diepxuan\Simba\Models\Concerns\HasSimbaCompositeKey;
use Diepxuan\Simba\SModel\SiDmCtModel as SModel;

/**
 * Model SiDmCt - Khai báo màn hình nhập chứng từ.
 *
 * Source: simba-docs/tables/SiDmCt.md.
 *
 * Schema nằm trọn ở `SiDmCtModel`. Model này chỉ giữ behavior Simba-level
 * và `HasSimbaCompositeKey` để thao tác theo composite primary key
 * (ma_cty, ma_ct) an toàn.
 */
class SiDmCt extends SModel
{
    use HasSimbaCompositeKey;

    /**
     * Scope: tìm voucher metadata theo mã công ty + mã chứng từ.
     *
     * @param  \Illuminate\Database\Eloquent\Builder  $query
     * @return \Illuminate\Database\Eloquent\Builder
     */
    public function scopeVoucher($query, string $maCt, string $maCty = SModel::CTY)
    {
        return $query->where('ma_cty', $maCty)->where('ma_ct', $maCt);
    }

    /**
     * Scope: tìm voucher metadata theo menuid.
     *
     * @param  \Illuminate\Database\Eloquent\Builder  $query
     * @return \Illuminate\Database\Eloquent\Builder
     */
    public function scopeMenuId($query, string $menuId)
    {
        return $query->where('menuid', $menuId);
    }

    /**
     * Lấy danh sách cột header cho nhập kho từ cột PhFieldlist2IN.
     *
     * @return list<string>
     */
    public function headerFieldsForInventory(): array
    {
        return array_values(array_filter(array_map('trim', explode(',', (string) $this->PhFieldlist2IN))));
    }

    /**
     * Lấy danh sách cột detail cho nhập kho từ cột CtFieldlist2IN.
     *
     * @return list<string>
     */
    public function detailFieldsForInventory(): array
    {
        return array_values(array_filter(array_map('trim', explode(',', (string) $this->CtFieldlist2IN))));
    }
}