# SimbaSql Documentation Index

Tổng hợp toàn bộ tài liệu dự án SimbaSql.

---

## Quick Navigation

| Category | Path | Description |
|----------|------|-------------|
| **Core Docs** | [docs/](./) | Tài liệu chính |
| **Asia Guides** | [docs/asia/guides/](./asia/guides/) | Tài liệu Asia ERP App |
| **SQL Guides** | [docs/procedures/guides/](./procedures/guides/) | Tài liệu SQL Simba |
| **Reference** | [docs/reference/](./reference/) | Tài liệu tra cứu kỹ thuật |
| **Flows** | [docs/flows/](./flows/) | Luồng xử lý công việc (đang cập nhật) |
| **Modules** | [docs/modules/](./modules/) | Tài liệu theo module |
| **Asia App** | [docs/asia/](./asia/) | Phân tích Asia ERP App |
| **Tasks** | [docs/tasks/](./tasks/) | Task tracking và kế hoạch |
| **Database** | [dbo/](../dbo/) | Cấu trúc database |
| **RAG** | [rag/](../rag/) | AI search & query |

---

## Core Documentation

### Getting Started
- [AI_AGENT_CONTRACT.md](./AI_AGENT_CONTRACT.md) - Hợp đồng cho AI agent
- [API_CONTRACT.md](./API_CONTRACT.md) - API contracts
- [DATA_DICTIONARY.md](./DATA_DICTIONARY.md) - Từ điển dữ liệu

### Architecture & Design
- [01_ARCHITECTURE.md](./01_ARCHITECTURE.md) - Kiến trúc hệ thống
- [02_DATA_MODEL.md](./02_DATA_MODEL.md) - Mô hình dữ liệu
- [03_MULTI_TENANCY_MODEL.md](./03_MULTI_TENANCY_MODEL.md) - Multi-tenancy
- [04_SECURITY_MODEL.md](./04_SECURITY_MODEL.md) - Mô hình bảo mật
- [05_PERFORMANCE_OPTIMIZATION.md](./05_PERFORMANCE_OPTIMIZATION.md) - Tối ưu hiệu suất
- [06_MONITORING_AND_MAINTENANCE.md](./06_MONITORING_AND_MAINTENANCE.md) - Giám sát & bảo trì
- [07_DEPLOYMENT_MODEL.md](./07_DEPLOYMENT_MODEL.md) - Triển khai

### Asia App Guides
- [asia/guides/PROJECT_GUIDE.md](./asia/guides/PROJECT_GUIDE.md) - Tổng quan dự án và mapping Asia App
- [asia/guides/MODULES.md](./asia/guides/MODULES.md) - Chi tiết các module Asia
- [asia/guides/WORKFLOWS.md](./asia/guides/WORKFLOWS.md) - Luồng nghiệp vụ chi tiết

### SQL Simba Guides
- [procedures/guides/CORE.md](./procedures/guides/CORE.md) - Kiến trúc core và naming convention

### Reference
- [reference/ASIA_SIMBA_MAPPING.md](./reference/ASIA_SIMBA_MAPPING.md) - Liên kết Asia App và Simba SQL
- [reference/QUICK_REFERENCE.md](./reference/QUICK_REFERENCE.md) - Tham khảo nhanh SP theo nghiệp vụ
- [reference/CODE_MAPPING.md](./reference/CODE_MAPPING.md) - Mapping code decompiled sang SP
- [reference/FUNCTIONS.md](./reference/FUNCTIONS.md) - Danh sách functions theo module
- [reference/FILE_INDEX.md](./reference/FILE_INDEX.md) - Index file nhanh

### Tasks
- [tasks/ASIA_APP_ANALYSIS_REPORT.md](./tasks/ASIA_APP_ANALYSIS_REPORT.md) - Báo cáo phân tích Asia App
- [tasks/ASIA_DECOMPILE_TASKS.md](./tasks/ASIA_DECOMPILE_TASKS.md) - Task decompile tracking
- [tasks/ASIA_DOC_RESTRUCTURE_PLAN.md](./tasks/ASIA_DOC_RESTRUCTURE_PLAN.md) - Kế hoạch tái cấu trúc

### Catalogs
- [catalog/PROCEDURES.md](./catalog/PROCEDURES.md) - Danh mục 2031 stored procedures
- [catalog/procedures/](./catalog/procedures/) - Chi tiết từng procedure

---

## Business Workflows (Luồng xử lý)

### Core Business Flows
| Flow | File | Modules |
|------|------|---------|
| **Mua hàng** | [asia/guides/WORKFLOWS.md](./asia/guides/WORKFLOWS.md#luồng-mua-hàng) | PO, AP, CA, IN, GL |
| **Bán hàng** | [asia/guides/WORKFLOWS.md](./asia/guides/WORKFLOWS.md#luồng-bán-hàng) | SO, SI, AR, CA, IN, GL |
| **Thu chi tiền** | [asia/guides/WORKFLOWS.md](./asia/guides/WORKFLOWS.md#luồng-thu-chi) | CA, GL |
| **Nhập xuất kho** | [asia/guides/WORKFLOWS.md](./asia/guides/WORKFLOWS.md#luồng-kho) | IN, PO, SO, GL |
| **Tài sản cố định** | [asia/guides/WORKFLOWS.md](./asia/guides/WORKFLOWS.md#luồng-tài-sản) | FA, GL |
| **Công nợ phải thu** | [asia/guides/WORKFLOWS.md](./asia/guides/WORKFLOWS.md#luồng-công-nợ-thu) | AR, SI, CA, GL |
| **Công nợ phải trả** | [asia/guides/WORKFLOWS.md](./asia/guides/WORKFLOWS.md#luồng-công-nợ-trả) | AP, PO, CA, GL |
| **Sổ cái** | [asia/guides/WORKFLOWS.md](./asia/guides/WORKFLOWS.md#luồng-sổ-cái) | GL |

---

## Module Documentation

### Financial Modules
| Module | Path | Procedures |
|--------|------|------------|
| **GL** - General Ledger | [modules/GL/](./modules/GL/) | 313 procedures |
| **AR** - Accounts Receivable | [modules/AR/](./modules/AR/) | 94 procedures |
| **AP** - Accounts Payable | [modules/AP/](./modules/AP/) | 41 procedures |
| **CA** - Cash & Banking | [modules/CA/](./modules/CA/) | 55 procedures |

### Operations Modules
| Module | Path | Procedures |
|--------|------|------------|
| **SO** - Sales Order | [modules/SO/](./modules/SO/) | 171 procedures |
| **PO** - Purchase Order | [modules/PO/](./modules/PO/) | 127 procedures |
| **SI** - Sales Invoice | [modules/SI/](./modules/SI/) | ~50 procedures |
| **IN** - Inventory | [modules/IN/](./modules/IN/) | 146 procedures |

### Asset & HR Modules
| Module | Path | Procedures |
|--------|------|------------|
| **FA** - Fixed Assets | [modules/FA/](./modules/FA/) | 58 procedures |
| **CO** - Manufacturing | [modules/CO/](./modules/CO/) | 65 procedures |
| **HR** - Human Resources | [modules/HR/](./modules/HR/) | 172 procedures |

---

## Database Objects

### Stored Procedures
- [dbo/StoredProcedures/README.md](../dbo/StoredProcedures/README.md) - 2031 procedures
- [dbo/StoredProcedures/](../dbo/StoredProcedures/) - Source files

### Other Objects
- [dbo/Functions/README.md](../dbo/Functions/README.md) - 89 functions
- [dbo/Tables/README.md](../dbo/Tables/README.md) - 440 tables
- [dbo/Views/README.md](../dbo/Views/README.md) - 4 views

---

## Tools & Scripts

- [tools/README.md](../tools/README.md) - SQL tools
- [tools/generate_docs.sh](../tools/generate_docs.sh) - Generate documentation
- [examples/README.md](../examples/README.md) - SQL examples
- [Follow/](../Follow/) - Maintenance scripts

---

## RAG Pipeline

- [rag/README.md](../rag/README.md) - AI search documentation
- [rag/index.py](../rag/index.py) - Index documents
- [rag/query.py](../rag/query.py) - Query interface
- [rag/api.py](../rag/api.py) - API server

---

## Cross-References

### Module → Flow Mapping
```
GL:  [general_ledger_workflow.md](./flows/general_ledger_workflow.md)
AR:  [accounts_receivable_workflow.md](./flows/accounts_receivable_workflow.md)
AP:  [accounts_payable_workflow.md](./flows/accounts_payable_workflow.md)
CA:  [cash_banking_workflow.md](./flows/cash_banking_workflow.md)
SO:  [sales_order_workflow.md](./flows/sales_order_workflow.md)
PO:  [purchase_order_workflow.md](./flows/purchase_order_workflow.md)
SI:  [sales_order_workflow.md](./flows/sales_order_workflow.md)
IN:  [inventory_workflow.md](./flows/inventory_workflow.md)
FA:  [fixed_assets_workflow.md](./flows/fixed_assets_workflow.md)
```

### Flow → Module Dependencies
```
purchase_order_workflow:  PO → AP → CA → IN → GL
sales_order_workflow:     SO → SI → AR → CA → IN → GL
accounts_receivable:      AR → SI → CA → GL
accounts_payable:         AP → PO → CA → GL
cash_banking:             CA → GL
inventory:                IN → PO → SO → GL
fixed_assets:             FA → GL
general_ledger:           GL (all modules)
```

---

## External Links

- Repository: https://github.com/diepxuan/SimbaSql
- Issues: https://github.com/diepxuan/SimbaSql/issues
- PRs: https://github.com/diepxuan/SimbaSql/pulls

---

*Last updated: 2026-03-28*
