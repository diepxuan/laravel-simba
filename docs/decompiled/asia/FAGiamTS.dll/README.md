# Báo cáo Phân tích DLL: FAGiamTS.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | FAGiamTS |
| Assembly Title | Khai báo giảm tài sản cố định |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
FAGiamTS.dll/
├── FAGiamTS.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.DataAccess/
│   ├── FAGiamTSDAO.cs           # DAO class
│   └── MsSqlFAGiamTSDAO.cs      # SQL Server DAO implementation
└── AsiaERP.UserInterface/
    ├── frmFAGiamTS.cs           # Main form class (danh mục view)
    └── frmFAGiamTSEdit.cs       # Edit form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaERP.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFAGiamTS` | `frmDMView` | Form xem danh mục giảm tài sản |
| `frmFAGiamTSEdit` | `frmDMEdit` | Form nhập liệu giảm tài sản |
| `FAGiamTSDAO` | - | DAO class |
| `MsSqlFAGiamTSDAO` | - | SQL Server DAO implementation |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Khai báo giảm tài sản cố định" - Tên chức năng chính
- "Mã tài sản", "Tên tài sản"
- "Nguyên giá" (t_ng_gia)
- "Số ct/bb" (số chứng từ/biên bản)
- "Ngày ct/bb" (ngày chứng từ/biên bản)
- "Ngày giảm"
- "Lý do giảm" (ma_giam_ts)
- "Tên lý do giảm"

### Thuật ngữ kế toán

| Thuật tính | Ý nghĩa |
|------------|---------|
| `ma_ts` | Mã tài sản |
| `ten_ts` | Tên tài sản |
| `t_ng_gia` | Tổng nguyên giá |
| `so_ct_giam` | Số chứng từ giảm |
| `ngay_ct_giam` | Ngày chứng từ giảm |
| `ngay_giam` | Ngày giảm tài sản |
| `ma_giam_ts` | Mã lý do giảm tài sản |
| `ten_ld_giam` | Tên lý do giảm |
| `ngay_tang` | Ngày tăng tài sản (gốc) |
| `ngay_bdkh` | Ngày bắt đầu khấu hao (gốc) |
| `st_kh` | Số tháng khấu hao (gốc) |
| `so_luong` | Số lượng tài sản |

---

## Mục đích sử dụng

**FAGiamTS.dll là module quản lý "Khai báo giảm tài sản cố định"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Khai báo giảm tài sản
- Chọn tài sản cần giảm từ danh mục
- Nhập số chứng từ/biên bản giảm
- Nhập ngày chứng từ/biên bản
- Nhập ngày giảm tài sản
- Chọn lý do giảm (ma_giam_ts)

#### 2. Thông tin tài sản
- Hiển thị tên tài sản (read-only)
- Hiển thị nguyên giá (read-only)
- Lấy thông tin từ danh mục tài sản:
  - Ngày tăng gốc
  - Ngày bắt đầu KH gốc
  - Số tháng KH gốc
  - Số lượng

#### 3. Validation
- Kiểm tra mã tài sản tồn tại
- Ngày giảm phải >= ngày tăng tài sản
- Kiểm tra không giảm tài sản trùng ngày (ChkGiamTs)
- Validate các trường bắt buộc:
  - Mã tài sản
  - Số chứng từ
  - Ngày chứng từ
  - Ngày giảm
  - Lý do giảm

#### 4. Lookup
- MA_TS: Lookup tài sản
- MA_LDTG: Lookup lý do tăng giảm (điều kiện: tg='G' - giảm)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- AfterCodeValidating event cho lookup mã tài sản
- Lấy thông tin tài sản gốc khi chọn mã
- Validation chặt chẽ ngày tháng
- DAO pattern với FAGiamTSDAO

### Business Logic

- Ngày giảm phải sau ngày tăng tài sản
- Không cho phép giảm tài sản cùng ngày (tránh trùng lặp)
- Khi giảm tài sản, hệ thống sẽ:
  - Cập nhật trạng thái tài sản
  - Tính toán khấu hao đến ngày giảm
  - Tạo bút toán kế toán nếu cần

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc khai báo giảm tài sản cố định (thanh lý, nhượng bán, điều chuyển...) - một chức năng quan trọng trong quản lý vòng đời tài sản cố định của doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
