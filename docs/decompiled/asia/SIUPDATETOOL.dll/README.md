# Báo cáo Phân tích DLL: SIUPDATETOOL.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# (decompiled từ VB.NET) |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SIUPDATETOOL |
| Assembly Title | SIUPDATETOOL |
| Assembly Company | Asia |
| Assembly Product | SIUPDATETOOL |
| Assembly Copyright | Copyright © Asia 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | ac868467-96fa-413c-9a3b-69088648d4e2 |
| ComVisible | false |

---

## Cấu trúc File

```
SIUPDATETOOL.dll/
├── SIUPDATETOOL.csproj         # Project file
├── app.ico                     # Application icon
├── frmSplash.cs                # Form splash screen
├── frmSplash.resx
├── Properties/
│   └── AssemblyInfo.cs         # Assembly metadata
├── My/
│   ├── MyApplication.cs        # VB My namespace
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   └── InternalXmlHelper.cs
├── My.Resources/
│   └── Resources.cs            # Resource manager
├── AsiaErp.UserInterface/
│   └── FrmSync.cs              # Form đồng bộ chính
└── AsiaErp.DataAccess/
    ├── UpdateDAO.cs            # Interface DAO
    └── MsSqlUpdateDAO.cs       # Implementation SQL Server
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Xml.Linq | XML processing |
| System.Core | Core framework |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| System.Configuration | Cấu hình ứng dụng |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `System.Configuration`, `System.IO`, `System.Threading`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `FrmSync` | `frmAsiaRoot` | Form đồng bộ cập nhật chương trình |
| `frmSplash` | `Form` | Màn hình splash khi cập nhật |
| `UpdateDAO` | `DAO` | Interface truy xuất dữ liệu update |
| `MsSqlUpdateDAO` | `UpdateDAO` | Implementation cho SQL Server |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Cập nhật chương trình" - Tên form chính
- "Từ thư mục" - Label chỉ đường dẫn nguồn
- "Đến thư mục" - Label chỉ đường dẫn đích
- "Đồng bộ với máy chủ" - RadioButton chế độ server
- "Cập nhật từ file (*.zip)" - RadioButton chế độ file zip
- "Cập nhật" - Button thực hiện
- "Hủy" - Button hủy bỏ
- "Chương trình sẽ tự thoát khi cập nhật" - Ghi chú
- "Cập nhật phiên bản mới từ thư mục" - Mô tả folder browser

### Thông báo lỗi

| Mã lỗi | Ý nghĩa |
|--------|---------|
| 50999 | Thư mục/file không tồn tại |
| 50110 | File config không tồn tại |
| 50998 | Lỗi ghi config |
| 50010 | Lỗi chung |
| 50015 | Thành công |

---

## Mục đích sử dụng

**SIUPDATETOOL.dll là công cụ đồng bộ và cập nhật phiên bản mới** cho hệ thống Asia ERP.

### Chức năng chính

#### 1. Đồng bộ từ Server
- Chọn chế độ "Đồng bộ với máy chủ"
- Chỉ định thư mục nguồn chứa file cập nhật
- Tự động copy file từ thư mục nguồn đến thư mục ứng dụng
- Ghi log cập nhật vào database

#### 2. Cập nhật từ File Zip
- Chọn chế độ "Cập nhật từ file (*.zip)"
- Chọn file zip chứa package cập nhật
- Giải nén và áp dụng cập nhật
- Hỗ trợ file nén từ SiUpdateLog.dll

#### 3. Quản lý cấu hình
- Đọc/ghi file `AsiaErpSync.exe.config`
- Lưu trữ đường dẫn UPDATE_PATH
- Sử dụng `ExeConfigurationFileMap` để truy cập config

#### 4. Splash Screen
- Hiển thị màn hình chờ trong quá trình cập nhật
- Chạy trên thread riêng (`threadShowSplash`)
- Tự động đóng khi hoàn tất

#### 5. Kill Application
- Đóng process `Startup.exe` trước khi cập nhật
- Đảm bảo file không bị khóa khi copy/replace

### Quy trình cập nhật

```
1. Người dùng chọn chế độ (Server/Zip file)
2. Chỉ định đường dẫn nguồn
3. Validate đường dẫn tồn tại
4. Ghi config UPDATE_PATH
5. Start AsiaErpSync.exe
6. Kill Startup.exe
7. Tự thoát để hoàn tất cập nhật
```

### Đặc điểm kỹ thuật

- Sử dụng `Process.Start()` để chạy sync process
- `Process.GetProcessesByName()` để tìm và kill process
- `ConfigurationManager` để đọc/ghi config
- `Thread` cho splash screen
- `Timer` cho đồng bộ UI
- Hotkey: ESC (đóng form)

### File cấu hình

**AsiaErpSync.exe.config:**
```xml
<configuration>
  <appSettings>
    <add key="UPDATE_PATH" value="\\server\updates" />
  </appSettings>
</configuration>
```

### Database Logging

| Method | Mục đích |
|--------|----------|
| `InsertLogUpdate` | Ghi log cập nhật vào database |
| `ExecuteTSQL` | Thực thi SQL script |

---

## Kết luận

Đây là module cập nhật tự động cho Asia ERP, hỗ trợ cả hai chế độ: đồng bộ từ server network và cập nhật từ file zip offline. Module đảm bảo an toàn khi cập nhật bằng cách kill các process đang chạy trước khi replace file.

---

*Ngày phân tích: 2026-03-29*
