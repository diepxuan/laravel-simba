# Báo cáo Phân tích DLL: CoRptKHCPTT.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| Chức năng | Báo cáo khai báo chi phí tập trung |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | CoRptKHCPTT |
| Assembly Title | Báo cáo tồn kho cuối kỳ |
| Assembly Product | AsiaERP |
| Assembly Company | ASIASOFT |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 6cf0aa81-5a68-42ff-8764-7956a0ff3a07 |
| ComVisible | false |

---

## Cấu trúc File

```
CoRptKHCPTT.dll/
├── CoRptKHCPTT.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmCoRptCTPBCPTT.cs      # Main form class
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs             # VB.NET My project support
    ├── MyApplication.cs         # Application support
    ├── MyComputer.cs            # Computer support
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
| `frmCoRptCTPBCPTT` | `frmReport` | Form báo cáo khai báo chi phí tập trung |

---

## Các controls chính

### Filter Controls
| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_bpsd | AsTextBox | Mã bộ phận sử dụng |
| lblTen_bpsd | Label | Tên bộ phận sử dụng |
| lblMa_bpsd | Label | Nhãn "Mã BPSD" |

### Report Controls (kế thừa từ frmReport)
| Control | Mô tả |
|---------|-------|
| cboKyBc | Kỳ báo cáo |
| txtNgay1 | Từ ngày |
| txtNgay2 | Đến ngày |
| cboMau_bc | Mẫu báo cáo |
| txtTieu_De | Tiêu đề báo cáo |
| cmdOk | Xem báo cáo |
| cmdCancel | Hủy |
| cmdExcel | Xuất Excel |
| cmdModifyReport | Sửa mẫu báo cáo |
| optVND | Tùy chọn tiền VND |
| optNt | Tùy chọn tiền ngoại tệ |
| txtMa_Nt | Mã ngoại tệ |

---

## Business Logic

### Quy trình báo cáo

1. **Chọn kỳ**: Người dùng chọn kỳ báo cáo (tự động tính từ ngày - đến ngày)
2. **Lọc dữ liệu**: Nhập điều kiện lọc theo bộ phận sử dụng
3. **LoadData**: Gọi controller lấy dữ liệu theo các tham số
4. **Hiển thị**: Hiển thị dữ liệu trên DataGridView và cho phép in/xuất

### Methods

| Method | Mô tả |
|--------|-------|
| `LoadData()` | Lấy dữ liệu báo cáo từ database |
| `GetFilterTitle()` | Tạo chuỗi mô tả điều kiện lọc |

### Parameters truyền vào Controller

| Parameter | Mô tả |
|-----------|-------|
| CompanyID | Mã công ty |
| Ngay1 | Từ ngày |
| Ngay2 | Đến ngày |
| Ma_bpsd | Mã bộ phận sử dụng |

### Lookup Codes

| Control | LookupCode | Mô tả |
|---------|------------|-------|
| txtMa_bpsd | MA_BPSD | Mã bộ phận sử dụng |

### Error Handling

| Xử lý | Mô tả |
|-------|-------|
| Try-Catch | Bắt lỗi khi load dữ liệu và hiển thị thông báo "Lỗi lọc dữ liệu" |

---

## Mục đích sử dụng

**CoRptKHCPTT.dll là module báo cáo khai báo chi phí tập trung** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Báo cáo khai báo chi phí
- Hiển thị danh sách các chi phí tập trung đã khai báo
- Theo dõi thông tin chi tiết của từng chi phí
- Báo cáo theo bộ phận sử dụng

#### 2. Lọc dữ liệu
- Lọc theo bộ phận sử dụng
- Lọc theo kỳ báo cáo

#### 3. Xuất dữ liệu
- Xem trực tiếp trên form
- In ấn báo cáo
- Xuất ra Excel

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc báo cáo danh sách khai báo chi phí tập trung, giúp người dùng theo dõi tổng quan các chi phí đã khai báo trong hệ thống.

---

*Ngày phân tích: 2026-03-29*
