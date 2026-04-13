# Báo cáo Phân tích DLL: FADMTS.dll

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
| Assembly Name | FADMTS |
| Assembly Title | ARDMKH |
| Assembly Company | Asia |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 244f5fa8-38fe-4fb9-9d2c-d662f06b2133 |
| ComVisible | false |

---

## Cấu trúc File

```
FADMTS.dll/
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── My/
│   ├── MySettings.cs            # Application settings
│   ├── MyApplication.cs         # Application context
│   ├── MySettingsProperty.cs    # Settings properties
│   ├── MyProject.cs             # Project configuration
│   └── MyComputer.cs            # Computer info
├── My.Resources/
│   └── Resources.cs             # Resource manager
├── AsiaErp.DataAccess/
│   └── IFADMTSDAO.cs            # Data Access Interface
└── AsiaErp.UserInterface/
    ├── frmFADMTS.cs             # Main form - Danh mục tài sản
    └── frmFADMTSEdit.cs         # Edit form - Chi tiết tài sản
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

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFADMTS` | `frmDMView` | Form danh mục tài sản cố định |
| `frmFADMTSEdit` | `frmDMEdit` | Form nhập liệu chi tiết tài sản |
| `IFADMTSDAO` | - | Interface truy cập dữ liệu tài sản |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã tài sản", "Tên tài sản", "Đơn vị tính"
- "Nhà cung cấp", "Nước sản xuất", "Công suất"
- "Năm sản xuất", "Số lượng", "Ngày đưa vào SD"
- "Ngày tăng", "Lý do tăng", "Ngày bắt đầu KH"
- "Ngày ghi nhận GTCL", "Ngày đình chỉ", "Lý do đình chỉ"
- "Số chứng từ", "Ngày chứng từ"

### Tab Control

| Tab | Ý nghĩa |
|-----|---------|
| `tabTTC` | Thông tin chung |
| `tabTTKH` | Thông tin khấu hao |
| `tabPT_LK` | Phụ tùng, linh kiện |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ten_ts` | Tên tài sản |
| `dvt` | Đơn vị tính |
| `ma_nhts1/2/3` | Mã nhóm tài sản 1/2/3 |
| `ma_tg_ts` | Mã lý do tăng tài sản |
| `tk_ts` | Tài khoản tài sản |
| `tk_kh` | Tài khoản khấu hao |
| `tk_cp` | Tài khoản chi phí |
| `st_kh` | Số tháng khấu hao |
| `tl_kh` | Tỷ lệ khấu hao |
| `ngay_bdkh` | Ngày bắt đầu khấu hao |
| `ngay_gt_cl` | Ngày ghi nhận giá trị còn lại |
| `ngay_dc` | Ngày đình chỉ |
| `ld_dc` | Lý do đình chỉ |
| `ng_gia_n1/2/3/4` | Nguyên giá nguồn vốn 1/2/3/4 |
| `gt_kh_n1/2/3/4` | Giá trị khấu hao nguồn vốn 1/2/3/4 |
| `gt_cl_n1/2/3/4` | Giá trị còn lại nguồn vốn 1/2/3/4 |
| `kh_th_n1/2/3/4` | Khấu hao tháng nguồn vốn 1/2/3/4 |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_phi` | Mã phí |

### GridView Linh kiện

| Cột | Ý nghĩa |
|-----|---------|
| ma_cty | Mã công ty |
| ma_ts | Mã tài sản |
| ma_lk | Mã linh kiện |
| ten_lk | Tên linh kiện |
| dvt | Đơn vị tính |
| so_luong | Số lượng |
| gia_tri | Giá trị |
| KSD | Không sử dụng |

---

## Mục đích sử dụng

**FADMTS.dll là module quản lý Danh mục tài sản cố định** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục tài sản
- Xem danh sách tài sản cố định
- Thêm, sửa, xóa tài sản
- Kiểm tra mã tài sản tồn tại qua `IFADMTSDAO.CheckMaTSExists()`

#### 2. Thông tin chi tiết tài sản (3 tab)
- **Thông tin chung**: Mã TS, tên TS, nhà CC, nước SX, công suất, ngày đưa vào SD, ngày tăng, lý do tăng, nhóm TS, bộ phận SD, sản phẩm CT, phí
- **Thông tin khấu hao**: Số tháng KH, tỷ lệ KH, tính KH, TK tài sản, TK khấu hao, TK chi phí, chi tiết nguyên giá theo 4 nguồn vốn, giá trị đã KH, giá trị còn lại, giá trị KH 1 tháng
- **Phụ tùng linh kiện**: Quản lý danh sách linh kiện thuộc tài sản

#### 3. Tính toán tự động
- Tính tổng nguyên giá từ 4 nguồn vốn
- Tính tổng giá trị đã khấu hao
- Tính tổng giá trị còn lại
- Tính tổng khấu hao tháng
- Tính giá trị khấu hao 1 tháng theo tỷ lệ
- Tính giá trị còn lại = Nguyên giá - Giá trị đã KH

#### 4. Validation dữ liệu
- Kiểm tra ngày tăng, ngày bắt đầu KH, ngày ghi nhận GTCL hợp lệ
- Kiểm tra ràng buộc ngày: ngay_gt_cl >= ngay_bdkh >= ngay_tang
- Kiểm tra số tháng KH > 0 khi tính KH
- Kiểm tra TK tài sản, TK khấu hao, TK chi phí không được trống

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- TabControl với 3 tab: Thông tin chung, Thông tin khấu hao, Phụ tùng linh kiện
- GridView quản lý danh sách linh kiện
- Tính toán tự động khi thay đổi nguyên giá, số tháng KH
- Hỗ trợ sửa khấu hao thủ công qua checkbox `chkSua_kh`

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục tài sản cố định - một module cốt lõi trong quản lý tài sản doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
