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

use Diepxuan\Simba\SModel\FaDmLkModel as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class FaDmLk.
 *
 * This class represents the model for fixed asset link/component master data.
 */
class FaDmLk extends Model
{
    /** Filter theo mã công ty */
    public function scopeFilterByMaCty(Builder $query, ?string $maCty): Builder
    {
        if (!empty($maCty)) {
            return $query->where('Ma_cty', $maCty);
        }

        return $query;
    }

    /** Filter theo mã tài sản */
    public function scopeFilterByMaTs(Builder $query, ?string $maTs): Builder
    {
        if (!empty($maTs)) {
            return $query->where('Ma_Ts', $maTs);
        }

        return $query;
    }

    /** Filter theo mã liên kết */
    public function scopeFilterByMaLk(Builder $query, ?string $maLk): Builder
    {
        if (!empty($maLk)) {
            return $query->where('Ma_Lk', $maLk);
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

    /** Relationship với tài sản cố định */
    public function faDmTs()
    {
        return $this->belongsTo(FaDmTs::class, 'Ma_Ts', 'Ma_Ts');
    }

    /**
     * Tính tổng giá trị liên kết theo tài sản
     */
    public static function getTotalValueByAsset(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('Ma_cty', $maCty);
        
        if ($fromDate || $toDate) {
            $query->whereHas('faDmTs', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('cdate', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('cdate', '<=', $toDate);
                }
            });
        }
        
        return $query->select('Ma_Ts', DB::raw('SUM(Gia_Tri) as tong_gia_tri'))
            ->groupBy('Ma_Ts')
            ->get();
    }

    /**
     * Gọi stored procedure asFaRptLK01 để lấy báo cáo liên kết tài sản
     */
    public static function getFaRptLK01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asFaRptLK01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pMa_Ts = :pMa_Ts,
            @pMa_Lk = :pMa_Lk
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pMa_Ts'    => $params['pMa_Ts'] ?? '',
            'pMa_Lk'    => $params['pMa_Lk'] ?? '',
        ]));
    }
}
