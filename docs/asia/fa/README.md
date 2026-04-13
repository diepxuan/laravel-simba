# FA Module - Fixed Assets

Module quản lý tài sản cố định (Fixed Assets).

## Cấu trúc thư mục

- `vouchers/` - Chứng từ nghiệp vụ FA
- `reports/` - Báo cáo FA
- `masters/` - Danh mục và dữ liệu nền tảng

## Vouchers

### Tính khấu hao và điều chỉnh

| File | Mô tả |
|------|-------|
| [FACalKHTS.md](vouchers/FACalKHTS.md) | Tính khấu hao tài sản cố định |
| [FAAdjustKHTS.md](vouchers/FAAdjustKHTS.md) | Điều chỉnh khấu hao tài sản |
| [FADelKHTS.md](vouchers/FADelKHTS.md) | Xóa khấu hao tài sản cố định |
| [FAThoiKHTS.md](vouchers/FAThoiKHTS.md) | Khai báo tạm ngưng khấu hao |

### Post và xóa bút toán GL

| File | Mô tả |
|------|-------|
| [FAPostTS2GL.md](vouchers/FAPostTS2GL.md) | Post phân bổ tài sản cố định sang GL |
| [FAPostCC2GL.md](vouchers/FAPostCC2GL.md) | Post phân bổ công cụ dụng cụ sang GL |
| [FADelTS2GL.md](vouchers/FADelTS2GL.md) | Xóa bút toán phân bổ tài sản cố định |
| [FADelCC2GL.md](vouchers/FADelCC2GL.md) | Xóa bút toán phân bổ công cụ dụng cụ |

### Biến động tài sản

| File | Mô tả |
|------|-------|
| [FADGTS.md](vouchers/FADGTS.md) | Đánh giá lại tài sản (tăng/giảm nguyên giá) |
| [FAGiamTS.md](vouchers/FAGiamTS.md) | Khai báo giảm tài sản cố định |
| [FAChuyenTS.md](vouchers/FAChuyenTS.md) | Chuyển tài sản (bộ phận, SPCT, mã phí, TK) |

### Công cụ dụng cụ

| File | Mô tả |
|------|-------|
| [FABHCC.md](vouchers/FABHCC.md) | Báo hỏng công cụ dụng cụ |

### Kiểm kê

| File | Mô tả |
|------|-------|
| [Fakkts.md](vouchers/Fakkts.md) | Kiểm kê tài sản cố định |

## Reports

### Báo cáo phân tích tài sản

| File | Mô tả |
|------|-------|
| [FARptBCPT01.md](reports/FARptBCPT01.md) | Báo cáo phân tích tài sản 01 |
| [FARptBCPT02.md](reports/FARptBCPT02.md) | Báo cáo phân tích tài sản 02 |
| [FARptBCPT03.md](reports/FARptBCPT03.md) | Báo cáo phân tích tài sản 03 |
| [FARptBCPT04.md](reports/FARptBCPT04.md) | Báo cáo phân tích tài sản 04 |
| [FARptBCPT05.md](reports/FARptBCPT05.md) | Báo cáo phân tích tài sản 05 |
| [FARptBCPT06.md](reports/FARptBCPT06.md) | Báo cáo phân tích tài sản 06 |
| [FARptBCPT07.md](reports/FARptBCPT07.md) | Báo cáo phân tích tài sản 07 |
| [FARptBCPT08.md](reports/FARptBCPT08.md) | Báo cáo phân tích tài sản 08 |
| [FARptBCPT09.md](reports/FARptBCPT09.md) | Báo cáo phân tích tài sản 09 |
| [FARptBCPT10.md](reports/FARptBCPT10.md) | Báo cáo phân tích tài sản 10 |

### Báo cáo tổng hợp tài sản

| File | Mô tả |
|------|-------|
| [FARptBCTS01.md](reports/FARptBCTS01.md) | Báo cáo tổng hợp tài sản 01 |
| [FARptBCTS04.md](reports/FARptBCTS04.md) | Báo cáo tổng hợp tài sản 04 |
| [FARptBCTS05.md](reports/FARptBCTS05.md) | Báo cáo tổng hợp tài sản 05 |
| [FARptBCTS06.md](reports/FARptBCTS06.md) | Báo cáo tổng hợp tài sản 06 |
| [FARptBCTS07.md](reports/FARptBCTS07.md) | Báo cáo tổng hợp tài sản 07 |
| [FARptBCTS08.md](reports/FARptBCTS08.md) | Báo cáo tổng hợp tài sản 08 |
| [FARptBCTS09.md](reports/FARptBCTS09.md) | Báo cáo tổng hợp tài sản 09 |

### Sổ theo dõi

| File | Mô tả |
|------|-------|
| [FARptSoSD.md](reports/FARptSoSD.md) | Sổ sử dụng |
| [FARptSoTSCD.md](reports/FARptSoTSCD.md) | Sổ tài sản cố định |

## Masters

### Danh mục chính

| File | Mô tả |
|------|-------|
| [FADMTS.md](masters/FADMTS.md) | Danh mục tài sản cố định |
| [FADMCC.md](masters/FADMCC.md) | Danh mục công cụ dụng cụ |

### Danh mục tham chiếu

| File | Mô tả |
|------|-------|
| [FADMBPSD.md](masters/FADMBPSD.md) | Danh mục bộ phận sử dụng |
| [FADMNHTS.md](masters/FADMNHTS.md) | Danh mục phân nhóm tài sản (3 cấp) |
| [FADMLDTS.md](masters/FADMLDTS.md) | Danh mục lý do tăng giảm |
| [FADMNV.md](masters/FADMNV.md) | Danh mục nguồn vốn (hệ thống) |

## Luồng xử lý chính

### 1. Tính khấu hao hàng tháng
```
FACalKHTS (Tính KH) → FAPostTS2GL (Post sang GL)
```

### 2. Điều chỉnh khấu hao
```
FAAdjustKHTS (Điều chỉnh) → FAPostTS2GL (Post lại sang GL)
```

### 3. Xóa khấu hao
```
FADelKHTS (Xóa KH) → FACalKHTS (Tính lại)
```

### 4. Biến động tài sản
```
FADGTS (Đánh giá lại) / FAGiamTS (Giảm) / FAChuyenTS (Chuyển)
```

### 5. Công cụ dụng cụ
```
FADMCC (Danh mục) → FABHCC (Báo hỏng) → FAPostCC2GL (Post PB)
```

## Tham khảo

- [FA_SUMMARY.md](../FA_SUMMARY.md) - Tổng quan toàn bộ module FA
