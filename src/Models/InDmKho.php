<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-06-22
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\Models\Concerns\HasSimbaCompositeKey;
use Diepxuan\Simba\SModel\InDmKhoModel as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;

/**
 * Class InDmKho.
 *
 * This class represents the model for warehouse master data.
 *
 * Behavior nghiệp vụ (tồn kho theo vật tư / giá trị tồn kho) đã được tách
 * sang `Diepxuan\Catalog\Models\Concerns\HasInDmKhoInventoryOperations`
 * và gắn vào `Diepxuan\Catalog\Models\Simba\InDmKho`.
 *
 * Còn giữ ở đây:
 * - Global scope filter (ma_cty, ma_kho, ten_kho, kho_dl, ksd).
 * - Scope `active`, `isAgency`.
 * - Quan hệ Simba-Simba: glDmTk, inDmViTri, inCtNhap, inCtXuat.
 * - Stored procedure wrapper: getAsINRptCD01.
 */
class InDmKho extends Model
{
    use HasSimbaCompositeKey;

    /** Filter theo mã công ty */
    public function scopeFilterByMaCty(Builder $query, ?string $maCty): Builder
    {
        if (!empty($maCty)) {
            return $query->where('ma_cty', $maCty);
        }

        return $query;
    }

    /** Filter theo mã kho */
    public function scopeFilterByMaKho(Builder $query, ?string $maKho): Builder
    {
        if (!empty($maKho)) {
            return $query->where('ma_kho', 'like', "%{$maKho}%");
        }

        return $query;
    }

    /** Filter theo tên kho */
    public function scopeFilterByTenKho(Builder $query, ?string $tenKho): Builder
    {
        if (!empty($tenKho)) {
            return $query->where('ten_kho', 'like', "%{$tenKho}%");
        }

        return $query;
    }

    /** Filter theo kho đại lý */
    public function scopeFilterByKhoDl(Builder $query, ?bool $khoDl): Builder
    {
        if ($khoDl !== null) {
            return $query->where('kho_dl', $khoDl);
        }

        return $query;
    }

    /** Filter theo trạng thái sử dụng */
    public function scopeFilterByKsd(Builder $query, ?bool $ksd): Builder
    {
        if ($ksd !== null) {
            return $query->where('ksd', $ksd);
        }

        return $query;
    }

    /** Scope chỉ lấy kho đang hoạt động */
    public function scopeActive(Builder $query): Builder
    {
        return $query->where('ksd', false);
    }

    /** Scope chỉ lấy kho đại lý */
    public function scopeIsAgency(Builder $query): Builder
    {
        return $query->where('kho_dl', true);
    }

    /** Relationship với tài khoản đại lý */
    public function glDmTk()
    {
        return $this->belongsTo(GlDmTk::class, 'tk_dl', 'tk');
    }

    /** Relationship với các vị trí trong kho */
    public function inDmViTri()
    {
        return $this->hasMany(InDmViTri::class, 'ma_kho', 'ma_kho');
    }

    /** Relationship với các chứng từ nhập kho */
    public function inCtNhap()
    {
        return $this->hasMany(InCt::class, 'ma_kho_nhap', 'ma_kho');
    }

    /** Relationship với các chứng từ xuất kho */
    public function inCtXuat()
    {
        return $this->hasMany(InCt::class, 'ma_kho_xuat', 'ma_kho');
    }

    /**
     * Gọi stored procedure asINRptCD01 để lấy báo cáo tồn kho chi tiết.
     */
    public static function getAsINRptCD01(array $params): Collection
    {
        return \Diepxuan\Simba\StoredProcedures\AsINRptCD01::call([
            'pMa_Cty'    => $params['pMa_Cty'] ?? '',
            'pMa_kho'    => $params['pMa_kho'] ?? '',
            'pMa_vt'     => $params['pMa_vt'] ?? '',
            'pNgay1'     => $params['pNgay'] ?? date('Y-m-d'),
            'pNgoai_te'  => $params['pMa_Nt'] ?? 'VND',
            'pNgay2'     => null,
            'pLoai_bc'   => null,
            'pTk_vt'     => null,
            'pMa_nhvt'   => null,
            'pMa_vitri'  => null,
            'pma_plvt1'  => null,
            'pma_plvt2'  => null,
            'pma_plvt3'  => null,
            'pDVT'       => null,
            'pPSDC'      => null,
            'pSysMsg1'   => null,
        ]);
    }
}
