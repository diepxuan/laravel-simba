# SimbaSql File Index

Index nhanh cho các file quan trọng.

---

## Stored Procedures by Module

| Module | Count | Pattern | Location |
|--------|-------|---------|----------|
| GL | 290 | `asGL*` | `dbo/StoredProcedures/asGL*.sql` |
| SO | 152 | `asSO*` | `dbo/StoredProcedures/asSO*.sql` |
| PO | 120 | `asPO*` | `dbo/StoredProcedures/asPO*.sql` |
| IN | 119 | `asIN*` | `dbo/StoredProcedures/asIN*.sql` |
| AR | 87 | `asAR*` | `dbo/StoredProcedures/asAR*.sql` |
| CA | 61 | `asCA*` | `dbo/StoredProcedures/asCA*.sql` |
| FA | 58 | `asFA*` | `dbo/StoredProcedures/asFA*.sql` |
| CO | 35 | `asCO*` | `dbo/StoredProcedures/asCO*.sql` |
| AP | 41 | `asAP*` | `dbo/StoredProcedures/asAP*.sql` |
| SI | 47 | `asSI*` | `dbo/StoredProcedures/asSI*.sql` |

## Tables by Type

| Type | Count | Pattern | Location |
|------|-------|---------|----------|
| Danh mục | ~80 | `dmdb*` | `dbo/Tables/dmdb*.sql` |
| Chi tiết CT | ~150 | `ct*` | `dbo/Tables/ct*.sql` |
| Phiếu/Header | ~60 | `ph*` | `dbo/Tables/ph*.sql` |
| Danh mục CT | ~20 | `dmct*` | `dbo/Tables/dmct*.sql` |

## Documentation

| File | Mục đích |
|------|----------|
| [ASIA_SIMBA_MAPPING.md](ASIA_SIMBA_MAPPING.md) | Mapping Asia App → Simba SP |
| [CODE_REFERENCE.md](CODE_REFERENCE.md) | Chi tiết code → SP |
| [QUICK_REFERENCE.md](QUICK_REFERENCE.md) | Tra cứu nhanh theo nghiệp vụ |

## Decompiled Code

```
docs/decompiled/asia/
├── Framework.dll/          → Core classes
├── ToolCommon.dll/         → DB Connection
├── GLVchGL1.dll/           → Phiếu kế toán
├── SOVchSO1.dll/           → Đơn hàng bán
├── INVchIN1.dll/           → Nhập kho
└── ... 147+ DLLs
```

## Tìm kiếm nhanh

```bash
# Tìm procedure
cd /root/.openclaw/workspace/projects/SimbaSql
find dbo/StoredProcedures -name "*SearchTerm*.sql"

# Tìm table
find dbo/Tables -name "*SearchTerm*.sql"

# Tìm trong code SQL
grep -r "keyword" dbo/StoredProcedures/*.sql | head -10
```

## Luồng nghiệp vụ chính

### Bán hàng: SO → SI → AR → GL
```
asSoInsPh1 → asSIInsInvoice → asINInsIssue → asARInsReceipt → asPost2GL
```

### Mua hàng: PO → IN → AP → GL
```
asPOInsPH0 → asINInsReceipt → asAPInsInvoice → asAPInsPayment → asPost2GL
```
