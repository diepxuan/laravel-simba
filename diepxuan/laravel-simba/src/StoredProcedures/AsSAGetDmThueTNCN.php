<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAGetDmThueTNCN
 *
 * Stored procedure: asSAGetDmThueTNCN
 * Mục đích: Danh mục thuế thu nhập cá nhân.
 * Procedure trả về danh sách các bậc thuế thu nhập cá nhân của một công ty.
 * Nếu công ty chưa có dữ liệu thuế TNCN, procedure sẽ tự động chèn dữ liệu mẫu theo quy định của Luật thuế thu nhập cá nhân năm 2007 (Điều 22).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset chứa các cột:
 *   + Ma_cty: Mã công ty
 *   + Bac_thue: Bậc thuế (1-7)
 *   + Dinh_muc_tu: Định mức từ (số tiền bắt đầu)
 *   + Dinh_muc_den: Định mức đến (số tiền kết thúc)
 *   + Thue_suat: Thuế suất (%)
 *   + Thue_toi_da: Thuế tối đa (số tiền)
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsSAGetDmThueTNCN::call([
 *     'pMa_cty' => '001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure kiểm tra nếu bảng SaDmThueTNCN chưa có dữ liệu cho công ty đó, sẽ chèn 7 bậc thuế mẫu với các giá trị cố định:
 *   + Bậc 1: 0-5 triệu, thuế suất 5%, thuế tối đa 250.000
 *   + Bậc 2: 5-10 triệu, thuế suất 10%, thuế tối đa 500.000
 *   + Bậc 3: 10-18 triệu, thuế suất 15%, thuế tối đa 1.200.000
 *   + Bậc 4: 18-32 triệu, thuế suất 20%, thuế tối đa 2.800.000
 *   + Bậc 5: 32-52 triệu, thuế suất 25%, thuế tối đa 5.000.000 (có thể ghi chú là 5.000.000? Trong SQL là 50000000, có thể là 5.000.000?)
 *   + Bậc 6: 52-80 triệu, thuế suất 30%, thuế tối đa 8.400.000
 *   + Bậc 7: trên 80 triệu, thuế suất 35%, thuế tối đa 0 (không giới hạn)
 * - Dữ liệu mẫu này theo luật thuế cũ (2007), có thể không còn phù hợp với quy định hiện hành. Cần cập nhật nếu có thay đổi.
 * - Sau khi đảm bảo có dữ liệu, procedure SELECT toàn bộ bậc thuế của công ty đó.
 * - Người dùng cần có quyền INSERT và SELECT trên bảng SaDmThueTNCN.
 */
class AsSAGetDmThueTNCN
{
    /**
     * Gọi stored procedure asSAGetDmThueTNCN
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asSAGetDmThueTNCN', $params);
    }
}