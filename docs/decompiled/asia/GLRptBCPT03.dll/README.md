# Báo cáo Phân tích DLL: GLRptBCPT03.dll

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
| Assembly Name | GLRptBCPT03 |
| Assembly Title | Bảng cân đối kế toán theo kỳ |
| Assembly Product | DTE |
| Assembly Company | ASIASOFT |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | e1a88250-8eec-45c9-883c-3eb618c7e6ba |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptBCPT03.dll/
├── GLRptBCPT03.csproj             # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptBCPT03.cs          # Main report form
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MyApplication.cs
    ├── MyComputer.cs
    └── MySettingsProperty.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Drawing | Graphics rendering |
| System.Windows.Forms | UI framework |
| AsiaErp.Framework | Asia ERP Framework base classes |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCPT03` | `frmReport` | Form báo cáo cân đối kế toán theo kỳ |

---

## Controls và UI Components

### Input Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `cboLoai_bc` | ComboBox | Loại báo cáo |
| `txtMonth` | AsTextNumeric | Tháng |
| `txtSo_ky` | AsTextNumeric | Số kỳ |
| `lblMonth` | Label | Nhãn tháng |
| `lblSo_ky` | Label | Nhãn số kỳ |
| `cboMau_bc` | ComboBox | Mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Lựa chọn tiền tệ |
| `txtTieu_De` | TextBox | Tiêu đề báo cáo |

### Action Buttons

| Button | Mục đích |
|--------|----------|
| `cmdOk` | Thực hiện báo cáo |
| `cmdCancel` | Hủy bỏ |
| `cmdExcel` | Xuất Excel |
| `cmdModifyReport` | Sửa mẫu báo cáo |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng cân đối kế toán theo kỳ" - Tên chức năng chính
- "Loại báo cáo" - Phân loại báo cáo
- "Tháng" - Tháng báo cáo
- "Số kỳ" - Số kỳ so sánh

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `loai_bc` | Loại báo cáo |
| `month` | Tháng |
| `so_ky` | Số kỳ so sánh |
| `ma_nt` | Mã ngoại tệ |

### Cột báo cáo (dự kiến)

| Cột | Ý nghĩa |
|-----|----------|
| Chỉ tiêu | Tên chỉ tiêu |
| Mã số | Mã số chỉ tiêu |
| Tháng hiện tại | Số liệu tháng hiện tại |
| Kỳ trước | Số liệu kỳ trước |
| Chênh lệch | Chênh lệch giữa các kỳ |
| % | Tỷ lệ % thay đổi |

---

## Mục đích sử dụng

**GLRptBCPT03.dll là module báo cáo "Bảng cân đối kế toán theo kỳ"** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Báo cáo cân đối kế toán
- Hiển thị bảng cân đối kế toán (Balance Sheet)
- So sánh số liệu giữa các kỳ
- Hỗ trợ xem theo tháng và số kỳ so sánh

#### 2. Phân tích theo kỳ
- Chọn loại báo cáo (cboLoai_bc)
- Chọn tháng báo cáo
- Chọn số kỳ để so sánh
- Xem xu hướng biến động qua các kỳ

#### 3. Lọc dữ liệu
- Lọc theo mã ngoại tệ
- Lựa chọn mẫu báo cáo
- Lựa chọn loại tiền tệ (VND/Ngoại tệ)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form báo cáo của Asia ERP
- Sử dụng `ArrayList` để truyền tham số cho stored procedure
- Event `cboLoai_bc_SelectedIndexChanged` để xử lý thay đổi loại báo cáo
- Các trường ngày ẩn (Visible = false) - sử dụng tháng/kỳ thay thế

### Events

| Event | Mục đích |
|-------|----------|
| `cboLoai_bc_SelectedIndexChanged` | Xử lý khi thay đổi loại báo cáo |

### Tham số truy vấn (dự kiến)

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtMonth.Value);                   // Tháng
params.Add(txtSo_ky.Value);                 // Số kỳ
params.Add(cboLoai_bc.SelectedValue);       // Loại báo cáo
params.Add(txtMa_Nt.Text);                  // Mã ngoại tệ
```

---

## Kết luận

Đây là module báo cáo cân đối kế toán theo kỳ trong hệ thống ERP Asia Enterprise, cho phép xem và so sánh bảng cân đối kế toán qua nhiều kỳ khác nhau để phân tích xu hướng tài chính.

---

*Ngày phân tích: 2026-03-29*
