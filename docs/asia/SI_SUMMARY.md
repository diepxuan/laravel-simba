# SI Module Summary - Hệ thống chung

## Overview

Module SI (Sales Invoice / System Infrastructure) là tập hợp các thành phần hệ thống chung của Asia ERP, cung cấp nền tảng cho các phân hệ nghiệp vụ khác.

## Module Inventory

### Category: Master Data (Danh mục)

| DLL | Name | Purpose | Key Features |
|-----|------|---------|--------------|
| SIDMCT.dll | Voucher Category | Danh mục chứng từ | Cấu hình loại CT, số CT, trường mở rộng |
| SIDMHD.dll | Contract Category | Danh mục hợp đồng | Quản lý HĐ mua/bán, thời hạn, giá trị |
| SIDMNHHD.dll | Contract Group | Danh mục nhóm HĐ | Phân loại hợp đồng |
| SIDMHTTT.dll | Payment Method | Danh mục HTTT | Hình thức thanh toán |
| SIDMNT.dll | Currency | Danh mục ngoại tệ | Quản lý tiền tệ |
| SIDMTGNT.dll | Exchange Rate | Danh mục tỷ giá | Tỷ giá ngoại tệ theo ngày |
| SIDMNGH.dll | Bank | Danh mục ngân hàng | Thông tin ngân hàng |
| SIDMPHI.dll | Fee Category | Danh mục phí | Các loại phí |
| SIDMOpt9.dll | Option 9 | Danh mục tùy chọn 9 | Thông tin mở rộng |
| SIDMOpt10.dll | Option 10 | Danh mục tùy chọn 10 | Thông tin mở rộng |

### Category: Vouchers (Chứng từ)

| DLL | Voucher Code | Name | Description |
|-----|-------------|------|-------------|
| SIVchSI1.dll | IN1 | Phiếu nhập kho | Nhập kho thành phẩm và khác |

### Category: Reports (Báo cáo)

| DLL | Name | Purpose |
|-----|------|---------|
| SIRptLOGCT.dll | Voucher Log Report | Theo dõi sửa/xóa chứng từ |

### Category: System Tools (Công cụ hệ thống)

| DLL | Name | Purpose |
|-----|------|---------|
| SIAbout.dll | About | Thông tin phần mềm |
| SIBackupData.dll | Backup/Restore | Sao lưu/khôi phục dữ liệu |
| SIMaintain.dll | System Maintenance | Bảo trì hệ thống |
| SISysvars.dll | System Variables | Tham số hệ thống |
| SITheme.dll | Theme | Cấu hình giao diện |
| SIUPDATETOOL.dll | Update Tool | Cập nhật phiên bản |
| SIGroupInfo.dll | Group Info | Quản lý nhóm và phân quyền |

### Category: Utilities (Tiện ích)

| DLL | Name | Purpose |
|-----|------|---------|
| SiChangeFY.dll | Change FY | Thay đổi năm tài chính |
| SiImExData.dll | Import/Export | Chuyển số liệu |
| SiInfomationProduct.dll | Product Info | Thông tin và license |
| SiReOrderVoucherNumber.dll | Reorder VN | Sắp xếp lại số CT |
| SiTools.dll | Tools | Công cụ admin |
| SiTools_2.dll | Tools v2 | Công cụ admin (nhẹ) |
| SiUpdateLog.dll | Update Log | Quản lý package update |

## Data Flow

```
Master Data (SIDM*)
    ↓
Vouchers (SIVch*)
    ↓
Reports (SIRpt*)
    ↓
System Tools (SI*)
```

## Key Entities

### Voucher Configuration (SIDMCT)
- Voucher code (`ma_ct`)
- Voucher name (`ten_ct`)
- Parent code (`ma_ct_me`)
- Module (`phan_he`)
- Default accounts (`tk_no`, `tk_co`)
- Number format (`vn_prefix`, `vn_sequence`, `vn_postfix`, `vn_pattern`, `vn_width`)
- Duplicate check (`kieu_trung`)
- Extension fields (`vv`, `phi`, `bp`, `spct`, `lo`)

### Contract (SIDMHD)
- Contract code (`ma_hd`)
- Contract type (`loai`: 1=Sell, 2=Buy)
- Customer (`ma_kh`)
- Department (`ma_bp`)
- Contract date (`ngay_hd`)
- Expiry date (`ngay_hh`)
- Amount (`tien`, `tien_nt`)

### Currency (SIDMNT/SIDMTGNT)
- Currency code (`ma_nt`)
- Currency name (`ten_nt`)
- Exchange rate (`ty_gia`)
- Rate date (`ngay`)

## Technical Stack

- **Platform**: .NET Framework 3.5
- **Language**: C# (decompiled from VB.NET)
- **UI**: Windows Forms
- **Database**: SQL Server
- **Architecture**: 3-tier (UI - DAO - Database)

## Common Dependencies

```
AsiaErp.Framework
AsiaErp.DataAccess
AsiaErp.Helper
Microsoft.VisualBasic
System.Data
System.Drawing
System.Windows.Forms
```

## Version Information

- **Company**: Asia Software Development JSC / ASIASOFT
- **Product**: Asia Enterprise / AsiaERP
- **Version**: 9.1.0.0 / 1.0.0.0
- **Copyright**: 2010-2012

## Integration Points

| Module | Integration Type | Description |
|--------|---------------|-------------|
| AR | Uses | Customer data from SIDMHD |
| IN | Uses | Voucher config from SIDMCT |
| GL | Uses | Account setup from SIDMCT |
| All | Uses | Currency from SIDMNT/SIDMTGNT |
| All | Uses | Permission from SIGroupInfo |

## Security

- Group-based permission system
- Four access levels: View, Insert, Update, Delete
- User filtering (`loc_nsd`)
- Audit logging (SIRptLOGCT)

## Maintenance Features

| Feature | Description | Stored Procedure |
|---------|-------------|----------------|
| ReIndex | Optimize database | asSIMaintain01_ReIndex |
| Trim Codes | Remove whitespace | asSIMaintain021/022 |
| Check Posting | Validate GL accounts | asSIMaintain Check HT |
| Check Balance | Compare ledger vs stock | asSIMaintain Check Lech |
| Backup | Manual backup | asSIMaintain05 |
| Auto Backup | Scheduled backup | asSiScheduleAutoBackupData |

## Notes

- SI module provides foundational services for all other modules
- Master data in SI is referenced throughout the system
- IN1 voucher is the primary goods receipt document
- Maintenance tools help administrators keep system healthy
- Update tools support deployment and version management

---

*Generated: 2026-03-29*
*Source: docs/decompiled/asia/SI*.dll/README.md*
