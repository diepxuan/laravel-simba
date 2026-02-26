<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:19:48
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInsTATNDN01A.
 *
 * Stored procedure: asInsTATNDN01A
 * Mục đích: Chèn một bản ghi vào bảng TATNDN01A (có thể là chi tiết tờ khai thuế thu nhập doanh nghiệp mẫu 01A).
 * Bảng này lưu các chỉ tiêu, cách tính, tài khoản, số tiền cho mẫu tờ khai thuế.
 *
 * Tham số:
 * - @pMau (string, bắt buộc): Mẫu tờ khai (3 ký tự). Ví dụ: '01A'.
 * - @pMa_so (string, bắt buộc): Mã số chỉ tiêu (16 ký tự). Mã số dòng trong tờ khai.
 * - @pStt (int, bắt buộc): Số thứ tự (nguyên). Dùng để sắp xếp các dòng trong cùng mã số?.
 * - @pChi_tieu (string, bắt buộc): Tên chỉ tiêu (255 ký tự, Unicode). Mô tả chỉ tiêu.
 * - @pCach_tinh (string, bắt buộc): Cách tính (100 ký tự, Unicode). Công thức hoặc hướng dẫn tính.
 * - @pTk (string, bắt buộc): Tài khoản (100 ký tự). Danh sách tài khoản liên quan, có thể cách nhau dấu phẩy.
 * - @pNo_co (string, bắt buộc): Bên Nợ/Có (10 ký tự). Ví dụ: 'Nợ', 'Có', 'Nợ/Có'.
 * - @pTk_du (string, bắt buộc): Tài khoản dư (100 ký tự). Tài khoản đối ứng hoặc dư.
 * - @pBold (bool, bắt buộc): In đậm (bit). 1 = in đậm, 0 = bình thường.
 * - @pIn_ck (bool, bắt buộc): In chữ ký? (bit). 1 = in chữ ký, 0 = không in.
 * - @pTien (decimal, bắt buộc): Số tiền (decimal không chỉ định độ chính xác). Số tiền của chỉ tiêu.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 *
 * Giá trị mặc định:
 * - Không có.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu INSERT thành công, khác 0 là mã lỗi SQL.
 *
 * Logic chi tiết:
 * 1. INSERT vào TATNDN01A với các giá trị truyền vào.
 * 2. Gán @pRet = @@ERROR.
 *
 * Lưu ý:
 * - Bảng TATNDN01A có khóa chính có thể là (mau, ma_so, stt) hoặc (ma_so, stt).
 * - Kiểu decimal của @pTien không chỉ định độ chính xác, sẽ dùng độ chính xác mặc định của cột tien trong bảng.
 * - Cột bold và in_ck có thể dùng để định dạng khi in tờ khai.
 * - Cột no_co có thể ảnh hưởng đến công thức tính toán (lấy số liệu từ bên Nợ hay Có của tài khoản).
 * - Nên đảm bảo các tài khoản trong @pTk, @pTk_du tồn tại trong danh mục tài khoản.
 * - Có thể có ràng buộc với bảng master tờ khai (TATNDN01) thông qua mã số.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsInsTATNDN01A::call([
 *     'pMau' => '01A',
 *     'pMa_so' => '01',
 *     'pStt' => 1,
 *     'pChi_tieu' => 'Doanh thu bán hàng và cung cấp dịch vụ',
 *     'pCach_tinh' => 'Lấy từ TK 511',
 *     'pTk' => '511',
 *     'pNo_co' => 'Có',
 *     'pTk_du' => '',
 *     'pBold' => false,
 *     'pIn_ck' => false,
 *     'pTien' => 1000000000.0,
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 *
 * Liên quan:
 * - Bảng TATNDN01A: chi tiết tờ khai thuế TNDN mẫu 01A.
 * - Các procedure khác: asGetTATNDN01A, asUpdTATNDN01A, asDelTATNDN01A.
 */
class AsInsTATNDN01A
{
    /**
     * Gọi stored procedure asInsTATNDN01A.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter @pRet)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsTATNDN01A', $params, $connection);
    }

    /**
     * Call stored procedure asInsTATNDN01A with named parameters.
     */
    public static function callWithParams(?string $Mau = null, ?string $Ma_so = null, ?int $Stt = null, ?string $Chi_tieu = null, ?string $Cach_tinh = null, ?string $Tk = null, ?string $No_co = null, ?string $Tk_du = null, ?bool $Bold = null, ?bool $In_ck = null, ?float $Tien = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMau'       => $Mau,
            'pMa_so'     => $Ma_so,
            'pStt'       => $Stt,
            'pChi_tieu'  => $Chi_tieu,
            'pCach_tinh' => $Cach_tinh,
            'pTk'        => $Tk,
            'pNo_co'     => $No_co,
            'pTk_du'     => $Tk_du,
            'pBold'      => $Bold,
            'pIn_ck'     => $In_ck,
            'pTien'      => $Tien,
            'pRet'       => $Ret,
        ];

        return self::call($params);
    }
}
