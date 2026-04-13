# Báo cáo Phân tích DLL: CoDelPostCP2GL.dll

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
| Assembly Name | CoDelPostCP2GL |
| Assembly Title | Phân bổ công cụ dụng cụ |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |
| Assembly Trademark | AsiaSoft |

---

## Cấu trúc File

```
CoDelPostCP2GL.dll/
├── CoDelPostCP2GL.csproj              # Project file
├── app.ico                            # Application icon
├── Properties/
│   └── AssemblyInfo.cs                # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmCoDelPostCP2GL.cs         # Main form - Xóa post chi phí sang GL
└── AsiaErp.UserInterface.My/
    ├── MySettingsProperty.cs          # Settings property
    └── MySettings.cs                  # Settings manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (../../../../projects/SimbaSql/native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../projects/SimbaSql/native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Collections`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCoDelPostCP2GL` | `frmCalc` | Form xóa post chi phí sang GL |

---

## Controls và UI Components

### Controls chính (frmCoDelPostCP2GL)

| Control | Loại | Mục đích |
|---------|------|----------|
| cboKyBc | AsComboBox | ComboBox chọn kỳ báo cáo (Tháng) |
| txtNam | AsTextNumeric | TextBox nhập năm |
| Label1 | Label | Label "Tháng" |
| Label2 | Label | Label "Năm" |
| cmdOK | Button | Nút OK thực hiện xóa post |
| cmdCancel | Button | Nút Cancel hủy |
| gbInput | GroupBox | GroupBox chứa các control nhập liệu |

---

## Business Logic và Events

### Constructors

| Constructor | Tham số | Mô tả |
|-------------|---------|-------|
| `frmCoDelPostCP2GL(string MenuId)` | MenuId | Constructor với menu ID |

### Methods chính

| Phương thức | Mô tả |
|-------------|-------|
| `Execute()` | Thực hiện xóa post chi phí sang GL |
| `ValidData()` | Kiểm tra dữ liệu hợp lệ |
| `InitComponents()` | Khởi tạo các components |
| `InitKyBaoCao()` | Khởi tạo danh sách kỳ báo cáo |

### Events

| Event | Handler | Mục đích |
|-------|---------|----------|
| Form.Load | InitComponents | Khởi tạo form |
| cmdOK.Click | Execute | Thực hiện xóa post chi phí |

### Xử lý chính

1. **Kiểm tra ngày khóa sổ**: Đảm bảo kỳ xóa post sau ngày khóa sổ
2. **Gọi stored procedure**: Thực hiện xóa post chi phí sang GL
3. **Truyền tham số**:
   - `CompanyInformations.CompanyID`: Mã công ty
   - `MyMenuInfo.par1`: Tham số từ menu
   - `txtNam.Text`: Năm
   - `cboKyBc.Text`: Tháng/kỳ

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Phân bổ công cụ dụng cụ" - Tên chức năng (từ Assembly Title)
- "Tháng" - Label chọn tháng
- "Năm" - Label nhập năm

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `Post CP` | Post chi phí |
| `GL` | General Ledger (Sổ cái) |
| `KyBc` | Kỳ báo cáo |
| `ngay_ks` | Ngày khóa sổ |
| `par1` | Tham số 1 từ menu |

---

## Mục đích sử dụng

**CoDelPostCP2GL.dll là module xóa post chi phí sang GL** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Xóa post chi phí sang sổ cái (GL)
- Xóa bỏ các bút toán post chi phí đã được chuyển sang sổ cái
- Thường dùng khi cần tính toán lại hoặc có sai sót trong việc post chi phí

#### 2. Kiểm soát kỳ
- Chọn tháng và năm cần xóa post
- Kiểm tra ngày khóa sổ để đảm bảo an toàn dữ liệu


#### 3. Tích hợp với module phân bổ công cụ dụng cụ
- Liên quan đến việc phân bổ công cụ dụng cụ (CCDC)
- Xóa post chi phí khi cần tính toán lại phân bổ CCDC

### Đặc điểm kỹ thuật

- Kế thừa từ `frmCalc` - form tính toán chung
- Sử dụng `AsComboBox` để chọn kỳ báo cáo
- Kiểm tra ngày khóa sổ trước khi thực hiện
- Gọi stored procedure qua `MyController.Execute()`
- Hiển thị thông báo kết quả (thành công/thất bại)

### Validation

- Kiểm tra ngày kết thúc kỳ phải sau ngày khóa sổ
- Sử dụng `ValidData()` để kiểm tra trước khi thực hiện

---

## Kết luận

Đây là một module Windows Forms củả hệ thống ERP Asia Enterprise, phục vụ cho việc xóa post chi phí sang sổ cái (GL) - một chức năng quản lý kế toán quan trọng trong việc điều chỉnh và quản lý chi phí.

---

*Ngày phân tích: 2026-03-29*
