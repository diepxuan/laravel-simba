# SimbaSql Core Documentation

## 1. Project Overview

SimbaSql là database ERP (SQL Server) với 2,031 stored procedures, 440 tables, phát triển bởi Asia Software.

**Triết lý thiết kế:**
- Multi-company: Tất cả bảng có `ma_cty`
- SP-driven: Business logic trong stored procedures
- No ORM: Không dùng ORM
- Accounting-first: Kế toán là trung tâm

## 2. Architecture

### 3-Tier Architecture
```
Presentation (WinForms) → Business Logic (SP) → Data (SQL Server)
```

### Core Components
- **Framework**: Base classes, Voucher pattern
- **Modules**: GL, AR, AP, CA, SO, SI, PO, IN, FA, CO
- **Reports**: Dynamic report engine
- **Security**: Role-based access control

## 3. Database Design

### Naming Conventions
| Prefix | Meaning | Example |
|--------|---------|---------|
| `dmdb` | Danh mục | `dmdbCustomer` |
| `dmct` | Danh mục CT | `dmctVoucherType` |
| `ct` | Chi tiết | `ctGLVoucher` |
| `ph` | Phiếu/Header | `phSOOrder` |
| `as` | SP nghiệp vụ | `asGLInsVoucher` |
| `z` | SP tạm | `z_asGLGetVoucher` |

### Data Types
- `SMALLDATETIME`: Ngày giờ
- `NVARCHAR`: Unicode text
- `DECIMAL(19,4)`: Số tiền
- `UNIQUEIDENTIFIER`: GUID keys

## 4. Multi-Tenancy

```sql
-- Mọi bảng đều có ma_cty
CREATE TABLE dmdbCustomer (
    ma_cty VARCHAR(10),  -- Company ID
    ma_kh VARCHAR(20),   -- Customer ID
    ...
    PRIMARY KEY (ma_cty, ma_kh)
);
```

## 5. Security Model

- **Authentication**: Windows/SQL Server
- **Authorization**: Role-based
- **Audit**: cdate, cuser, ldate, luser
- **Encryption**: Connection string encrypted

## 6. Performance Guidelines

### Indexing
- Index trên các trường filter
- Composite keys: `(ma_cty, ngay_ct, ma_ct)`

### Query Optimization
- Dùng SP thay vì inline SQL
- Avoid SELECT *
- Use EXISTS thay v LEFT JOIN

## 7. Deployment

### Database Setup
```sql
-- Create database
CREATE DATABASE SimbaSql;

-- Deploy objects
:r "deploy_database.sql"
```

### Migration
- Backup trước khi deploy
- Test trên staging
- Deploy từng module

## 8. Error Handling

### SP Error Pattern
```sql
CREATE PROCEDURE asExample
    @ErrorCode INT OUTPUT,
    @ErrorMessage NVARCHAR(500) OUTPUT
AS
BEGIN
    SET @ErrorCode = 0;
    SET @ErrorMessage = '';
    
    BEGIN TRY
        -- Business logic
    END TRY
    BEGIN CATCH
        SET @ErrorCode = ERROR_NUMBER();
        SET @ErrorMessage = ERROR_MESSAGE();
    END CATCH
END;
```

### Error Codes
- 0: Success
- 1-99: Validation errors
- 100-199: Business rule violations
- 200+: System errors

## 9. Naming Convention

### Stored Procedures
```
as[Module][Action][Entity]

Examples:
- asGLInsVoucher    : GL Insert Voucher
- asSOGetOrder      : SO Get Order
- asARPost2GL       : AR Post to GL
```

### Tables
```
[Type][Module][Entity]

Examples:
- dmdbCustomer      : Danh mục Customer
- ctSOOrder         : Chi tiết SO Order
- phGLVoucher       : Phiếu GL Voucher
```

## 10. Module Interaction

### Interaction Matrix

```
            ┌─────────────────────────────────────────────────────────────┐
            │                    MODULE INTERACTION                       │
            ├──────────┬──────┬──────┬──────┬──────┬──────┬──────┬──────┤
            │   FROM   │  SI  │  GL  │  AR  │  AP  │  CA  │  PO  │  SO  │
            ├──────────┼──────┼──────┼──────┼──────┼──────┼──────┼──────┤
            │    SI    │  -   │  R   │  R   │  R   │  R   │  R   │  R   │
            ├──────────┼──────┼──────┼──────┼──────┼──────┼──────┼──────┤
            │    GL    │  R   │  -   │  W   │  W   │  W   │  R   │  R   │
            ├──────────┼──────┼──────┼──────┼──────┼──────┼──────┼──────┤
            │    AR    │  R   │  W   │  -   │  R   │  W   │  R   │  W   │
            ├──────────┼──────┼──────┼──────┼──────┼──────┼──────┼──────┤
            │    AP    │  R   │  W   │  R   │  -   │  W   │  W   │  R   │
            ├──────────┼──────┼──────┼──────┼──────┼──────┼──────┼──────┤
            │    CA    │  R   │  W   │  W   │  W   │  -   │  R   │  R   │
            ├──────────┼──────┼──────┼──────┼──────┼──────┼──────┼──────┤
            │    PO    │  R   │  R   │  R   │  W   │  R   │  -   │  R   │
            ├──────────┼──────┼──────┼──────┼──────┼──────┼──────┼──────┤
            │    SO    │  R   │  R   │  W   │  R   │  R   │  R   │  -   │
            └──────────┴──────┴──────┴──────┴──────┴──────┴──────┴──────┘

Legend: R = Read, W = Write, - = Self
```

### Hub: GL (General Ledger)
- Nhận dữ liệu từ TẤT CẢ modules (CA, AR, AP, IN, PO, SO, CO)
- Central repository cho financial transactions
- Tạo báo cáo tài chính

### Core: SI (System)
- Quản lý users, permissions, setup
- Cung cấp master data (SiDmTk, SiDmNv, SiDmThue)
- Control access qua `asGetRight`, `asGetSttRec`

## Quick Reference

### Module Counts
| Module | SPs | Tables |
|--------|-----|--------|
| GL | 313 | 45 |
| SO | 171 | 32 |
| AR | 94 | 28 |
| AP | 41 | 22 |
| IN | 146 | 38 |
| CA | 55 | 18 |
| FA | 58 | 25 |
| CO | 65 | 30 |
| PO | 127 | 35 |
| SI | 50 | 20 |

### Key Workflows
1. **Bán hàng**: SO → SI → AR → GL
2. **Mua hàng**: PO → IN → AP → GL
3. **Thu chi**: CA → GL
4. **Khấu hao**: FA → GL
5. **Sản xuất**: CO → GL
