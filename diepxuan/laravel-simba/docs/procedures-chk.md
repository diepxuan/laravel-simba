# Nhóm Stored Procedures: asChk* (Check)

Nhóm các stored procedure kiểm tra (check) dữ liệu, quyền, điều kiện trong hệ thống Simba ERP. Tiền tố `asChk*` (viết tắt của "check") thường dùng cho các thủ tục kiểm tra tồn tại mã, quyền thực thi, trùng số chứng từ, đăng nhập, v.v.

## Danh sách procedures đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| `asChkCodeExists` | `AsChkCodeExists` | `@pMa_Cty` (NVARCHAR(3), default '111')<br>`@pTable_name` (SYSNAME, default 'ARDMKH')<br>`@pCode_name` (SYSNAME, default 'MA_KH')<br>`@pCode_value` (NVARCHAR(20), default 'KH005') | Kiểm tra tồn tại mã trong danh mục. Dùng cho các thủ tục Insert Danh mục. Chỉ dùng cho các danh mục có 1 trường mã (Khách hàng, Vật tư, Hợp đồng, Bộ phận, Kho...). |
| `asChkCodeExistsBeforeChange` | `AsChkCodeExistsBeforeChange` | `@pMa_Cty` (NVARCHAR(3))<br>`@pTable_name` (SYSNAME)<br>`@pCode_name` (SYSNAME)<br>`@pOldValue` (NVARCHAR(20))<br>`@pNewValue` (NVARCHAR(20)) | Kiểm tra tồn tại mã trong danh mục trước khi thay đổi (update). Loại trừ giá trị cũ, kiểm tra giá trị mới có trùng với mã khác không. |
| `asChkExecRight` | `AsChkExecRight` | `@pMa_Cty` (NVARCHAR(3), default '')<br>`@pUserName` (NVARCHAR(20))<br>`@pMenuID` (NVARCHAR(10))<br>`@pRet` (INT, output) | Kiểm tra quyền thực thi của người dùng trên một menu/chức năng. Kiểm tra quyền cơ bản, quyền người dùng, quyền nhóm, quyền công ty. |
| `asChkSoCt` | `AsChkSoCt` | `@pMa_cty` (NVARCHAR(3))<br>`@pMa_ct` (NVARCHAR(3))<br>`@pStt_rec` (NVARCHAR(20))<br>`@pSo_ct` (NVARCHAR(12))<br>`@pNgay_Ct` (SMALLDATETIME)<br>`@pRet` (INT, output) | Kiểm tra trùng số chứng từ (so_ct) theo cấu hình kiểu trùng (theo tháng, theo năm). Duyệt qua các bảng liên quan (chứng từ con) để đếm số chứng từ trùng. |
| `asChkUserLogin` | `AsChkUserLogin` | `@pUserName` (NVARCHAR(20))<br>`@pPassword` (NVARCHAR(255))<br>`@pIsGrand` (INT, output)<br>`@pIsAdmin` (INT, output)<br>`@pOk` (INT, output)<br>`@pMa_cty` (NVARCHAR(3), default '') | Kiểm tra thông tin đăng nhập của người dùng, trả về các cờ quyền (IsAdmin, IsGrand) và xác thực thành công (Ok). |

## Chi tiết từng procedure

### asChkCodeExists

**Mục đích**: Kiểm tra tồn tại mã trong danh mục, dùng trước khi thêm mới một bản ghi danh mục để tránh trùng mã. Hỗ trợ kiểm tra mã phân cấp (LIKE).

**Tham số**:
- `@pMa_Cty` (tùy chọn): Mã công ty, mặc định '111'.
- `@pTable_name` (tùy chọn): Tên bảng danh mục, mặc định 'ARDMKH'.
- `@pCode_name` (tùy chọn): Tên cột mã trong bảng, mặc định 'MA_KH'.
- `@pCode_value` (tùy chọn): Giá trị mã cần kiểm tra, mặc định 'KH005'.

**Logic**:
- Nếu bảng thuộc danh sách loại trừ ('GLDMTK', 'GlMauBctc02', 'GlMauBctc03', 'GlMauBctc04') thì RETURN ngay (không kiểm tra).
- Xây dựng SQL động: đếm số bản ghi thỏa `(pCode_name LIKE @value + '%' OR @pCode_value LIKE pCode_name + '%') AND ma_cty = @pMa_Cty AND pCode_name <> ''`.
- Trả về số lượng bản ghi.

**Kết quả**: Một số nguyên (single column, single row). >0 nghĩa là mã đã tồn tại.

**Sử dụng**: Gọi từ framework khi thêm mới danh mục.

### asChkCodeExistsBeforeChange

**Mục đích**: Kiểm tra tồn tại mã trước khi thay đổi giá trị mã của một bản ghi danh mục (update). Đảm bảo mã mới không trùng với mã khác (ngoại trừ mã cũ).

**Tham số** (tất cả bắt buộc):
- `@pMa_Cty`: Mã công ty.
- `@pTable_name`: Tên bảng danh mục.
- `@pCode_name`: Tên cột mã.
- `@pOldValue`: Giá trị mã cũ.
- `@pNewValue`: Giá trị mã mới.

**Logic**:
- Nếu bảng là 'GLDMTK' thì gán `@pOldValue = ''`.
- Nếu `@pOldValue <> ''`: sử dụng điều kiện LIKE (kiểm tra mã phân cấp) và loại trừ giá trị cũ.
- Nếu `@pOldValue = ''`: sử dụng điều kiện chính xác (=).
- Luôn có điều kiện `ma_cty = @pMa_Cty`.
- Trả về số lượng bản ghi thỏa mãn.

**Kết quả**: Một số nguyên. >0 nghĩa là mã mới đã tồn tại (trùng với mã khác), không thể thay đổi.

**Sử dụng**: Gọi từ framework khi cập nhật mã danh mục.

### asChkExecRight

**Mục đích**: Kiểm tra quyền thực thi của người dùng trên một menu/chức năng cụ thể. Kiểm tra nhiều lớp quyền: quyền cơ bản (basicright), quyền người dùng trực tiếp, quyền nhóm, quyền công ty của người dùng, quyền công ty của nhóm.

**Tham số**:
- `@pMa_Cty` (tùy chọn): Mã công ty, mặc định rỗng.
- `@pUserName` (bắt buộc): Tên đăng nhập.
- `@pMenuID` (bắt buộc): Mã menu.
- `@pRet` (output): Kết quả quyền (0: không có quyền, >0: có quyền).

**Logic**:
1. Lấy basicright từ sysmenu.
2. Nếu không có, lấy tổng ViewRight từ sysUserRight.
3. Nếu không có, lấy tổng ViewRight từ sysGroupRight (các nhóm của người dùng).
4. Nếu vẫn không có quyền, RETURN.
5. Kiểm tra quyền công ty của người dùng (sysUserCompanyRight).
6. Nếu không có, kiểm tra quyền công ty của nhóm (sysGroupCompanyRight).
7. Gán tổng số quyền vào @pRet.

**Kết quả**: Giá trị output parameter @pRet.

**Sử dụng**: Gọi trước khi cho phép người dùng truy cập một chức năng.

### asChkSoCt

**Mục đích**: Kiểm tra trùng số chứng từ (so_ct) theo cấu hình kiểu trùng (theo tháng hoặc theo năm). Duyệt qua các bảng chứng từ con (nếu có) để đảm bảo tính duy nhất.

**Tham số** (tất cả bắt buộc):
- `@pMa_cty`: Mã công ty.
- `@pMa_ct`: Mã chứng từ (loại chứng từ).
- `@pStt_rec`: Số thứ tự bản ghi (để loại trừ chính bản ghi đang kiểm tra).
- `@pSo_ct`: Số chứng từ cần kiểm tra.
- `@pNgay_Ct`: Ngày chứng từ.
- `@pRet` (output): Số lượng chứng từ trùng (0: không trùng).

**Logic**:
- Lấy cấu hình `kieu_trung_so_ct` từ sidmct (0: không kiểm tra, 1: theo tháng, 2: theo năm).
- Nếu =0 thì RETURN.
- Xác định năm và tháng từ ngày chứng từ.
- Lấy mã chứng từ mẹ (nếu có) và duyệt qua các bảng con.
- Với mỗi bảng, đếm số chứng từ trùng với điều kiện cùng công ty, cùng loại chứng từ, cùng số chứng từ, cùng năm (và tháng nếu kiểu =1), loại trừ stt_rec hiện tại.
- Nếu tìm thấy trùng, dừng duyệt và trả về số lượng.

**Kết quả**: Giá trị output parameter @pRet.

**Sử dụng**: Gọi trước khi lưu chứng từ (insert/update) để đảm bảo số chứng từ không trùng.

### asChkUserLogin

**Mục đích**: Kiểm tra thông tin đăng nhập của người dùng, xác thực username/password, đồng thời trả về các quyền liên quan (admin, grand).

**Tham số**:
- `@pUserName` (bắt buộc): Tên đăng nhập.
- `@pPassword` (bắt buộc): Mật khẩu.
- `@pIsGrand` (output): Quyền ủy quyền (0/1).
- `@pIsAdmin` (output): Quyền quản trị (0/1).
- `@pOk` (output): Xác thực thành công (0/1).
- `@pMa_cty` (tùy chọn): Mã công ty, mặc định rỗng (hiện không sử dụng).

**Logic**:
- Đếm số bản ghi trong sysUSERINFO thỏa username, password, disabled = '0'.
- Nếu count = 0, RETURN (không tính quyền).
- Tính tổng ISADMIN và GRAND của người dùng.
- Gán các giá trị vào output parameters.

**Kết quả**: Ba output parameters @pOk, @pIsAdmin, @pIsGrand.

**Sử dụng**: Gọi khi người dùng đăng nhập vào hệ thống.

## Ghi chú chung

- Nhóm asChk* thường trả về kết quả kiểm tra dưới dạng số nguyên (count) hoặc output parameter.
- Nhiều procedure có output parameter, cần xử lý đặc biệt khi gọi qua ProcedureCaller (hiện chưa hỗ trợ output parameters).
- Các procedure này thường được gọi từ framework (Base - FrameWork.dll) để thực hiện validation và kiểm tra quyền.
- Đa số không thay đổi dữ liệu, chỉ đọc và kiểm tra.
- Khi gọi qua lớp PHP, sử dụng phương thức tĩnh `::call()` với mảng tham số tương ứng. Đối với output parameters, có thể cần sử dụng DB::statement trực tiếp.

## Tiến độ chuyển đổi

- Đã chuyển đổi: 5 procedures.
- Tổng số procedures trong nhóm: 5 (đã hoàn thành toàn bộ nhóm asChk* hiện có trong source SQL).

Cập nhật lần cuối: 2026-02-11