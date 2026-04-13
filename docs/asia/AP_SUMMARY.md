# AP Module Summary - ASIA ERP

## Tổng quan Module AP (Accounts Payable)

Module AP quản lý công nợ phải trả, bao gồm:
- Chứng từ thanh toán phải trả
- Phân bổ thanh toán cho hóa đơn
- Điều khoản thanh toán mua hàng
- Các báo cáo công nợ phải trả

## Danh sách Components

### 1. Reports (3 files)

| DLL | Chức năng | Mã BC | Mô tả |
|-----|-----------|-------|-------|
| APRptBK01 | Bảng kê chứng từ mua hàng | BK01 | Chi tiết chứng từ mua hàng với nhiều điều kiện lọc |
| APRptBK02 | Bảng kê công nợ theo hạn | BK02 | Aging report phân loại công nợ theo hạn kỳ thanh toán |
| APRptBK03 | Bảng kê phiếu chi thanh toán | BK03 | Liệt kê phiếu chi/ủy nhiệm chi thanh toán tiền hàng |

### 2. Vouchers (2 files)

| DLL | Chức năng | Mã CT | Mô tả |
|-----|-----------|-------|-------|
| ApVchAP4 | Chứng từ thanh toán | AP4 | Thanh toán phải trả dạng grid nhập liệu |
| APPost2TT | Phân bổ thanh toán | - | Phân bổ tiền thanh toán cho các hóa đơn chưa tất toán |

### 3. Danh mục/Utility (1 file)

| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| APTT | Điều khoản thanh toán | Quản lý điều khoản thanh toán với nhà cung cấp |

## Chi tiết chức năng

### APRptBK01 - Bảng kê chứng từ mua hàng
- Lọc theo nhà cung cấp, nhóm NCC, phân loại NCC
- Lọc theo mã vật tư, nhóm vật tư
- Lọc theo bộ phận, hợp đồng, kho
- Lọc theo loại chứng từ (Hóa đơn/Đơn hàng)
- Sắp xếp theo nhà cung cấp

### APRptBK02 - Bảng kê công nợ theo hạn thanh toán
- Ngày so sánh để phân loại công nợ
- 3 hạn kỳ thanh toán tùy chỉnh (han_ky1, han_ky2, han_ky3)
- Phân loại: Còn hạn, Quá hạn kỳ 1, Quá hạn kỳ 2, Quá hạn kỳ 3
- Lọc theo trạng thái: Chưa tất toán, Đã tất toán, Tất cả

### APRptBK03 - Bảng kê phiếu chi thanh toán
- Liệt kê phiếu chi/ủy nhiệm chi thanh toán
- Lọc theo nhà cung cấp, nhóm NCC, phân loại NCC (3 cấp)
- Lọc theo loại giao dịch (Hóa đơn/Đơn hàng)
- Lọc theo số chứng từ (từ số - đến số)
- Lọc theo trạng thái tất toán

### ApVchAP4 - Chứng từ thanh toán
- Nhập chứng từ thanh toán công nợ phải trả
- Header: Ngày CT, Số CT, Ngoại tệ, Tỷ giá
- Detail: Grid nhập liệu với TK, Mã KH, Ps nợ/NT, Ps có/NT
- Chế độ ngoại tệ chung/riêng
- Kiểm tra nhóm định khoản cân đối nợ/có

### APPost2TT - Phân bổ thanh toán
- Chọn chứng từ thanh toán (phiếu chi, ủy nhiệm chi)
- Phân bổ số tiền thanh toán cho các hóa đơn chưa tất toán
- Hỗ trợ đa tiền tệ với tỷ giá chuyển đổi
- Tính toán tự động số tiền còn lại sau phân bổ

### APTT - Điều khoản thanh toán
- Tạo và quản lý điều khoản thanh toán với nhà cung cấp
- Liên kết với hợp đồng mua hàng
- Thiết lập hạn thanh toán và chiết khấu
- Quản lý lãi suất quá hạn
- Tính toán tự động: Tổng thanh toán = Tiền hàng + Tiền thuế

## Stored Procedures chính

### Reports
| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| sp_rpt_ap_bk01 | APRptBK01 | Bảng kê chứng từ mua hàng |
| sp_rpt_ap_bk02 | APRptBK02 | Công nợ theo hạn thanh toán |
| sp_rpt_ap_bk03 | APRptBK03 | Chi tiết công nợ phải trả |

### Vouchers
| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| sp_get_apvchap4_ph | ApVchAP4 | Lấy thông tin phiếu thanh toán |
| sp_get_apvchap4_ct | ApVchAP4 | Lấy chi tiết phiếu thanh toán |
| sp_insert_apvchap4 | ApVchAP4 | Thêm chứng từ thanh toán |
| sp_update_apvchap4 | ApVchAP4 | Cập nhật chứng từ thanh toán |
| sp_delete_apvchap4 | ApVchAP4 | Xóa chứng từ thanh toán |
| sp_get_appost2tt | APPost2TT | Lấy thông tin phân bổ thanh toán |
| sp_insert_appost2tt | APPost2TT | Thêm phân bổ thanh toán |
| sp_update_appost2tt | APPost2TT | Cập nhật phân bổ thanh toán |

### Danh mục
| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| sp_get_aptt | APTT | Lấy danh sách điều khoản thanh toán |
| sp_insert_aptt | APTT | Thêm mới điều khoản thanh toán |
| sp_update_aptt | APTT | Cập nhật điều khoản thanh toán |
| sp_delete_aptt | APTT | Xóa điều khoản thanh toán |

## Tables liên quan

### Header tables
| Table | Mô tả |
|-------|-------|
| apvchap4_ph | Phiếu thanh toán header |
| aptt | Điều khoản thanh toán |
| appost2tt | Phân bổ thanh toán |

### Detail tables
| Table | Mô tả |
|-------|-------|
| apvchap4_ct | Phiếu thanh toán chi tiết |
| apbk01 | Dữ liệu bảng kê chứng từ mua hàng |
| apbk02 | Dữ liệu bảng kê công nợ theo hạn |
| apbk03 | Dữ liệu chi tiết công nợ |

### Danh mục liên quan
| Table | Mô tả |
|-------|-------|
| dmkh | Danh mục khách hàng/NCC |
| dmvt | Danh mục vật tư |
| dmnhvt | Danh mục nhóm vật tư |
| dmkho | Danh mục kho |
| dmbp | Danh mục bộ phận |
| dmhd | Danh mục hợp đồng |
| dmphi | Danh mục phí |
| dmlo | Danh mục lô |
| dmspct | Danh mục SPCT |
| dmplkh | Danh mục phân loại KH |
| dmnt | Danh mục ngoại tệ |
| dmtt_po | Danh mục thời hạn thanh toán |
| dmtk | Danh mục tài khoản |

## Cross-module interactions

```
PO (Mua hàng) → AP (Công nợ phải trả) → GL (Sổ cái)
```

- Nhận dữ liệu từ module PO (hóa đơn mua hàng)
- Post thanh toán sang module GL qua sp_post2gl
- Liên kết với module CA cho chứng từ chi tiền

## Business logic patterns

### 1. Voucher Pattern (ApVchAP4)
- Header: Ngày CT, Số CT, Ngoại tệ, Tỷ giá
- Detail: Grid nhập liệu với TK, Mã KH, Ps nợ/NT, Ps có/NT
- Chế độ ngoại tệ chung/riêng
- Kiểm tra nhóm định khoản cân đối nợ/có

### 2. Aging Report Pattern (APRptBK02)
- Ngày so sánh
- 3 hạn kỳ thanh toán tùy chỉnh
- Phân loại: Chưa đến hạn, Hạn kỳ 1-3, Quá hạn

### 3. Payment Terms Pattern (APTT)
- Liên kết với dmtt_po để lấy hạn CK, hạn TT, tỷ lệ CK, lãi suất QH
- Tính toán tự động: Tổng thanh toán = Tiền hàng + Tiền thuế
- Dư hợp đồng = Tổng thanh toán - Tiền đã thanh toán

### 4. Payment Allocation Pattern (APPost2TT)
- Chọn chứng từ thanh toán
- Phân bổ cho hóa đơn chưa tất toán
- Tính toán số tiền còn lại
- Chuyển đổi ngoại tệ theo tỷ giá

## Tổng kết

- Tổng số DLL: 5
- Tổng số Reports: 3
- Tổng số Vouchers: 2
- Tổng số Danh mục: 1
- Tổng số SP: ~20
