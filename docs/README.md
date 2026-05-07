# SimbaSql Documentation Index

Tổng hợp toàn bộ tài liệu dự án SimbaSql.

---

## Quick Navigation

| Category | Path | Description |
|----------|------|-------------|
| **Asia App** | [docs/asia/](./asia/) | Phân tích Asia ERP App |
| **Asia Guides** | [docs/asia/guides/](./asia/guides/) | Tài liệu Asia ERP App |
| **SQL Guides** | [docs/procedures/guides/](./procedures/guides/) | Tài liệu SQL Simba |
| **Reference** | [docs/reference/](./reference/) | Tài liệu tra cứu kỹ thuật |
| **Data** | [docs/data/](./data/) | System tables documentation |
| **Procedures** | [docs/procedures/](./procedures/) | Stored Procedures documentation |
| **Decompiled** | [docs/decompiled/](./decompiled/) | Decompiled DLL analysis |
| **Tasks** | [docs/tasks/](./tasks/) | Task tracking và kế hoạch |
| **Database** | [dbo/](../dbo/) | Cấu trúc database |
| **Scripts** | [scripts/](../scripts/) | Scripts & tools |

---

## Asia App Documentation

### Tổng quan Module
| Module | File | Mô tả |
|--------|------|-------|
| **GL** | [asia/GL_SUMMARY.md](./asia/GL_SUMMARY.md) | Kế toán tổng hợp |
| **AR** | [asia/AR_SUMMARY.md](./asia/AR_SUMMARY.md) | Công nợ phải thu |
| **AP** | [asia/AP_SUMMARY.md](./asia/AP_SUMMARY.md) | Công nợ phải trả |
| **CA** | [asia/CA_SUMMARY.md](./asia/CA_SUMMARY.md) | Tiền mặt/ngân hàng |
| **SO** | [asia/SO_SUMMARY.md](./asia/SO_SUMMARY.md) | Bán hàng |
| **PO** | [asia/PO_SUMMARY.md](./asia/PO_SUMMARY.md) | Mua hàng |
| **IN** | [asia/IN_SUMMARY.md](./asia/IN_SUMMARY.md) | Quản lý kho |
| **CO** | [asia/CO_SUMMARY.md](./asia/CO_SUMMARY.md) | Sản xuất/giá thành |
| **FA** | [asia/FA_SUMMARY.md](./asia/FA_SUMMARY.md) | Tài sản cố định |
| **SI** | [asia/SI_SUMMARY.md](./asia/SI_SUMMARY.md) | Hệ thống |

### Tài liệu tham chiếu Asia
| File | Mô tả |
|------|-------|
| [asia/CROSS_MODULE_INTERACTIONS.md](./asia/CROSS_MODULE_INTERACTIONS.md) | Luồng dữ liệu giữa các module |
| [asia/SP_INDEX.md](./asia/SP_INDEX.md) | Danh sách Stored Procedures |
| [asia/TABLES_INDEX.md](./asia/TABLES_INDEX.md) | Danh sách Database Tables |

### Chi tiết Module
- [asia/gl/](./asia/gl/) - Vouchers, Reports, Masters, Financial Statements
- [asia/ar/](./asia/ar/) - Vouchers, Reports
- [asia/ap/](./asia/ap/) - Vouchers, Reports
- [asia/ca/](./asia/ca/) - Vouchers, Masters, Reports
- [asia/so/](./asia/so/) - Vouchers, Reports
- [asia/po/](./asia/po/) - Vouchers, Reports
- [asia/in/](./asia/in/) - Vouchers, Masters, Reports
- [asia/co/](./asia/co/) - Vouchers, Reports
- [asia/fa/](./asia/fa/) - Vouchers, Masters, Reports
- [asia/si/](./asia/si/) - Vouchers, Masters

---

## Stored Procedures Documentation

### Main
- [procedures/README.md](./procedures/README.md) - Tổng quan

### Theo Module
| Module | README | Procedures |
|--------|--------|------------|
| GL | [procedures/GL/README.md](./procedures/GL/README.md) | [procedures.md](./procedures/GL/procedures.md) |
| AR | [procedures/AR/README.md](./procedures/AR/README.md) | [procedures.md](./procedures/AR/procedures.md) |
| AP | [procedures/AP/README.md](./procedures/AP/README.md) | [procedures.md](./procedures/AP/procedures.md) |
| CA | [procedures/CA/README.md](./procedures/CA/README.md) | - |
| SO | [procedures/SO/README.md](./procedures/SO/README.md) | [procedures.md](./procedures/SO/procedures.md) |
| PO | [procedures/PO/README.md](./procedures/PO/README.md) | [procedures.md](./procedures/PO/procedures.md) |
| IN | [procedures/IN/README.md](./procedures/IN/README.md) | [procedures.md](./procedures/IN/procedures.md) |
| CO | [procedures/CO/README.md](./procedures/CO/README.md) | [procedures.md](./procedures/CO/procedures.md) |
| FA | [procedures/FA/README.md](./procedures/FA/README.md) | [procedures.md](./procedures/FA/procedures.md) |
| SI | [procedures/SI/README.md](./procedures/SI/README.md) | [procedures.md](./procedures/SI/procedures.md) |
| System | [procedures/System/README.md](./procedures/System/README.md) | [procedures.md](./procedures/System/procedures.md) |

### Guides
- [procedures/guides/CORE.md](./procedures/guides/CORE.md) - Kiến trúc core và naming convention

---

## System Data Documentation

| File | Mô tả |
|------|-------|
| [data/sysMenu.md](./data/sysMenu.md) | Hệ thống menu |
| [data/sysVoucherInfo.md](./data/sysVoucherInfo.md) | Thông tin chứng từ |
| [data/sysVoucherResx.md](./data/sysVoucherResx.md) | Resource chứng từ |
| [data/sysDictionaryInfo.md](./data/sysDictionaryInfo.md) | Từ điển dữ liệu |
| [data/sysDictionaryResx.md](./data/sysDictionaryResx.md) | Resource từ điển |
| [data/sysReportInfo.md](./data/sysReportInfo.md) | Thông tin báo cáo |
| [data/sysReportDrillDownInfo.md](./data/sysReportDrillDownInfo.md) | Drill-down báo cáo |
| [data/sysOpeningBalanceInfo.md](./data/sysOpeningBalanceInfo.md) | Số dư đầu kỳ |
| [data/sysSetupModule.md](./data/sysSetupModule.md) | Cấu hình module |
| [data/sysDAOInfo.md](./data/sysDAOInfo.md) | DAO information |
| [data/sysDmMagd.md](./data/sysDmMagd.md) | Danh mục nhóm người dùng |
| [data/SiDmCt.md](./data/SiDmCt.md) | Danh mục chứng từ |
| [data/SiDmCtResx.md](./data/SiDmCtResx.md) | Resource danh mục CT |
| [data/SiDmExcProc.md](./data/SiDmExcProc.md) | Exception procedures |

---

## Reference Documentation

| File | Mô tả |
|------|-------|
| [reference/ASIA_SIMBA_MAPPING.md](./reference/ASIA_SIMBA_MAPPING.md) | Liên kết Asia App và Simba SQL |
| [reference/QUICK_REFERENCE.md](./reference/QUICK_REFERENCE.md) | Tham khảo nhanh SP theo nghiệp vụ |
| [reference/CODE_REFERENCE.md](./reference/CODE_REFERENCE.md) | Reference code |
| [reference/FILE_INDEX.md](./reference/FILE_INDEX.md) | Index file nhanh |

---

## Decompiled DLL Analysis

338 DLL đã được phân tích, nằm trong [docs/decompiled/asia/](./decompiled/asia/).

Mỗi DLL có README.md riêng chứa thông tin về forms, methods, SP calls, và business logic.

---

## Tasks

| File | Mô tả |
|------|-------|
| [tasks/001-in-danhmuc-vattu-bom.md](./tasks/001-in-danhmuc-vattu-bom.md) | Task IN: Danh mục vật tư BOM |
| [tasks/002-si-simba-login-entrypoint.md](./tasks/002-si-simba-login-entrypoint.md) | Task SI: Login entrypoint |
| [tasks/ASIA_APP_ANALYSIS_REPORT.md](./tasks/ASIA_APP_ANALYSIS_REPORT.md) | Báo cáo phân tích Asia App |
| [tasks/ASIA_DECOMPILE_TASKS.md](./tasks/ASIA_DECOMPILE_TASKS.md) | Task decompile tracking |
| [tasks/ASIA_DOC_RESTRUCTURE_PLAN.md](./tasks/ASIA_DOC_RESTRUCTURE_PLAN.md) | Kế hoạch tái cấu trúc docs |

---

## Database Objects

| Object Type | Path | Count |
|-------------|------|-------|
| Tables | [dbo/Tables/README.md](../dbo/Tables/README.md) | 440 |
| StoredProcedures | [dbo/StoredProcedures/README.md](../dbo/StoredProcedures/README.md) | 2,031 |
| Functions | [dbo/Functions/README.md](../dbo/Functions/README.md) | 89 |
| Views | [dbo/Views/README.md](../dbo/Views/README.md) | 4 |

---

## Business Workflows (Luồng xử lý)

### Core Business Flows
| Flow | File | Modules |
|------|------|---------|
| **Mua hàng** | [asia/CROSS_MODULE_INTERACTIONS.md](./asia/CROSS_MODULE_INTERACTIONS.md#2-mua-hàng-po--in--ap--gl) | PO, IN, AP, GL |
| **Bán hàng** | [asia/CROSS_MODULE_INTERACTIONS.md](./asia/CROSS_MODULE_INTERACTIONS.md#1-bán-hàng-so--si--ar--gl) | SO, SI, AR, GL |
| **Thu chi tiền** | [asia/CROSS_MODULE_INTERACTIONS.md](./asia/CROSS_MODULE_INTERACTIONS.md#3-thu-chi-ca--gl) | CA, GL |
| **Tài sản cố định** | [asia/CROSS_MODULE_INTERACTIONS.md](./asia/CROSS_MODULE_INTERACTIONS.md#4-tài-sản-cố-định-fa--gl) | FA, GL |
| **Tính giá thành** | [asia/CROSS_MODULE_INTERACTIONS.md](./asia/CROSS_MODULE_INTERACTIONS.md#5-tính-giá-thành-co--gl) | CO, GL |

---

## External Links

- Repository: https://github.com/diepxuan/SimbaSql
- Issues: https://github.com/diepxuan/SimbaSql/issues
- PRs: https://github.com/diepxuan/SimbaSql/pulls

---

*Last updated: 2026-05-05*
