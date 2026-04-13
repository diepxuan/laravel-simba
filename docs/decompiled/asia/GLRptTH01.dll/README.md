# Báo cáo Phân tích DLL: GLRptTH01.dll

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
| Assembly Name | GLRptF5TH01.vb |
| Assembly Title | GLRptF5TH01.vb |
| Assembly Company | Asia |
| Assembly Product | GLRptF5TH01.vb |
| Assembly Copyright | Copyright © Asia 2011 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 7068faf8-cad3-474c-bf50-f555e9fca4e9 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptTH01.dll/
├── GLRptTH01.csproj           # Project file
├── app.ico                    # Application icon
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptTH01.cs        # Main form class
├── AsiaErp.UserInterface.My/
│   ├── MySettings.cs
│   ├── MyApplication.cs
│   ├── MySettingsProperty.cs
│   ├── MyComputer.cs
│   └── MyProject.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs           # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System, System.Data, System.Drawing, System.Windows.Forms | .NET Framework cơ bản |
| Microsoft.VisualBasic | Visual Basic runtime support |
| AsiaErp.Framework | Framework chung của Asia ERP |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptTH01` | `frmReport` | Form báo cáo tổng hợp 01 |
| `Resources` | - | Resource manager cho localization |

---

## Controls chính

### Filter Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `cboNhom_Theo` | ComboBox | Chọn nhóm theo (KH, TK, BP, HD, Phi, SPCT) |
| `txtTk` | AsTextBox | Lọc theo tài khoản |
| `txtTk_Du` | AsTextBox | Lọc theo tài khoản đối ứng |
| `cboNo_Co` | ComboBox | Chọn Nợ/Có (Tất cả/Nợ/Có) |
| `txtMa_Kh` | AsTextBox | Lọc theo mã khách hàng |
| `txtMa_plkh1/2/3` | AsTextBox | Lọc theo phân loại KH 1/2/3 |
| `txtMa_Bp` | AsTextBox | Lọc theo bộ phận |
| `txtMa_Phi` | AsTextBox | Lọc theo phí |
| `txtMa_Hd` | AsTextBox | Lọc theo hợp đồng |
| `txtMa_nhhd` | AsTextBox | Lọc theo nhóm hợp đồng |
| `txtMa_Spct` | AsTextBox | Lọc theo sản phẩm chi tiết |
| `txtMa_lo` | AsTextBox | Lọc theo lô |
| `txtMa_Ct` | AsTextBox | Lọc theo chứng từ |
| `txtSo_Ct1/2` | TextBox | Khoảng số chứng từ |
| `txtDien_giai` | TextBox | Lọc theo diễn giải |

---

## Methods và Business Logic

### Methods chính

| Method | Mục đích |
|--------|----------|
| `InitOtherComponents()` | Khởi tạo các components, datasource cho combobox |
| `LoadData()` | Load dữ liệu báo cáo từ database |
| `GetFilterTitle()` | Tạo tiêu đề filter cho báo cáo |
| `CreateDrilldownArgument()` | Tạo parameters cho drilldown (F5) |

### Logic xử lý

#### LoadData()
```csharp
- Tạo ArrayList với 22 parameters
- Bao gồm: CompanyID, Ngay1, Ngay2, Ma_Ct, TK, TK_Du, 
  Ma_plkh1/2/3, Ma_Kh, So_Ct1/2, No_Co, Ma_Nt, 
  Ma_Hd, Ma_Phi, Dien_giai, Ma_Bp, Ma_Spct, Ma_nhhd, Ma_lo
- Thêm parameter nhóm theo (groupType)
- Gọi MyController.GetData() và hiển thị Crystal Report
```

#### GetFilterTitle()
```csharp
- Xây dựng chuỗi tiêu đề filter từ các controls
- Chỉ thêm các filter có giá trị khác rỗng
- Sử dụng cho hiển thị trên báo cáo
```

#### CreateDrilldownArgument()
```csharp
- Hỗ trợ drilldown (F5) từ báo cáo
- Lấy dữ liệu từ dòng hiện tại của DataGridView
- Tạo parameters để mở form chi tiết
- Hỗ trợ modifier keys để thay đổi hành vi
```

---

## Các chuỗi Text đáng chú ý

### Nhóm theo (cboNhom_Theo)

| Giá trị | Ý nghĩa |
|---------|---------|
| Khách hàng | Nhóm theo khách hàng |
| Tài khoản | Nhóm theo tài khoản |
| Tài khoản đối ứng | Nhóm theo TK đối ứng |
| Bộ phận | Nhóm theo bộ phận |
| Hợp đồng | Nhóm theo hợp đồng |
| Phí | Nhóm theo phí |
| Sản phẩm | Nhóm theo sản phẩm chi tiết |

### Nợ/Có (cboNo_Co)

| Giá trị | Ý nghĩa |
|---------|---------|
| 0 - Tất cả | Cả nợ và có |
| 1 - Nợ | Chỉ phát sinh nợ |
| 2 - Có | Chỉ phát sinh có |

---

## Mục đích sử dụng

**GLRptTH01.dll là module "Báo cáo tổng hợp 01"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo tổng hợp phát sinh
- Tổng hợp số liệu theo nhiều tiêu chí khác nhau
- Hỗ trợ 7 cách nhóm: KH, TK, TK đối ứng, BP, HD, Phi, SPCT
- Lọc theo khoảng ngày, chứng từ, tài khoản

#### 2. Filter đa chiều
- Tài khoản và tài khoản đối ứng
- Khách hàng và phân loại KH (3 cấp)
- Bộ phận, phí, hợp đồng, nhóm hợp đồng
- Sản phẩm chi tiết, lô
- Số chứng từ (từ số - đến số)
- Diễn giải
- Ngoại tệ

#### 3. Drilldown (F5)
- Từ báo cáo tổng hợp có thể xem chi tiết
- Hỗ trợ F5 để mở form chi tiết
- Tự động truyền parameters theo đối tượng nhóm

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn
- Sử dụng Crystal Report để hiển thị
- Hỗ trợ đa tiền tệ
- DataBinding với DataTable
- Filter động với 22+ parameters

---

## Kết luận

Đây là một module báo cáo tổng hợp quan trọng trong hệ thống ERP Asia Enterprise, cho phép người dùng xem và phân tích số liệu kế toán theo nhiều tiêu chí khác nhau với khả năng drilldown chi tiết.

---

*Ngày phân tích: 2026-03-29*
