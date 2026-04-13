# ASIA ERP Documentation

Tài liệu phân tích và thiết kế chuyển đổi ASIA ERP từ WinForms sang Laravel.

## Cấu trúc thư mục

```
docs/asia/
├── README.md                          # File này
├── COMMON_PATTERNS.md                 # Pattern chung toàn hệ thống
├── CROSS_MODULE_INTERACTIONS.md       # Luồng dữ liệu giữa các module
├── FRAMEWORK_MAPPING.md               # Mapping sang Laravel framework
├── SP_INDEX.md                        # Danh sách Stored Procedures
├── TABLES_INDEX.md                    # Danh sách Database Tables
├── RESTRUCTURE_COMPLETE.md            # Log tái cấu trúc
│
├── AP_SUMMARY.md                      # Tổng quan module AP
├── AR_SUMMARY.md                      # Tổng quan module AR
├── CA_SUMMARY.md                      # Tổng quan module CA
├── CO_SUMMARY.md                      # Tổng quan module CO
├── FA_SUMMARY.md                      # Tổng quan module FA
├── GL_BATCH2_SUMMARY.md               # Tổng quan GL Batch 2
├── GL_MODULE_COMPLETE.md              # Tổng quan đầy đủ module GL
├── IN_MODULE_INDEX.md                 # Index module IN
├── INVENTORY_FULL_ANALYSIS.md         # Phân tích đầy đủ IN
├── INVENTORY_REPORTS_SUMMARY.md       # Tổng quan báo cáo IN
├── INVENTORY_VOUCHERS_SUMMARY.md      # Tổng quan chứng từ IN
├── PO_MODULE_ANALYSIS_SUMMARY.md      # Phân tích module PO
├── SI_SUMMARY.md                      # Tổng quan module SI
├── SO_MODULE_SUMMARY.md               # Tổng quan module SO
│
└── modules/                           # Chi tiết từng module
    ├── ap/                            # Accounts Payable
    ├── ar/                            # Accounts Receivable
    ├── ca/                            # Cash/Banking
    ├── co/                            # Cost Accounting
    ├── fa/                            # Fixed Asset
    ├── gl/                            # General Ledger
    ├── in/                            # Inventory
    ├── po/                            # Purchase Order
    ├── si/                            # Sales Invoice
    └── so/                            # Sales Order
```

## Các Module

| Module | Tên đầy đủ | Mô tả | Tài liệu |
|--------|------------|-------|----------|
| AP | Accounts Payable | Công nợ phải trả | [AP_SUMMARY.md](AP_SUMMARY.md) |
| AR | Accounts Receivable | Công nợ phải thu | [AR_SUMMARY.md](AR_SUMMARY.md) |
| CA | Cash/Banking | Thu chi tiền mặt/ngân hàng | [CA_SUMMARY.md](CA_SUMMARY.md) |
| CO | Cost Accounting | Giá thành, chi phí | [CO_SUMMARY.md](CO_SUMMARY.md) |
| FA | Fixed Asset | Tài sản cố định | [FA_SUMMARY.md](FA_SUMMARY.md) |
| GL | General Ledger | Sổ cái tổng hợp | [GL_MODULE_COMPLETE.md](GL_MODULE_COMPLETE.md) |
| IN | Inventory | Quản lý kho | [IN_MODULE_INDEX.md](IN_MODULE_INDEX.md) |
| PO | Purchase Order | Mua hàng | [PO_MODULE_ANALYSIS_SUMMARY.md](PO_MODULE_ANALYSIS_SUMMARY.md) |
| SI | Sales Invoice | Hóa đơn bán hàng | [SI_SUMMARY.md](SI_SUMMARY.md) |
| SO | Sales Order | Bán hàng | [SO_MODULE_SUMMARY.md](SO_MODULE_SUMMARY.md) |

## Tài liệu tham khảo chung

- **[COMMON_PATTERNS.md](COMMON_PATTERNS.md)** - Các pattern phổ biến trong ASIA ERP
- **[CROSS_MODULE_INTERACTIONS.md](CROSS_MODULE_INTERACTIONS.md)** - Luồng dữ liệu giữa các module
- **[FRAMEWORK_MAPPING.md](FRAMEWORK_MAPPING.md)** - Mapping sang Laravel framework
- **[SP_INDEX.md](SP_INDEX.md)** - Danh sách Stored Procedures
- **[TABLES_INDEX.md](TABLES_INDEX.md)** - Danh sách Database Tables

## Tìm kiếm theo loại

### Chứng từ (Vouchers)
Xem trong `modules/[module]/vouchers/`:
- AP: `modules/ap/vouchers/`
- AR: `modules/ar/vouchers/`
- CA: `modules/ca/vouchers/`
- FA: `modules/fa/vouchers/`
- GL: `modules/gl/vouchers/`
- IN: `modules/in/vouchers/`
- PO: `modules/po/vouchers/`
- SI: `modules/si/vouchers/`
- SO: `modules/so/vouchers/`

### Báo cáo (Reports)
Xem trong `modules/[module]/reports/`:
- AP: `modules/ap/reports/`
- AR: `modules/ar/reports/`
- CA: `modules/ca/reports/`
- CO: `modules/co/reports/`
- FA: `modules/fa/reports/`
- GL: `modules/gl/reports/`
- IN: `modules/in/reports/`
- PO: `modules/po/reports/`
- SO: `modules/so/reports/`

### Danh mục (Masters)
Xem trong `modules/[module]/masters/`:
- AP: `modules/ap/masters/`
- AR: `modules/ar/masters/`
- CA: `modules/ca/masters/`
- FA: `modules/fa/masters/`
- GL: `modules/gl/masters/`
- IN: `modules/in/masters/`

### Báo cáo tài chính
Xem trong `modules/gl/financial-statements/`:
- Mẫu thuyết minh BCTC
- Báo cáo tài chính theo chuẩn mực

## Thống kê

- Tổng số module: 10
- Tổng số file tài liệu chi tiết: ~195 files
- Tổng số DLL đã phân tích: 200+

## Lịch sử cập nhật

Xem [RESTRUCTURE_COMPLETE.md](RESTRUCTURE_COMPLETE.md) để biết chi tiết quá trình tái cấu trúc.
