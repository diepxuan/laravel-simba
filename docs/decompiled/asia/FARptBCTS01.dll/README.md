# Báo cáo Phân tích DLL: FARptBCTS01.dll

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
| Assembly Name | FARptBCTS01 |
| Assembly Title | Thẻ tài sản |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | d7a12a96-4897-4fb5-9c50-50135092320c |
| ComVisible | false |

---

## Cấu trúc File

```
FARptBCTS01.dll/
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
└── AsiaERp.UserInterface/
    ├── frmFARptBCTS01.cs            # Main form - Báo cáo biến động TS
    └── My/
        ├── MyProject.cs             # Project configuration
        ├── MyApplication.cs         # Application context
        ├── MyComputer.cs            # Computer info
        ├── MySettings.cs            # Application settings
        ├── MySettingsProperty.cs    # Settings properties
        └── My.Resources/
            └── Resources.cs         # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| System.Drawing | Graphics support |
| System.Text | StringBuilder |
| AsiaErp.Framework | ERP Framework Core |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaERp.UserInterface`
- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Text`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCTS01` | `frmReport2DGV` | Form báo cáo biến động tài sản |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Thẻ tài sản" - Tiêu đề báo cáo
- "Mã TS" - Lọc theo mã tài sản
- "Từ ngày", "Đến ngày" - Khoảng thời gian
- "Kỳ báo cáo" - Chọn kỳ
- "Mẫu báo cáo" - Chọn mẫu in
- "Tiêu đề" - Tiêu đề báo cáo

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ten_ts` | Tên tài sản |
| `ngay1` | Từ ngày |
| `ngay2` | Đến ngày |
| `ma_cty` | Mã công ty |
| `ma_nt` | Mã ngoại tệ |

---

## Mục đích sử dụng

**FARptBCTS01.dll là module Báo cáo biến động tài sản cố định (Thẻ tài sản)** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Báo cáo biến động tài sản
- Xem báo cáo biến động của tài sản cố định
- 2 DataGridView: Master (phần header) và Detail (chi tiết)
- Lọc theo mã tài sản, khoảng thời gian

#### 2. Tham số báo cáo
- `ma_cty` - Mã công ty
- `ngay2` - Đến ngày (ngày báo cáo)
- `ma_ts` - Mã tài sản (tùy chọn)
- `ma_ts_all` - Danh sách mã TS được chọn (từ grid)

#### 3. Chức năng xem/In
- Xem trước trên grid
- In qua Crystal Report (ViewCrystalByConnection)
- Xuất Excel
- Chọn mẫu báo cáo

#### 4. Tương tác với grid
- Click vào dòng master để xem chi tiết
- Checkbox chọn tài sản để in (cột TAG)
- Lọc chi tiết theo mã tài sản đang chọn

### Đặc điểm kỹ thuật

- Kế thừa `frmReport2DGV` - form báo cáo với 2 grid
- SplitContainer chia màn hình
- DataSet với 2 DataTable: Master và Detail
- Send2CrystalByConnection = true
- Stored procedure lấy dữ liệu qua `MyController.GetDataSet()`

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP AsiaERP, phục vụ cho việc xem và in báo cáo biến động tài sản cố định (Thẻ tài sản) - theo dõi các giao dịch tăng, giảm, điều chỉnh tài sản.

---

*Ngày phân tích: 2026-03-29*
