# Báo cáo Phân tích DLL: GLTransferGLCDTK.dll

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
| Assembly Name | Chuyển số dư tài khoản sang năm sau |
| Assembly Title | Chuyển số dư tài khoản sang năm sau |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | aee5ba0c-ea97-45a5-ae8f-25ed2faddb55 |
| ComVisible | false |

---

## Cấu trúc File

```
GLTransferGLCDTK.dll/
├── GLTransferGLCDTK.csproj    # Project file
├── app.ico                    # Application icon
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaERP.UserInterface/
│   └── frmGLTransferGLCDTK.cs # Main form class
├── AsiaERP.UserInterface.My/
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   └── MyApplication.cs
└── AsiaERP.UserInterface.My.Resources/
    └── Resources.cs           # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System, System.Windows.Forms | .NET Framework cơ bản |
| Microsoft.VisualBasic | Visual Basic runtime support |
| AsiaErp.Framework | Framework chung của Asia ERP |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLTransferGLCDTK` | `frmCalc` | Form chuyển số dư tài khoản sang năm sau |
| `Resources` | - | Resource manager cho localization |

---

## Controls chính

| Control | Loại | Mục đích |
|---------|------|----------|
| `lblSure` | Label | Label cảnh báo (màu đỏ) |
| `lblFinal_day` | Label | Label ngày cuối năm |
| `lblConfirm` | Label | Label xác nhận |
| `lblMa_so` | Label | Label mã số |
| `txtMa_so` | TextBox | Hiển thị mã số ngẫu nhiên (readonly) |
| `txtConfirm` | TextBox | Nhập mã xác nhận |
| `txtFinal_day` | AsMaskedTextBox | Hiển thị ngày cuối năm (readonly) |
| `bgWork` | BackgroundWorker | Xử lý nền khi thực hiện |
| `cmdOK` | Button | Thực hiện chuyển số dư |
| `cmdCancel` | Button | Hủy bỏ |

---

## Methods và Business Logic

### Methods chính

| Method | Mục đích |
|--------|----------|
| `InitComponents()` | Khởi tạo mã số ngẫu nhiên, ngày cuối năm |
| `Execute()` | Bắt đầu quá trình chuyển số dư |
| `txtConfirm_TextChanged()` | Validate mã xác nhận |
| `bgWork_DoWork()` | Thực hiện chuyển số dư trên background thread |
| `bgWork_RunWorkerCompleted()` | Xử lý kết quả sau khi hoàn thành |

### Logic xử lý

#### InitComponents()
```csharp
- Tạo số ngẫu nhiên làm mã xác nhận
- Hiển thị ngày cuối năm từ cấu hình hệ thống
- Disable cmdOK cho đến khi nhập đúng mã
- Focus vào txtConfirm
```

#### txtConfirm_TextChanged()
```csharp
- So sánh txtConfirm với txtMa_so
- Nếu khớp: Enable cmdOK
- Nếu không khớp: Disable cmdOK
```

#### Execute()
```csharp
- Disable cmdCancel và cmdOK
- Chạy bgWork.RunWorkerAsync()
- Thực hiện trên background thread
```

#### bgWork_DoWork()
```csharp
- Tạo ArrayList với parameters: CompanyID, FinalDay
- Gọi MyController.Execute() để thực hiện
- Lưu kết quả vào bSuccess
```

#### bgWork_RunWorkerCompleted()
```csharp
- Nếu thành công: Hiển thị message 50015 và đóng form
- Nếu thất bại: Hiển thị message 50010 (lỗi)
```

---

## Các chuỗi Text đáng chú ý

### Labels

| Text | Ý nghĩa |
|------|---------|
| "Bạn có chắc muốn chuyển số dư sang năm sau?" | Cảnh báo (màu đỏ) |
| "Ngày cuối năm hiện thời" | Label cho txtFinal_day |
| "Mã số" | Label cho txtMa_so |
| "Xác nhận" | Label cho txtConfirm |

### Messages

| Code | Ý nghĩa |
|------|---------|
| 50015 | Thực hiện thành công |
| 50010 | Thực hiện thất bại |

---

## Mục đích sử dụng

**GLTransferGLCDTK.dll là module "Chuyển số dư tài khoản sang năm sau"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Chuyển số dư cuối năm
- Chuyển số dư tài khoản từ năm hiện tại sang năm sau
- Thực hiện vào cuối kỳ kế toán năm
- Sử dụng stored procedure của database

#### 2. Xác thực an toàn
- Hiển thị mã số ngẫu nhiên
- Yêu cầu người dùng nhập lại để xác nhận
- Tránh thực hiện nhầm thao tác quan trọng

#### 3. Xử lý nền
- Sử dụng BackgroundWorker để không block UI
- Hiển thị trạng thái chờ trong quá trình xử lý
- Xử lý kết quả sau khi hoàn thành

### Đặc điểm kỹ thuật

- Kế thừa từ `frmCalc` - form tính toán chuẩn
- Sử dụng cơ chế xác nhận mã số để tránh thao tác nhầm
- Background processing với BackgroundWorker
- Ngày cuối năm lấy từ cấu hình hệ thống (Ngay_CnTc)
- Random mã xác nhận mỗi lần mở form
- Disable controls trong quá trình xử lý

---

## Quy trình sử dụng

1. Mở form từ menu
2. Xem ngày cuối năm hiện thời
3. Ghi nhớ mã số được hiển thị
4. Nhập mã số vào ô xác nhận
5. Click "OK" khi mã khớp
6. Chờ quá trình xử lý hoàn tất
7. Xem kết quả (thành công/thất bại)

---

## Kết luận

Đây là một module tiện ích quan trọng trong hệ thống ERP Asia Enterprise, phục vụ cho việc chuyển số dư tài khoản cuối năm - một thao tác kế toán quan trọng cần được xác thực cẩn thận để tránh sai sót.

---

*Ngày phân tích: 2026-03-29*
