<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:54:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsReCalCA54Relate.
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
     * Gọi stored procedure asReCalCA54Relate.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (không có resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalCA54Relate', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_Cty'  => $params['pMa_Cty'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asReCalCA54Relate with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_Cty'  => $Ma_Cty,
        ];

        return self::call($params);
    }
}
