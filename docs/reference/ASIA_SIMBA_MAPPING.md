# Asia App to SimbaSql Mapping

Liên kết Asia ERP Application (VB.NET/WinForms) và SimbaSql Database.

---

## Kiến trúc Tổng quan

```
┌─────────────────────────────────────────┐
│  CLIENT (Asia ERP App - VB.NET)       │
│  ├── GLVchGL1.dll (Phiếu kế toán) │
│  ├── SOVchSO1.dll (Đơn hàng bán)  │
│  └── ... 147+ DLLs                    │
├─────────────────────────────────────────┤
│  DATABASE (SimbaSql - SQL Server)     │
│  ├── Stored Procedures: 2,031 (as*, z*, sp*) │
│  ├── Tables: 440 (dmdb*, ct*, ph*)   │
│  └── Views: 4                         │
└─────────────────────────────────────────┘
```

---

## Mapping Module → DLL → SP

| Module | DLL chính | SP Insert | SP Update | SP Get |
|--------|-------------|-----------|-----------|--------|
| **GL** | GLVchGL1.dll | `asGLInsPh1`, `asGLInsCt1` | `asGLUpdPh1` | `asGLGetPh1`, `asGLGetCt1` |
| **SO** | SOVchSO1.dll | `asSoInsPh1`, `asSoInsCt1` | `asSOUpdPH1` | `asSOGetPh1`, `asSOGetCT1` |
| **SI** | SIVchSI1.dll | `asSIInsInvoice` | - | `asSIGetDMCT` |
| **PO** | POVchPO1.dll | `asPOInsPH0`, `asPOInsCT0` | `asPOUpdPH0` | `asPOGetPH0`, `asPOGetCT0` |
| **AP** | APVchAP4.dll | `asAPInsPayment` | - | `asAPGetInvoice` |
| **AR** | ARVchAR4.dll | `asARInsPH1`, `asARInsCT1` | `asARUpdPH1` | `asARGetPH1`, `asARGetCT1` |
| **IN** | INVchIN1.dll | `asINInsPH1`, `asINInsCT1` | `asINUpdPH1` | `asINGetPH1`, `asINGetCT1` |
| **CA** | CAVchCA1.dll | `asCAInsPH1`, `asCAInsCT1` | `asCAUpdPH1` | `asCAGetPH1`, `asCAGetCT1` |
| **FA** | FADMTS.dll | `asFAInsDMTS` | `asFAUpdDMTS` | `asFAGetDMTS` |
| **CO** | CODMBOM.dll | `asCOInsDMCoBomPH` | `asCOUpdDMCoBomPH` | `asCOGetDMCoBomPH` |

Chi tiết SP: [CODE_REFERENCE.md](CODE_REFERENCE.md)

---

## Luồng Nghiệp vụ

### Bán hàng: SO → SI → AR → GL
```
[SOVchSO1] Lập đơn hàng    → asSoInsPh1
     ↓
[SIVchSI1] Xuất hóa đơn    → asSIInsInvoice
     ↓
[INVchIN2] Xuất kho          → asINInsIssue
     ↓
[ARVchAR4] Ghi nhận công nợ → asARInsReceipt
     ↓
[GLVchGL1] Post sang GL      → asPost2GL
```

### Mua hàng: PO → IN → AP → GL
```
[POVchPO1] Lập đơn mua      → asPOInsPH0
     ↓
[INVchIN1] Nhập kho          → asINInsReceipt
     ↓
[APVchAP4] Nhận hóa đơn    → asAPInsInvoice
     ↓
[APPay] Thanh toán            → asAPInsPayment
     ↓
[GLVchGL1] Post sang GL      → asPost2GL
```

---

## Quy ước Đặt tên

| Loại | Pattern | Ví dụ |
|------|---------|-------|
| Stored Procedure | `as[Module][Action][Entity]` | `asGLInsVoucher` |
| Tables | `[Type][Module][Entity]` | `dmdbCustomer`, `ctSOOrder`, `phGLVoucher` |
| DLLs | `[Module][Type][Name].dll` | `GLVchGL1.dll` |

---

## Tham khảo Nhanh

```bash
# Tìm procedure theo module
grep -l "asGL" dbo/StoredProcedures/*.sql

# Tìm table theo loại
grep -l "dmdb" dbo/Tables/*.sql       # Danh mục
grep -l "^ct" dbo/Tables/*.sql        # Chi tiết
grep -l "^ph" dbo/Tables/*.sql        # Phiếu/Header

# Tìm hàm gọi SP trong code
grep -r "asGL\|asSO\|asAR" docs/decompiled/asia/ --include="*.cs"
```

---

## Thống kê

| Loại | Số lượng |
|------|----------|
| Asia App DLLs | 147+ |
| Stored Procedures | 2,031 |
| Tables | 440 |
| Functions | 89 |
| Views | 4 |

---

## Liên kết

- Chi tiết SP: [CODE_REFERENCE.md](CODE_REFERENCE.md)
- Tra cứu nhanh: [QUICK_REFERENCE.md](QUICK_REFERENCE.md)
- File index: [FILE_INDEX.md](FILE_INDEX.md)
- Decompiled code: `docs/decompiled/asia/`
