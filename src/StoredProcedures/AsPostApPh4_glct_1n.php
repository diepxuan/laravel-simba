<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 12:14:36
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPostApPh4Glct1n.
 *
 * Stored procedure: asPostApPh4_glct_1n
 * Mục đích: Post phiếu kế toán (ApPh4) cho một nhóm điều khoản (nh_dk) cụ thể, trường hợp "1 nợ nhiều có" – tức là có một dòng chi tiết có ps_no <> 0 (bên Nợ) và nhiều dòng có ps_co <> 0 (bên Có).
 * Procedure thực hiện các bước:
 * 1. Lấy ngày chứng từ (ngay_ct) từ ApPh4, năm tài chính (NamTC) và tháng tài chính (ThangTC) thông qua hàm afNamTC, afThangTC.
 * 2. Lấy mã ngoại tệ gốc (ma_nt0) và ngày khóa sổ (ngay_ks) từ siSetup.
 * 3. Kiểm tra nếu ngày chứng từ <= ngày khóa sổ thì return (không post).
 * 4. Insert bút toán bên Nợ (tk ghi nợ làm tk):
 *    - Lấy các dòng chi tiết có ps_no <> 0 (bên Nợ) làm nguồn chính (a).
 *    - Kết hợp với các dòng chi tiết có ps_co <> 0 (bên Có) làm đối ứng (b).
 *    - Tính ps_no_nt, ps_co_nt: nếu mã ngoại tệ của dòng chi tiết bằng mã ngoại tệ gốc (@pMa_nt0) thì tiền ngoại tệ = 0.
 *    - Insert vào GLCT với tk = tk từ a (bên Nợ), tk_du = tk từ b (bên Có), ps_no_nt = ps_co_nt từ b, ps_co_nt = ps_no_nt từ b.
 * 5. Insert bút toán bên Có (tk ghi có làm tk):
 *    - Lấy các dòng chi tiết có ps_co <> 0 (bên Có) làm nguồn chính (a), đã tính tiền ngoại tệ.
 *    - Kết hợp với tk từ dòng bên Nợ (b) làm đối ứng.
 *    - Insert vào GLCT với tk = tk từ a (bên Có), tk_du = tk từ b (bên Nợ), ps_no_nt và ps_co_nt từ a.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 *   Ví dụ: '001'
 * - @pSTT_rec (string, bắt buộc): Số chứng từ (stt_rec) – khóa chính của phiếu kế toán (nvarchar(20)).
 *   Ví dụ: 'PK202500001'
 * - @pNh_dk (string, bắt buộc): Nhóm điều khoản (nh_dk) cần post (nvarchar(3)).
 *   Ví dụ: '001'
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Nếu ngày chứng từ đã khóa sổ, procedure return ngay.
 * - Số bản ghi insert vào GLCT = số dòng bên Có + số dòng bên Nợ (thực tế là 2 * số dòng bên Có, vì chỉ có 1 dòng bên Nợ).
 *
 * Logic chi tiết:
 * - Lấy ngày chứng từ: SELECT ngay_ct FROM ApPh4 WHERE ma_cty = @pMa_cty AND stt_rec = @pStt_rec.
 * - Gọi hàm dbo.afNamTC, dbo.afThangTC.
 * - SELECT TOP 1 ma_nt0, ngay_ks FROM siSetup WHERE ma_cty = @pMa_Cty.
 * - Kiểm tra khóa sổ: IF @pNgay_ct <= @pNgay_ks RETURN.
 * - Hai lệnh INSERT GlCt với các sub‑query phức tạp.
 *
 * Ví dụ gọi:
 * ```php
 * // Post nhóm điều khoản 001 của phiếu kế toán PK202500001, trường hợp 1 nợ nhiều có
 * AsPostApPh4Glct1n::call([
 *     'pMa_cty' => '001',
 *     'pSTT_rec' => 'PK202500001',
 *     'pNh_dk' => '001',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ.
 * - Cần đảm bảo dữ liệu trong ApPh4 và ApCt4 đã tồn tại, và nhóm điều khoản chỉ có đúng 1 dòng ps_no <> 0.
 * - Các hàm afNamTC và afThangTC phải được định nghĩa trong database.
 * - Bảng siSetup phải có bản ghi cho công ty tương ứng.
 * - Việc tính tiền ngoại tệ phụ thuộc vào mã ngoại tệ gốc của công ty.
 */
class AsPostApPh4_glct_1n extends StoredProcedure
{
    public const NAME = 'asPostApPh4_glct_1n';

    /**
     * Gọi stored procedure asPostApPh4_glct_1n.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (thường là không có resultset)
     *               Call stored procedure asPostApPh4_glct_1n
     */
    public static function call(array $params): Collection
    {
        return parent::call(array_merge([
            'pMa_cty'  => $params['pMa_cty'] ?? SModel::CTY,
            'pSTT_rec' => $params['pSTT_rec'] ?? null,
            'pNh_dk'   => $params['pNh_dk'] ?? null,
            'pNamTC'   => $params['pNamTC'] ?? null,
            'pThangTC' => $params['pThangTC'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_ks' => $params['pNgay_ks'] ?? null,
            'pMa_nt0'  => $params['pMa_nt0'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pma_cty'  => $params['pma_cty'] ?? null,
            'pnh_dk'   => $params['pnh_dk'] ?? null,
            'pstt_rec' => $params['pstt_rec'] ?? null,
        ], $params));
    }

    /**
     * Call stored procedure asPostApPh4_glct_1n with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $STT_rec = null, ?string $Nh_dk = null, ?int $NamTC = null, ?int $ThangTC = null, ?string $Ngay_ct = null, ?string $Ngay_ks = null, ?string $Ma_nt0 = null, mixed $Stt_rec = null, mixed $ma_cty = null, mixed $nh_dk = null, mixed $stt_rec = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pSTT_rec' => $STT_rec,
            'pNh_dk'   => $Nh_dk,
            'pNamTC'   => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pMa_nt0'  => $Ma_nt0,
            'pStt_rec' => $Stt_rec,
            'pma_cty'  => $ma_cty,
            'pnh_dk'   => $nh_dk,
            'pstt_rec' => $stt_rec,
        ];

        return self::call($params);
    }
}
