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
     * Sử dụng class AsINRptCD02 thay vì gọi stored procedure trực tiếp
     */
    public function getInventoryByProduct(string $maVt, ?string $ngay = null): array
    {
        $params = [
            'pMa_Cty' => $this->ma_cty,
            'pMa_vt' => $maVt,
            'pMa_kho' => $this->ma_kho,
            'pNgay' => $ngay ?? date('Y-m-d'),
        ];

        $result = \Diepxuan\Simba\StoredProcedures\AsINRptCD02::call([
            'pMa_Cty' => $this->ma_cty,
            'pMa_vt' => $maVt,
            'pMa_kho' => $this->ma_kho,
            'pNgay' => $ngay ?? date('Y-m-d'),
            // Các tham số khác để null
            'pMa_vitri' => null,
            'pTk_vt' => null,
            'pMa_nhvt' => null,
            'pDVT' => null,
            'pNgoai_te' => null,
            'pDk_Ck' => null,
            'pMa_lo' => null,
            'pQuaToiThieu' => null,
            'pQuaToiDa' => null,
            'pSysMsg1' => null,
        ]);

        return $result->isNotEmpty() ? (array) $result->first() : [];
    }

    /**
     * Lấy danh sách vật tư tồn kho
     * Sử dụng class AsINRptCD02 thay vì gọi stored procedure trực tiếp
     */
    public function getInventoryList(?string $maNhvt = null, ?string $ngay = null): Collection
    {
        return \Diepxuan\Simba\StoredProcedures\AsINRptCD02::call([
            'pMa_Cty' => $this->ma_cty,
            'pMa_kho' => $this->ma_kho,
            'pMa_nhvt' => $maNhvt ?? '',
            'pNgay' => $ngay ?? date('Y-m-d'),
            // Các tham số khác để null
            'pMa_vt' => null,
            'pMa_vitri' => null,
            'pTk_vt' => null,
            'pDVT' => null,
            'pNgoai_te' => null,
            'pDk_Ck' => null,
            'pMa_lo' => null,
            'pQuaToiThieu' => null,
            'pQuaToiDa' => null,
            'pSysMsg1' => null,
        ]);
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
     * Sử dụng class AsINGetDMKHO thay vì gọi stored procedure trực tiếp
     */
    public static function getAsINGetDMKHO(array $params): Collection
    {
        // Sử dụng AsINGetDMKHO class để gọi stored procedure
        // Class sẽ xử lý đúng số lượng tham số (3 tham số thực tế)
        return \Diepxuan\Simba\StoredProcedures\AsINGetDMKHO::call([
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pMa_kho'   => $params['pMa_kho'] ?? null,
            'pStruct'   => $params['pStruct'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null, // Tham số này sẽ bị bỏ qua trong class
        ]);
    }

    /**
     * Gọi stored procedure asINRptCD01 để lấy báo cáo tồn kho chi tiết
     * Sử dụng class AsINRptCD01 thay vì gọi stored procedure trực tiếp
     */
    public static function getAsINRptCD01(array $params): Collection
    {
        // Sử dụng AsINRptCD01 class để gọi stored procedure
        // Map pMa_Nt to pNgoai_te (foreign currency)
        return \Diepxuan\Simba\StoredProcedures\AsINRptCD01::call([
            'pMa_Cty' => $params['pMa_Cty'] ?? '',
            'pMa_kho' => $params['pMa_kho'] ?? '',
            'pMa_vt'  => $params['pMa_vt'] ?? '',
            'pNgay1'  => $params['pNgay'] ?? date('Y-m-d'), // Map pNgay to pNgay1
            'pNgoai_te' => $params['pMa_Nt'] ?? 'VND', // Map pMa_Nt to pNgoai_te
            // Các tham số khác để null
            'pNgay2' => null,
            'pLoai_bc' => null,
            'pTk_vt' => null,
            'pMa_nhvt' => null,
            'pMa_vitri' => null,
            'pma_plvt1' => null,
            'pma_plvt2' => null,
            'pma_plvt3' => null,
            'pDVT' => null,
            'pPSDC' => null,
            'pSysMsg1' => null,
        ]);
    }
}
