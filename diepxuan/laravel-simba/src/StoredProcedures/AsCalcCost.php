<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCalcCost
 *
 * Stored procedure: asCalcCost
 * Mục đích: Tính giá thành sản phẩm/công trình, lưu vào bảng COBGT.
 * Procedure thực hiện tính toán giá thành sản xuất cho các sản phẩm và công trình trong một khoảng thời gian cụ thể.
 * Dựa trên các tham số: mã công ty, ngày bắt đầu, ngày kết thúc, tài khoản sản phẩm dở dang (TK154).
 * Procedure thực hiện các bước:
 * 1. Xóa dữ liệu cũ trong bảng CoBGT.
 * 2. Tính dở dang cuối kỳ cho các công trình.
 * 3. Tính chi phí phát sinh trong kỳ.
 * 4. Tính giá thành trực tiếp trong kỳ cho công trình.
 * 5. Lấy danh sách thành phẩm nhập kho.
 * 6. Cập nhật dở dang đầu kỳ và cuối kỳ.
 * 7. Phân loại sản phẩm/công trình.
 * 8. Tính tổng giá thành và giá thành đơn vị (chỉ cho sản phẩm).
 * 9. Trả về kết quả dưới dạng hai resultset:
 *    - Header: tổng hợp theo mã sản phẩm.
 *    - Chi tiết: thẻ giá thành với diễn giải.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định '111'): Mã công ty (3 ký tự).
 * - @pNgay1 (datetime, tùy chọn, mặc định '20150101'): Ngày bắt đầu kỳ tính giá thành (định dạng YYYYMMDD hoặc chuỗi ngày).
 * - @pNgay2 (datetime, tùy chọn, mặc định '20150131'): Ngày kết thúc kỳ tính giá thành.
 * - @pTk154 (string, tùy chọn, mặc định ''): Tài khoản sản phẩm dở dang (TK154). Nếu rỗng sẽ lấy tất cả tài khoản bắt đầu bằng chuỗi rỗng (tức toàn bộ).
 * 
 * Giá trị trả về:
 * - Procedure trả về hai resultset:
 *   1. Header: gồm các cột: ma_spct, Ten_spct, dvt, dddk, tongcp, ddck, tonggt, tpnk, gtdv, san_pham.
 *   2. Chi tiết: gồm các cột: ma_spct, tk, loai_ps, tk_du, gia_tri, dien_giai, ma_so.
 * - Không có output parameter.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCalcCost::call([
 *     'pMa_cty' => '901',
 *     'pNgay1' => '2011-01-01',
 *     'pNgay2' => '2011-01-31',
 *     'pTk154' => '154',
 * ]);
 * // $result là mảng chứa hai phần tử:
 * // $result[0] là resultset header
 * // $result[1] là resultset chi tiết
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng nhiều bảng: CoBGT, CoDd, glct, inct, codmspct, CoTGTMau.
 * - Các loại ps (loại_ps) được định nghĩa:
 *   'CPPS': chi phí phát sinh.
 *   'GTCTBG': giá thành công trình bàn giao.
 *   'TPNK': thành phẩm nhập kho.
 *   'DDDK': dở dang đầu kỳ.
 *   'DDCK': dở dang cuối kỳ.
 *   'TONGGT': tổng giá thành.
 *   'GTDV': giá thành đơn vị.
 * - Chỉ tính giá thành đơn vị cho sản phẩm (san_pham = '1'), không tính cho công trình (san_pham <> '1').
 * - Ngày được chuyển đổi sang tháng/năm để lọc dữ liệu.
 */
class AsCalcCost
{
    /**
     * Gọi stored procedure asCalcCost
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là array của nhiều resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCalcCost', $params);
    }
}