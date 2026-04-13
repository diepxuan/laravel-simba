# Báo cáo Phân tích DLL: FARptSoTSCD.dll

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
| Assembly Name | FARptSoTSCD |
| Assembly Title | Sổ tài sản cố định |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2012 |
| Assembly Version | 12.1.3.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 6cf0aa81-5a68-42ff-8764-7956a0ff3a07 |
| ComVisible | false |

---

## Cấu trúc File

```
FARptSoTSCD.dll/
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFARptSoTSCD.cs            # Main form - Sổ tài sản cố định
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
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptSoTSCD` | `frmReport` | Form sổ tài sản cố định |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Sổ tài sản cố định" - Tiêu đề báo cáo
- "Mã tài sản" - Lọc theo mã tài sản
- "Mã nhóm tài sản" - Lọc theo nhóm
- "Mã bộ phận sử dụng" - Lọc theo bộ phận
- "Kỳ báo cáo" - Chọn kỳ
- "Báo cáo" - Chọn mẫu báo cáo
- "Tiêu đề" - Tiêu đề báo cáo

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ten_ts` | Tên tài sản |
| `ma_nhts` | Mã nhóm tài sản |
| `ten_nhts` | Tên nhóm tài sản |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ten_bpsd` | Tên bộ phận sử dụng |
| `ngay1` | Từ ngày |
| `ngay2` | Đến ngày |
| `ma_cty` | Mã công ty |

---

## Mục đích sử dụng

**FARptSoTSCD.dll là module Sổ tài sản cố định** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo sổ tài sản cố định
- Xem sổ theo dõi tài sản cố định
- Tổng hợp thông tin tài sản theo nhiều tiêu chí
- Lọc theo mã tài sản, nhóm tài sản, bộ phận sử dụng

#### 2. Tham số báo cáo
- `ma_cty` - Mã công ty
- `ngay1` - Từ ngày
- `ngay2` - Đến ngày
- `ma_ts` - Mã tài sản (tùy chọn)
- `ma_nhts` - Mã nhóm tài sản (tùy chọn)
- `ma_bpsd` - Mã bộ phận sử dụng (tùy chọn)

#### 3. Chức năng xem/In
- Xem trước trên grid
- In qua Crystal Report
- Xuất Excel
- Chọn mẫu báo cáo

#### 4. Thông tin hiển thị
- Thông tin tài sản: mã, tên, nhóm, bộ phận SD
- Nguyên giá, giá trị đã khấu hao, giá trị còn lại
- Thông tin khấu hao: số tháng, tỷ lệ, giá trị KH tháng

### Đặc điểm kỹ thuật

- Kế thừa `frmReport` - form báo cáo chuẩn
- TabControl với 2 tab: Filter và Grid
- AutoLookup cho các trường mã (tài sản, nhóm, bộ phận)
- DataBinding với DataTable
- Lấy dữ liệu qua `MyController.GetData()`

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in sổ tài sản cố định - báo cáo tổng hợp quan trọng trong quản lý tài sản.

---

*Ngày phân tích: 2026-03-29*
