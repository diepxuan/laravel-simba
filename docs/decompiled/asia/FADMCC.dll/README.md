# Báo cáo Phân tích DLL: FADMCC.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | FADMCC |
| Assembly Title | FADMCC |
| Assembly Company | - |
| Assembly Product | FADMCC |
| Assembly Copyright | Copyright © 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | b71f3569-e439-4607-b511-60dc5628362c |
| ComVisible | false |

---

## Cấu trúc File

```
FADMCC.dll/
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── My/
│   ├── MyProject.cs             # Project configuration
│   ├── MyComputer.cs            # Computer info
│   └── MySettingsProperty.cs    # Settings properties
├── My.Resources/
│   └── Resources.cs             # Resource manager
├── AsiaErp.DataAccess/
│   ├── IFADMCCDAO.cs            # Data Access Interface
│   └── MsSqlFADMCCDAO.cs        # MSSQL Data Access Implementation
└── AsiaErp.UserInterface/
    ├── frmFADMCC.cs             # Main form - Danh mục công cụ
    └── frmFADMCCEdit.cs         # Edit form - Chi tiết công cụ
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| System.Drawing | Graphics support |
| AsiaErp.DataAccess | ERP Framework DataAccess |
| AsiaErp.Framework | ERP Framework Core |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFADMCC` | `frmDMComplexView` | Form danh mục công cụ dụng cụ |
| `frmFADMCCEdit` | `frmDMComplexEdit` | Form nhập liệu chi tiết công cụ |
| `IFADMCCDAO` | - | Interface truy cập dữ liệu công cụ |
| `MsSqlFADMCCDAO` | - | MSSQL implementation cho công cụ |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã công cụ", "Tên công cụ", "Đvt"
- "Số lượng", "Đơn giá", "Nguyên giá"
- "Số kỳ PB", "Giá trị đã phân bổ", "Giá trị phân bổ còn lại"
- "Giá trị phân bổ 1 kỳ"
- "TK phân bổ", "TK chi phí"
- "Ngày gtcl", "Ngày bắt đầu pb"
- "Ngày ct", "Số ct"
- "Mã phí", "Mã spct", "Mã bpsd"
- "Sửa phân bổ" - Checkbox cho phép sửa

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_cc` | Mã công cụ |
| `ten_cc` | Tên công cụ |
| `dvt` | Đơn vị tính |
| `so_luong` | Số lượng |
| `don_gia` | Đơn giá |
| `ng_gia` | Nguyên giá |
| `so_ky` | Số kỳ phân bổ |
| `gt_da_kh` | Giá trị đã khấu hao (phân bổ) |
| `gt_cl` | Giá trị còn lại |
| `kh_ky` | Khấu hao 1 kỳ (phân bổ 1 kỳ) |
| `tk_cc` | Tài khoản công cụ (phân bổ) |
| `tk_cp` | Tài khoản chi phí |
| `ngay_bdkh` | Ngày bắt đầu khấu hao (phân bổ) |
| `ngay_gt_cl` | Ngày ghi nhận giá trị còn lại |
| `ngay_ct` | Ngày chứng từ |
| `so_ct` | Số chứng từ |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `sua_kh` | Sửa khấu hao (sửa phân bổ) |
| `stt_rec` | Số thứ tự record |

---

## Mục đích sử dụng

**FADMCC.dll là module quản lý Danh mục công cụ dụng cụ** trong hệ thống ERP.

### Chức năng chính

#### 1. Quản lý danh mục công cụ
- Xem danh sách công cụ dụng cụ
- Thêm, sửa, xóa công cụ
- Kiểm tra mã công cụ tồn tại qua `IFADMCCDAO.CheckMaCcExists()`
- Xóa công cụ qua `IFADMCCDAO.DeleteCC()`

#### 2. Thông tin chi tiết công cụ
- Mã công cụ, tên công cụ, đơn vị tính
- Số lượng, đơn giá, nguyên giá (tự động tính = SL * ĐG)
- Số kỳ phân bổ, giá trị đã phân bổ, giá trị còn lại
- Giá trị phân bổ 1 kỳ (tự động tính hoặc nhập tay)
- Tài khoản phân bổ, tài khoản chi phí
- Ngày chứng từ, ngày bắt đầu phân bổ, ngày ghi nhận GTCL
- Mã phí, mã sản phẩm chi tiết, mã bộ phận sử dụng

#### 3. Tính toán tự động
- Nguyên giá = Số lượng * Đơn giá
- Giá trị còn lại = Nguyên giá - Giá trị đã phân bổ
- Phân bổ 1 kỳ = Giá trị còn lại / Số kỳ (nếu không sửa)
- Hoặc tính = Nguyên giá / Số kỳ tùy cấu hình

#### 4. Validation dữ liệu
- Kiểm tra mã công cụ, tên công cụ không được trống
- Kiểm tra số lượng > 0
- Kiểm tra số kỳ phân bổ > 0
- Kiểm tra nguyên giá > 0
- Kiểm tra TK phân bổ, TK chi phí không được trống
- Kiểm tra ngày bắt đầu PB, ngày GTCL, ngày CT hợp lệ

#### 5. Cấu hình tính phân bổ
- Checkbox "Sửa phân bổ" cho phép nhập tay giá trị phân bổ 1 kỳ
- Cấu hình kiểu tính qua `Environment.GetFAConfiguration().kieu_tinh_kh`

### Đặc điểm kỹ thuật

- Sử dụng `frmDMComplexView`/`frmDMComplexEdit` - form danh mục phức tạp
- DataBinding với DataTable
- Tính toán tự động khi thay đổi số lượng, đơn giá, giá trị đã PB
- MaskTextBoxAll cho định dạng số tiền
- AutoLookup cho các trường mã (TK, BPSD, SPCT, phí)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP, phục vụ cho việc quản lý danh mục công cụ dụng cụ - tương tự như tài sản cố định nhưng áp dụng cho công cụ, dụng cụ phân bổ theo kỳ.

---

*Ngày phân tích: 2026-03-29*
