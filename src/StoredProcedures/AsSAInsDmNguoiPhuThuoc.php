<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 09:54:20
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSAInsDmNguoiPhuThuoc.
 *
 * Stored procedure: asSAInsDmNguoiPhuThuoc
 * Mục đích: Thêm danh mục người phụ thuộc.
 * Procedure thêm một bản ghi mới vào danh mục người phụ thuộc cho một nhân viên trong một kỳ (tháng/năm) cụ thể.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pThang (string, bắt buộc): Tháng (20 ký tự, lưu dạng chuỗi). Thường là số tháng (1-12).
 * - @pNam (string, bắt buộc): Năm (20 ký tự, lưu dạng chuỗi). Thường là số năm.
 * - @pMa_nv (string, bắt buộc): Mã nhân viên (200 ký tự).
 * - @pSo_npt (int, bắt buộc): Số người phụ thuộc.
 * - @pGhi_chu (string, bắt buộc): Ghi chú (200 ký tự).
 * - @pCuser (string, bắt buộc): Tên người dùng thực hiện thêm (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSAInsDmNguoiPhuThuoc::call([
 *     'pMa_cty' => '001',
 *     'pThang' => '2',
 *     'pNam' => '2025',
 *     'pMa_nv' => 'NV001',
 *     'pSo_npt' => 2,
 *     'pGhi_chu' => 'Có 2 người phụ thuộc',
 *     'pCuser' => 'admin',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure thực hiện INSERT vào bảng SaDmNguoiPhuThuoc với các giá trị được cung cấp.
 * - Các trường Cdate và Ldate được gán bằng GETDATE() (thời điểm hiện tại).
 * - Trường Luser được gán bằng @pCuser (người tạo cũng là người sửa lần cuối).
 * - Nếu bản ghi đã tồn tại (trùng khóa chính Ma_cty, Thang, Nam, Ma_nv), sẽ xảy ra lỗi violation và @pRet sẽ là mã lỗi SQL.
 * - Cần đảm bảo rằng mã nhân viên tồn tại trong bảng HrHSNS (nếu có ràng buộc khóa ngoại).
 */
class AsSAInsDmNguoiPhuThuoc
{
    /**
     * Gọi stored procedure asSAInsDmNguoiPhuThuoc.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAInsDmNguoiPhuThuoc', $params, $connection);
    }

    /**
     * Call stored procedure asSAInsDmNguoiPhuThuoc with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Thang = null, ?string $Nam = null, ?string $Ma_nv = null, ?int $So_npt = null, ?string $Ghi_chu = null, ?string $Cuser = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pThang'   => $Thang,
            'pNam'     => $Nam,
            'pMa_nv'   => $Ma_nv,
            'pSo_npt'  => $So_npt,
            'pGhi_chu' => $Ghi_chu,
            'pCuser'   => $Cuser,
            'pRet'     => $Ret,
        ];

        return self::call($params);
    }
}
