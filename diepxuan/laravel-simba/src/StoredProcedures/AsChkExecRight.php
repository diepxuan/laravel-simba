<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsChkExecRight
 *
 * Stored procedure: asChkExecRight
 * Mục đích: Kiểm tra quyền thực thi (execution right) của người dùng trên một menu/chức năng.
 * Procedure kiểm tra nhiều cấp độ quyền: quyền cơ bản (basic right), quyền trực tiếp của người dùng,
 * quyền của nhóm người dùng, quyền của người dùng trên công ty, quyền của nhóm trên công ty.
 * 
 * Tham số:
 * - @pMa_Cty (string, tùy chọn): Mã công ty (nvarchar(3)).
 *   Giá trị mặc định: '' (chuỗi rỗng). Khi không truyền, dùng giá trị mặc định rỗng.
 * - @pUserName (string, bắt buộc): Tên đăng nhập của người dùng (nvarchar(20)).
 *   Không có giá trị mặc định.
 * - @pMenuID (string, bắt buộc): Mã menu/chức năng cần kiểm tra quyền (nvarchar(10)).
 *   Không có giá trị mặc định.
 * - @pRet (int, output): Tham số đầu ra (output parameter) chứa kết quả kiểm tra quyền.
 *   Giá trị trả về: 
 *     - 0: không có quyền.
 *     - >0: có quyền (có thể là tổng quyền từ nhiều nguồn).
 *   Lưu ý: Đây là tham số output, không truyền giá trị vào.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ trả về giá trị qua tham số output @pRet.
 * - Nếu sử dụng ProcedureCaller::call(), giá trị trả về có thể là null hoặc mảng rỗng (tùy vào driver).
 * - Để lấy giá trị output parameter, có thể cần sử dụng phương thức khác (VD: DB::statement với output binding).
 * 
 * Logic chi tiết:
 * 1. Kiểm tra quyền cơ bản (basicright) từ bảng sysmenu:
 *    - Lấy basicright của menu với MenuId = @pMenuID.
 *    - Nếu có basicright (khác null), chuyển thành integer và gán cho @pRet.
 *    - Nếu không có, gán @pRet = 0.
 * 2. Nếu @pRet = 0, kiểm tra quyền trực tiếp của người dùng từ bảng sysUserRight:
 *    - Tính tổng ViewRight của người dùng @pUserName trên menu @pMenuID.
 *    - Nếu tổng > 0, gán cho @pRet.
 * 3. Nếu @pRet = 0, kiểm tra quyền của nhóm người dùng từ bảng sysGroupRight:
 *    - Lấy tất cả nhóm của người dùng từ sysUserGroup.
 *    - Tính tổng ViewRight của các nhóm đó trên menu @pMenuID.
 *    - Nếu tổng > 0, gán cho @pRet.
 * 4. Nếu @pRet = 0 hoặc NULL, procedure RETURN (không kiểm tra tiếp).
 * 5. Kiểm tra quyền của người dùng trên công ty từ bảng sysUserCompanyRight:
 *    - Đếm số bản ghi có ma_cty = @pMa_Cty và username = @pUserName.
 *    - Nếu count > 0, gán @pRet = count; ngược lại @pRet = 0.
 * 6. Nếu @pRet = 0, kiểm tra quyền của nhóm người dùng trên công ty từ bảng sysGroupCompanyRight:
 *    - Lấy các nhóm của người dùng.
 *    - Đếm số bản ghi có ma_cty = @pMa_Cty và groupname khớp.
 *    - Nếu count > 0, gán @pRet = count.
 * 
 * Kết quả cuối cùng: @pRet > 0 nghĩa là người dùng có quyền thực thi menu đó trên công ty đã chọn.
 * 
 * Ví dụ gọi (sử dụng DB facade trực tiếp để lấy output parameter):
 * ```php
 * // Cách gọi với output parameter (cần sử dụng DB::statement hoặc DB::select với cú pháp SQL thuần):
 * $pRet = 0;
 * DB::statement('EXEC dbo.asChkExecRight @pMa_Cty = ?, @pUserName = ?, @pMenuID = ?, @pRet = ? OUTPUT',
 *     ['001', 'admin', 'MN001', $pRet]);
 * // Sau khi gọi, $pRet sẽ chứa giá trị output.
 * 
 * // Cách gọi qua ProcedureCaller (chưa hỗ trợ output parameter):
 * $result = AsChkExecRight::call([
 *     'pMa_Cty' => '001',
 *     'pUserName' => 'admin',
 *     'pMenuID' => 'MN001',
 *     'pRet' => null, // Truyền null cho output parameter, nhưng không nhận được giá trị trả về.
 * ]);
 * // $result có thể là null hoặc mảng rỗng.
 * ```
 * 
 * Lưu ý:
 * - Tham số @pMa_Cty có thể rỗng, nhưng nếu rỗng thì bước kiểm tra quyền công ty sẽ không có kết quả (có thể dẫn đến không có quyền).
 * - Procedure này thường được gọi trước khi cho phép người dùng truy cập một chức năng trong phần mềm.
 * - Nếu chỉ có quyền cơ bản (basicright) mà không có quyền công ty, vẫn có thể có quyền thực thi.
 * - Cần cẩn thận với output parameter khi sử dụng ProcedureCaller hiện tại; có thể cần mở rộng ProcedureCaller để hỗ trợ output parameters.
 */
class AsChkExecRight
{
    /**
     * Gọi stored procedure asChkExecRight
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     *   Đối với output parameter @pRet, truyền giá trị null (sẽ không nhận được giá trị trả về).
     * @return mixed Kết quả trả về từ procedure (thường là null hoặc mảng rỗng do output parameter).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asChkExecRight', $params);
    }
}