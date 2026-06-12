<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpddaoinfo
 *
 * Stored procedure: asUpddaoinfo
 * Mục đích: Cập nhật thông tin DAO (Data Access Object) trong hệ thống.
 * Procedure cập nhật các stored procedure liên quan đến một bảng dữ liệu (DAO) trong bảng sysdaoinfo.
 * Các stored procedure bao gồm: Get (lấy), Ins (thêm), Upd (cập nhật), Del (xóa), Sch (tìm kiếm), Chg (thay đổi).
 * 
 * Tham số:
 * - @pKey_Table_name (string, bắt buộc): Tên bảng cũ dùng làm điều kiện WHERE (NVARCHAR(100)).
 * - @pTable_name (string, bắt buộc): Tên bảng mới (NVARCHAR(100)).
 * - @pGet_sp (string, bắt buộc): Tên stored procedure dùng để lấy dữ liệu (NVARCHAR(100)).
 * - @pIns_sp (string, bắt buộc): Tên stored procedure dùng để thêm dữ liệu (NVARCHAR(100)).
 * - @pUpd_sp (string, bắt buộc): Tên stored procedure dùng để cập nhật dữ liệu (NVARCHAR(100)).
 * - @pDel_sp (string, bắt buộc): Tên stored procedure dùng để xóa dữ liệu (NVARCHAR(100)).
 * - @pSch_sp (string, bắt buộc): Tên stored procedure dùng để tìm kiếm (NVARCHAR(100)).
 * - @pChg_sp (string, bắt buộc): Tên stored procedure dùng để thay đổi (NVARCHAR(100)).
 * - @pDescription (string, bắt buộc): Mô tả (NVARCHAR(255)).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Logic chi tiết:
 * - UPDATE bảng sysdaoinfo với tất cả các cột được liệt kê, điều kiện WHERE Table_name = @pKey_Table_name.
 * - Lưu ý cột Table_name cũng được cập nhật thành giá trị mới @pTable_name (có thể thay đổi tên bảng).
 * - Bắt lỗi: SET @pRet = @@error.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsUpddaoinfo::call([
 *     'pKey_Table_name' => 'tblOldName',
 *     'pTable_name' => 'tblNewName',
 *     'pGet_sp' => 'asGettblNewName',
 *     'pIns_sp' => 'asInstblNewName',
 *     'pUpd_sp' => 'asUpdtblNewName',
 *     'pDel_sp' => 'asDeltblNewName',
 *     'pSch_sp' => 'asSchtrblNewName',
 *     'pChg_sp' => 'asChgtblNewName',
 *     'pDescription' => 'Bảng dữ liệu mẫu',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pKey_Table_name là tên bảng cũ dùng để xác định bản ghi cần cập nhật. Nếu tên không tồn tại, không có dòng nào bị ảnh hưởng.
 * - Các stored procedure liên quan (Get_sp, Ins_sp, ...) thường được đặt tên theo quy ước 'asActionTableName'.
 * - Bảng sysdaoinfo lưu trữ metadata về DAO, giúp hệ thống biết các stored procedure nào được sử dụng cho các thao tác CRUD trên bảng.
 * - Nếu thay đổi tên bảng (@pTable_name), cần đảm bảo các stored procedure thực sự tồn tại.
 * - Lỗi @@error có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Procedure không thay đổi các cột khác như LUser, LDate (nếu có). Cần kiểm tra bảng gốc.
 */
class AsUpddaoinfo
{
    /**
     * Gọi stored procedure asUpddaoinfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asUpddaoinfo', $params);
    }
}