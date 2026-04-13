# Báo cáo Phân tích DLL: RptCommon.dll

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
| Assembly Name | RptCommon |
| Assembly Title | bảng kê đơn đặt hàng |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | "" |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 5b533d97-568d-41be-b375-36ef4aabce81 |
| ComVisible | false |

---

## Cấu trúc File

```
RptCommon.dll/
├── RptCommon.csproj             # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmRptCommon.cs          # Main report form
│   ├── Form1.cs                 # Form phụ 1
│   ├── Form2.cs                 # Form phụ 2
│   └── Form3.cs                 # Form phụ 3
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   └── MySettingsProperty.cs
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
- `System`, `System.Collections`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmRptCommon` | `frmReport` | Form báo cáo chung |
| `Form1` | - | Form phụ 1 |
| `Form2` | - | Form phụ 2 |
| `Form3` | - | Form phụ 3 |

---

## Controls chính trong frmRptCommon

| Control | Loại | Mục đích |
|---------|------|----------|
| `palFilter` | FlowLayoutPanel | Panel chứa các filter động |
| `palFilterMa` | Panel | Panel chứa filter mã |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `txtNgay1` | AsMaskedTextBox | Từ ngày |
| `txtNgay2` | AsMaskedTextBox | Đến ngày |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND` | RadioButton | Option VNĐ |
| `optNt` | RadioButton | Option ngoại tệ |
| `txtTieu_De` | TextBox | Tiêu đề báo cáo |
| `cmdOk` | Button | Thực hiện báo cáo |
| `cmdCancel` | Button | Hủy |
| `cmdExcel` | Button | Xuất Excel |
| `cmdModifyReport` | Button | Sửa mẫu báo cáo |
| `dgvBC` | DataGridView | Grid hiển thị dữ liệu báo cáo |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "bảng kê đơn đặt hàng" - Tên chức năng mặc định
- "Mẫu báo cáo" - Chọn mẫu in |
| "Kỳ báo cáo" - Chọn kỳ |
| "Tiêu đề" - Tiêu đề báo cáo |
| "Mã ngoại tệ" - Lọc theo ngoại tệ |

### Dynamic Filter

Form hỗ trợ tạo filter động dựa trên cấu hình `par1` trong menu:
- `L=` - Label text
- `R` - Required field
- `T=C` - Control type AsTextBox (lookup)
- `T=T` - Control type TextBox

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `mau_bc` | Mã mẫu báo cáo |
| `ky_bc` | Kỳ báo cáo |
| `ngay1` | Từ ngày |
| `ngay2` | Đến ngày |
| `ma_nt` | Mã ngoại tệ |
| `tieu_de` | Tiêu đề báo cáo |
| `strFilterTitle` | Tiêu đề filter |

---

## Mục đích sử dụng

**RptCommon.dll là module báo cáo chung (Common Report)** trong hệ thống AsiaERP của ASIASOFT.

### Chức năng chính

#### 1. Báo cáo động (Dynamic Report)
- Tạo báo cáo dựa trên cấu hình menu
- Hỗ trợ nhiều mẫu báo cáo khác nhau
- Filter động theo tham số cấu hình

#### 2. Filter linh hoạt
- Filter mã (AsTextBox với AutoLookup)
- Filter text (TextBox thường)
- Filter ngày (AsMaskedTextBox)
- Filter số tiền (AsTextNumeric)
- Filter bắt buộc (Required)

#### 3. Tùy chọn hiển thị
- Chọn mẫu báo cáo (cboMau_bc)
- Chọn kỳ báo cáo (cboKyBc)
- Chọn ngoại tệ (optVND/optNt)
- Nhập tiêu đề tùy chỉnh

#### 4. Xuất dữ liệu
- Hiển thị trên DataGridView
- Xuất ra Excel (cmdExcel)
- In ấn báo cáo
- Sửa mẫu báo cáo (cmdModifyReport)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport`
- Tạo controls động dựa trên cấu hình `par1`
- Format: `FIELD:L=Label:R:T=C` (Code lookup) hoặc `T=T` (Text)
- ArrayList lưu trữ controls và required fields
- ToolTip hỗ trợ người dùng
- HelpProvider tích hợp

### Cấu hình Filter động

Filter được định nghĩa trong trường `par1` của menu:
```
MA_KH:L=Mã KH:R:T=C,SO_CT:L=Số CT:T=T,...
```

- `MA_KH` - Tên field
- `L=Mã KH` - Label hiển thị
- `R` - Bắt buộc nhập
- `T=C` - Loại control (C=Code lookup, T=Text)

---

## Kết luận

Đây là module Windows Forms của hệ thống AsiaERP, phục vụ như một framework báo cáo chung cho phép tạo các báo cáo động dựa trên cấu hình - giảm thiểu việc phát triển form báo cáo riêng lẻ cho từng nghiệp vụ.

---

*Ngày phân tích: 2026-03-29*
