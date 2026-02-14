<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2025-06-20 13:08:16
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\InDmKhoModel as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class InDmKho.
 *
 * This class represents the model for warehouse master data.
 */
class InDmKho extends Model
{
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
     * Tính tổng tồn kho theo vật tư
     */
    public function getInventoryByProduct(string $maVt, ?string $ngay = null): array
    {
        $params = [
            'pMa_Cty' => $this->ma_cty,
            'pMa_vt' => $maVt,
            'pMa_kho' => $this->ma_kho,
            'pNgay' => $ngay ?? date('Y-m-d'),
        ];

        $result = DB::connection($this->getConnectionName())->select('EXEC asINRptCD02
            @pMa_Cty = :pMa_Cty,
            @pMa_vt = :pMa_vt,
            @pMa_kho = :pMa_kho,
            @pNgay = :pNgay
        ', $params);

        return $result ? (array) $result[0] : [];
    }

    /**
     * Lấy danh sách vật tư tồn kho
     */
    public function getInventoryList(?string $maNhvt = null, ?string $ngay = null): Collection
    {
        $params = [
            'pMa_Cty' => $this->ma_cty,
            'pMa_kho' => $this->ma_kho,
            'pMa_nhvt' => $maNhvt ?? '',
            'pNgay' => $ngay ?? date('Y-m-d'),
        ];

        return collect(DB::connection($this->getConnectionName())->select('EXEC asINRptCD02
            @pMa_Cty = :pMa_Cty,
            @pMa_kho = :pMa_kho,
            @pMa_nhvt = :pMa_nhvt,
            @pNgay = :pNgay
        ', $params));
    }

    /**
     * Tính giá trị tồn kho
     */
    public function getInventoryValue(?string $ngay = null): float
    {
        $inventoryList = $this->getInventoryList(null, $ngay);
        
        $totalValue = 0;
        foreach ($inventoryList as $item) {
            $totalValue += ($item->sl_ton ?? 0) * ($item->gia_nt2 ?? 0);
        }
        
        return $totalValue;
    }

    /**
     * Gọi stored procedure asINGetDMKHO để lấy danh sách kho
     */
    public static function getAsINGetDMKHO(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asINGetDMKHO
            @pMa_Cty = :pMa_Cty,
            @pMa_kho = :pMa_kho,
            @pStruct = :pStruct,
            @pLanguage = :pLanguage
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pMa_kho'   => $params['pMa_kho'] ?? null,
            'pStruct'   => $params['pStruct'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? SysLanguage::DEFAULT,
        ]));
    }

    /**
     * Gọi stored procedure asINRptCD01 để lấy báo cáo tồn kho chi tiết
     */
    public static function getAsINRptCD01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asINRptCD01
            @pMa_Cty = :pMa_Cty,
            @pMa_kho = :pMa_kho,
            @pMa_vt = :pMa_vt,
            @pNgay = :pNgay,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty' => $params['pMa_Cty'] ?? '',
            'pMa_kho' => $params['pMa_kho'] ?? '',
            'pMa_vt'  => $params['pMa_vt'] ?? '',
            'pNgay'   => $params['pNgay'] ?? date('Y-m-d'),
            'pMa_Nt'  => $params['pMa_Nt'] ?? 'VND',
        ]));
    }
}
