# Báo cáo Phân tích DLL: ReportDynamic.dll

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
| Assembly Name | ReportDynamic |
| Assembly Title | Bảng kê đơn đặt hàng |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 5b533d97-568d-41be-b375-36ef4aabce81 |
| ComVisible | false |

---

## Cấu trúc File

```
ReportDynamic.dll/
├── ReportDynamic.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmReportDynamic.cs      # Main form class - Dynamic Report Form
├── AsiaErp.DataAccess/
│   ├── ReportDynamicDAO.cs      # DAO Interface
│   └── MsSqlReportDynamicDAO.cs # SQL Server DAO Implementation
└── My/
    ├── MyProject.cs             # VB.NET My namespace support
    ├── MyComputer.cs            # My.Computer support
    ├── MyApplication.cs         # My.Application support
    ├── MySettings.cs            # Settings manager
    └── MySettingsProperty.cs    # Settings properties
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmReportDynamic` | `frmReport` | Form báo cáo động - tự động tạo control filter từ cấu hình |
| `ReportDynamicDAO` | `DAO` | Interface định nghĩa phương thức lấy cấu hình filter |
| `MsSqlReportDynamicDAO` | `MsSqlDAO`, `ReportDynamicDAO` | Triển khai SQL Server cho DAO |
| `Resources` | - | Resource manager cho localization |

---

## Dynamic Report System

### Cơ chế hoạt động

ReportDynamic.dll cung cấp **framework tạo báo cáo động** - form filter và báo cáo được tạo tự động dựa trên cấu hình từ database.

#### 1. Cấu hình Filter Control

Stored procedure `asDynGetControl4Form` trả về chuỗi định nghĩa các control filter:

```
Format: FieldName:L=Label:D=Default:T=Type:...
```

| Ký hiệu | Ý nghĩa |
|---------|---------|
| `L=` | Label hiển thị |
| `D=` | Giá trị mặc định |
| `T=` | Loại control (TEXTBOX, LOOKUP, CHECKBOX, RADIO, COMBOBOX) |
| `W=` | Chiều rộng (pixel) |
| `*` | Bắt buộc nhập (required) |
| `RADIO=Opt1/Opt2/Opt3` | Radio button với các option |
| `CHECKBOX=Value` | Checkbox với giá trị tag |
| `COMBOBOX=Val1/Val2/Val3` | Dropdown với các giá trị |
| `LOOKUPWHERE=Condition` | Lookup với điều kiện lọc |

#### 2. Các loại Control được hỗ trợ

| Loại | Control | Đặc điểm |
|------|---------|----------|
| TEXTBOX | TextBox | Nhập liệu tự do, width mặc định 330px |
| LOOKUP | AsTextBox | Auto-lookup với danh mục, width mặc định 90px |
| CHECKBOX | CheckBox | Checkbox với tag value, width mặc định 90px |
| RADIO | GroupBox + RadioButton | Nhóm radio buttons, width mặc định 396px |
| COMBOBOX | ComboBox | Dropdown list, width tự tính theo content |

#### 3. Ví dụ cấu hình

```
ma_kh:L=Khách hàng:D=:T=LOOKUP:W=120,
ngay_hd:L=Ngày HĐ:D=:T=TEXTBOX:W=100,
tinh_trang:L=Tình trạng:D=1:T=RADIO=Chưa xử lý/Đang xử lý/Hoàn thành,
chk_duyet:L=Đã duyệt:D=:T=CHECKBOX=1:*
```

---

## Thuật ngữ và trường dữ liệu

### UI Elements

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtNgay1`, `txtNgay2` | Từ ngày - Đến ngày |
| `cboKyBc` | Kỳ báo cáo |
| `cboMau_bc` | Mẫu báo cáo |
| `txtTieu_De` | Tiêu đề báo cáo |
| `optVND`, `optNt` | Tùy chọn tiền tệ (VNĐ/Ngoại tệ) |
| `cmdOk` | Nút xem báo cáo |
| `cmdExcel` | Nút xuất Excel |
| `cmdCancel` | Nút hủy |
| `cmdModifyReport` | Nút chỉnh sửa mẫu báo cáo |

### Dynamic Control Prefixes

| Prefix | Loại control |
|--------|--------------|
| `txt` | TextBox / AsTextBox |
| `lbl` | Label |
| `chk` | CheckBox |
| `rad` | RadioButton |
| `cbo` | ComboBox |
| `lblName` | Label hiển thị tên lookup |

---

## Mục đích sử dụng

**ReportDynamic.dll là module báo cáo động** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Tạo form filter động
- Đọc cấu hình từ stored procedure `asDynGetControl4Form`
- Tự động render các control filter theo định nghĩa
- Hỗ trợ 5 loại control: TEXTBOX, LOOKUP, CHECKBOX, RADIO, COMBOBOX
- Quản lý tab index tự động

#### 2. Quản lý tham số báo cáo
- Thu thập giá trị từ các dynamic control
- Xử lý validation cho trường bắt buộc (`*`)
- Tạo filter title từ các tham số đã chọn
- Truyền tham số vào stored procedure báo cáo

#### 3. Tích hợp hệ thống
- Kế thừa từ `frmReport` - base form báo cáo
- Sử dụng `AsTabControl` cho giao diện tabbed
- Tích hợp HelpProvider cho context-sensitive help
- Hỗ trợ lookup tự động với `AsTextBox.AutoLookup`

### Đặc điểm kỹ thuật

| Đặc điểm | Chi tiết |
|----------|----------|
| Dynamic UI Generation | Tạo control tại runtime từ string config |
| Type Safety | Sử dụng Reflection để xác định loại control |
| Data Binding | Binding với DataTable cho ComboBox |
| Validation | Kiểm tra trường bắt buộc trước khi xem báo cáo |
| Localization | Hỗ trợ đa ngôn ngữ qua Resources |

### Cách sử dụng

1. **Định nghĩa stored procedure báo cáo** với tên được đăng ký trong `DMBCTHEO`
2. **Tạo stored procedure `asDynGetControl4Form`** trả về chuỗi cấu hình filter
3. **Đăng ký trong menu** với mã báo cáo tương ứng
4. **Form tự động render** các control filter khi mở

---

## Database Integration

### Stored Procedures

| SP Name | Mục đích |
|---------|----------|
| `asDynGetControl4Form` | Lấy cấu hình filter control cho form |
| `[SP báo cáo tùy chỉnh]` | Truy vấn dữ liệu báo cáo |

### Tables liên quan

| Table | Mục đích |
|-------|----------|
| `DMBCTHEO` | Danh mục báo cáo - chứa tên SP và cấu hình |

---

## Kết luận

Đây là module **Dynamic Report Framework** của hệ thống ERP Asia, cho phép tạo các báo cáo tùy chỉnh mà không cần viết code form. Chỉ cần định nghĩa cấu hình trong database, form filter sẽ được tự động sinh ra với đầy đủ các loại control cần thiết.

Module này giảm thiểu đáng kể effort phát triển báo cáo mới và đảm bảo tính nhất quán trong giao diện người dùng.

---

*Ngày phân tích: 2026-03-29*
