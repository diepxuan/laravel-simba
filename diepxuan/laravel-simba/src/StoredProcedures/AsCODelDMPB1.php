<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCODelDMPB1
 *
 * Stored procedure: asCODelDMPB1
 * Mục đích: Xóa một chi tiết phân bổ (bảng CODMPB1) sau khi kiểm tra xem đã có bút toán phân bổ trong GLCT chưa.
 * Procedure kiểm tra sự tồn tại của bút toán phân bổ dựa trên quy tắc tạo stt_rec (mã công ty + ws_id + mã chứng từ + ID).
 * Nếu chưa có bút toán, cho phép xóa chi tiết phân bổ; ngược lại, không xóa và trả về mã lỗi.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pId (int, bắt buộc): ID phân bổ (tham chiếu đến codmpb.id).
 * - @pTk_nhan_pb (string, bắt buộc): Tài khoản nhận phân bổ (20 ký tự).
 * - @pMa_ct (string, bắt buộc): Mã chứng từ phân bổ (3 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0: đã xóa, >0: chưa xóa (có bút toán).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu xóa thành công (không có bút toán).
 * - @pRet = 1 nếu có bút toán tồn tại, không xóa.
 * - @pRet cũng có thể là số lượng bút toán tìm thấy (nhưng code hiện tại gán @ID = 1 nếu có bút toán).
 * 
 * Logic chi tiết:
 * 1. Lấy ws_id từ sisetup dựa trên mã công ty.
 * 2. Tạo chuỗi stt_rec = @pma_cty + @ws_id + @pMa_ct + replicate(0,7-len(@pID)) + convert(varchar(10),@pID).
 *    - replicate(0,7-len(@pID)): thêm các số 0 phía trước để đủ 7 ký tự cho phần ID.
 *    - Ví dụ: ID = 123, độ dài 3 => replicate(0,4) => '0000', stt_rec = '001WCO2000123' (giả sử).
 * 3. Đếm số bút toán trong glct có ma_cty = @pMa_cty và stt_Rec LIKE @stt_rec + '%' (bắt đầu bằng stt_rec).
 * 4. Nếu đếm = 0: Xóa bản ghi trong CODMPB1 với điều kiện Ma_cty, Id, Tk_nhan_pb.
 *    Ngược lại: gán @ID = 1.
 * 5. Gán @pRet = @ID.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCODelDMPB1::call([
 *     'pMa_cty' => '001',
 *     'pId' => 5,
 *     'pTk_nhan_pb' => '1541',
 *     'pMa_ct' => 'CO2',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Có bút toán phân bổ, không thể xóa
 * }
 * ```
 * 
 * Lưu ý:
 * - Việc kiểm tra dựa trên quy tắc tạo stt_rec của bút toán phân bổ, đảm bảo không xóa chi tiết phân bổ đã được sử dụng.
 * - Nếu có nhiều bút toán phân bổ (nhiều ngày) thì cũng không cho xóa.
 * - Xóa chỉ ảnh hưởng đến một chi tiết phân bổ cụ thể (tài khoản nhận phân bổ) của một ID phân bổ.
 * - Cần đảm bảo mã chứng từ @pMa_ct chính xác theo mã chứng từ phân bổ đã dùng khi tạo bút toán.
 */
class AsCODelDMPB1
{
    /**
     * Gọi stored procedure asCODelDMPB1
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCODelDMPB1', $params);
    }
}