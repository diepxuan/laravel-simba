# Báo cáo Phân tích DLL: INCalGiaBQDD.dll

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
| Assembly Name | INCalGiaBQDD |
| Assembly Title | Tính giá bình quân di động |
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
INCalGiaBQDD.dll/
├── INCalGiaBQDD.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmINCalGiaBQDD.cs       # Main form class
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   └── InternalXmlHelper.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Collections.Generic`
- `System.ComponentModel`, `System.Data`, `System.Diagnostics`
- `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINCalGiaBQDD` | `frmCalc` | Form tính giá bình quân di động |

---

## Chi tiết Form frmINCalGiaBQDD

### Các trường dữ liệu chính

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| cboKyBc | Kỳ tính | Chọn kỳ báo cáo |
| txtMa_kho | Ma_kho | Mã kho (lọc) |
| txtMa_NhVt | Ma_NhVt | Nhóm vật tư (lọc) |
| txtMa_vt | Ma_vt | Mã vật tư (lọc) |
| txtMa_tkvt | TK_VT | Tài khoản vật tư (lọc) |
| cboKieu_ps | Kiểu PS | Kiểu tạo phát sinh chênh lệch |
| txttk_cl | tk_cl | Tài khoản chênh lệch |

### Kiểu tạo phát sinh chênh lệch

| Giá trị | Mô tả |
|---------|-------|
| 0 | Không tạo |
| 1 | Tạo cho các trường hợp số lượng = 0, số tiền #0 |
| 2 | Tạo cho tất cả các trường hợp có phát sinh chênh lệch |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tính giá bình quân di động" - Tiêu đề form
- "Kỳ tính" - Chọn kỳ báo cáo
- "Mã kho" - Lọc theo kho
- "Nhóm vật tư" - Lọc theo nhóm
- "Mã vật tư" - Lọc theo vật tư
- "TK vật tư" - Lọc theo TK vật tư
- "Kiểu tạo PS chênh lệch" - Tùy chọn tạo phát sinh
- "TK chênh lệch" - TK ghi nhận chênh lệch (mặc định 632)

---

## Mục đích sử dụng

**INCalGiaBQDD.dll là module tính giá bình quân di động (Moving Average)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Tính giá bình quân di động
- Tính giá bình quân di động cho kỳ được chọn
- Giá được tính sau mỗi lần nhập
- Cập nhật liên tục theo từng phát sinh

#### 2. Xử lý chênh lệch
- Tạo phát sinh chênh lệch nếu có
- Ghi nhận vào TK chênh lệch (mặc định 632)
- 3 kiểu xử lý chênh lệch khác nhau

#### 3. Lọc dữ liệu
- Theo kỳ báo cáo
- Theo kho, nhóm vật tư
- Theo mã vật tư cụ thể
- Theo tài khoản vật tư

### Đặc điểm kỹ thuật

- Sử dụng BackgroundWorker cho xử lý nền
- Lookup tự động cho các trường mã
- Validation kỳ tính (phải sau ngày khóa sổ)
- Tích hợp KyBaoCao cho chọn kỳ
- Mặc định TK chênh lệch từ INConfiguration.tk_gv hoặc 632

### Phương pháp bình quân di động

| Đặc điểm | Mô tả |
|----------|-------|
| Công thức | (Tồn hiện tại * Giá cũ + Nhập mới * Giá nhập) / Tổng số lượng |
| Cập nhật | Sau mỗi lần nhập |
| Ưu điểm | Phản ánh sát giá thị trường |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc tính giá bình quân di động - một phương pháp tính giá tồn kho phổ biến, đặc biệt phù hợp khi giá biến động thường xuyên.

---

*Ngày phân tích: 2026-03-29*
