# Utilities - Các chức năng tiện ích

Tổng hợp các stored procedures utility, generic operations và helper functions trong hệ thống SimbaSql.

---

## Tổng quan

**Purpose:** Cung cấp các chức năng tiện ích, generic operations dùng chung cho nhiều module.

**Tổng số:** ~150 procedures

---

## Categories

### 1. Process Operations (31 procedures)
```
asProcess*        - Xử lý nghiệp vụ chung
asProcessCT       - Xử lý chứng từ
asProcessCalLaiKU - Xử lý tính lãi
asProcessApPh*    - Xử lý AP
asProcessArPh*    - Xử lý AR
asProcessCaPh*    - Xử lý CA
asProcessGlPh*    - Xử lý GL
asProcessInPh*    - Xử lý IN
asProcessPoPh*    - Xử lý PO
asProcessSoPh*    - Xử lý SO
```

### 2. Generic Get Operations (30 procedures)
```
asGet*            - Đọc dữ liệu chung
asGetAll*         - Đọc tất cả
asGetCompanyInfo  - Thông tin công ty
asGetUserInfo     - Thông tin user
asGetMenu*        - Menu hệ thống
asGetRight*       - Quyền user
asGetReport*      - Báo cáo
asGetVoucher*     - Chứng từ
```

### 3. Generic Insert Operations (25 procedures)
```
asIns*            - Thêm mới chung
asInsLog*         - Log operations
asInsReport*      - Thêm báo cáo
asInsMenu*        - Thêm menu
asInsUser*        - Thêm user
asInsVoucher*     - Thêm chứng từ
```

### 4. Generic Update Operations (20 procedures)
```
asUpd*            - Cập nhật chung
asUpdReport*      - Cập nhật báo cáo
asUpdUser*        - Cập nhật user
asUpdVoucher*     - Cập nhật chứng từ
asUpdSysVar       - Cập nhật system variables
```

### 5. Generic Delete Operations (15 procedures)
```
asDel*            - Xóa chung
asDelReport*      - Xóa báo cáo
asDelUser*        - Xóa user
asDelVoucher*     - Xóa chứng từ
asDelGroup*       - Xóa nhóm
```

### 6. Check/Validation Operations (10 procedures)
```
asChk*            - Kiểm tra
asCheck*          - Validate
asChkCodeExists   - Kiểm tra mã tồn tại
asChkUserLogin    - Kiểm tra đăng nhập
asChkSoCt         - Kiểm tra số chứng từ
asChkExecRight    - Kiểm tra quyền thực thi
```

### 7. Lookup Operations (5 procedures)
```
asLookup*         - Tìm kiếm
asLookupCodmbom   - Tìm BOM
```

### 8. System Operations (10 procedures)
```
asSys*            - Hệ thống
asSysCreateCompany - Tạo công ty
asSysCopyDatabase  - Copy database
asSysDelAllData    - Xóa toàn bộ data
asSysUpdCompany    - Cập nhật công ty
```

### 9. Dashboard Operations (5 procedures)
```
asDash*           - Dashboard
asDashGetParameter - Tham số dashboard
asDashExample     - Ví dụ dashboard
```

---

## Common Patterns

### Process Pattern
```sql
-- Xử lý nghiệp vụ chung
EXEC asProcessCT
    @Ma_cty = '001',
    @Stt_rec = 'REC001',
    @Action = 'POST',
    @LUser = 'admin'
```

### Generic Get Pattern
```sql
-- Đọc thông tin chung
EXEC asGetCompanyInfo
    @Ma_cty = '001'

EXEC asGetUserInfo
    @UserName = 'admin'
```

### Check Pattern
```sql
-- Kiểm tra trước khi thực hiện
EXEC asChkCodeExists
    @Ma_cty = '001',
    @TableName = 'DMVT',
    @Code = 'VT001',
    @Exists OUTPUT
```

---

## Integration

Các utility procedures được sử dụng bởi tất cả modules:
- CA, GL, PO, SO, AR, AP, IN, CO, SI, HR, FA, SA

---

## Related Documentation

- [docs/catalog/PROCEDURE_CATALOG.md](../../catalog/PROCEDURE_CATALOG.md)
- [docs/09_NAMING_CONVENTION.md](../../09_NAMING_CONVENTION.md)

---

*Last updated: 2026-03-12*


---

## Technical Reference

| Document | Description |
|----------|-------------|
| [Database Schema](../../dbo/Tables/) | Cấu trúc bảng dữ liệu |
| [Module Index](../../catalog/PROCEDURES.md) | Danh mục procedures |

## Related Modules

| Module | Description |
|--------|-------------|
| [All Modules](../) | Tất cả các module |

---

# End of UTILITIES Module Documentation
