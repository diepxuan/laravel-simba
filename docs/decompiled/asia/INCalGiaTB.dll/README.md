# Báo cáo Phân tích DLL: INCalGiaTB.dll

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
| Assembly Name | INCalGiaTB |
| Assembly Title | Tính giá trung bình tháng |
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
INCalGiaTB.dll/
├── INCalGiaTB.csproj          # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmINCalGiaTB.cs         # Main form class
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
- `System`, `System.Collections`, `System.ComponentModel`, `System.Data`
- `System.Diagnostics`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINCalGiaTB` | `frmCalc` | Form tính giá trung bình tháng |

---

## Chi tiết Form frmINCalGiaTB

### Các trường dữ liệu chính

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| cboKyBc | Kỳ tính | Chọn kỳ báo cáo |
| txtMa_kho | Ma_kho | Mã kho (lọc) |
| txtNh_vt | Ma_NhVt | Nhóm vật tư (lọc) |
| txtMa_vt | Ma_vt | Mã vật tư (lọc) |
| txtMa_tkvt | TK_VT | Tài khoản vật tư (lọc) |
| cboKieu_ps | Kiểu PS | Kiểu tạo phát sinh chênh lệch |
| txttk_cl | tk_cl | Tài khoản chênh lệch |

### Kiểu tạo phát sinh chênh lệch

| Giá trị | Mô tả |
|---------|-------|
| 0 | Không tạo |
| 1 | Tạo cho các trường hợp số lượng = 0, số tiền #0 |
| 2 | Tạo cho các trường hợp có phát sinh chênh lệch |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tính giá trung bình tháng" - Tiêu đề form
- "Kỳ tính" - Chọn kỳ báo cáo
- "Mã kho" - Lọc theo kho
- "Nhóm vật tư" - Lọc theo nhóm
- "Mã vật tư" - Lọc theo vật tư
- "Tài khoản vật tư" - Lọc theo TK vật tư
- "Kiểu tạo PS chênh lệch" - Tùy chọn tạo phát sinh
- "Tài khoản chênh lệch" - TK ghi nhận chênh lệch (mặc định 632)

---

## Mục đích sử dụng

**INCalGiaTB.dll là module tính giá trung bình tháng** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Tính giá trung bình
- Tính giá trung bình cho kỳ được chọn
- Áp dụng cho vật tư theo các điều kiện lọc
- Cập nhật giá tồn kho

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
- Mặc định TK chênh lệch từ INConfiguration.tk_gv

### Xử lý nghiệp vụ

| Bước | Mô tả |
|------|-------|
| 1 | Chọn kỳ tính |
| 2 | Nhập điều kiện lọc (nếu cần) |
| 3 | Chọn kiểu tạo PS chênh lệch |
| 4 | Nhập TK chênh lệch (nếu có) |
| 5 | Thực thi tính giá |
| 6 | Hiển thị kết quả |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc tính giá trung bình tháng - một chức năng quan trọng trong quản lý tồn kho và giá vốn.

---

*Ngày phân tích: 2026-03-29*
