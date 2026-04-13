# Module CO - Kế toán Giá thành (Cost Accounting)

## Tổng quan

Module **CO (Cost Accounting)** là module kế toán giá thành trong hệ thống ERP Asia Enterprise. Module này cung cấp các chức năng quản lý chi phí sản xuất, tính giá thành sản phẩm và phân bổ chi phí.

## Cấu trúc module

```
docs/asia/co/
├── README.md              # Tài liệu này
├── CO_SUMMARY.md          # Tổng quan các DLL
└── vouchers/              # Tài liệu chi tiết từng DLL
    ├── CODD1.md           # Định mức chi tiết
    ├── CODMBOM.md         # Định mức nguyên vật liệu (BOM)
    ├── CODMNHSPCT.md      # Danh mục nhóm SPCT
    ├── CODMPB.md          # Danh mục bút toán phân bổ
    ├── CODMSPCT.md        # Danh mục sản phẩm công trình
    ├── COGDBGT.md         # Báo cáo giá định biên
    ├── COLK.md            # Liên kết
    ├── COPB.md            # Bút toán phân bổ tự động
    ├── CORptGt01.md       # Báo cáo giá thành 01
    ├── CORptGt02.md       # Báo cáo giá thành 02
    ├── CORptGt03.md       # Báo cáo giá thành 03
    ├── CoCalcCost.md      # Tính giá thành
    ├── CoDMCPTT.md        # Danh mục chi phí tập trung
    ├── CoDelPostCP2GL.md  # Xóa post chi phí sang GL
    ├── CoNgungKHCPTT.md   # Ngừng phân bổ CPTT
    ├── CoPostCPTT2GL.md   # Post chi phí sang GL
    ├── CoRptCTPBCPTT.md   # Báo cáo chi tiết phân bổ
    └── CoRptKHCPTT.md     # Báo cáo khai báo CPTT
```

## Phân loại chức năng

### 1. Danh mục (Master Data)

| DLL | Chức năng |
|-----|-----------|
| CODMSPCT | Danh mục sản phẩm công trình |
| CODMNHSPCT | Danh mục nhóm sản phẩm công trình |
| CODMBOM | Định mức nguyên vật liệu (BOM) |
| CODD1 | Định mức chi tiết |
| CODMPB | Danh mục bút toán phân bổ tự động |
| CoDMCPTT | Danh mục chi phí tập trung |
| COLK | Liên kết |
| CoNgungKHCPTT | Ngừng phân bổ chi phí tập trung |

### 2. Nghiệp vụ (Transaction)

| DLL | Chức năng |
|-----|-----------|
| COPB | Bút toán phân bổ tự động |
| CoCalcCost | Tính giá thành |
| CoPostCPTT2GL | Post chi phí tập trung sang GL |
| CoDelPostCP2GL | Xóa post chi phí sang GL |

### 3. Báo cáo (Reports)

| DLL | Chức năng |
|-----|-----------|
| CORptGt01 | Báo cáo giá thành 01 |
| CORptGt02 | Báo cáo giá thành 02 |
| CORptGt03 | Báo cáo giá thành 03 |
| COGDBGT | Báo cáo giá định biên giá thành |
| CoRptCTPBCPTT | Báo cáo chi tiết phân bổ CPTT |
| CoRptKHCPTT | Báo cáo khai báo chi phí tập trung |

## Quy trình xử lý giá thành

### Bước 1: Khai báo danh mục
1. Khai báo danh mục sản phẩm công trình (CODMSPCT)
2. Phân nhóm sản phẩm (CODMNHSPCT)
3. Khai báo định mức nguyên vật liệu (CODMBOM)
4. Khai báo định mức chi tiết (CODD1)
5. Khai báo chi phí tập trung (CoDMCPTT)
6. Khai báo bút toán phân bổ (CODMPB)

### Bước 2: Xử lý nghiệp vụ
1. Tính giá thành sản phẩm (CoCalcCost)
2. Phân bổ chi phí tự động (COPB)
3. Post chi phí sang GL (CoPostCPTT2GL)

### Bước 3: Báo cáo
1. Báo cáo giá thành (CORptGt01/02/03)
2. Báo cáo giá định biên (COGDBGT)
3. Báo cáo chi tiết phân bổ (CoRptCTPBCPTT)
4. Báo cáo khai báo CPTT (CoRptKHCPTT)

## Các khái niệm chính

### SPCT (Sản phẩm công trình)
Là đối tượng tính giá thành chính trong module CO. Mỗi SPCT có:
- Mã sản phẩm (ma_spct)
- Tên sản phẩm (ten_spct)
- Nhóm sản phẩm (liên kết CODMNHSPCT)

### BOM (Bill of Materials)
Định nghĩa cấu trúc sản phẩm bao gồm:
- Nguyên vật liệu cấu thành
- Định mức tiêu hao
- Đơn giá nhân công

### CPTT (Chi phí tập trung)
Là các chi phí gián tiếp cần phân bổ:
- Chi phí công cụ dụng cụ
- Chi phí phân bổ dần
- Theo dõi nguyên giá, số kỳ phân bổ, giá trị còn lại

### Phân bổ chi phí
Quá trình phân bổ chi phí gián tiếp vào các đối tượng chi phí trực tiếp theo:
- Sản phẩm công trình (SPCT)
- Bộ phận sử dụng (BPSD)
- Tài khoản đối ứng (TKDU)

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| SPCT | Sản phẩm công trình |
| BOM | Bill of Materials (Định mức NVL) |
| CPTT | Chi phí tập trung |
| BPSD | Bộ phận sử dụng |
| TK | Tài khoản kế toán |
| GL | General Ledger (Sổ tổng hợp) |
| PB | Phân bổ |
| KH | Khấu hao |
| GT | Giá thành |
| CCDC | Công cụ dụng cụ |

## Technical Notes

- **Framework**: .NET Framework 3.5
- **Ngôn ngữ**: C#
- **Kiến trúc**: Windows Forms
- **Database**: SQL Server
- **Pattern**: DAO (Data Access Object)

## Dependencies

- Framework.dll - Asia ERP Framework
- Helper.dll - Asia ERP Helper Library
- Microsoft.VisualBasic - VB Runtime
- System.Data - Data Access
- CrystalDecisions.Windows.Forms - Report Viewer (một số module)

## Tham chiếu

- [CO_SUMMARY.md](CO_SUMMARY.md) - Tổng quan chi tiết các DLL
- [vouchers/](vouchers/) - Tài liệu chi tiết từng module

---

*Ngày cập nhật: 2026-03-29*
