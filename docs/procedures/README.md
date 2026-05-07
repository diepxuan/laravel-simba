# Stored Procedures Documentation

Tài liệu chi tiết cho tất cả Stored Procedures trong hệ thống Simba.

## Module Documentation

| Module | Overview | Procedures | Description |
|--------|----------|------------|-------------|
| [AP](./AP/) | [README](./AP/README.md) | [procedures.md](./AP/procedures.md) | Accounts Payable - Công nợ phải trả |
| [AR](./AR/) | [README](./AR/README.md) | [procedures.md](./AR/procedures.md) | Accounts Receivable - Công nợ phải thu |
| [CA](./CA/) | [README](./CA/README.md) | - | Cash - Tiền mặt/Ngân hàng |
| [CO](./CO/) | [README](./CO/README.md) | [procedures.md](./CO/procedures.md) | Manufacturing - Sản xuất |
| [Dash](./Dash/) | [README](./Dash/README.md) | - | Dashboard - Bảng điều khiển |
| [FA](./FA/) | [README](./FA/README.md) | [procedures.md](./FA/procedures.md) | Fixed Assets - Tài sản cố định |
| [GL](./GL/) | [README](./GL/README.md) | [procedures.md](./GL/procedures.md) | General Ledger - Sổ cái |
| [HR](./HR/) | [README](./HR/README.md) | - | Human Resources - Nhân sự |
| [IN](./IN/) | [README](./IN/README.md) | [procedures.md](./IN/procedures.md) | Inventory - Quản lý kho |
| [PO](./PO/) | [README](./PO/README.md) | [procedures.md](./PO/procedures.md) | Purchase Order - Mua hàng |
| [SA](./SA/) | [README](./SA/README.md) | - | Salary - Tiền lương |
| [SI](./SI/) | [README](./SI/README.md) | - | System - Hệ thống chung |
| [SO](./SO/) | [README](./SO/README.md) | [procedures.md](./SO/procedures.md) | Sales Order - Đơn hàng |
| [System](./System/) | [README](./System/README.md) | [procedures.md](./System/procedures.md) | System Admin - Quản trị hệ thống |
| [Ta](./Ta/) | [README](./Ta/README.md) | - | Tax - Thuế |
| [UTILITIES](./UTILITIES/) | [README](./UTILITIES/README.md) | - | Utilities - Tiện ích |

## Cấu trúc mỗi module

Mỗi module có cấu trúc:

```
docs/procedures/{MODULE}/
├── README.md       - Tổng quan module
└── procedures.md   - Chi tiết stored procedures (nếu có)
```

## Cách sử dụng

### Tìm procedure

1. Xác định module liên quan (AP, AR, CA, GL, v.v.)
2. Mở thư mục module tương ứng
3. Xem file `procedures.md` để tìm chi tiết procedure

### Ví dụ:

- Tìm procedure thêm phiếu thu: Xem trong `CA/README.md`
- Tìm procedure báo cáo tồn kho: Xem trong `IN/procedures.md`

## Quy ước đặt tên

| Prefix | Ý nghĩa | Ví dụ |
|--------|---------|-------|
| `as` | AsiaSoft | `asCAInsPH1` |
| `CA/AP/AR/...` | Module | `asCAInsPH1` = Cash module |
| `Ins/Upd/Del/Get/...` | Thao tác | `asCAInsPH1` = Insert |
| `PH/CT/DM...` | Loại đối tượng | `PH` = Phiếu header, `CT` = Chi tiết |

## Liên quan

- [docs/asia/SP_INDEX.md](../asia/SP_INDEX.md) - SP Index theo DLL
- [dbo/StoredProcedures/README.md](../../dbo/StoredProcedures/README.md) - Database SP files
- [docs/asia/CROSS_MODULE_INTERACTIONS.md](../asia/CROSS_MODULE_INTERACTIONS.md) - Cross-module
