# SimbaSql Project Guide

## TL;DR

SimbaSql là database ERP (SQL Server) với 2,031 stored procedures, 440 tables, hỗ trợ 10+ modules nghiệp vụ. Code gốc từ Asia App (VB.NET/WinForms) đã được decompile để tham khảo logic.

---

## 1. Kiến trúc Tổng quan

```
┌─────────────────────────────────────────────────────────────┐
│  CLIENT (Asia ERP App - VB.NET WinForms)                    │
│  ├── GLVchGL1.dll (Phiếu kế toán)                          │
│  ├── SOVchSO1.dll (Đơn hàng bán)                           │
│  ├── INVchIN1.dll (Nhập kho)                               │
│  └── ... 147+ DLLs                                         │
├─────────────────────────────────────────────────────────────┤
│  DATABASE (SimbaSql - SQL Server)                          │
│  ├── Stored Procedures (2,031): as*, z*, sp*               │
│  ├── Tables (440): dmdb*, dmct*, ct*, ph*                  │
│  └── Views (4)                                             │
└─────────────────────────────────────────────────────────────┘
```

---

## 2. Quy ước Đặt tên

### Stored Procedures
| Prefix | Ý nghĩa | Ví dụ |
|--------|---------|-------|
| `as` | Nghiệp vụ chính | `asGLInsVoucher`, `asSOGetOrder` |
| `z` | Tạm/Sao lưu | `z_asGLGetVoucher` |
| `sp` | Hệ thống | `spUtil_ReIndexDatabase` |
| `af` | Aggregate functions | `afGLGetBalance` |

### Tables
| Prefix | Ý nghĩa | Ví dụ |
|--------|---------|-------|
| `dmdb` | Danh mục đối tượng | `dmdbCustomer`, `dmdbItem` |
| `dmct` | Danh mục chứng từ | `dmctVoucherType` |
| `ct` | Chi tiết chứng từ | `ctGLVoucher`, `ctSOOrder` |
| `ph` | Phiếu/Header | `phGLVoucher`, `phSOOrder` |

---

## 3. Modules & Functions

### 3.1 GL (General Ledger) - Kế toán tổng hợp
**File DLL gốc:** `GLVchGL1.dll`, `GLPost2GL.dll`, `GLCDTK.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Lập phiếu kế toán | `asGLInsVoucher` | Insert/update phiếu kế toán |
| Post GL | `asGLPost2GL` | Post chứng từ sang sổ cái |
| Tính số dư TK | `asGLCalcBalance` | Tính số dư tài khoản |
| Báo cáo tài chính | `asGLRptBCTC` | Báo cáo tài chính |

### 3.2 SO (Sales Order) - Bán hàng
**File DLL gốc:** `SOVchSO1.dll`, `SOVchSO4.dll`, `SODMKH.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Tạo đơn hàng | `asSOInsOrder` | Insert đơn hàng bán |
| Duyệt đơn hàng | `asSOApproveOrder` | Duyệt/Sửa đơn hàng |
| Post SO | `asSOPost2GL` | Post đơn hàng sang GL |
| Báo giá | `asSOGetQuote` | Lấy báo giá |

### 3.3 SI (Sales Invoice) - Hóa đơn bán
**File DLL gốc:** `SIVchSI1.dll`, `SIDMHD.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Lập hóa đơn | `asSIInsInvoice` | Insert hóa đơn bán |
| Post SI | `asSIPost2AR` | Post hóa đơn sang AR |
| Xuất kho tự động | `asSIAutoOutStock` | Tự động xuất kho |

### 3.4 PO (Purchase Order) - Mua hàng
**File DLL gốc:** `POVchPO1.dll`, `PODMCP.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Tạo PO | `asPOInsOrder` | Insert đơn hàng mua |
| Nhận hàng | `asPOReceive` | Nhận hàng từ PO |
| Post PO | `asPOPost2AP` | Post sang AP |

### 3.5 AP (Accounts Payable) - Phải trả
**File DLL gốc:** `APVchAP4.dll`, `APPost2TT.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Phiếu chi | `asAPInsPayment` | Thanh toán cho NCC |
| Tính công nợ | `asAPCalcBalance` | Tính công nợ NCC |
| Post AP | `asAPPost2GL` | Post sang GL |

### 3.6 AR (Accounts Receivable) - Phải thu
**File DLL gốc:** `ARVchAR4.dll`, `ARPost2TT.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Phiếu thu | `asARInsReceipt` | Thu tiền từ KH |
| Tính công nợ KH | `asARCalcBalance` | Tính công nợ khách |
| Post AR | `asARPost2GL` | Post sang GL |

### 3.7 IN (Inventory) - Kho
**File DLL gốc:** `INVchIN1.dll`, `INVchIN2.dll`, `INCalGiaBQDD.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Nhập kho | `asINInsReceipt` | Nhập kho mua/bán |
| Xuất kho | `asINInsIssue` | Xuất kho bán/điều chuyển |
| Tính giá TB | `asINCalcAvgPrice` | Tính giá bình quân |
| Kiểm kê | `asINStockCheck` | Kiểm kê kho |

### 3.8 CA (Cash) - Tiền mặt/Ngân hàng
**File DLL gốc:** `CAVchCA1.dll`, `CACDKU.dll`, `CACDPC.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Phiếu báo nợ | `asCAInsDebit` | Ghi nhận thu tiền |
| Phiếu báo có | `asCAInsCredit` | Ghi nhận chi tiền |
| Post CA | `asCAPost2GL` | Post sang GL |

### 3.9 FA (Fixed Asset) - Tài sản cố định
**File DLL gốc:** `FADMTS.dll`, `FACalKHTS.dll`, `FAGiamTS.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Khấu hao TS | `asFACalcDepreciation` | Tính khấu hao |
| Ghi tăng TS | `asFAInsAsset` | Ghi nhận TSCĐ |
| Ghi giảm TS | `asFADisposeAsset` | Thanh lý TSCĐ |
| Post FA | `asFAPost2GL` | Post sang GL |

### 3.10 CO (Manufacturing) - Sản xuất
**File DLL gốc:** `CODMBOM.dll`, `CoCalcCost.dll`, `COPB.dll`

| Function | Stored Procedure | Mô tả |
|----------|------------------|-------|
| Định mức BOM | `asCOInsBOM` | Thiết lập BOM |
| Tính giá thành | `asCOCalcCost` | Tính giá thành SP |
| Post CO | `asCOPost2GL` | Post sang GL |

---

## 4. Luồng Nghiệp vụ Chính

### 4.1 Bán hàng (SO → SI → AR → GL)
```
[SODMKH] Tạo KH mới
    ↓
[SOVchSO1] Lập đơn hàng → asSOInsOrder
    ↓
[SOVchSO4] Duyệt đơn hàng → asSOApproveOrder
    ↓
[SIVchSI1] Xuất hóa đơn → asSIInsInvoice
    ↓
[INVchIN2] Xuất kho tự động → asINInsIssue
    ↓
[ARVchAR4] Ghi nhận công nợ → asARInsReceipt
    ↓
[GLVchGL1] Post sang GL → asGLPost2GL
```

### 4.2 Mua hàng (PO → IN → AP → GL)
```
[POVchPO1] Lập đơn hàng mua → asPOInsOrder
    ↓
[INVchIN1] Nhập kho → asINInsReceipt
    ↓
[APVchAP4] Nhận hóa đơn → asAPInsInvoice
    ↓
[APPost2TT] Thanh toán → asAPInsPayment
    ↓
[GLVchGL1] Post sang GL → asGLPost2GL
```

### 4.3 Tiền mặt/Ngân hàng
```
[CAVchCA1] Lập phiếu thu/chi → asCAInsDebit/asCAInsCredit
    ↓
[GLVchGL1] Post sang GL → asCAPost2GL
```

---

## 5. Code Decompiled từ Asia App

**Location:** `docs/decompiled/asia/` (147 DLLs)

### Cấu trúc Namespace
```
AsiaErp.Framework     → Core classes, Voucher base, Commons
AsiaErp.UserInterface → Forms (frmVoucher, frmDMEdit, frmReport)
AsiaErp.DataAccess    → DAO classes (MsSql*DAO)
AsiaErp.Business      → Business logic
```

### Các DLL Quan trọng
| DLL | Chức năng chính |
|-----|-----------------|
| `Framework.dll` | Base Voucher, DAO pattern |
| `ToolCommon.dll` | DB Connection, Session |
| `GLVchGL1.dll` | Phiếu kế toán |
| `SOVchSO1.dll` | Đơn hàng bán |
| `INVchIN1.dll` | Nhập kho |
| `APVchAP4.dll` | Phiếu chi |
| `ARVchAR4.dll` | Phiếu thu |

### Pattern gọi Stored Procedure
```csharp
// Từ decompiled code
public class MsSqlGLVoucherDAO : IGLVoucherDAO
{
    public void InsertVoucher(VoucherEntity voucher)
    {
        // Gọi SP: asGLInsVoucher
        SqlCommand cmd = new SqlCommand("asGLInsVoucher", connection);
        cmd.Parameters.AddWithValue("@VoucherID", voucher.ID);
        cmd.Parameters.AddWithValue("@VoucherDate", voucher.Date);
        // ... các params khác
        cmd.ExecuteNonQuery();
    }
}
```

---

## 6. Tham khảo Nhanh

### Tìm Procedure theo Module
```bash
# GL procedures
grep -l "asGL" dbo/StoredProcedures/*.sql

# SO procedures
grep -l "asSO" dbo/StoredProcedures/*.sql

# AR procedures
grep -l "asAR" dbo/StoredProcedures/*.sql
```

### Tìm Table theo Loại
```bash
# Danh mục
grep -l "dmdb" dbo/Tables/*.sql

# Chi tiết chứng từ
grep -l "ct" dbo/Tables/*.sql | grep -v "dmct"

# Phiếu/Header
grep -l "ph" dbo/Tables/*.sql | grep -v "eph"
```

### Đọc Code Decompiled
```bash
# Xem code 1 DLL
cat docs/decompiled/asia/GLVchGL1.dll/AsiaErp.UserInterface/frmGlVchGL1.cs

# Tìm hàm gọi SP trong code
grep -r "asGL\|asSO\|asAR\|asAP\|asIN\|asCA\|asFA\|asCO\|asPO\|asSI" docs/decompiled/asia/ --include="*.cs" | head -20
```

---

## 7. Thống kê

| Loại | Số lượng |
|------|----------|
| Stored Procedures | 2,031 |
| Tables | 440 |
| Functions | 89 |
| Views | 4 |
| Decompiled DLLs | 147 |

---

## 8. Liên kết Nhanh

- **Báo cáo phân tích chi tiết:** `docs/ASIA_APP_ANALYSIS_REPORT.md`
- **Code decompiled:** `docs/decompiled/asia/`
- **Stored procedures:** `dbo/StoredProcedures/`
- **Tables:** `dbo/Tables/`
- **Module docs:** `docs/modules/`
- **Workflows:** `docs/flows/`

---

## 9. Lưu ý cho AI Agent

1. **Tìm procedure:** Dùng prefix `as` + module code (GL/SO/AR/AP/IN/CA/FA/CO/PO/SI)
2. **Tìm table:** Dùng prefix `dmdb` (danh mục), `ct` (chi tiết), `ph` (phiếu)
3. **Tham khảo logic:** Xem code decompiled trong `docs/decompiled/asia/[DLL]/`
4. **Luồng nghiệp vụ:** Mọi module đều post về GL (General Ledger)
5. **Quy tắc đặt tên:** Procedure = `as` + Module + Action (Ins/Get/Del/Post/Rpt)