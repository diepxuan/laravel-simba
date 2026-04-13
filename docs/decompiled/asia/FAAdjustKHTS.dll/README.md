# Báo cáo Phân tích DLL: FAAdjustKHTS.dll

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
| Assembly Name | FAAdjustKHTS |
| Assembly Title | Nhập số tồn kho đầu kỳ |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | ced0d8d3-a55f-4181-92b2-8f5f36d765fa |
| ComVisible | false |

---

## Cấu trúc File

```
FAAdjustKHTS.dll/
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmFAAdjustKHTS.cs           # Main form - Điều chỉnh KH tài sản
    ├── frmFAAdjustKHTSFilter.cs     # Filter form - Chọn kỳ/tài sản
    └── frmFAAdjustKHTSEdit.cs       # Edit form - Chi tiết điều chỉnh
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| System.Drawing | Graphics support |
| AsiaErp.Framework | ERP Framework Core |
| AsiaErp.DataAccess | ERP Framework DataAccess |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`, `AsiaErp.DataAccess`
- `System`, `System.Collections`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFAAdjustKHTS` | `frmDMComplexView` | Form điều chỉnh khấu hao tài sản |
| `frmFAAdjustKHTSFilter` | `frmDMFilter` | Form chọn kỳ và tài sản |
| `frmFAAdjustKHTSEdit` | `frmDMComplexEdit` | Form nhập điều chỉnh khấu hao |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Điều chỉnh khấu hao tài sản" - Tiêu đề form
- "Tháng" - Chọn tháng điều chỉnh
- "Mã tài sản" - Chọn tài sản cần điều chỉnh
- "Điều chỉnh" - Button chỉnh sửa

### Edit Form - Thông tin điều chỉnh

- "Mã tài sản", "Tên tài sản"
- "Mã tài sản tăng giảm nguyên giá"
- "Nguyên giá", "Giá trị đã khấu hao đến đầu tháng"
- "Giá trị còn lại đến đầu tháng"
- "Giá trị khấu hao trong kỳ"
- "Sửa khấu hao" - Checkbox cho phép sửa
- "Nguồn vốn 1/2/3/4" - Chi tiết theo nguồn vốn
- "Tổng cộng" - Tổng giá trị KH

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ten_ts` | Tên tài sản |
| `ma_ts_tgng` | Mã tài sản tăng giảm nguyên giá |
| `t_ng_gia` | Tổng nguyên giá |
| `t_gt_da_kh` | Tổng giá trị đã khấu hao |
| `t_gt_cl` | Tổng giá trị còn lại |
| `kh_n1/2/3/4` | Khấu hao nguồn vốn 1/2/3/4 |
| `t_kh_th` | Tổng khấu hao tháng |
| `sua_kh` | Cho phép sửa khấu hao |
| `nv1/2/3/4` | Nguồn vốn 1/2/3/4 |

---

## Mục đích sử dụng

**FAAdjustKHTS.dll là module Điều chỉnh khấu hao tài sản cố định** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Chọn kỳ và tài sản (Filter)
- Form `frmFAAdjustKHTSFilter` hiển thị trước
- Chọn tháng cần điều chỉnh (qua cboKyBc)
- Chọn mã tài sản (tùy chọn, qua txtMa_Ts)
- Kiểm tra ngày kết thúc kỳ > ngày khóa sổ

#### 2. Xem danh sách
- Hiển thị danh sách tài sản theo kỳ đã chọn
- GridView hiển thị thông tin tài sản và giá trị khấu hao
- Dữ liệu lấy từ `MyController.GetData()`

#### 3. Điều chỉnh khấu hao (Edit)
- Button "Điều chỉnh" mở form edit
- Hiển thị thông tin: mã TS, tên TS, mã TS tăng giảm nguyên giá
- Hiển thị: Nguyên giá, giá trị đã KH, giá trị còn lại (readonly)
- Cho phép điều chỉnh giá trị khấu hao trong kỳ

#### 4. Chi tiết điều chỉnh
- Checkbox "Sửa khấu hao" cho phép nhập thủ công
- Nhập giá trị KH cho từng nguồn vốn (4 nguồn)
- Tự động tính tổng KH tháng
- Tên nguồn vốn lấy từ `Commons.FAGetTenNguonVon()`

#### 5. Validation
- Kiểm tra kỳ > ngày khóa sổ
- Tổng KH tháng = Tổng các nguồn vốn

### Đặc điểm kỹ thuật

- Kế thừa `frmDMComplexView`/`frmDMComplexEdit` - form danh mục phức tạp
- Sử dụng `frmDMFilter` để chọn kỳ
- AutoLookup cho chọn tài sản
- DataBinding với các trường numeric
- Tính toán tự động tổng KH khi thay đổi
- Tự động đóng form nếu không chọn kỳ (check=false)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP AsiaERP, phục vụ cho việc điều chỉnh giá trị khấu hao tài sản cố định - cho phép nhập tay giá trị KH khi cần điều chỉnh sau khi đã tính khấu hao.

---

*Ngày phân tích: 2026-03-29*
