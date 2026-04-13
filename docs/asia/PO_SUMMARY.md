# PO Module Summary - Tổng hợp Module Mua hàng

## Overview

Module PO (Purchase Order / Mua hàng) là module quản lý toàn bộ quy trình mua hàng trong hệ thống ERP Asia Enterprise/Simba Accounting.

## Danh sách DLL

Tổng cộng: **18 DLL**

### 1. Danh mục (3 DLL)

| DLL | Tên tiếng Việt | Purpose |
|-----|----------------|---------|
| PODMCP.dll | Danh mục chương trình mua hàng | Quản lý chương trình mua hàng |
| PODMDKTT.dll | Danh mục điều khoản thanh toán mua | Điều khoản thanh toán với NCC |
| PODMHTTT.dll | Danh mục hình thức thanh toán mua | Hình thức TT và cấu hình TK |

### 2. Chứng từ Voucher (6 DLL)

| DLL | Mã CT | Tên chứng từ | Purpose |
|-----|-------|--------------|---------|
| POVchPO1.dll | PO1 | Đơn đặt hàng mua | Tạo đơn đặt hàng |
| POVchPO3.dll | PO3 | Hóa đơn mua hàng | Nhập hóa đơn mua |
| POVchPO4.dll | PO4 | Phiếu nhập kho | Nhập hàng vào kho |
| POVchPO5.dll | PO5 | Phiếu trả lại hàng mua | Trả hàng cho NCC |
| PoVchPO6.dll | PO6 | Hóa đơn mua dịch vụ | Mua dịch vụ/không qua kho |
| POVchPO7.dll | PO7 | Phiếu nhập kho nội bộ | Nhập kho nội bộ |

### 3. Báo cáo (8 DLL)

| DLL | Tên báo cáo | Purpose |
|-----|-------------|---------|
| PORptBCPT03.dll | Báo cáo mua hàng theo hai chỉ tiêu | Phân tích 2 chiều |
| PORptBK01.dll | Bảng kê chứng từ mua hàng | Master-Detail |
| PORptBK02.dll | Bảng kê mua hàng nhóm theo chỉ tiêu | Nhóm theo 10 chỉ tiêu |
| PORptBK03.dll | Bảng kê chi phí mua hàng | Theo dõi chi phí |
| PORptF5TH0.dll | Báo cáo tổng hợp F5 | Drill-down |
| PORptTH01.dll | Báo cáo tổng hợp mua hàng 01 | Tổng hợp |
| PORptTH02.dll | Báo cáo tổng hợp mua hàng 02 | Theo thời gian |
| PORptTH03.dll | Tổng hợp chi phí mua hàng | Tổng hợp chi phí |

### 4. Tiện ích (1 DLL)

| DLL | Tên | Purpose |
|-----|-----|---------|
| POTAIN.dll | Thuế đầu vào | Quản lý thuế GTGT mua vào |
| POUtilities.dll | Tiện ích PO | Thanh toán chứng từ |

## Danh sách Stored Procedures

### Báo cáo

| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| asPOGetBCPT03 | PORptBCPT03 | Báo cáo phân tích chi phí thành phẩm |
| asPOGetBK01 | PORptBK01 | Báo cáo biến động kho 01 |
| asPOGetBK02 | PORptBK02 | Báo cáo biến động kho 02 |
| asPOGetBK03 | PORptBK03 | Báo cáo biến động kho 03 |
| asPOGetTH01 | PORptTH01 | Báo cáo tổng hợp 01 |
| asPOGetTH02 | PORptTH02 | Báo cáo tổng hợp 02 |
| asPOGetTH03 | PORptTH03 | Báo cáo tổng hợp 03 |
| asSIGetDmSo_ct | PORptTH01, PORptTH02 | Lấy danh mục sổ chứng từ |

### Chứng từ

| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| asPOGetPO3 | POVchPO3 | Lấy phiếu nhập mua hàng |
| asPOSavePO3 | POVchPO3 | Lưu phiếu nhập mua hàng |
| asPODeletePO3 | POVchPO3 | Xóa phiếu nhập mua hàng |
| asPOGetPO4 | POVchPO4 | Lấy phiếu chi phí |
| asPOSavePO4 | POVchPO4 | Lưu phiếu chi phí |
| asPODeletePO4 | POVchPO4 | Xóa phiếu chi phí |
| asPOGetPO5 | POVchPO5 | Lấy hóa đơn mua hàng |
| asPOSavePO5 | POVchPO5 | Lưu hóa đơn mua hàng |
| asPODeletePO5 | POVchPO5 | Xóa hóa đơn mua hàng |
| asPOGetPO6 | PoVchPO6 | Lấy hóa đơn dịch vụ |
| asPOSavePO6 | PoVchPO6 | Lưu hóa đơn dịch vụ |
| asPODeletePO6 | PoVchPO6 | Xóa hóa đơn dịch vụ |
| asPOGetPO7 | POVchPO7 | Lấy hóa đơn nhập khẩu |
| asPOSavePO7 | POVchPO7 | Lưu hóa đơn nhập khẩu |
| asPODeletePO7 | POVchPO7 | Xóa hóa đơn nhập khẩu |

## Danh sách Lookup Codes

| Code | Description | Sử dụng trong |
|------|-------------|---------------|
| MA_NCC | Nhà cung cấp | Tất cả |
| MA_NHKH | Nhóm nhà cung cấp | Tất cả |
| MA_VT | Vật tư | Tất cả |
| MA_NHVT | Nhóm vật tư | Tất cả |
| MA_KHO | Kho | Tất cả |
| MA_HD | Hợp đồng | Tất cả |
| MA_NHHD | Nhóm hợp đồng | Tất cả |
| MA_PLKH | Phân loại khách hàng | Tất cả |
| MA_PHI | Phí | Tất cả |
| MA_SPCT | Sản phẩm công trình | Tất cả |
| MA_HTTT | Hình thức thanh toán | Tất cả |
| MA_TT_PO | Điều khoản thanh toán PO | Tất cả |
| MA_LO | Lô | Tất cả |
| MA_VITRI | Vị trí | Tất cả |
| MA_PLVT | Phân loại vật tư | Tất cả |

## Key Fields - Các trường dữ liệu chính

### Thông tin chung

| Field | Description |
|-------|-------------|
| ma_kh | Mã nhà cung cấp |
| ma_vt | Mã vật tư |
| ma_kho | Mã kho |
| ma_nt | Mã ngoại tệ |
| ty_gia | Tỷ giá |

### Thông tin thanh toán

| Field | Description |
|-------|-------------|
| ma_httt | Mã hình thức thanh toán |
| ma_tt_po | Mã điều khoản thanh toán |
| tk_pt | Tài khoản phải trả |
| tk_thue | Tài khoản thuế |

### Thông tin tiền tệ

| Field | Description |
|-------|-------------|
| t_tien_nt0 | Tổng tiền hàng NT |
| t_tien0 | Tổng tiền hàng |
| t_thue_nt | Tổng thuế NT |
| t_thue | Tổng thuế |
| t_tt_nt | Tổng thanh toán NT |
| t_tt | Tổng thanh toán |
| t_ck_nt | Tổng chiết khấu NT |
| t_ck | Tổng chiết khấu |

## Business Flow

```
┌─────────────────┐
│  PO1            │
│  Đơn đặt hàng   │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│  PO3            │
│  Hóa đơn mua    │
└────────┬────────┘
         │
         ▼
┌─────────────────┐     ┌─────────────────┐
│  PO4            │────▶│  PO5            │
│  Phiếu nhập kho │     │  Trả lại hàng   │
└─────────────────┘     └─────────────────┘
```

## Special Vouchers

- **PO6**: Mua dịch vụ (không qua kho)
- **PO7**: Nhập kho nội bộ
- **TAI**: Thuế đầu vào (trong POTAIN.dll)

## Technical Stack

- **Framework**: .NET Framework 3.5
- **Language**: C#
- **UI**: Windows Forms
- **Report**: Crystal Reports
- **Database**: SQL Server

## Dependencies

```
PO Module
├── AsiaErp.Framework
├── AsiaErp.Helper
├── AsiaErp.POUtilities (shared)
├── Microsoft.VisualBasic
├── System.Data
└── CrystalDecisions.* (for reports)
```

## Lưu ý chuyển đổi sang PHP

### 1. Reports

- Sử dụng DataTables hoặc Grid component cho hiển thị
- Xuất Excel sử dụng library PhpSpreadsheet
- Drilldown sử dụng modal hoặc tab mới
- Filter sử dụng form với các lookup component

### 2. Vouchers

- Master-Detail form với tabs
- Grid editable cho chi tiết
- Auto-calculation khi thay đổi số liệu
- Validation trước khi save
- Number format cho các trường tiền tệ

### 3. Common

- Lookup component dùng chung cho các mã danh mục
- Date picker cho các trường ngày
- Currency mask cho các trường tiền
- Multi-language support
- Permission check cho các action

## Documentation Structure

```
docs/asia/po/
├── README.md           # Overview
├── vouchers/
│   ├── PO1.md         # Đơn đặt hàng
│   ├── PO3.md         # Hóa đơn mua
│   ├── PO4.md         # Phiếu nhập kho
│   ├── PO5.md         # Trả lại hàng
│   ├── PO6.md         # Mua dịch vụ
│   └── PO7.md         # Nhập kho nội bộ
└── (categories & reports documented in README)
```

## Thống kê

| Loại | Số lượng |
|------|----------|
| Tổng số DLL | 18 |
| Tổng số Reports | 8 |
| Tổng số Vouchers | 6 |
| Tổng số Danh mục | 3 |
| Tổng số SP | ~25 |
| Tổng số Lookup Codes | 14 |

## Notes

- All vouchers inherit from `frmVoucher`
- All categories inherit from `frmDMView`/`frmDMEdit`
- All reports inherit from `frmReport`
- Multi-currency support (VND/Foreign currency)
- Integrated with Asia ERP permission system

## Analysis Info

- Phân tích: Sub-agent (analyze-po)
- Thời gian: 2026-03-26
- Workspace: /root/.openclaw/workspace/projects/SimbaSql
