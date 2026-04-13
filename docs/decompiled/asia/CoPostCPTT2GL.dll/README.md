# Báo cáo Phân tích DLL: CoPostCPTT2GL.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| Chức năng | Post chi phí tập trung sang GL (Tổng hợp) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | CoPostCPTT2GL |
| Assembly Title | Phân bổ công cụ dụng cụ |
| Assembly Product | Asia Enterprise |
| Assembly Company | Asia Software Development JSC |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
CoPostCPTT2GL.dll/
├── CoPostCPTT2GL.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmCoPostCPTT2GL.cs      # Main form class
└── AsiaErp.UserInterface.My/
    ├── MySettings.cs            # Settings support
    └── MySettingsProperty.cs    # Settings property
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| System.Drawing | Graphics support |
| Microsoft.VisualBasic | VB.NET runtime support |
| AsiaErp.Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCoPostCPTT2GL` | `frmCalc` | Form thực hiện post chi phí tập trung sang GL |

---

## Các controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| cboKyBc | AsComboBox | Chọn kỳ báo cáo (tháng) |
| txtNam | AsTextNumeric | Năm báo cáo (readonly) |
| Label1 | Label | Nhãn "Tháng" |
| Label2 | Label | Nhãn "Năm" |
| cmdOK | Button | Thực hiện post |
| cmdCancel | Button | Hủy bỏ |
| gbInput | GroupBox | Groupbox chứa input |

---

## Business Logic

### Quy trình Post

1. **Chọn kỳ**: Người dùng chọn tháng và năm cần post
2. **Validate**: Kiểm tra ngày kỳ báo cáo > ngày khóa sổ
3. **Execute**: Gọi controller thực hiện post chi phí
4. **Kết quả**: Hiển thị thông báo thành công/thất bại

### Methods

| Method | Mô tả |
|--------|-------|
| `Execute()` | Thực hiện post chi phí tập trung sang GL |
| `ValidData()` | Validate dữ liệu trước khi post |
| `InitComponents()` | Khởi tạo các component và giá trị mặc định |
| `InitKyBaoCao()` | Load danh sách kỳ báo cáo |

### Parameters truyền vào Controller

| Parameter | Mô tả |
|-----------|-------|
| CompanyID | Mã công ty |
| Năm | Năm báo cáo |
| Tháng | Tháng báo cáo |
| par1 | Tham số bổ sung từ MenuInfo |

### Validation

- Ngày kết thúc kỳ báo cáo phải > ngày khóa sổ (`ngay_ks`)
- Nếu không thỏa mãn: hiển thị lỗi 50136

### Error Handling

| Mã lỗi | Mô tả |
|--------|-------|
| 50010 | Lỗi không xác định |
| 50015 | Thực hiện thành công |
| 50136 | Ngày kỳ báo cáo phải sau ngày khóa sổ |

---

## Mục đích sử dụng

**CoPostCPTT2GL.dll là module thực hiện post chi phí tập trung sang Tổng hợp (GL)** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Post chi phí tập trung
- Tính toán giá trị phân bổ chi phí tập trung cho kỳ được chọn
- Tạo các bút toán phân bổ từ TK phân bổ sang TK chi phí
- Ghi nhận vào sổ Tổng hợp (GL)

#### 2. Kiểm soát kỳ
- Chỉ cho phép post các kỳ sau ngày khóa sổ
- Đảm bảo tính toàn vẹn dữ liệu kế toán

#### 3. Tích hợp hệ thống
- Sử dụng Controller pattern để thực hiện nghiệp vụ
- Tích hợp với module CO (Cost Accounting) và GL (General Ledger)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc post (ghi sổ) chi phí tập trung sang Tổng hợp - một bước quan trọng trong quy trình kế toán cuối kỳ để phân bổ chi phí gián tiếp vào chi phí sản xuất kinh doanh.

---

*Ngày phân tích: 2026-03-29*
