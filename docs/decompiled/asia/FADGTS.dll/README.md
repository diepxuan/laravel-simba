# Báo cáo Phân tích DLL: FADGTS.dll

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
| Assembly Name | FADGTS |
| Assembly Title | Đánh giá lại tài sản cố định |
| Assembly Company | Asia |
| Assembly Product | ARDMKH |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 244f5fa8-38fe-4fb9-9d2c-d662f06b2133 |
| ComVisible | false |

---

## Cấu trúc File

```
FADGTS.dll/
├── FADGTS.csproj                  # Project file
├── app.ico                        # Application icon
├── AsiaErp.UserInterface.frmFADGTSEdit.resx  # Resource file
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmFADGTS.cs               # Main form class (danh mục view)
│   └── frmFADGTSEdit.cs           # Edit form class
├── AsiaErp.DataAccess/
│   ├── IFADGTSDAO.cs              # DAO Interface
│   └── MsSqlFADGTSDAO.cs          # SQL Server DAO implementation
└── My/
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    ├── MyApplication.cs
    └── MyComputer.cs
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

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `My` (internal)
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFADGTS` | `frmDMComplexView` | Form xem danh mục đánh giá tài sản |
| `frmFADGTSEdit` | `frmDMComplexEdit` | Form nhập liệu đánh giá tài sản |
| `IFADGTSDAO` | - | Interface cho DAO |
| `MsSqlFADGTSDAO` | - | SQL Server DAO implementation |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Đánh giá lại tài sản cố định" - Tên chức năng chính
- "Mã tài sản", "Tên tài sản", "Diễn giải"
- "Kiểu đánh giá": Tăng TS / Giảm TS
- "Mã đánh giá" (ma_ts_tgng)

### Tab Control

| Tab | Mục đích |
|-----|----------|
| tabTTDG | Thông tin đánh giá |
| tabPT_LK | Đánh giá phụ tùng, linh kiện |
| tabTTKH | Thông tin tài sản |

### Thông tin đánh giá (tabTTDG)

- "Số chứng từ", "Ngày chứng từ"
- "Ngày tăng giảm"
- "Lý do tăng giảm" (ma_ldtg)
- "Ngày bắt đầu KH", "Ngày GTCL"
- "Số tháng KH", "Tỷ lệ KH tháng"
- "Số lượng tăng giảm"
- "Sửa KH" (checkbox)

### Chi tiết nguồn vốn

| Nguồn | Trường dữ liệu |
|-------|---------------|
| Nguồn vốn 1 | ng_gia_n1, gt_kh_n1, gt_cl_n1, kh_th_n1 |
| Nguồn vốn 2 | ng_gia_n2, gt_kh_n2, gt_cl_n2, kh_th_n2 |
| Nguồn vốn 3 | ng_gia_n3, gt_kh_n3, gt_cl_n3, kh_th_n3 |
| Nguồn vốn 4 | ng_gia_n4, gt_kh_n4, gt_cl_n4, kh_th_n4 |
| Tổng cộng | t_ng_gia, t_gt_kh, t_gt_cl, t_kh_th |

### Phụ tùng linh kiện (tabPT_LK)

- "Mã linh kiện", "Tên linh kiện", "Đơn vị tính"
- "Số lượng", "Giá trị"
- "Tăng / Giảm linh kiện"
- DataGridView với các cột: ma_cty, ma_ts, ma_lk, ten_lk, dvt, so_luong, gia_tri, tang_giam

### Thông tin tài sản (tabTTKH)

- "Ngày tăng", "Ngày GTCL"
- "Số tháng KH", "Tỷ lệ KH tháng"
- "Số lượng"
- "Tính KH", "Sửa KH" (checkboxes)
- "Tài khoản tài sản", "Tài khoản khấu hao", "Tài khoản chi phí"

### Thuật ngữ kế toán

| Thuật tính | Ý nghĩa |
|------------|---------|
| `ma_ts` | Mã tài sản |
| `ma_ts_tgng` | Mã tài sản tăng giảm nguyên giá |
| `so_ct` | Số chứng từ |
| `ngay_ct` | Ngày chứng từ |
| `ngay_tg` | Ngày tăng giảm |
| `ma_ldtg` | Mã lý do tăng giảm |
| `ngay_bdkh` | Ngày bắt đầu khấu hao |
| `ngay_gt_cl` | Ngày giá trị còn lại |
| `st_kh` | Số tháng khấu hao |
| `tl_kh` | Tỷ lệ khấu hao |
| `so_luong` | Số lượng tăng giảm |
| `sua_kh` | Sửa khấu hao |
| `ng_gia_n1-4` | Nguyên giá nguồn vốn 1-4 |
| `gt_kh_n1-4` | Giá trị đã KH nguồn vốn 1-4 |
| `gt_cl_n1-4` | Giá trị còn lại nguồn vốn 1-4 |
| `kh_th_n1-4` | Khấu hao tháng nguồn vốn 1-4 |

---

## Mục đích sử dụng

**FADGTS.dll là module quản lý "Đánh giá lại tài sản cố định"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Tăng/Giảm nguyên giá tài sản
- Hỗ trợ tăng hoặc giảm nguyên giá tài sản cố định
- Chọn kiểu đánh giá: Tăng TS hoặc Giảm TS (RadioButton)
- Mã đánh giá (ma_ts_tgng) để theo dõi

#### 2. Quản lý thông tin đánh giá
- Số chứng từ, ngày chứng từ
- Ngày tăng giảm, lý do tăng giảm
- Ngày bắt đầu KH mới, ngày GTCL mới
- Số tháng KH, tỷ lệ KH tháng
- Số lượng tăng giảm

#### 3. Chi tiết nguồn vốn
- Quản lý nguyên giá theo 4 nguồn vốn
- Giá trị đã khấu hao (gt_kh)
- Giá trị còn lại (gt_cl)
- Khấu hao tháng (kh_th)
- Tổng cộng các nguồn vốn

#### 4. Quản lý phụ tùng linh kiện
- Thêm/xóa linh kiện gắn với tài sản
- Quản lý mã linh kiện, tên, đơn vị tính
- Số lượng và giá trị linh kiện
- Tăng/giảm linh kiện

#### 5. Thông tin tài sản
- Xem thông tin hiện tại của tài sản
- Ngày tăng, ngày GTCL hiện tại
- Số tháng KH, tỷ lệ KH hiện tại
- Tài khoản TS, KH, CP

### Đặc điểm kỹ thuật

- Sử dụng TabControl với 3 tab
- DataGridView cho danh sách linh kiện
- Tính toán tự động khấu hao tháng
- Validation chặt chẽ ngày tháng:
  - Ngày GTCL >= Ngày BDKH >= Ngày tăng
- Lookup codes: MA_TS, MA_LDTG, MA_LK
- Transaction handling cho insert/update

### Validation

- Mã tài sản: bắt buộc
- Kiểm tra không có đánh giá sau ngày chứng từ
- Ngày chứng từ, ngày tăng giảm: bắt buộc
- Lý do tăng giảm: bắt buộc
- Số tháng KH > 0
- Nguyên giá phải > 0 (khi tính KH)
- Kiểm tra mã linh kiện không trùng với mã tài sản

---

## Kết luận

Đây là một module Windows Forms phức tạp của hệ thống ERP Asia Enterprise, phục vụ cho việc đánh giá lại (tăng/giảm nguyên giá) tài sản cố định, quản lý linh kiện và điều chỉnh thông tin khấu hao - một chức năng quan trọng trong quản lý tài sản cố định của doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
