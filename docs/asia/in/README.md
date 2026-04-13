# Module IN (Inventory) - Quản lý kho

## Tổng quan

Module IN (Inventory) là phân hệ quản lý kho và vật tư trong hệ thống ERP Asia Enterprise/Simba Accounting. Module này cung cấp đầy đủ các chức năng từ quản lý danh mục, nhập/xuất kho, đến báo cáo và tính giá tồn kho.

## Danh mục chứng từ (Vouchers)

| Mã | Tên chứng từ | File DLL | Mô tả |
|----|-------------|----------|-------|
| [IN1](./vouchers/IN1.md) | Phiếu nhập kho | INVchIN1.dll | Nhập hàng hóa/vật tư vào kho |
| [IN2](./vouchers/IN2.md) | Phiếu xuất kho | INVchIN2.dll | Xuất hàng hóa/vật tư khỏi kho |
| [IN3](./vouchers/IN3.md) | Phiếu chuyển kho | INVchIN3.dll | Chuyển hàng giữa các kho nội bộ |
| [IN5](./vouchers/IN5.md) | Phiếu xuất CCDC | INVchIN5.dll | Xuất công cụ dụng cụ |
| [IN6](./vouchers/IN6.md) | Phiếu lắp ráp/tháo dỡ | INVchIN6.dll | Chuyển đổi chi tiết/thành phẩm |

## Danh mục (Masters)

| Mã | Tên danh mục | File DLL | Mô tả |
|----|-------------|----------|-------|
| INDMKHO | Danh mục kho | INDMKHO.dll | Quản lý danh sách kho |
| INDMLO | Danh mục lô | INDMLO.dll | Quản lý lô hàng, hạn dùng |
| INDMNHVT | Danh mục nhóm vật tư | INDMNHVT.dll | Phân nhóm vật tư theo cây |
| INDMVT | Danh mục vật tư | INDMVT.dll | Quản lý thông tin vật tư |
| INDMVT_ | Danh mục vật tư (BOM) | INDMVT_.dll | Vật tư với quản lý BOM |
| INDMPLVT | Danh mục phân loại VT | INDMPLVT.dll | Phân loại vật tư |
| INDMNHVAT | Danh mục nhóm VAT | INDMNHVAT.dll | Nhóm hàng cho thuế VAT |

## Báo cáo (Reports)

| Mã | Tên báo cáo | File DLL | Mô tả |
|----|------------|----------|-------|
| INRptBK01 | Bảng kê chứng từ | INRptBK01.dll | Liệt kê chứng từ theo tháng |
| INRptBKN04 | Bảng kê phiếu nhập | INRptBKN04.dll | Chi tiết phiếu nhập kho |
| INRptBKX04 | Bảng kê phiếu xuất | INRptBKX04.dll | Chi tiết phiếu xuất kho |
| INRptCD01 | Báo cáo công nợ 01 | INRptCD01.dll | Tồn đầu/PS nhập/PS xuất/Tồn cuối |
| INRptCD02 | Báo cáo tồn kho | INRptCD02.dll | Tồn kho với cảnh báo tồn tối đa/thiểu |
| INRptCTVT01 | Báo cáo chi tiết VT 01 | INRptCTVT01.dll | Chi tiết nhập xuất từng vật tư |
| INRptCTVT02 | Thẻ kho - Sổ chi tiết | INRptCTVT02.dll | In thẻ kho cho tất cả vật tư |
| INRptF5CD01 | Công nợ F5 01 | INRptF5CD01.dll | Báo cáo drill-down công nợ |
| INRptTHN01 | Tổng hợp nhập 01 | INRptTHN01.dll | Tổng hợp hàng nhập kho |
| INRptTHN02 | Tổng hợp nhập 02 | INRptTHN02.dll | Tổng hợp nhập nâng cao |
| INRptTHX01 | Tổng hợp xuất 01 | INRptTHX01.dll | Tổng hợp hàng xuất kho |
| INRptTHX02 | Tổng hợp xuất 02 | INRptTHX02.dll | Tổng hợp xuất nâng cao |

## Tiện ích (Utilities)

| Mã | Tên tiện ích | File DLL | Mô tả |
|----|-------------|----------|-------|
| INCDVT | Nhập số tồn kho đầu kỳ | INCDVT.dll | Nhập số dư đầu kỳ vật tư |
| INCDFIFO | Công nợ định mức FIFO | INCDFIFO.dll | Theo dõi công nợ theo FIFO |
| INCalGiaBQDD | Tính giá bình quân di động | INCalGiaBQDD.dll | Tính giá BQ di động |
| INCalGiaNTXT | Tính giá nhập trước xuất trước | INCalGiaNTXT.dll | Tính giá FIFO |
| INCalGiaTB | Tính giá trung bình tháng | INCalGiaTB.dll | Tính giá trung bình |
| INTransferINCDVT | Chuyển tồn kho năm sau | INTransferINCDVT.dll | Chuyển số dư sang năm mới |

## Các phương pháp tính giá tồn kho

| Phương pháp | Mã | Module | Mô tả |
|------------|-----|--------|-------|
| Giá trung bình tháng | 1 | INCalGiaTB.dll | Tính giá TB cuối tháng |
| Nhập trước xuất trước (FIFO) | 2 | INCalGiaNTXT.dll | Xuất theo giá nhập đầu tiên |
| Bình quân di động | 3 | INCalGiaBQDD.dll | Tính giá sau mỗi lần nhập |
| Đích danh | 4 | - | Xuất theo lô nhập cụ thể |

## Thuật ngữ chung

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_vt` | Mã vật tư |
| `ma_kho` | Mã kho |
| `ma_nhvt` | Mã nhóm vật tư |
| `ma_lo` | Mã lô |
| `tk_vt` | Tài khoản vật tư |
| `so_luong` | Số lượng |
| `gia_nt` | Giá ngoại tệ |
| `tien_nt` | Tiền ngoại tệ |
| `gia` | Giá VND |
| `tien` | Tiền VND |
| `ton_dau` | Tồn đầu kỳ |
| `ps_nhap` | Phát sinh nhập |
| `ps_xuat` | Phát sinh xuất |
| `ton_cuoi` | Tồn cuối kỳ |

## Dependencies

- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper
- `CrystalDecisions.CrystalReports.Engine` - Crystal Reports

## Framework

- .NET Framework 3.5
- Windows Forms
- C#

## Version

- Asia Enterprise: 9.1.0.0
- Simba Accounting: 14.1.0.0

## Company

- Asia Software Development JSC
- Copyright © AsiaSoft 2010-2014
