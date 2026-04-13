# FA Module Summary - Tổng quan Module Tài sản cố định

## Tổng quan

Module FA (Fixed Assets) quản lý toàn bộ vòng đời tài sản cố định và công cụ dụng cụ trong hệ thống AsiaERP.

## Cấu trúc module

```
docs/asia/fa/
├── README.md              # Hướng dẫn module FA
├── vouchers/              # Chứng từ nghiệp vụ
│   ├── Tính khấu hao      # FACalKHTS, FAAdjustKHTS, FADelKHTS, FAThoiKHTS
│   ├── Post GL            # FAPostTS2GL, FAPostCC2GL, FADelTS2GL, FADelCC2GL
│   ├── Biến động          # FADGTS, FAGiamTS, FAChuyenTS
│   ├── Công cụ            # FABHCC
│   └── Kiểm kê            # Fakkts
├── reports/               # Báo cáo
│   ├── BCPT               # FARptBCPT01-10 (Phân tích)
│   ├── BCTS               # FARptBCTS01,04-09 (Tổng hợp)
│   └── Sổ                 # FARptSoSD, FARptSoTSCD
└── masters/               # Danh mục
    ├── FADMTS             # Danh mục tài sản
    ├── FADMCC             # Danh mục công cụ
    └── Tham chiếu         # BPSD, NHTS, LDTS, NV
```

## Danh sách DLL

### Chứng từ (Vouchers)

| DLL | Tên | Mô tả |
|-----|-----|-------|
| FACalKHTS | Tính khấu hao | Tính khấu hao TSCĐ theo tháng |
| FAAdjustKHTS | Điều chỉnh KH | Điều chỉnh giá trị khấu hao |
| FADelKHTS | Xóa khấu hao | Xóa KH của TS trong kỳ |
| FAThoiKHTS | Tạm ngưng KH | Khai báo dừng khấu hao tạm thời |
| FAPostTS2GL | Post TS sang GL | Phân bổ khấu hao TSCĐ sang sổ cái |
| FAPostCC2GL | Post CC sang GL | Phân bổ CCDC sang sổ cái |
| FADelTS2GL | Xóa post TS | Xóa bút toán post TSCĐ |
| FADelCC2GL | Xóa post CC | Xóa bút toán post CCDC |
| FADGTS | Đánh giá lại | Tăng/giảm nguyên giá TS |
| FAGiamTS | Giảm tài sản | Khai báo giảm, thanh lý TS |
| FAChuyenTS | Chuyển tài sản | Chuyển bộ phận, SPCT, mã phí, TK |
| FABHCC | Báo hỏng CC | Ghi nhận công cụ hỏng |
| Fakkts | Kiểm kê | Kiểm kê tài sản (import Excel) |

### Báo cáo (Reports)

| DLL | Tên | Mô tả |
|-----|-----|-------|
| FARptBCPT01-10 | Báo cáo phân tích | 10 mẫu báo cáo phân tích TS |
| FARptBCTS01,04-09 | Báo cáo tổng hợp | 7 mẫu báo cáo tổng hợp TS |
| FARptSoSD | Sổ sử dụng | Theo dõi sử dụng TS |
| FARptSoTSCD | Sổ TSCĐ | Sổ tài sản cố định |

### Danh mục (Masters)

| DLL | Tên | Mô tả |
|-----|-----|-------|
| FADMTS | Danh mục TS | Quản lý thông tin tài sản cố định |
| FADMCC | Danh mục CC | Quản lý công cụ dụng cụ |
| FADMBPSD | Bộ phận SD | Danh mục bộ phận sử dụng |
| FADMNHTS | Nhóm TS | Phân nhóm TS (3 cấp) |
| FADMLDTS | Lý do TG | Lý do tăng giảm tài sản |
| FADMNV | Nguồn vốn | Danh mục nguồn vốn (hệ thống) |

## Luồng xử lý chính

### 1. Khấu hao hàng tháng

```
┌─────────────┐     ┌──────────────┐     ┌─────────────┐
│ FACalKHTS   │ →   │ FAPostTS2GL  │ →   │ General     │
│ (Tính KH)   │     │ (Post GL)    │     │ Ledger      │
└─────────────┘     └──────────────┘     └─────────────┘
```

### 2. Điều chỉnh khấu hao

```
┌─────────────┐     ┌──────────────┐     ┌─────────────┐
│ FAAdjustKHTS│ →   │ FAPostTS2GL  │     │ General     │
│ (Điều chỉnh)│     │ (Post lại)   │     │ Ledger      │
└─────────────┘     └──────────────┘     └─────────────┘
```

### 3. Xóa và tính lại

```
┌─────────────┐     ┌──────────────┐     ┌─────────────┐
│ FADelKHTS   │ →   │ FACalKHTS    │     │ FAPostTS2GL │
│ (Xóa KH)    │     │ (Tính lại)   │     │ (Post lại)  │
└─────────────┘     └──────────────┘     └─────────────┘
```

### 4. Biến động tài sản

```
┌─────────────┐     ┌──────────────┐     ┌─────────────┐
│ FADGTS      │     │ FAGiamTS     │     │ FAChuyenTS  │
│ (Đánh giá)  │     │ (Giảm TS)    │     │ (Chuyển)    │
└─────────────┘     └──────────────┘     └─────────────┘
```

### 5. Công cụ dụng cụ

```
┌─────────────┐     ┌──────────────┐     ┌─────────────┐
│ FADMCC      │ →   │ FABHCC       │ →   │ FAPostCC2GL │
│ (Danh mục)  │     │ (Báo hỏng)   │     │ (Post PB)   │
└─────────────┘     └──────────────┘     └─────────────┘
```

## Thuật ngữ chính

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| TS / TSCĐ | Tài sản / Tài sản cố định |
| CC / CCDC | Công cụ / Công cụ dụng cụ |
| KH | Khấu hao |
| PB | Phân bổ |
| NG | Nguyên giá |
| GTCL | Giá trị còn lại |
| GTĐKH | Giá trị đã khấu hao |
| BPSD | Bộ phận sử dụng |
| SPCT | Sản phẩm công trình |
| GL | General Ledger (Sổ cái) |
| NHTS | Nhóm tài sản |
| LDTS | Lý do tăng giảm |
| NV | Nguồn vốn |

## Các nguồn vốn

Hệ thống hỗ trợ 4 nguồn vốn để theo dõi chi tiết:

| Nguồn | Ký hiệu | Trường dữ liệu |
|-------|---------|----------------|
| Nguồn vốn 1 | NV1 | ng_gia_n1, gt_kh_n1, gt_cl_n1, kh_th_n1 |
| Nguồn vốn 2 | NV2 | ng_gia_n2, gt_kh_n2, gt_cl_n2, kh_th_n2 |
| Nguồn vốn 3 | NV3 | ng_gia_n3, gt_kh_n3, gt_cl_n3, kh_th_n3 |
| Nguồn vốn 4 | NV4 | ng_gia_n4, gt_kh_n4, gt_cl_n4, kh_th_n4 |

## Tài khoản kế toán

| TK | Ý nghĩa |
|----|---------|
| TK_TS | Tài khoản tài sản (211, 213...) |
| TK_KH | Tài khoản khấu hao (214) |
| TK_CP | Tài khoản chi phí (641, 642...) |
| TK_CC | Tài khoản công cụ (153, 242...) |

## Validation rules

### Ngày tháng
- `ngay_gt_cl >= ngay_bdkh >= ngay_tang`
- Ngày xử lý > ngày khóa sổ

### Khấu hao
- Số tháng KH > 0
- Nguyên giá > 0
- Tỷ lệ KH phù hợp

### Chứng từ
- Mã tài sản tồn tại
- Không trùng chứng từ cùng ngày
- Lý do tăng giảm hợp lệ

## Xem thêm

- [fa/README.md](fa/README.md) - Chi tiết module FA
- [fa/vouchers/](fa/vouchers/) - Chứng từ nghiệp vụ
- [fa/masters/](fa/masters/) - Danh mục
- [fa/reports/](fa/reports/) - Báo cáo
