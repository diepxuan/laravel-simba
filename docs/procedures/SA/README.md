# Salary & Payroll (SA) - Tiền lương và Bảng lương

Module quản lý tiền lương, bảng lương, quỹ lương và các khoản trích nộp bảo hiểm, thuế TNCN.

---

## Tổng quan

**Purpose:** Quản lý toàn bộ quy trình tính lương, quỹ lương và các báo cáo liên quan đến tiền lương của nhân viên.

**Key Functions:**
- Quản lý bảng lương theo tháng/năm
- Quản lý quỹ lương theo bộ phận
- Tính toán các khoản trích nộp (BHXH, BHYT, công đoàn)
- Tính thuế thu nhập cá nhân (TNCN)
- Báo cáo phiếu lương, bảng lương chi tiết
- Khóa/mở bảng lương với mật khẩu bảo vệ
- Tính lương làm thêm giờ (overtime)

---

## Database Tables

### Primary Tables
```
SaBangLuong    - Bảng lương chi tiết theo nhân viên
SaQuyLuong     - Quỹ lương theo bộ phận
SaSetup        - Tham số thiết lập phân hệ lương
```

### Master Data
```
SaBangLuongFields      - Cấu hình field hiển thị bảng lương
SaBangLuongFieldsResx  - Đa ngôn ngữ field bảng lương
HrDmCcTc               - Danh mục cơ cấu tổ chức (HR)
HrDmOrther             - Danh mục chức vụ (HR)
HrHsns                 - Hồ sơ nhân sự (HR)
```

### Configuration
```
SaSetup.G_ML_TT        - Mức lương tối thiểu toàn quốc
SaSetup.G_TL_DPCD      - Tỷ lệ đoàn phí công đoàn
```

---

## Stored Procedures

**Tổng số:** 22 procedures

### Categories

#### 1. Get Operations (Đọc dữ liệu)
```
asSaGetbangluong        - Đọc bảng lương theo tháng/năm/bộ phận
asSaGetQuyLuong         - Đọc quỹ lương theo tháng/năm
asSaGetSetup            - Lấy tham số thiết lập phân hệ lương
asSaGetBangLuongFields  - Lấy cấu hình field hiển thị bảng lương
```

#### 2. Insert/Update Operations (Thêm/Cập nhật)
```
asSaUpdbangluong        - Cập nhật bảng lương nhân viên
asSaUpdQuyLuong         - Cập nhật quỹ lương bộ phận
asSaCreateQuyLuong      - Tạo quỹ lương từ cơ cấu tổ chức
```

#### 3. Delete Operations (Xóa)
```
asSaDelbangluong        - Xóa bảng lương nhân viên
asSaDelQuyLuong         - Xóa quỹ lương bộ phận
```

#### 4. Check Operations (Kiểm tra)
```
asSaChkExistQuyLuong    - Kiểm tra quỹ lương đã tồn tại
asSaCheckKhoaBL         - Kiểm tra trạng thái khóa bảng lương
```

#### 5. Lock Operations (Khóa/Mở)
```
asSaKhoaMoBL            - Khóa/Mở/Đổi mật khẩu bảng lương
```

#### 6. Report Operations (Báo cáo)
```
asSaRptBangLuong01      - Bảng thanh toán tiền lương (theo bộ phận)
asSaRptBangLuong02      - Bảng thanh toán tiền lương (theo nhân viên)
asSaRptPhieuLuong       - Phiếu lương cá nhân
asSaRptTongQuyLuong     - Báo cáo tổng quỹ lương
asSaRptPhiBHXH          - Báo cáo trích nộp BHXH
asSaRptPhiCongDoan      - Bảng trích nộp đoàn phí công đoàn
asSaRptThueTNCN         - Bảng trích nộp thuế TNCN
asSaRptTamUng           - Bảng thanh toán tạm ứng
asSaRptThemGio          - Bảng lương làm thêm giờ
asSaRptDynBangLuong     - Báo cáo động bảng lương tùy chọn
```

---

## Business Flows

### 1. Tạo Quỹ Lương (Salary Fund Creation)
```
Period Start
      ↓
1. asSaCreateQuyLuong - Tạo quỹ lương từ cơ cấu tổ chức
      ↓
2. asSaGetQuyLuong - Xem quỹ lương
      ↓
3. asSaUpdQuyLuong - Cập nhật quỹ lương (nếu cần)
      ↓
4. Quỹ lương sẵn sàng cho tính lương
```

### 2. Tính Lương (Payroll Calculation)
```
Chấm công từ HR
      ↓
1. Tính công theo các loại (cb, sp, le, phep, om...)
      ↓
2. Tính lương theo công: Luong_cb, Luong_sp...
      ↓
3. Tính lương làm thêm giờ: Luong_tg (75%, 100%, 150%...)
      ↓
4. Tính phụ cấp: Pc_tn, Pc_th, Phu_cap...
      ↓
5. Tính tổng lương: Tong_luong
      ↓
6. Trừ các khoản: Tam_ung, Bhxh, Bhyt, Thue_tn...
      ↓
7. Thực lĩnh: Thuc_linh = Tong_luong - Các khoản trừ
      ↓
8. asSaUpdbangluong - Lưu bảng lương
```

### 3. Khóa Bảng Lương (Payroll Lock)
```
Bảng lương hoàn tất
      ↓
1. asSaCheckKhoaBL - Kiểm tra trạng thái
      ↓
2. asSaKhoaMoBL (Khoa=1) - Khóa bảng lương
      ↓
3. Nhập mật khẩu bảo vệ
      ↓
4. Bảng lương được khóa
      ↓
5. Muốn sửa: asSaKhoaMoBL (Khoa=0) + nhập mật khẩu
```

### 4. Báo Cáo Lương (Payroll Reporting)
```
Bảng lương đã khóa
      ↓
1. asSaRptBangLuong01 - Bảng lương theo bộ phận
      ↓
2. asSaRptPhieuLuong - In phiếu lương cho NV
      ↓
3. asSaRptTongQuyLuong - Tổng hợp quỹ lương
      ↓
4. asSaRptPhiBHXH - Báo cáo BHXH
      ↓
5. asSaRptThueTNCN - Báo cáo thuế TNCN
```

---

## Key Parameters

### Common Parameters
```sql
@pMa_cty       -- Mã công ty (Company ID)
@pThang        -- Tháng (Month)
@pNam          -- Năm (Year)
@pMa_bp        -- Mã bộ phận (Department ID)
@pMa_nv        -- Mã nhân viên (Employee ID)
@pMa_cv        -- Mã chức vụ (Position ID)
@pBHXH         -- Lọc BHXH: 1=Tất cả, 2=Có, 3=Không
@pUser         -- Người dùng thực hiện
@pRet          -- Return code (output)
```

### Salary Fields
```sql
-- Công làm việc
Cong_cb        -- Công chuẩn
Cong           -- Công thực tế
Cong_sp        -- Công sản phẩm
Cong_le        -- Công lễ
Cong_phep      -- Công phép
Cong_om        -- Công ốm
Cong_tg        -- Công tăng ca (thêm giờ)

-- Lương
Luong_cb       -- Lương cơ bản
Luong_cong     -- Lương theo công
Luong_sp       -- Lương sản phẩm
Luong_tg       -- Lương tăng ca
Tong_luong     -- Tổng lương
Thuc_linh      -- Thực lĩnh

-- Hệ số
Hsl_cb         -- Hệ số lương cơ bản
Hsl_cv         -- Hệ số lương chức vụ
Hs_loai        -- Hệ số loại nhân viên

-- Trích nộp
Bhxh           -- Bảo hiểm xã hội
Bhyt           -- Bảo hiểm y tế
Dpcd           -- Đoàn phí công đoàn
Thue_tn        -- Thuế thu nhập
Tam_ung        -- Tạm ứng
```

---

## Usage Examples

### 1. Tạo Quỹ Lương
```sql
-- Tạo quỹ lương tháng 3/2026 cho tất cả bộ phận
EXEC asSaCreateQuyLuong
    @pMa_cty = '001',
    @pThang = 3,
    @pNam = 2026,
    @pMa_bp = NULL,
    @pRet = @output_ret OUTPUT
```

### 2. Đọc Bảng Lương
```sql
-- Lấy bảng lương tháng 3/2026
EXEC asSaGetbangluong
    @pMa_cty = '001',
    @pThang = 3,
    @pNam = 2026,
    @pMa_bp = NULL,
    @pId_nv = NULL,
    @pMa_nv = NULL
```

### 3. Cập Nhật Bảng Lương
```sql
-- Cập nhật thông tin lương nhân viên
EXEC asSaUpdbangluong
    @pMa_cty = '001',
    @pThang = 3,
    @pNam = 2026,
    @pMa_bp = 'BP001',
    @pTen_bp = 'Phòng Kế toán',
    @pId_nv = 'NV001',
    @pMa_nv = 'A-001',
    @pTen_nv = 'Nguyen Van A',
    @pCong = 22,
    @pTong_luong = 15000000,
    @pThuc_linh = 13000000,
    @pUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 4. Khóa Bảng Lương
```sql
-- Khóa bảng lương tháng 3/2026
EXEC asSaKhoaMoBL
    @pMa_cty = '001',
    @pThang = 3,
    @pNam = 2026,
    @pMa_bp = 'BP001',
    @pKhoa = '1',          -- 1: Khóa, 0: Mở, 2: Đổi mật khẩu
    @pMatKhau1 = '123456', -- Mật khẩu mới
    @pMatKhau2 = '',
    @pRet = @output_ret OUTPUT
```

### 5. Báo Cáo Bảng Lương
```sql
-- Bảng thanh toán tiền lương
EXEC asSaRptBangLuong01
    @pMa_cty = '001',
    @pThang = 3,
    @pNam = 2026,
    @pMa_bp = '',
    @pMa_cv = '',
    @pMa_nv = '',
    @pBHXH = '1'           -- 1: Tất cả
```

### 6. Phiếu Lương Cá Nhân
```sql
-- In phiếu lương nhân viên
EXEC asSaRptPhieuLuong
    @pMa_cty = '001',
    @pThang = 3,
    @pNam = 2026,
    @pMa_bp = '',
    @pMa_nv = 'A-001'
```

### 7. Báo Cáo BHXH
```sql
-- Báo cáo trích nộp BHXH năm 2026
EXEC asSaRptPhiBHXH
    @pMa_cty = '001',
    @pNam = 2026,
    @pMa_bp = ''
```

### 8. Báo Cáo Thuế TNCN
```sql
-- Bảng trích nộp thuế TNCN tháng 3/2026
EXEC asSaRptThueTNCN
    @pMa_cty = '001',
    @pThang = 3,
    @pNam = 2026,
    @pMa_bp = ''
```

---

## Integration Points

### 1. Human Resources (HR)
- Lấy thông tin nhân viên từ HrHsns
- Lấy cơ cấu tổ chức từ HrDmCcTc
- Lấy chức vụ từ HrDmOrther
- Link: HR → SA (thông tin nhân sự)

### 2. General Ledger (GL)
- Post chi phí lương vào GL
- Post BHXH, BHYT, công đoàn vào GL
- Link: SA → GL (hạch toán chi phí)

### 3. Cash & Banking (CA)
- Thanh toán lương qua ngân hàng
- Tạm ứng lương
- Link: SA → CA (thanh toán)

---

## Validation Rules

### 1. Amount Validation
```
Tong_luong >= 0
Thuc_linh >= 0
Bhxh >= 0
Bhyt >= 0
Thue_tn >= 0
```

### 2. Period Validation
```
Thang IN (1, 2, ..., 12)
Nam > 2000
```

### 3. Lock Validation
```
IF Khoa = 1 THEN Không được sửa
IF Sai mat khau THEN Không được mở khóa
```

### 4. Department Validation
```
Ma_bp phải tồn tại trong HrDmCcTc
Không khóa/mở ở bộ phận mẹ (có con)
```

---

## Error Handling

### Common Errors
```
Error 0    - Thành công
Error 1    - Lỗi chung
Error 2    - Không khóa/mở ở bộ phận mẹ
Error 3    - Không khóa/mở ở bộ phận mẹ (có con)
Error 4    - Sai mật khẩu khi mở
Error 5    - Sai mật khẩu cũ khi đổi
```

### Error Handling Pattern
```sql
BEGIN TRY
    EXEC asSaKhoaMoBL ...
    
    IF @pRet <> 0
    BEGIN
        -- Xử lý theo return code
        RETURN
    END
END TRY
BEGIN CATCH
    DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE()
    RAISERROR(@ErrMsg, 16, 1)
END CATCH
```

---

## Performance Guidelines

### Indexing Strategy
```sql
-- Recommended indexes
CREATE INDEX IX_SaBangLuong_Ma_cty ON SaBangLuong(Ma_cty)
CREATE INDEX IX_SaBangLuong_Thang_Nam ON SaBangLuong(Thang, Nam)
CREATE INDEX IX_SaBangLuong_Ma_bp ON SaBangLuong(Ma_bp)
CREATE INDEX IX_SaBangLuong_Ma_nv ON SaBangLuong(Ma_nv)
CREATE INDEX IX_SaQuyLuong_Ma_cty ON SaQuyLuong(Ma_cty)
```

### Query Optimization
```sql
-- Sử dụng afChkMa_Bp để kiểm tra bộ phận
WHERE dbo.afChkMa_Bp(@pMa_cty, Ma_bp, @pMa_bp) = 1

-- Lọc theo tháng/năm
WHERE Thang = @pThang AND Nam = @pNam
```

---

## Security & Permissions

### Role-based Access
```
ROLE_SA_ADMIN     - Full access
ROLE_SA_CREATE    - Tạo/cập nhật bảng lương
ROLE_SA_VIEW      - Xem báo cáo
ROLE_SA_REPORT    - In báo cáo
ROLE_SA_LOCK      - Khóa/mở bảng lương
```

### Row-level Security
```sql
-- Users chỉ thấy data của bộ phận được assign
CREATE VIEW SaBangLuong_vw AS
SELECT * FROM SaBangLuong
WHERE Ma_bp IN (SELECT Ma_bp FROM UserDept WHERE User = CURRENT_USER)
```

---

## Audit Trail

### Tracked Fields
```
Cuser       - Người tạo
Cdate       - Ngày tạo
Luser       - Người sửa cuối
Ldate       - Ngày sửa cuối
Khoa        - Trạng thái khóa
Pass        - Mật khẩu khóa (encrypted)
```

---

## Related Documentation

### Workflows
- [docs/flows/payroll_workflow.md](../../flows/payroll_workflow.md) - Quy trình tính lương
- [docs/flows/hr_workflow.md](../../flows/hr_workflow.md) - Quy trình nhân sự

### Core Docs
- [docs/modules/HR/README.md](../HR/README.md) - Module Nhân sự
- [docs/modules/GL/README.md](../GL/README.md) - Module Tổng hợp
- [docs/DATA_DICTIONARY.md](../../DATA_DICTIONARY.md) - Định nghĩa cột

---

## Change History

| Date | Version | Change | Author |
|------|---------|--------|--------|
| 2026-03-12 | 1.0 | Initial documentation | Bột |

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
| [GL](../GL/) | General Ledger - Sổ cái |
| [HR](../HR/) | Human Resources - Nhân sự |

---

# End of SA Module Documentation
