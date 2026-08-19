# Nhóm asGet* - Get Data Procedures

Nhóm `asGet*` chứa các stored procedure dùng để lấy dữ liệu (SELECT) từ cơ sở dữ liệu. Đây là nhóm lớn nhất với khoảng 92 procedures, bao gồm các thao tác lấy danh mục, thông tin hệ thống, quyền người dùng, dữ liệu tra cứu, v.v.

## Tiến độ chuyển đổi

- **Tổng số procedures ước tính**: 92 (theo số file asGet*.sql).
- **Đã chuyển đổi**: 17 (cập nhật 2026-02-11)
- **Tỷ lệ hoàn thành**: 18.5%

## Danh sách procedures đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asGetAllCompanyInfo | `AsGetAllCompanyInfo` | `@pLanguage` (nvarchar(5), default 'vi-VN') | Lấy thông tin tất cả công ty đang hoạt động, với hỗ trợ đa ngôn ngữ. |
| asGetAllDAOInfo | `AsGetAllDAOInfo` | (none) | Lấy toàn bộ thông tin từ bảng sysDAOInfo (cấu hình DAO). |
| asGetAllLanguage | `AsGetAllLanguage` | (none) | Lấy danh sách ngôn ngữ đang được sử dụng (ksd = 1). |
| asGetAllMenus | `AsGetAllMenus` | `@pLanguage` (nvarchar(5), default 'vi-VN') | Lấy danh sách đầy đủ các menu hệ thống với hỗ trợ đa ngôn ngữ. |
| asGetAllRightCompany | `AsGetAllRightCompany` | `@pUserName` (nvarchar(20)) | Lấy danh sách quyền của User đối với các công ty. |
| asGetAllRightDash | `AsGetAllRightDash` | `@pUserName` (nvarchar(20)), `@pLanguage` (nvarchar(5), default 'vi-VN') | Lấy danh sách quyền của User trên màn hình chủ (dashboard). |
| asGetAllRightGroupCompany | `AsGetAllRightGroupCompany` | `@pGroupName` (nvarchar(20)) | Lấy danh sách các quyền của Group đối với các công ty. |
| asGetAllUserRights | `AsGetAllUserRights` | `@pUserName` (nvarchar(20)), `@pLanguage` (nvarchar(5), default 'vi-VN') | Lấy tất cả các quyền của một người dùng để phân quyền. |
| asGetArkhInfo_SO | `AsGetArkhInfo_SO` | `@pMa_cty` (nvarchar(3)), `@pMa_kh` (nvarchar(20)), `@pThang` (int), `@pNam` (int) | Lấy thông tin khách hàng cho Hóa đơn mã chứng từ = 'SO3'. |
| asGetCODMPBCachTinhHS | `AsGetCODMPBCachTinhHS` | `@pMa_cty` (nvarchar(3), default NULL), `@pKsd` (bit, default 0), `@pModuleId` (nvarchar(8), default 'CO'), `@pLanguage` (nvarchar(5), default 'vi-VN') | Lấy danh sách cách tính hệ số phân bổ (CODMPBCachTinhHS) theo công ty, module và trạng thái sử dụng. |
| asGetCOdd | `AsGetCOdd` | `@pMa_cty` (nvarchar(3)), `@pNam` (int), `@pThang` (int), `@pMa_spct` (nvarchar(20), default ''), `@pTk` (nvarchar(20), default '') | Lấy dữ liệu dở dang (codd) theo công ty, năm, tháng, mã sản phẩm công trình và tài khoản. |
| asGetCalcInfo | `AsGetCalcInfo` | `@pMenuID` (nvarchar(8), default '') | Lấy thông tin tính toán (sysCalcInfo) theo MenuID. |
| asGetCompanyInfo | `AsGetCompanyInfo` | `@pMa_cty` (nvarchar(3)), `@pLanguage` (nvarchar(5), default 'vi-VN') | Lấy thông tin chi tiết của một công ty theo mã công ty, với hỗ trợ đa ngôn ngữ. |
| asGetCompanyInfoByUserName | `AsGetCompanyInfoByUserName` | `@pUserName` (nvarchar(20), default ''), `@pLanguage` (nvarchar(5), default 'vi-VN') | Lấy thông tin công ty mà user có quyền truy cập, với hỗ trợ đa ngôn ngữ. |
| asGetCultureInfo | `AsGetCultureInfo` | (none) | Lấy danh sách ngôn ngữ (culture) từ bảng [Language], loại bỏ trùng lặp. |
| asGetCurrentCultureInfo | `AsGetCurrentCultureInfo` | (none) | Lấy ngôn ngữ hiện tại được chọn (selected = '1') từ bảng sysLanguage. |
| asGetDAOInfo | `AsGetDAOInfo` | `@pTableName` (nvarchar(50)) | Lấy thông tin DAO (Data Access Object) theo tên bảng. |

## Chi tiết từng procedure

### asGetAllCompanyInfo

**Mục đích**: Lấy thông tin tất cả công ty đang hoạt động, với hỗ trợ đa ngôn ngữ.

**Tham số**:
- `@pLanguage` (nvarchar(5), tùy chọn, mặc định 'vi-VN'): Mã ngôn ngữ.

**Kết quả**: Các cột thông tin công ty: mã, tên, địa chỉ, điện thoại, mã thuế, fax, ngân hàng, giám đốc, kế toán trưởng, email...

**Ví dụ**:
```php
$rows = AsGetAllCompanyInfo::call(['pLanguage' => 'vi-VN']);
```

### asGetAllDAOInfo

**Mục đích**: Lấy toàn bộ thông tin từ bảng sysDAOInfo (cấu hình DAO - Data Access Object).

**Tham số**: Không có.

**Kết quả**: Tất cả cột của bảng sysDAOInfo (id, name, connection_string, provider, is_default, active...).

**Ví dụ**:
```php
$rows = AsGetAllDAOInfo::call();
```

### asGetAllLanguage

**Mục đích**: Lấy danh sách ngôn ngữ đang được sử dụng (có cờ ksd = 1).

**Tham số**: Không có.

**Kết quả**: Cột Name (tên ngôn ngữ) và Description (mô tả).

**Ví dụ**:
```php
$rows = AsGetAllLanguage::call();
```

### asGetAllMenus

**Mục đích**: Lấy danh sách đầy đủ các menu hệ thống với hỗ trợ đa ngôn ngữ.

**Tham số**:
- `@pLanguage` (nvarchar(5), tùy chọn, mặc định 'vi-VN'): Mã ngôn ngữ.

**Kết quả**: Các cột thông tin menu: stt, moduleid, bar (tên hiển thị), short_name, menuid, dllName, command, code_name, report, basicright, form, opt, par1-par8, picture1, picture2, rowid, developer, maintainer, used, active.

**Ví dụ**:
```php
$rows = AsGetAllMenus::call(['pLanguage' => 'vi-VN']);
```

### asGetAllRightCompany

**Mục đích**: Lấy danh sách quyền của User đối với các công ty.

**Tham số**:
- `@pUserName` (nvarchar(20), bắt buộc): Tên đăng nhập user.

**Kết quả**: Cột ma_cty, ten_cty, Username (tên user hoặc @pUserName), Active (1 nếu có quyền, 0 nếu không).

**Ví dụ**:
```php
$rows = AsGetAllRightCompany::call(['pUserName' => 'admin']);
```

### asGetAllRightDash

**Mục đích**: Lấy danh sách quyền của User trên màn hình chủ (dashboard).

**Tham số**:
- `@pUserName` (nvarchar(20), bắt buộc): Tên đăng nhập user.
- `@pLanguage` (nvarchar(5), tùy chọn, mặc định 'vi-VN'): Mã ngôn ngữ.

**Kết quả**: Các cột functionId, stt, description (mô tả chức năng), viewright, updateright, deleteright, insertright, cuser, luser, cdate, ldate.

**Ví dụ**:
```php
$rows = AsGetAllRightDash::call(['pUserName' => 'admin', 'pLanguage' => 'vi-VN']);
```

### asGetAllRightGroupCompany

**Mục đích**: Lấy danh sách các quyền của Group đối với các công ty.

**Tham số**:
- `@pGroupName` (nvarchar(20), bắt buộc): Tên nhóm.

**Kết quả**: Cột ma_cty, ten_cty, active ('1' nếu nhóm có quyền, '0' nếu không).

**Ví dụ**:
```php
$rows = AsGetAllRightGroupCompany::call(['pGroupName' => 'Administrators']);
```

### asGetAllUserRights

**Mục đích**: Lấy tất cả các quyền của một người dùng để phân quyền.

**Tham số**:
- `@pUserName` (nvarchar(20), bắt buộc): Tên đăng nhập user.
- `@pLanguage` (nvarchar(5), tùy chọn, mặc định 'vi-VN'): Mã ngôn ngữ.

**Kết quả**: Các cột MenuID, bar (tên menu), BasicRight, LinkDetail, Link, ViewRight, UpdateRight, DeleteRight, InsertRight, LimitedPrint.

**Ví dụ**:
```php
$rows = AsGetAllUserRights::call(['pUserName' => 'admin']);
```

### asGetArkhInfo_SO

**Mục đích**: Lấy thông tin khách hàng cho Hóa đơn mã chứng từ = 'SO3'.

**Tham số**:
- `@pMa_cty` (nvarchar(3), bắt buộc): Mã công ty.
- `@pMa_kh` (nvarchar(20), bắt buộc): Mã khách hàng.
- `@pThang` (int, bắt buộc): Tháng.
- `@pNam` (int, bắt buộc): Năm.

**Kết quả**: Các chỉ số tài chính: dư hiện thời, hóa đơn, hóa đơn chưa tất toán, phiếu thu, hóa đơn cuối, phiếu thu cuối.

**Ví dụ**:
```php
$rows = AsGetArkhInfo_SO::call([
    'pMa_cty' => '001',
    'pMa_kh' => 'KH001',
    'pThang' => 10,
    'pNam' => 2023,
]);
```

### asGetCODMPBCachTinhHS

**Mục đích**: Lấy danh sách cách tính hệ số phân bổ (CODMPBCachTinhHS) theo công ty, module và trạng thái sử dụng.

**Tham số**:
- `@pMa_cty` (nvarchar(3), tùy chọn, mặc định NULL): Mã công ty (nên truyền giá trị hợp lệ).
- `@pKsd` (bit, tùy chọn, mặc định 0): Trạng thái sử dụng (0: ngừng, 1: đang sử dụng).
- `@pModuleId` (nvarchar(8), tùy chọn, mặc định 'CO'): Mã module.
- `@pLanguage` (nvarchar(5), tùy chọn, mặc định 'vi-VN'): Mã ngôn ngữ.

**Kết quả**: Cột id, ten (tên cách tính).

**Ví dụ**:
```php
$rows = AsGetCODMPBCachTinhHS::call([
    'pMa_cty' => '001',
    'pKsd' => 1,
    'pModuleId' => 'CO',
]);
```

### asGetCOdd

**Mục đích**: Lấy dữ liệu dở dang (codd) theo công ty, năm, tháng, mã sản phẩm công trình và tài khoản.

**Tham số**:
- `@pMa_cty` (nvarchar(3), bắt buộc): Mã công ty.
- `@pNam` (int, bắt buộc): Năm.
- `@pThang` (int, bắt buộc): Tháng.
- `@pMa_spct` (nvarchar(20), tùy chọn, mặc định ''): Mã sản phẩm công trình.
- `@pTk` (nvarchar(20), tùy chọn, mặc định ''): Tài khoản.

**Kết quả**: Các cột ma_cty, nam, thang, tk, ma_spct, sl_dd_ck, gt_dd_ck.

**Ví dụ**:
```php
$rows = AsGetCOdd::call([
    'pMa_cty' => '001',
    'pNam' => 2023,
    'pThang' => 10,
    'pMa_spct' => 'SPCT001',
    'pTk' => '154',
]);
```

### asGetCalcInfo

**Mục đích**: Lấy thông tin tính toán (sysCalcInfo) theo MenuID.

**Tham số**:
- `@pMenuID` (nvarchar(8), tùy chọn, mặc định ''): Mã menu.

**Kết quả**: Tất cả cột của bảng sysCalcInfo.

**Ví dụ**:
```php
$rows = AsGetCalcInfo::call(['pMenuID' => 'CO']);
```

### asGetCompanyInfo

**Mục đích**: Lấy thông tin chi tiết của một công ty theo mã công ty, với hỗ trợ đa ngôn ngữ.

**Tham số**:
- `@pMa_cty` (nvarchar(3), bắt buộc): Mã công ty.
- `@pLanguage` (nvarchar(5), tùy chọn, mặc định 'vi-VN'): Mã ngôn ngữ.

**Kết quả**: Các cột thông tin công ty: mã, tên, địa chỉ, điện thoại, mã thuế, fax, ngân hàng, giám đốc, kế toán trưởng, email...

**Ví dụ**:
```php
$rows = AsGetCompanyInfo::call(['pMa_cty' => '001']);
```

### asGetCompanyInfoByUserName

**Mục đích**: Lấy thông tin công ty mà user có quyền truy cập, với hỗ trợ đa ngôn ngữ.

**Tham số**:
- `@pUserName` (nvarchar(20), tùy chọn, mặc định ''): Tên đăng nhập user.
- `@pLanguage` (nvarchar(5), tùy chọn, mặc định 'vi-VN'): Mã ngôn ngữ.

**Kết quả**: Các cột thông tin công ty tương tự asGetCompanyInfo, thêm cột fullname.

**Ví dụ**:
```php
$rows = AsGetCompanyInfoByUserName::call(['pUserName' => 'admin']);
```

### asGetCultureInfo

**Mục đích**: Lấy danh sách ngôn ngữ (culture) từ bảng [Language], loại bỏ trùng lặp.

**Tham số**: Không có.

**Kết quả**: Cột Name (tên ngôn ngữ) và Description (mô tả).

**Ví dụ**:
```php
$rows = AsGetCultureInfo::call();
```

### asGetCurrentCultureInfo

**Mục đích**: Lấy ngôn ngữ hiện tại được chọn (selected = '1') từ bảng sysLanguage.

**Tham số**: Không có.

**Kết quả**: Cột Name (tên ngôn ngữ được chọn).

**Ví dụ**:
```php
$rows = AsGetCurrentCultureInfo::call();
```

### asGetDAOInfo

**Mục đích**: Lấy thông tin DAO (Data Access Object) theo tên bảng.

**Tham số**:
- `@pTableName` (nvarchar(50), bắt buộc): Tên bảng.

**Kết quả**: Tất cả cột của bảng sysDAOInfo.

**Ví dụ**:
```php
$rows = AsGetDAOInfo::call(['pTableName' => 'incdvt']);
```

## Hướng dẫn sử dụng

1. **Import class**:
   ```php
   use Diepxuan\LaravelSimba\StoredProcedures\AsGetAllCompanyInfo;
   ```

2. **Gọi procedure**:
   ```php
   $result = AsGetAllCompanyInfo::call(['pLanguage' => 'vi-VN']);
   ```

3. **Xử lý kết quả**:
   - Kết quả là mảng các đối tượng stdClass hoặc mảng kết hợp (tùy cấu hình PDO).
   - Duyệt qua kết quả để lấy dữ liệu.

## Kế hoạch tiếp theo

- Tiếp tục chuyển đổi các procedures asGet* còn lại theo thứ tự alphabet.
- Ưu tiên các procedures có tên ngắn, tham số ít.
- Cập nhật tài liệu sau mỗi lô chuyển đổi.

## Liên kết

- [Simba SQL Source](../../SimbaSql/dbo/StoredProcedures/)
- [Stored Procedures Classes](../src/StoredProcedures/)
- [Tổng hợp PROCEDURES.md](../PROCEDURES.md)