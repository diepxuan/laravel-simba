# AR Module Summary - ASIA ERP

## Tổng quan Module AR (Accounts Receivable)

Module AR quản lý công nợ phải thu, bao gồm:
- Chứng từ hạch toán công nợ
- Phân bổ thanh toán cho hóa đơn
- Danh mục điều khoản thanh toán
- Các báo cáo công nợ phải thu đa dạng

## Danh sách Components

### 1. Danh mục (4 files)

| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| ARDMKH | Danh mục khách hàng | Quản lý thông tin khách hàng |
| ARDMNHKH | Danh mục nhóm khách hàng | Phân nhóm khách hàng |
| ARDMPLKH | Danh mục phân loại khách hàng | Phân loại KH theo 3 cấp độ |
| ARTT | Điều khoản thanh toán | Quản lý ĐMTT |

### 2. Vouchers (1 file)

| DLL | Chức năng | Mã CT | Mô tả |
|-----|-----------|-------|-------|
| ARVchAR4 | Chứng từ hạch toán công nợ | AR4 | Hạch toán công nợ tổng quát, bù trừ công nợ |

### 3. Reports - Bảng cân đối công nợ (6 files)

| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| ARRptBCCN01 | Công nợ theo TK và KH | Báo cáo cơ bản công nợ khách hàng |
| ARRptBCCN01a | Công nợ dạng Excel nâng cao | Xuất Excel cho nhiều khách hàng |
| ARRptBCCN02 | Công nợ theo phân loại | 3 cấp phân loại khách hàng |
| ARRptBCCN03 | Công nợ tổng hợp theo phân loại | Tổng hợp theo nhóm KH |
| ARRptBCCN04 | Công nợ nhóm và chi tiết | Nhóm theo KH/HD/SPCT/BP |
| ARRptBCCN05 | Đối chiếu công nợ | In thư đối chiếu gửi khách hàng |
| ARRptBCCN06 | So sánh công nợ theo hạn kỳ | Aging report phân loại công nợ |

### 4. Reports - Bảng kê (3 files)

| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| ARRptBK01 | Bảng kê chứng từ bán hàng | Chi tiết với nhiều tiêu chí lọc |
| ARRptBK02 | Bảng kê công nợ theo hạn | Phân loại theo hạn kỳ |
| ARRptBK03 | Bảng kê chứng từ thanh toán | Thu/chi tiền |

### 5. Reports - Drill-down (1 file)

| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| ArRptF5BCCN01a | Chi tiết công nợ (F5) | Drill-down từ ARRptBCCN01a |

### 6. Posting (1 file)

| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| ARPost2TT | Phân bổ thanh toán | Post thanh toán cho hóa đơn |

### 7. Utilities (1 file)

| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| ARCDKH | Công nợ khách hàng | Xem và quản lý công nợ KH |
| ARRecalCustBalance | Tính lại số dư khách hàng | Recalculate customer balance |

## Stored Procedures chính

### Reports
| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| asARRptBCCN01 | ARRptBCCN01 | Công nợ theo TK và KH |
| asARRptBCCN01a_Crys | ARRptBCCN01a | Dữ liệu Excel nâng cao |
| asARRptBCCN02 | ARRptBCCN02 | Công nợ theo phân loại |
| asARRptBCCN03 | ARRptBCCN03 | Công nợ tổng hợp phân loại |
| asARRptBCCN04 | ARRptBCCN04 | Công nợ nhóm và chi tiết |
| asARRptBCCN05 | ARRptBCCN05 | Đối chiếu công nợ |
| asARRptBCCN06 | ARRptBCCN06 | So sánh công nợ theo hạn kỳ |
| asARRptBK01 | ARRptBK01 | Bảng kê chứng từ bán hàng |
| asARRptBK02 | ARRptBK02 | Bảng kê công nợ theo hạn |
| asARRptBK03 | ARRptBK03 | Bảng kê chứng từ thanh toán |

### Vouchers
| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| asARGetArVchAR4 | ARVchAR4 | Lấy chứng từ hạch toán |
| asARInsArVchAR4 | ARVchAR4 | Thêm chứng từ hạch toán |
| asARUpdArVchAR4 | ARVchAR4 | Cập nhật chứng từ hạch toán |
| asARDelArVchAR4 | ARVchAR4 | Xóa chứng từ hạch toán |

### Danh mục
| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| asARGetARTT | ARTT | Lấy danh sách điều khoản thanh toán |
| asARInsARTT | ARTT | Thêm điều khoản thanh toán |
| asARUpdARTT | ARTT | Cập nhật điều khoản thanh toán |
| asARDelARTT | ARTT | Xóa điều khoản thanh toán |

### Posting
| SP Name | DLL sử dụng | Mô tả |
|---------|-------------|-------|
| asARGetMaCT | ARPost2TT | Lấy danh sách chứng từ |
| asARGetPost2TT_ARTT | ARPost2TT | Lấy dữ liệu thanh toán |
| asARGetPost2TT | ARPost2TT | Lấy chi tiết thanh toán |
| asARInsPost2TT_ARTT | ARPost2TT | Thêm phân bổ thanh toán |
| asARDelPost2TT_ARTT | ARPost2TT | Xóa phân bổ thanh toán |

## Tables liên quan

### Header tables
| Table | Mô tả |
|-------|-------|
| ARCT | Chứng từ thanh toán |
| ARTT | Phân bổ thanh toán |

### Detail tables
| Table | Mô tả |
|-------|-------|
| ARCTCT | Chi tiết chứng từ thanh toán |
| ARDCTT | Chi tiết công nợ |

### Danh mục liên quan
| Table | Mô tả |
|-------|-------|
| dmkh | Danh mục khách hàng |
| dmnhkh | Danh mục nhóm khách hàng |
| dmplkh | Danh mục phân loại khách hàng |
| dmtk | Danh mục tài khoản |
| dmnt | Danh mục ngoại tệ |
| dmtt | Danh mục điều khoản thanh toán |
| dmbp | Danh mục bộ phận |
| dmphi | Danh mục phí |
| dmhd | Danh mục hợp đồng |
| dmspct | Danh mục sản phẩm công trình |
| dmvt | Danh mục vật tư |
| dmnhvt | Danh mục nhóm vật tư |
| dmkho | Danh mục kho |
| dmlo | Danh mục lô |
| dmnvkd | Danh mục nhân viên kinh doanh |

## Cross-module interactions

```
SO (Đơn hàng) → SI (Hóa đơn) → AR (Công nợ) → GL (Sổ cái)
```

- Nhận dữ liệu từ module SO/SI (hóa đơn bán hàng)
- Post công nợ sang module GL qua sp_post2gl
- Liên kết với module CA cho chứng từ thu tiền
- ARPost2TT phân bổ thanh toán từ CA cho các hóa đơn AR

## Business logic patterns

### 1. Aging Report Pattern
- Ngày so sánh (mặc định ngày hiện tại)
- 3 hạn kỳ thanh toán (lấy từ SOConfiguration)
- Phân loại: Chưa đến hạn, Hạn kỳ 1-3, Quá hạn
- Tính số ngày quá hạn = Ngày so sánh - Ngày đến hạn

### 2. Payment Allocation Pattern (ARPost2TT)
- Tìm chứng từ thanh toán (phiếu thu/chuyển khoản)
- Load danh sách hóa đơn chưa thanh toán hết của KH
- Nhập số tiền thanh toán cho từng hóa đơn
- Tính tiền thanh toán quy đổi = Tiền NT × Tỷ giá
- Validate: Tổng tiền TT không vượt quá số tiền chứng từ

### 3. Classification Pattern (ARRptBCCN02)
- 3 cấp phân loại khách hàng (plkh1, plkh2, plkh3)
- Thứ tự sắp xếp tùy chỉnh theo các cấp phân loại
- Validation: Các thứ tự không được trùng nhau

### 4. Voucher Pattern (ARVchAR4)
- Header: Ngày CT, Ngoại tệ, Tỷ giá
- Detail: Grid với TK, Mã KH, Ps nợ/NT, Ps có/NT
- Tính tiền VND = Tiền NT × Tỷ giá
- Validate: Tổng Ps nợ = Tổng Ps có

## Tổng kết

- Tổng số DLL: 16
- Tổng số Reports: 10 (6 BCCN + 3 BK + 1 F5)
- Tổng số Vouchers: 1
- Tổng số Danh mục: 4 (DMKH, DMNHKH, DMPLKH, ARTT)
- Tổng số Posting: 1
- Tổng số Utilities: 2 (ARCDKH, ARRecalCustBalance)
- Tổng số SP: ~35
