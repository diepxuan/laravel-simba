<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOGetDMPB12
 *
 * Stored procedure: asCOGetDMPB12
 * Mục đích: Lấy thông tin chi tiết phân bổ theo năm và module, kết hợp với tên sản phẩm công trình, tên bộ phận và tên tài khoản.
 * Procedure tạo bảng tạm #Temp chứa dữ liệu từ codmpb2 (phân bổ chi tiết theo tháng) kết hợp với tên sản phẩm công trình và tên bộ phận.
 * Sau đó SELECT từ codmpb1 (danh sách tài khoản nhận phân bổ) kết hợp với #Temp và gldmtk để lấy đầy đủ thông tin.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pNam (int, bắt buộc): Năm cần lấy dữ liệu phân bổ.
 * - @pModuleId (string, bắt buộc): Mã module (8 ký tự). Dùng để lọc codmpb1.
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma_cty (string): Mã công ty.
 *   - thang (int?): Tháng phân bổ (từ #Temp). Có thể NULL nếu không có dữ liệu trong codmpb2.
 *   - nam (int?): Năm phân bổ (từ #Temp). Có thể NULL.
 *   - id (int): ID phân bổ.
 *   - tk_nhan_pb (string): Tài khoản nhận phân bổ.
 *   - ten_tk (string): Tên tài khoản (lấy từ gldmtk). Nếu không có sẽ là chuỗi rỗng.
 *   - ma_spct (string): Mã sản phẩm công trình (từ #Temp). Có thể NULL.
 *   - ten_spct (string): Tên sản phẩm công trình (từ #Temp). Có thể NULL.
 *   - ma_bp (string): Mã bộ phận (từ #Temp). Có thể NULL.
 *   - ten_bp (string): Tên bộ phận (từ #Temp). Có thể NULL.
 *   - he_so (float): Hệ số phân bổ (từ #Temp). Nếu NULL thì 0.
 *   - tien_nhan (float): Số tiền đã nhận phân bổ (từ #Temp). Nếu NULL thì 0.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. Tạo bảng tạm #Temp từ codmpb2 LEFT JOIN với codmspct và sidmbp, lọc theo năm và mã công ty.
 * 2. SELECT từ codmpb1 LEFT JOIN #Temp (theo ma_cty, id, tk_nhan_pb) và LEFT JOIN gldmtk (lấy ten_tk).
 * 3. Điều kiện WHERE: codmpb1.Ma_cty = @pMa_cty AND codmpb1.moduleid = @pModuleId.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsCOGetDMPB12::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2024,
 *     'pModuleId' => 'CO',
 * ]);
 * // $rows là mảng các đối tượng stdClass hoặc mảng kết hợp.
 * foreach ($rows as $row) {
 *     echo "ID: {$row->id}, TK nhận PB: {$row->tk_nhan_pb}, Hệ số: {$row->he_so}, Tiền nhận: {$row->tien_nhan}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Bảng tạm #Temp chỉ chứa dữ liệu của năm @pNam, do đó các bản ghi codmpb1 không có dữ liệu phân bổ trong năm đó sẽ có các cột từ #Temp là NULL.
 * - Các giá trị NULL được xử lý bằng ISNULL trong SELECT cuối (he_so và tien_nhan thành 0).
 * - Có thể có nhiều bản ghi cho cùng một id và tk_nhan_pb nhưng khác tháng? Bảng codmpb2 có khóa (ma_cty, id, tk_nhan_pb, thang). Ở đây #Temp có thể có nhiều tháng cùng năm, nhưng LEFT JOIN với codmpb1 sẽ lấy tất cả? Không có GROUP BY nên có thể trùng lặp. Cần xem xét logic giao diện sử dụng.
 * - ModuleId trong codmpb1 dùng để lọc loại phân bổ (ví dụ 'CO' cho phân bổ chi phí).
 */
class AsCOGetDMPB12
{
    /**
     * Gọi stored procedure asCOGetDMPB12
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOGetDMPB12', $params);
    }
}