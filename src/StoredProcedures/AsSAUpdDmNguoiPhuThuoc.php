<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 10:18:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSAUpdDmNguoiPhuThuoc.
 *
 * Stored procedure: asSAUpdDmNguoiPhuThuoc
 * Mục đích: Sửa danh mục người phụ thuộc.
 * Procedure cập nhật thông tin số người phụ thuộc và ghi chú cho một nhân viên trong một kỳ (tháng/năm) cụ thể.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pThang (string, bắt buộc): Tháng (20 ký tự, lưu dạng chuỗi). Thường là số tháng (1-12).
 * - @pNam (string, bắt buộc): Năm (20 ký tự, lưu dạng chuỗi). Thường là số năm.
 * - @pMa_nv (string, bắt buộc): Mã nhân viên (200 ký tự).
 * - @pSo_npt (int, bắt buộc): Số người phụ thuộc.
 * - @pGhi_chu (string, bắt buộc): Ghi chú (200 ký tự).
 * - @pLuser (string, bắt buộc): Tên người dùng thực hiện sửa (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSAUpdDmNguoiPhuThuoc::call([
 *     'pMa_cty' => '001',
 *     'pThang' => '2',
 *     'pNam' => '2025',
 *     'pMa_nv' => 'NV001',
 *     'pSo_npt' => 2,
 *     'pGhi_chu' => 'Có 2 người phụ thuộc',
 *     'pLuser' => 'admin',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure chỉ cập nhật các trường So_npt, Ghi_chu, Luser, Ldate của bảng SaDmNguoiPhuThuoc.
 * - Điều kiện update dựa trên bốn khóa: Ma_cty, Thang, Nam, Ma_nv.
 * - Ngày sửa (Ldate) được tự động cập nhật bằng GETDATE().
 * - Nếu không có bản ghi nào khớp điều kiện, procedure không báo lỗi nhưng @pRet sẽ là 0 (vì không có lỗi SQL). Cần kiểm tra số dòng bị ảnh hưởng thông qua kết nối database.
 * - Cần đảm bảo bản ghi đã tồn tại trước khi sửa (nếu không, không có hành động gì). Có thể sử dụng procedure asSAInsDmNguoiPhuThuoc để thêm mới.
 */
class AsSAUpdDmNguoiPhuThuoc
{
    /**
     * Gọi stored procedure asSAUpdDmNguoiPhuThuoc.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAUpdDmNguoiPhuThuoc', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pThang'   => $params['pThang'] ?? null,
            'pNam'     => $params['pNam'] ?? null,
            'pMa_nv'   => $params['pMa_nv'] ?? null,
            'pSo_npt'  => $params['pSo_npt'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pLuser'   => $params['pLuser'] ?? null,
            'pRet'     => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asSAUpdDmNguoiPhuThuoc with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Thang = null, ?string $Nam = null, ?string $Ma_nv = null, ?int $So_npt = null, ?string $Ghi_chu = null, ?string $Luser = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pThang'   => $Thang,
            'pNam'     => $Nam,
            'pMa_nv'   => $Ma_nv,
            'pSo_npt'  => $So_npt,
            'pGhi_chu' => $Ghi_chu,
            'pLuser'   => $Luser,
            'pRet'     => $Ret,
        ];

        return self::call($params);
    }
}
