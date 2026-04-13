# Báo cáo Phân tích DLL: GLRptBCPT05.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLRptBCPT05 |
| Assembly Title | Báo cáo kết quả hoạt động sản xuất kinh doanh |
| Assembly Company | ASIASOFT |
| Assembly Product | DTE |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly File Version | 1.0.0.0 |
| Assembly Version | 1.0.0.0 |
| GUID | a341c082-09ae-4758-a1e6-9e068fc1292f |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptBCPT05.dll/
├── GLRptBCPT05.csproj              # Project file
├── app.ico                         # Application icon
├── Properties/
│   └── AssemblyInfo.cs             # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptBCPT05.cs           # Main report form
├── AsiaErp.UserInterface.My/
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   ├── MyComputer.cs
│   └── MyApplication.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs                # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Microsoft.VisualBasic | VB runtime |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.Collections`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCPT05` | `frmReport` | Form báo cáo KQHĐSXKD |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo cáo kết quả hoạt động sản xuất kinh doanh" - Tên báo cáo
- "Tài khoản" - Label nhập tài khoản
- "Mã bộ phận" - Label nhập mã bộ phận
- "Mã phí" - Label nhập mã phí
- "Mã spct" - Label nhập mã sản phẩm công trình
- "Nhóm cấp 1" đến "Nhóm cấp 4" - Các cấp nhóm báo cáo
- "Kiểu dự toán" - Label chọn kiểu dự toán

### Combobox options

| Control | Options |
|---------|---------|
| `cboNhom_cap1` | "Theo tài khoản", "Theo bộ phận", "Theo mã phí", "Theo sản phẩm công trình" |
| `cboKieu_DT` | "1. Theo tài khoản", "2. Theo tài khoản và bộ phận", "3. Theo tài khoản, bộ phận và mã phí", "4. Theo tài khoản và mã phí" |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Tài khoản |
| `ma_bp` | Mã bộ phận |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm công trình |
| `nhom_cap1-4` | Các cấp nhóm báo cáo |
| `kieu_dt` | Kiểu dự toán |

---

## Mục đích sử dụng

**GLRptBCPT05.dll là module báo cáo "Kết quả hoạt động sản xuất kinh doanh"** với khả năng nhóm và phân tích đa chiều trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Lọc dữ liệu báo cáo
- Chọn kỳ báo cáo (từ ngày đến ngày)
- Lọc theo tài khoản
- Lọc theo mã bộ phận
- Lọc theo mã phí
- Lọc theo mã sản phẩm công trình
- Chọn loại tiền tệ (VND/ngoại tệ)

#### 2. Nhóm dữ liệu đa chiều
- Hỗ trợ 4 cấp nhóm (Nhóm cấp 1 đến 4)
- Các cấp nhóm có thể chọn: Tài khoản, Bộ phận, Mã phí, Sản phẩm công trình
- Các cấp sau phụ thuộc vào cấp trước (cascade selection)

#### 3. Kiểu dự toán
- 4 kiểu dự toán khác nhau
- Quyết định cách tổng hợp và hiển thị dữ liệu

#### 4. Tính toán và hiển thị
- Tải dữ liệu từ database theo các tham số lọc
- Hiển thị dữ liệu trên DataGridView với nhóm đa chiều
- Xuất báo cáo ra Excel
- In báo cáo

#### 5. Tham số truyền vào stored procedure

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | Year | Năm |
| 3 | tk | Tài khoản |
| 4 | ma_phi | Mã phí |
| 5 | ma_bp | Mã bộ phận |
| 6 | ma_spct | Mã sản phẩm công trình |
| 7 | Ngay1 | Ngày bắt đầu |
| 8 | Ngay2 | Ngày kết thúc |
| 9 | Nhom_cap1 | Nhóm cấp 1 |
| 10 | Nhom_cap2 | Nhóm cấp 2 |
| 11 | Nhom_cap3 | Nhóm cấp 3 |
| 12 | Nhom_cap4 | Nhóm cấp 4 |

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Form báo cáo chuẩn
- Sử dụng `AsTextBox` với AutoLookup cho các mã
- Cascade selection cho các cấp nhóm
- Hỗ trợ đa tiền tệ (VND/ngoại tệ)
- Tích hợp Crystal Report cho in ấn
- Sử dụng `DictionaryEntry` cho datasource của combobox

### Xử lý cascade selection

```csharp
// Khi chọn Nhóm cấp 1 -> Cập nhật Nhóm cấp 2
// Khi chọn Nhóm cấp 2 -> Cập nhật Nhóm cấp 3
// Khi chọn Nhóm cấp 3 -> Cập nhật Nhóm cấp 4
```

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP, phục vụ cho việc xem và in báo cáo Kết quả hoạt động sản xuất kinh doanh với khả năng phân tích đa chiều theo nhiều tiêu thức khác nhau (tài khoản, bộ phận, mã phí, sản phẩm công trình).

---

*Ngày phân tích: 2026-03-29*
