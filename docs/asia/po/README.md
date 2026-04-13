# Module PO (Purchase Order) - Mua hàng

## Tổng quan

Module Mua hàng (PO) là một trong những module quan trọng của hệ thống ERP Asia Enterprise/Simba Accounting, quản lý toàn bộ quy trình mua hàng từ đơn đặt hàng đến nhập kho và thanh toán.

## Danh mục (Categories)

| Mã | Tên | Assembly | Mô tả |
|----|-----|----------|---------|
| PODMCP | Danh mục chương trình mua hàng | PODMCP.dll | Quản lý các chương trình mua hàng |
| PODMDKTT | Danh mục điều khoản thanh toán mua | PODMDKTT.dll | Quản lý điều khoản thanh toán với NCC |
| PODMHTTT | Danh mục hình thức thanh toán mua | PODMHTTT.dll | Quản lý hình thức TT và TK kế toán |

### PODMCP - Danh mục chương trình mua hàng

| Trường | Ý nghĩa |
|---------|----------|
| ma_cp | Mã chương trình mua hàng |
| ten_cp | Tên chương trình mua hàng |
| tt_pb | Thông tin phân bổ |

### PODMDKTT - Danh mục điều khoản thanh toán mua

| Trường | Ý nghĩa |
|---------|----------|
| ma_tt_po | Mã điều khoản thanh toán mua |
| mo_ta | Mô tả điều khoản |
| han_tt | Hạn thanh toán (ngày) |
| tl_ck | Tỷ lệ chiết khấu (%) |
| han_ck | Hạn chiết khấu (ngày) |
| ls_qh | Lãi suất quá hạn |

### PODMHTTT - Danh mục hình thức thanh toán mua

| Trường | Ý nghĩa |
|---------|----------|
| ma_httt | Mã hình thức thanh toán |
| ten_httt | Tên hình thức thanh toán |
| tk | Tài khoản thanh toán |
| tk_thue_mua | Tài khoản thuế GTGT mua |
| tk_thue_nk | Tài khoản thuế nhập khẩu |
| tk_gtgt_nk_no/co | Tài khoản GTGT NK nợ/có |
| tk_thue_ttdb | Tài khoản thuế tiêu thụ đặc biệt |
| tk_ck | Tài khoản chiết khấu |

## Chứng từ (Vouchers)

| Mã | Tên | Assembly | Mô tả |
|----|-----|----------|---------|
| PO1 | Đơn đặt hàng mua | POVchPO1.dll | Tạo đơn đặt hàng với NCC |
| PO3 | Hóa đơn mua hàng | POVchPO3.dll | Nhập hóa đơn mua hàng |
| PO4 | Phiếu nhập kho | POVchPO4.dll | Nhập hàng vào kho |
| PO5 | Phiếu trả lại hàng mua | POVchPO5.dll | Trả lại hàng cho NCC |
| PO6 | Hóa đơn mua dịch vụ | PoVchPO6.dll | Mua dịch vụ/hàng không qua kho |
| PO7 | Phiếu nhập kho nội bộ | POVchPO7.dll | Nhập kho nội bộ |

Chi tiết xem tại [vouchers/](vouchers/)

## Báo cáo (Reports)

| Mã | Tên | Assembly | Mô tả |
|----|-----|----------|---------|
| PORptBCPT03 | Báo cáo mua hàng theo hai chỉ tiêu | PORptBCPT03.dll | Phân tích mua hàng 2 chiều |
| PORptBK01 | Bảng kê chứng từ mua hàng | PORptBK01.dll | Bảng kê CT với Master-Detail |
| PORptBK02 | Bảng kê mua hàng nhóm theo chỉ tiêu | PORptBK02.dll | Nhóm CT theo 10 chỉ tiêu |
| PORptBK03 | Bảng kê chi phí mua hàng | PORptBK03.dll | Theo dõi chi phí mua hàng |
| PORptF5TH0 | Báo cáo tổng hợp F5 | PORptF5TH0.dll | Drill-down báo cáo tổng hợp |
| PORptTH01 | Báo cáo tổng hợp mua hàng 01 | PORptTH01.dll | Tổng hợp mua hàng |
| PORptTH02 | Báo cáo tổng hợp mua hàng 02 | PORptTH02.dll | Tổng hợp theo tháng/quý/năm |
| PORptTH03 | Tổng hợp chi phí mua hàng | PORptTH03.dll | Tổng hợp chi phí |

## Tiện ích (Utilities)

| Mã | Tên | Assembly | Mô tả |
|----|-----|----------|---------|
| POTAIN | Thuế đầu vào | POTAIN.dll | Quản lý thuế GTGT mua vào |
| POUtilities | Tiện ích PO | POUtilities.dll | Thanh toán chứng từ PO |

### POTAIN - Thuế đầu vào

- Mã chứng từ: **TAI**
- Quản lý thuế GTGT của các chứng từ mua hàng
- Validate chỉ cho phép sửa/xóa các bản ghi có `ma_ct = "TAI"`

### POUtilities - Thanh toán chứng từ PO

- Tạo chứng từ thanh toán cho các hóa đơn mua hàng
- Hỗ trợ 2 loại: Phiếu chi (CA2) và Báo nợ (CA4)
- Tích hợp Crystal Reports cho in ấn

## Quy trình nghiệp vụ

```
Đơn đặt hàng (PO1) → Hóa đơn mua (PO3) → Phiếu nhập kho (PO4)
                                           ↓
                              Phiếu trả lại hàng (PO5) ← (nếu có)
```

## Các chứng từ đặc biệt

- **PO6**: Mua dịch vụ/hàng hóa không qua kho
- **PO7**: Nhập kho nội bộ (không qua quy trình mua hàng thông thường)

## Dependencies chung

- AsiaErp.Framework
- AsiaErp.Helper
- AsiaErp.POUtilities (cho các voucher)
- Microsoft.VisualBasic
- System.Data
- CrystalDecisions.CrystalReports.Engine (cho báo cáo)

## Ghi chú

- Tất cả các voucher kế thừa từ `frmVoucher`
- Tất cả các danh mục kế thừa từ `frmDMView`/`frmDMEdit` hoặc `frmDMComplexView`/`frmDMComplexEdit`
- Tất cả các báo cáo kế thừa từ `frmReport` hoặc `frmReport2DGV`
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ) với tỷ giá linh hoạt
- Tích hợp phân quyền của Asia ERP
