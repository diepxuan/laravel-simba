<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-12 17:19:23
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAGetPH2.
 *
 * Stored procedure: `asCAGetPH2`
 *
 * ## Mục đích
 *
 * Lấy thông tin phiếu hàng 2 (PH2) từ hệ thống Simba.
 * Procedure trả về danh sách các phiếu thuộc bảng CA_PH2 (Cash Phiếu 2).
 *
 * ## Parameters (theo SQL Server)
 *
 * | Name | Type | Required | Description |
 * |------|------|----------|-------------|
 * | `@pMa_cty` | nvarchar(3) | ❌ | Mã công ty |
 * | `@pStt_rec` | nvarchar(20) | ❌ | Số tham chiếu (stt_rec) cần lấy |
 *
 * ## Fields trả về
 *
 * Procedure trả về Collection với các fields từ bảng `CA_PH2`:
 *
 * | Field | Kiểu | Diễn giải |
 * |-------|------|-----------|
 * | `ma_cty` | string(3) | Mã công ty |
 * | `stt_rec` | string(20) | Số thứ tự bản ghi (PK) |
 * | `ma_ct` | string(3) | Mã chứng từ (CA1, CA2, CA3, CA4, CA5, CA6) |
 * | `so_ct` | string(20) | Số chứng từ |
 * | `ngay_ct` | datetime | Ngày chứng từ |
 * | `ngay_lct` | datetime | Ngày lập chứng từ |
 * | `kht_tain` | boolean | Kế hoạch tài chính |
 * | `ma_kh` | string(20) | Mã khách hàng |
 * | `dia_chi` | string(255) | Địa chỉ |
 * | `nguoi_gd` | string(30) | Người giao dịch |
 * | `dien_giai` | string(255) | Diễn giải |
 * | `tk_co` | string(20) | Tài khoản Có |
 * | `ma_nt` | string(3) | Mã ngoại tệ |
 * | `ty_gia` | float | Tỷ giá |
 * | `t_tien` | float | Tổng tiền VNĐ |
 * | `t_tien_nt` | float | Tổng tiền ngoại tệ |
 * | `t_thue_nt` | float | Thuế ngoại tệ |
 * | `t_thue` | float | Thuế VNĐ |
 * | `t_tt` | float | Tổng thanh toán VNĐ |
 * | `t_tt_nt` | float | Tổng thanh toán ngoại tệ |
 * | `stt_rec_hd` | string(20) | STT rec hóa đơn |
 * | `trang_thai` | string | Trạng thái |
 * | `post2gl` | string | Đã post GL chưa |
 * | `cdate` | datetime | Ngày tạo |
 * | `cuser` | string | Người tạo |
 * | `ldate` | datetime | Ngày sửa |
 * | `luser` | string | Người sửa |
 *
 * ## Ví dụ sử dụng
 *
 * ```php
 * use Diepxuan\Simba\StoredProcedures\AsCAGetPH2;
 *
 * // 1. Lấy 1 phiếu theo stt_rec
 * $phieu = AsCAGetPH2::call([
 *     'pStt_rec' => '001wCA40000000676570',
 * ])->first();
 *
 * // 2. Lấy tất cả phiếu của công ty
 * $allPhieu = AsCAGetPH2::call([
 *     'pMa_cty' => '001',
 * ]);
 *
 * // 3. Lấy tất cả phiếu (không filter)
 * $allPhieu = AsCAGetPH2::call([]);
 *
 * // 4. Gọi với callWithParams()
 * $phieu = AsCAGetPH2::callWithParams(
 *     Ma_cty: '001',
 *     Stt_rec: '001wCA40000000676570'
 * )->first();
 * ```
 *
 * ## Lưu ý
 *
 * - Procedure thuộc nhóm Get (`asCAGet*`), không có output parameter
 * - Kết quả trả về là Laravel Collection
 * - Nếu không truyền params → trả về tất cả phiếu
 * - Dùng `pStt_rec` để filter theo 1 phiếu cụ thể
 * - Dùng `pMa_cty` để filter theo công ty
 *
 * ## Tham chiếu
 *
 * - Bảng: `CA_PH2`
 * - Procedure liên quan: `asCAGetCT2` (lấy chi tiết phiếu)
 */
class AsCAGetPH2
{
    /**
     * Gọi stored procedure asCAGetPH2.
     *
     * @param array $params Mảng tham số với các khóa: pMa_cty, pStt_rec
     *
     * @return Collection kết quả từ procedure
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAGetPH2', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asCAGetPH2 with named parameters.
     *
     * @param null|string $Ma_cty  Mã công ty
     * @param null|string $Stt_rec Số tham chiếu
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Stt_rec = null,
    ): Collection {
        return self::call([
            'pMa_cty'  => $Ma_cty,
            'pStt_rec' => $Stt_rec,
        ]);
    }
}
