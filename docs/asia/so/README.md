# Module SO - Sales Order (Bán hàng)

## Tổng quan

Module **Sales Order (SO)** là module quản lý toàn bộ nghiệp vụ bán hàng trong hệ thống Asia ERP, bao gồm từ đơn hàng, xuất kho, đến lập hóa đơn và xử lý trả hàng.

## Chức năng chính

| Nhóm | Chức năng |
|------|------------|
| **Đơn hàng** | Tạo và quản lý đơn hàng từ khách hàng |
| **Xuất kho** | Quản lý phiếu xuất kho hàng hóa |
| **Hóa đơn** | Lập hóa đơn VAT bán hàng |
| **Dịch vụ** | Xuất hóa đơn dịch vụ (không qua kho) |
| **Trả hàng** | Xử lý hàng bán bị trả lại |
| **Danh mục** | Quản lý các danh mục liên quan |
| **Báo cáo** | Báo cáo bán hàng, doanh thu, công nợ |

## Cấu trúc chứng từ

### Luồng nghiệp vụ chuẩn

```
┌─────────────┐     ┌─────────────┐     ┌─────────────┐
│   SO1       │ ──▶ │   SO2       │ ──▶ │   SO3       │
│ Đơn hàng    │     │ Phiếu xuất  │     │ Hóa đơn     │
│   bán       │     │    kho      │     │  bán hàng   │
└─────────────┘     └─────────────┘     └─────────────┘
       │                    │                    │
       │                    │                    │
       ▼                    ▼                    ▼
   Tồn kho            Giá vốn           Doanh thu
   (dự kiến)          (thực xuất)       (ghi nhận)
```

### Luồng dịch vụ

```
┌─────────────┐     ┌─────────────┐
│   SO5       │ ──▶ │    CA       │
│ Hóa đơn     │     │ Thu tiền    │
│ dịch vụ     │     │             │
└─────────────┘     └─────────────┘
```

### Luồng trả hàng

```
┌─────────────┐     ┌─────────────┐
│   SO3       │ ──▶ │   SO4       │
│ Hóa đơn     │     │ Phiếu nhập  │
│  gốc        │     │  trả hàng   │
└─────────────┘     └─────────────┘
```

## Danh sách chứng từ

| Mã | Tên | DLL | Mô tả |
|----|-----|-----|--------|
| [SO1](./vouchers/SO1.md) | Đơn hàng bán | SOVchSO1.dll | Chứng từ đặt hàng từ khách |
| [SO2](./vouchers/SO2.md) | Phiếu xuất kho | SOVchSO3.dll | Xuất kho giao hàng |
| [SO3](./vouchers/SO3.md) | Hóa đơn bán hàng | SOVchSO3.dll | Hóa đơn VAT hàng hóa |
| [SO3_](./vouchers/SO3_.md) | Phiếu xuất kho (mở rộng) | SOVchSO3_.dll | Xuất kho với barcode |
| [SO4](./vouchers/SO4.md) | Phiếu nhập hàng bán bị trả lại | SOVchSO4.dll | Xử lý trả hàng |
| [SO5](./vouchers/SO5.md) | Hóa đơn bán dịch vụ | SOVchSO5.dll | Hóa đơn dịch vụ |

## Danh mục liên quan

### Danh mục cơ bản

| Mã | Tên | DLL | Mô tả |
|----|-----|-----|--------|
| SODMCK | Danh mục chuyển khoản | SODMCK.dll | TK chuyển khoản thanh toán |
| SODMDGVT | Danh mục đơn giá vật tư | SODMDGVT.dll | Lịch sử đơn giá VT |
| SODMDKTT | Danh mục điều khoản thanh toán | SODMDKTT.dll | Hạn thanh toán, chiết khấu |
| SODMGIABAN | Danh mục giá bán | SODMGIABAN.dll | Giá bán theo KH/VT |
| SODMHHKM | Danh mục hàng hóa khuyến mãi | SODMHHKM.dll | CT khuyến mãi |
| SODMHTTT | Danh mục hình thức thanh toán | SODMHTTT.dll | TM, CK, Thẻ... |
| SODMKM | Danh mục khuyến mãi | SODMKM.dll | Chương trình KM |
| SODMNVKD | Danh mục nhân viên kinh doanh | SODMNVKD.dll | NVKD và target |
| SODMPTVT | Danh mục phương tiện vận tải | SODMPTVT.dll | Thông số phương tiện |
| SODMTD | Danh mục tuyến đường | SODMTD.dll | Khoảng cách tuyến đường |
| SODMTKM | Danh mục trả khuyến mãi | SODMTKM.dll | Chính sách trả KM |
| SODMTS | Danh mục thuế suất | SODMTS.dll | Thuế suất GTGT |

## Quản lý hóa đơn (SOND51)

### Danh mục hóa đơn

| DLL | Tên | Mô tả |
|-----|-----|-------|
| SOND51adhd | Quyết định áp dụng hóa đơn | Đăng ký áp dụng hóa đơn tự in |
| SOND51dmmhd | Danh mục mẫu hóa đơn | Quản lý mẫu số, ký hiệu |
| SOND51mhd | Khổ/bảng in hóa đơn | Định nghĩa khổ in, liên |
| SOND51mathd | Mã hóa đơn | Quản lý mã tờ báo cáo |
| SOND51phhd | Phát hành hóa đơn | Quản lý đợt phát hành |
| SOND51bmhd | Bảo mật hóa đơn | Mã hóa, xác thực hóa đơn |

### Thông báo hóa đơn

| DLL | Tên | Mô tả |
|-----|-----|-------|
| SOND51HuyHD | Hủy hóa đơn | Thông báo hủy với CQ thuế |
| SOND51bkhd | Bảng kê hóa đơn | Hết giá trị & gia hạn |
| SOND51mchhd | Mất cháy hỏng hóa đơn | Thông báo mất/cháy/hỏng |
| SOND51xoahd | Xóa hóa đơn | Thông báo xóa hóa đơn |

## Báo cáo

### Báo cáo phân tích

| Mã | Tên | DLL | Mô tả |
|----|-----|-----|--------|
| SORptBCPT03 | Báo cáo phân tích 03 | SORptBCPT03.dll | Phân tích bán hàng |
| SORptBCPT04 | Báo cáo phân tích 04 | SORptBCPT04.dll | Doanh số theo BP/NVKD |
| SORptBCPT06 | Báo cáo phân tích 06 | SORptBCPT06.dll | Báo cáo 2 chỉ tiêu |

### Báo cáo tổng hợp

| Mã | Tên | DLL | Mô tả |
|----|-----|-----|--------|
| SORptTH01 | Tổng hợp bán hàng 01 | SORptTH01.dll | Tổng quan doanh số |
| SORptTH02 | Tổng hợp bán hàng 02 | SORptTH02.dll | Theo kỳ (tháng/quý/năm) |

### Bảng kê

| Mã | Tên | DLL | Mô tả |
|----|-----|-----|--------|
| SORptBK01 | Bảng kê chứng từ bán hàng | SORptBK01.dll | Dạng master-detail |
| SORptBK02 | Bảng kê hóa đơn nhóm | SORptBK02.dll | Nhóm theo chỉ tiêu |

### Báo cáo đặc biệt

| Mã | Tên | DLL | Mô tả |
|----|-----|-----|--------|
| SORptLaiLo | Báo cáo lãi lỗ | SORptLaiLo.dll | Lãi lỗ theo hợp đồng |

### Báo cáo Drill-down (F5)

| Mã | Tên | DLL | Mô tả |
|----|-----|-----|--------|
| SORptF5BCPT03 | Drill-down BCPT03 | SORptF5BCPT03.dll | Chi tiết BCPT03 |
| SORptF5BCPT04 | Drill-down BCPT04 | SORptF5BCPT04.dll | Chi tiết BCPT04 |
| SORptF5BCPT06 | Drill-down BCPT06 | SORptF5BCPT06.dll | Chi tiết BCPT06 |
| SORptF5TH0 | Drill-down tổng hợp | SORptF5TH0.dll | Chi tiết tổng hợp |

## Tiện ích (Utilities)

| DLL | Tên | Mô tả |
|-----|-----|-------|
| SOUtilities | Tiện ích bán hàng | Pricing, lookup chain, print control |
| SOTaOut | Thuế đầu ra | Quản lý hóa đơn đầu ra |

## Các hàm tiện ích chính (SOUtilities)

### Pricing

| Hàm | Mô tả |
|-----|-------|
| Get_GiaBan | Lấy giá bán theo vật tư, ngoại tệ, ngày |
| Get_GiaGiamGia | Lấy giá và tính chiết khấu |

### Lookup Chain

| Hàm | Mô tả |
|-----|-------|
| SOLookupDH4PX | Lookup Đơn hàng → Phiếu xuất |
| SOLookupDH4HD | Lookup Đơn hàng → Hóa đơn |
| SOLookupPX4HD | Lookup Phiếu xuất → Hóa đơn |
| SOLookupPX4PN | Lookup Phiếu xuất → Phiếu nhập |
| SOLookupHD4PN | Lookup Hóa đơn → Phiếu nhập |

### Print & Rights

| Hàm | Mô tả |
|-----|-------|
| Get_RightPrint | Kiểm tra quyền in |
| SoInsLogPrint | Ghi log in ấn |
| SOChkStatusRightSO1-5 | Check quyền chứng từ |

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls
- AsiaErp.SOUtilities
- CrystalDecisions (báo cáo)

## Ghi chú

- Module SO tích hợp chặt chẽ với module tồn kho (IN) và công nợ (AR)
- Hỗ trợ đa tiền tệ với tỷ giá tự động
- Có thể cấu hình nhiều loại giá bán theo khách hàng
- Hỗ trợ in hóa đơn VAT qua Crystal Reports
