<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPost2GL
 *
 * Stored procedure: asPost2GL
 * Mục đích: Post hoặc Unpost một chứng từ cụ thể vào Sổ Cái (GLCT).
 * Procedure này thực hiện hai chức năng:
 * - Nếu @pPostUnpost = '1': Post chứng từ lên sổ cái bằng cách gọi stored procedure post tương ứng
 *   (lấy từ bảng sidmCt.sp_post) với mã công ty, mã chứng từ, số chứng từ.
 * - Nếu @pPostUnpost = '0': Xóa các bút toán liên quan trên sổ cái (GLCT) và cập nhật trạng thái Post2gl = '0'
 *   trên bảng chứng từ tương ứng (lấy từ sidmCt.ph).
 * 
 * Tham số:
 * - @pMa_Cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 *   Ví dụ: '001'
 * - @pStt_rec (string, bắt buộc): Số chứng từ (stt_rec) – khóa chính của chứng từ cần post/unpost (nvarchar(20)).
 *   Ví dụ: 'SO202500001'
 * - @pMa_ct (string, bắt buộc): Mã chứng từ (nvarchar(3)).
 *   Ví dụ: 'SO1'
 * - @pPostUnpost (string, bắt buộc): Chỉ định hành động post hoặc unpost (nvarchar(1)).
 *   Giá trị: '1' để post lên sổ cái, '0' để xóa khỏi sổ cái.
 *   Giá trị mặc định: '1' (post).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Kết quả được thực hiện thông qua các lệnh SQL động (sp_executesql).
 * 
 * Logic chi tiết:
 * 1. Nếu @pPostUnpost = '1':
 *    - Xây dựng câu lệnh SQL động: 'declare @pRet int' + 'exec ' + [sp_post từ sidmCt] + @pMa_Cty, @pStt_rec.
 *    - sp_post là tên stored procedure post cụ thể cho loại chứng từ, được lưu trong bảng sidmCt.
 *    - Thực thi câu lệnh để post chứng từ lên sổ cái.
 * 2. Nếu @pPostUnpost = '0':
 *    - Xóa các bút toán trên GLCT có ma_cty = @pMa_Cty và stt_rec = @pStt_rec.
 *    - Cập nhật bảng chứng từ (tên bảng lấy từ sidmCt.ph) set Post2gl = '0' với điều kiện tương tự.
 * 
 * Ví dụ gọi:
 * ```php
 * // Post chứng từ SO202500001 của công ty 001, mã chứng từ SO1
 * AsPost2GL::call([
 *     'pMa_Cty' => '001',
 *     'pStt_rec' => 'SO202500001',
 *     'pMa_ct' => 'SO1',
 *     'pPostUnpost' => '1',
 * ]);
 * 
 * // Unpost (xóa khỏi sổ cái) chứng từ trên
 * AsPost2GL::call([
 *     'pMa_Cty' => '001',
 *     'pStt_rec' => 'SO202500001',
 *     'pMa_ct' => 'SO1',
 *     'pPostUnpost' => '0',
 * ]);
 * 
 * // Sử dụng giá trị mặc định cho pPostUnpost (post)
 * AsPost2GL::call([
 *     'pMa_Cty' => '001',
 *     'pStt_rec' => 'SO202500001',
 *     'pMa_ct' => 'SO1',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Bảng sidmCt phải có thông tin sp_post và ph tương ứng với mã chứng từ.
 * - Việc post/unpost có thể ảnh hưởng đến dữ liệu sổ cái, cần đảm bảo tính toàn vẹn.
 * - Nếu stored procedure post cụ thể trả về giá trị @pRet, giá trị đó sẽ được khai báo nhưng không sử dụng trong class này.
 */
class AsPost2GL
{
    /**
     * Gọi stored procedure asPost2GL
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (thường là không có resultset).
     */
    public static function call(array $params = [])
    {
        // Thiết lập giá trị mặc định cho pPostUnpost nếu không được cung cấp
        if (!isset($params['pPostUnpost'])) {
            $params['pPostUnpost'] = '1';
        }
        return ProcedureCaller::call('asPost2GL', $params);
    }
}