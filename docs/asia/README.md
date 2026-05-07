# ASIA ERP Documentation

Tài liệu phân tích và thiết kế chuyển đổi ASIA ERP từ WinForms sang Laravel.

## Cấu trúc thư mục

```
docs/asia/
├── README.md                          # File này
├── CROSS_MODULE_INTERACTIONS.md       # Luồng dữ liệu giữa các module
├── SP_INDEX.md                        # Danh sách Stored Procedures
├── TABLES_INDEX.md                    # Danh sách Database Tables
│
├── GL_SUMMARY.md                      # Tổng quan module GL
├── AR_SUMMARY.md                      # Tổng quan module AR
├── AP_SUMMARY.md                      # Tổng quan module AP
├── CA_SUMMARY.md                      # Tổng quan module CA
├── SO_SUMMARY.md                      # Tổng quan module SO
├── PO_SUMMARY.md                      # Tổng quan module PO
├── IN_SUMMARY.md                      # Tổng quan module IN
├── CO_SUMMARY.md                      # Tổng quan module CO
├── FA_SUMMARY.md                      # Tổng quan module FA
├── SI_SUMMARY.md                      # Tổng quan module SI
│
├── gl/                                # Chi tiết module GL
│   ├── vouchers/                      # Chứng từ nghiệp vụ
│   ├── reports/                       # Báo cáo
│   ├── masters/                       # Danh mục
│   └── financial-statements/          # Mẫu BCTC
├── ar/                                # Chi tiết module AR
├── ap/                                # Chi tiết module AP
├── ca/                                # Chi tiết module CA
├── so/                                # Chi tiết module SO
├── po/                                # Chi tiết module PO
├── in/                                # Chi tiết module IN
├── co/                                # Chi tiết module CO
├── fa/                                # Chi tiết module FA
├── si/                                # Chi tiết module SI
├── common/                            # Pattern chung
└── guides/                            # Hướng dẫn
```

## Các Module

| Module | Tên đầy đủ | Mô tả | Summary | Chi tiết |
|--------|------------|-------|---------|----------|
| GL | General Ledger | Sổ cái tổng hợp | [GL_SUMMARY.md](GL_SUMMARY.md) | [gl/](gl/) |
| AR | Accounts Receivable | Công nợ phải thu | [AR_SUMMARY.md](AR_SUMMARY.md) | [ar/](ar/) |
| AP | Accounts Payable | Công nợ phải trả | [AP_SUMMARY.md](AP_SUMMARY.md) | [ap/](ap/) |
| CA | Cash/Banking | Thu chi tiền mặt/ngân hàng | [CA_SUMMARY.md](CA_SUMMARY.md) | [ca/](ca/) |
| SO | Sales Order | Bán hàng | [SO_SUMMARY.md](SO_SUMMARY.md) | [so/](so/) |
| PO | Purchase Order | Mua hàng | [PO_SUMMARY.md](PO_SUMMARY.md) | [po/](po/) |
| IN | Inventory | Quản lý kho | [IN_SUMMARY.md](IN_SUMMARY.md) | [in/](in/) |
| CO | Cost/Manufacturing | Sản xuất/giá thành | [CO_SUMMARY.md](CO_SUMMARY.md) | [co/](co/) |
| FA | Fixed Asset | Tài sản cố định | [FA_SUMMARY.md](FA_SUMMARY.md) | [fa/](fa/) |
| SI | System | Hệ thống | [SI_SUMMARY.md](SI_SUMMARY.md) | [si/](si/) |

## Tài liệu tham chiếu chung

- **[CROSS_MODULE_INTERACTIONS.md](CROSS_MODULE_INTERACTIONS.md)** - Luồng dữ liệu giữa các module
- **[SP_INDEX.md](SP_INDEX.md)** - Danh sách Stored Procedures (~118 SP chính)
- **[TABLES_INDEX.md](TABLES_INDEX.md)** - Danh sách Database Tables (~65 tables chính)

## Thống kê

| Đối tượng | Số lượng |
|-----------|----------|
| Module | 10 |
| Tables | 440 |
| Stored Procedures | 2,031 |
| Functions | 89 |
| Views | 4 |
| DLL đã phân tích | 338 |
| File tài liệu chi tiết | ~755 |

## Business Workflows

| Workflow | Luồng | Modules |
|----------|-------|---------|
| Bán hàng | SO → SI → AR → GL | SO, SI, AR, GL |
| Mua hàng | PO → IN → AP → GL | PO, IN, AP, GL |
| Thu chi tiền | CA → GL | CA, GL |
| Tài sản cố định | FA → GL | FA, GL |
| Giá thành | CO → GL | CO, GL |

## Tìm kiếm theo loại

### Chứng từ (Vouchers)
- GL: [gl/vouchers/](gl/vouchers/)
- AR: [ar/vouchers/](ar/vouchers/)
- AP: [ap/vouchers/](ap/vouchers/)
- CA: [ca/vouchers/](ca/vouchers/)
- SO: [so/vouchers/](so/vouchers/)
- PO: [po/vouchers/](po/vouchers/)
- IN: [in/vouchers/](in/vouchers/)
- CO: [co/vouchers/](co/vouchers/)
- FA: [fa/vouchers/](fa/vouchers/)
- SI: [si/vouchers/](si/vouchers/)

### Báo cáo (Reports)
- GL: [gl/reports/](gl/reports/)
- AR: [ar/vouchers/](ar/vouchers/) (báo cáo nằm chung)
- AP: [ap/vouchers/](ap/vouchers/) (báo cáo nằm chung)
- CA: [ca/reports/](ca/reports/)
- SO: [so/reports/](so/reports/)
- PO: [po/reports/](po/reports/)
- IN: [in/reports/](in/reports/)
- CO: [co/reports/](co/reports/)
- FA: [fa/reports/](fa/reports/)

### Danh mục (Masters)
- GL: [gl/masters/](gl/masters/)
- CA: [ca/masters/](ca/masters/)
- IN: [in/masters/](in/masters/)
- FA: [fa/masters/](fa/masters/)
- SI: [si/vouchers/](si/vouchers/)

### Mẫu báo cáo tài chính
- [gl/financial-statements/](gl/financial-statements/) - 36 mẫu BCTC

---

*Last updated: 2026-05-05*
