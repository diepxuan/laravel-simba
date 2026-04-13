# Báo cáo Phân tích DLL: GLRptBCTCCR01F5.dll

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
| Assembly Name | GLRptBCTCCR01F5 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 9.1.0.0 |

---

## Cấu trúc File

```
GLRptBCTCCR01F5.dll/
├── GLRptBCTCCR01F5.csproj       # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGLRptBCTCCR01F5.cs    # Drill-down report form
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
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCTCCR01F5` | `frmDrilldownReport` | Form drill-down báo cáo CCR01 |

---

## Các tham số báo cáo

| Parameter | Kiểu | Mục đích |
|-----------|------|----------|
| motherReportInfo | ReportInformation | Thông tin báo cáo mẹ |
| drilldownMenuId | string | ID menu drill-down |
| formularFields | AsDictionary | Các trường công thức |
| isNT | bool | Có phải ngoại tệ không |
| nhan_in | string | Nhãn in |
| filter4Tilte | string | Điều kiện lọc cho tiêu đề |
| formatedColList | string | Danh sách cột định dạng |
| datasource | object | Nguồn dữ liệu |
| arg | params object[] | Tham số bổ sung |

---

## Các chuỗi Text đáng chú ý

### Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk_du` | Tài khoản đối ứng |
| `Parameters4DrillDown` | Tham số drill-down |
| `ngay_ct1` | Ngày chứng từ từ |
| `ngay_ct2` | Ngày chứng từ đến |
| `ma_nt` | Mã ngoại tệ |

---

## Mục đích sử dụng

**GLRptBCTCCR01F5.dll là module drill-down báo cáo tài chính CCR01** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Drill-down báo cáo CCR01
- Hiển thị chi tiết từ báo cáo CCR01 chính
- Xem thông tin tài khoản đối ứng (tk_du)
- Drill-down sâu hơn với F5

#### 2. Tạo tham số drill-down
- Tự động tạo tham số từ dòng được chọn
- Truyền tham số: CompanyID, TK, TK đối ứng, ngày, mã ngoại tệ
- Hiển thị tiêu đề lọc với định dạng "TK/TK_du"

#### 3. Tích hợp với báo cáo mẹ
- Nhận thông tin từ báo cáo mẹ (motherReportInfo)
- Kế thừa các tham số từ báo cáo gốc
- Chia sẻ datasource với báo cáo mẹ

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` - form drill-down chuẩn
- Sử dụng `CreateDrilldownArgument` để tạo tham số
- Hỗ trợ phím tắt F5 để drill-down tiếp
- Tự động kiểm tra `tk_du` trước khi drill-down

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem chi tiết drill-down từ báo cáo CCR01 - hiển thị thông tin tài khoản đối ứng và cho phép drill-down sâu hơn.

---

*Ngày phân tích: 2026-03-29*
