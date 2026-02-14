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

use Diepxuan\Simba\SModel\CaCt1Model as Model;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class CaCt1.
 *
 * This class represents the model for cash transaction details.
 */
class CaCt1 extends Model
{
    /** Filter theo mã công ty */
    public function scopeFilterByMaCty(Builder $query, ?string $maCty): Builder
    {
        if (!empty($maCty)) {
            return $query->where('ma_cty', $maCty);
        }

        return $query;
    }

    /** Filter theo tài khoản */
    public function scopeFilterByTk(Builder $query, ?string $tk): Builder
    {
        if (!empty($tk)) {
            return $query->where('tk', $tk);
        }

        return $query;
    }

    /** Filter theo danh sách tài khoản */
    public function scopeFilterByTkList(Builder $query, ?string $list): Builder
    {
        return $query->filterLikeList('tk', $list);
    }

    /** Filter theo mã khách hàng */
    public function scopeFilterByMaKh(Builder $query, ?string $maKh): Builder
    {
        if (!empty($maKh)) {
            return $query->where('ma_kh', $maKh);
        }

        return $query;
    }

    /** Filter theo mã bộ phận */
    public function scopeFilterByMaBp(Builder $query, ?string $maBp): Builder
    {
        if (!empty($maBp)) {
            return $query->where('ma_bp', $maBp);
        }

        return $query;
    }

    /** Filter theo ngày chứng từ thông qua phiếu tổng hợp */
    public function scopeFilterByNgayCt(Builder $query, ?string $fromDate, ?string $toDate): Builder
    {
        if (!empty($fromDate)) {
            $query->whereHas('caPh3', function ($q) use ($fromDate) {
                $q->whereDate('ngay_ct', '>=', $fromDate);
            });
        }
        if (!empty($toDate)) {
            $query->whereHas('caPh3', function ($q) use ($toDate) {
                $q->whereDate('ngay_ct', '<=', $toDate);
            });
        }

        return $query;
    }

    /** Relationship với phiếu tổng hợp */
    public function caPh3()
    {
        return $this->belongsTo(CaPh3::class, 'stt_rec', 'stt_rec');
    }

    /** Relationship với tài khoản */
    public function glDmTk()
    {
        return $this->belongsTo(GlDmTk::class, 'tk', 'tk');
    }

    /** Relationship với khách hàng */
    public function arDmKh()
    {
        return $this->belongsTo(ArDmKh::class, 'ma_kh', 'ma_kh');
    }

    /** Relationship với bộ phận */
    public function sysDepartment()
    {
        return $this->belongsTo(SysDepartment::class, 'ma_bp', 'ma_bp');
    }

    /**
     * Tính tổng thu tiền mặt theo tài khoản
     */
    public static function getTotalCashReceiptByAccount(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty)
            ->where('ps_co', '>', 0);
        
        if ($fromDate || $toDate) {
            $query->whereHas('caPh3', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('ngay_ct', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('ngay_ct', '<=', $toDate);
                }
            });
        }
        
        return $query->select('tk', DB::raw('SUM(ps_co) as tong_thu'), DB::raw('SUM(ps_co_nt) as tong_thu_nt'))
            ->groupBy('tk')
            ->get();
    }

    /**
     * Tính tổng chi tiền mặt theo tài khoản
     */
    public static function getTotalCashPaymentByAccount(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty)
            ->where('ps_no', '>', 0);
        
        if ($fromDate || $toDate) {
            $query->whereHas('caPh3', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('ngay_ct', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('ngay_ct', '<=', $toDate);
                }
            });
        }
        
        return $query->select('tk', DB::raw('SUM(ps_no) as tong_chi'), DB::raw('SUM(ps_no_nt) as tong_chi_nt'))
            ->groupBy('tk')
            ->get();
    }

    /**
     * Tính tổng thu tiền mặt theo khách hàng
     */
    public static function getTotalCashReceiptByCustomer(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty)
            ->where('ps_co', '>', 0)
            ->whereNotNull('ma_kh');
        
        if ($fromDate || $toDate) {
            $query->whereHas('caPh3', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('ngay_ct', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('ngay_ct', '<=', $toDate);
                }
            });
        }
        
        return $query->select('ma_kh', DB::raw('SUM(ps_co) as tong_thu'), DB::raw('SUM(ps_co_nt) as tong_thu_nt'))
            ->groupBy('ma_kh')
            ->get();
    }

    /**
     * Tính tổng chi tiền mặt theo nhà cung cấp
     */
    public static function getTotalCashPaymentBySupplier(string $maCty, ?string $fromDate = null, ?string $toDate = null): Collection
    {
        $query = self::where('ma_cty', $maCty)
            ->where('ps_no', '>', 0)
            ->whereNotNull('ma_kh');
        
        if ($fromDate || $toDate) {
            $query->whereHas('caPh3', function ($q) use ($fromDate, $toDate) {
                if ($fromDate) {
                    $q->whereDate('ngay_ct', '>=', $fromDate);
                }
                if ($toDate) {
                    $q->whereDate('ngay_ct', '<=', $toDate);
                }
            });
        }
        
        return $query->select('ma_kh', DB::raw('SUM(ps_no) as tong_chi'), DB::raw('SUM(ps_no_nt) as tong_chi_nt'))
            ->groupBy('ma_kh')
            ->get();
    }

    /**
     * Tính số dư tiền mặt theo tài khoản
     */
    public static function getCashBalanceByAccount(string $maCty, string $tk, ?string $toDate = null): array
    {
        $query = self::where('ma_cty', $maCty)
            ->where('tk', $tk);
        
        if ($toDate) {
            $query->whereHas('caPh3', function ($q) use ($toDate) {
                $q->whereDate('ngay_ct', '<=', $toDate);
            });
        }
        
        $result = $query->select(
            DB::raw('SUM(ps_no) as tong_chi'),
            DB::raw('SUM(ps_co) as tong_thu'),
            DB::raw('SUM(ps_no_nt) as tong_chi_nt'),
            DB::raw('SUM(ps_co_nt) as tong_thu_nt')
        )->first();
        
        return [
            'so_du' => ($result->tong_thu ?? 0) - ($result->tong_chi ?? 0),
            'so_du_nt' => ($result->tong_thu_nt ?? 0) - ($result->tong_chi_nt ?? 0),
        ];
    }

    /**
     * Gọi stored procedure asCARptTM01 để lấy báo cáo tiền mặt
     */
    public static function getCARptTM01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asCARptTM01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pTk = :pTk,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pTk'       => $params['pTk'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asCARptNH01 để lấy báo cáo ngân hàng
     */
    public static function getCARptNH01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asCARptNH01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pTk = :pTk,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pTk'       => $params['pTk'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }

    /**
     * Gọi stored procedure asCARptTMNH01 để lấy báo cáo tiền mặt ngân hàng
     */
    public static function getCARptTMNH01(array $params): Collection
    {
        return collect(DB::connection((new static())->getConnectionName())->select('EXEC asCARptTMNH01
            @pMa_Cty = :pMa_Cty,
            @pNgay_Ct1 = :pNgay_Ct1,
            @pNgay_Ct2 = :pNgay_Ct2,
            @pTk = :pTk,
            @pMa_Nt = :pMa_Nt
        ', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? '',
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? '2025-01-01',
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? now(),
            'pTk'       => $params['pTk'] ?? '',
            'pMa_Nt'    => $params['pMa_Nt'] ?? 'VND',
        ]));
    }
}
