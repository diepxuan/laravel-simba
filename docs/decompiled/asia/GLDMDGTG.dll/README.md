# Báo cáo Phân tích DLL: GLDMDGTG.dll

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
| Assembly Name | GLDMDGTG |
| Assembly Title | Khai báo các bút toán đánh giá tỷ giá |
| Assembly Company | ASIASOFT |
| Assembly Product | GLDMDGTG |
| Assembly Copyright | Copyright © ASIA 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 0ce1218b-9158-4801-a59d-f3c8d40d51f2 |
| ComVisible | false |

---

## Cấu trúc File

```
GLDMDGTG.dll/
├── GLDMDGTG.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLDMDGTG.cs           # Main form - Danh mục DGTG
│   └── frmGLDMDGTGEdit.cs       # Edit form - Nhập liệu DGTG
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs         # VB My.Application
│   ├── MyComputer.cs            # VB My.Computer
│   ├── MyProject.cs             # VB My.Project
│   ├── MySettings.cs            # Settings
│   └── MySettingsProperty.cs    # Settings property
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| AsiaErp.Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLDMDGTG` | `frmDMComplexView` | Form xem danh mục đánh giá tỷ giá |
| `frmGLDMDGTGEdit` | `frmDMComplexEdit` | Form nhập liệu đánh giá tỷ giá |
| `Resources` | - | Resource manager |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Khai báo các bút toán đánh giá tỷ giá" - Tên chức năng chính
- "Loại đánh giá" - Chọn loại đánh giá tỷ giá
- "Tên bút toán" - Tên bút toán đánh giá
- "Số chứng từ" - Số chứng từ mặc định

### Các tài khoản đánh giá

| Control | Ý nghĩa |
|---------|---------|
| TK đánh giá TG | Tài khoản đánh giá tỷ giá |
| TK lãi CLTG | Tài khoản lãi chênh lệch tỷ giá |
| TK lỗ CLTG | Tài khoản lỗ chênh lệch tỷ giá |
| TK CLTG công nợ | Tài khoản CLTG công nợ |

### Các đối tượng đánh giá

| Checkbox | Ý nghĩa |
|----------|---------|
| ĐG theo bộ phận | Đánh giá theo bộ phận |
| ĐG theo phí | Đánh giá theo phí |
| ĐG theo hợp đồng | Đánh giá theo hợp đồng |
| ĐG theo SPCT | Đánh giá theo sản phẩm chi tiết |
| ĐG theo khách hàng | Đánh giá theo khách hàng |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `stt` | Số thứ tự |
| `ten_bt` | Tên bút toán |
| `so_ct` | Số chứng từ |
| `loai_dg` | Loại đánh giá |
| `tk_dgtg` | Tài khoản đánh giá tỷ giá |
| `tk_lai_cltg` | Tài khoản lãi CLTG |
| `tk_lo_cltg` | Tài khoản lỗ CLTG |
| `tk_cltg_cn` | Tài khoản CLTG công nợ |
| `dg_bp` | Đánh giá theo bộ phận |
| `dg_phi` | Đánh giá theo phí |
| `dg_hd` | Đánh giá theo hợp đồng |
| `dg_spct` | Đánh giá theo SPCT |
| `dg_kh` | Đánh giá theo khách hàng |

---

## Mục đích sử dụng

**GLDMDGTG.dll là module Khai báo các bút toán đánh giá tỷ giá (DGTG)** trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Khai báo bút toán đánh giá tỷ giá
- Thiết lập các bút toán đánh giá tỷ giá tự động
- Cấu hình tài khoản lãi/lỗ chênh lệch tỷ giá
- Thiết lập tài khoản đánh giá tỷ giá công nợ

#### 2. Phân tích đánh giá
- Chọn các chiều phân tích: bộ phận, phí, hợp đồng, SPCT, khách hàng
- Cấu hình loại đánh giá tỷ giá

#### 3. Quản lý danh mục
- Thêm, sửa, xóa các bút toán đánh giá
- Sắp xếp theo số thứ tự
- Quản lý số chứng từ mặc định

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMComplexView` - Form danh mục phức tạp
- Tự động tính số thứ tự lớn nhất khi thêm mới
- Hỗ trợ lookup tài khoản
- Sử dụng DataBinding

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc khai báo và quản lý các bút toán đánh giá tỷ giá.

---

*Ngày phân tích: 2026-03-29*
