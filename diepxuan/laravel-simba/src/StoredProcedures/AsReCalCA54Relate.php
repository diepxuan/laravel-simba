<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalCA54Relate
 *
 * Stored procedure: asReCalCA54Relate
 * Mục đích: Tính toán lại số dư của các phiếu chi.
 * Procedure thực hiện duyệt qua các phiếu chi liên quan từ bảng cact3 (các chứng từ liên kết)
 * và gọi procedure asCARecalCA2 để tính toán lại số dư cho từng phiếu chi.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi (stt_rec) của chứng từ gốc (phiếu chi cần tính toán lại số dư).
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện các cập nhật trực tiếp thông qua asCARecalCA2.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalCA54Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'PC001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng cursor để duyệt qua các stt_rec_pc từ bảng cact3 với điều kiện ma_cty = @pMa_cty và stt_rec = @pStt_rec.
 * - Mỗi stt_rec_pc tìm được sẽ gọi asCARecalCA2(@pMa_cty, @stt_rec_pc) để tính lại số dư phiếu chi.
 * - Bảng cact3 có lẽ là bảng chi tiết chứng từ liên kết (có thể là chi tiết phiếu chi liên quan).
 * - Procedure này thuộc nhóm Recalculate (asReCal*).
 */
class AsReCalCA54Relate
{
    /**
     * Gọi stored procedure asReCalCA54Relate
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalCA54Relate', $params);
    }
}