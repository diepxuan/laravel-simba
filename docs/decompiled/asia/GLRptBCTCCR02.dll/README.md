# Báo cáo Phân tích DLL: GLRptBCTCCR02.dll

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
| Assembly Name | GLRptBCTCCR02 |
| Assembly Title | Bảng cân đối kế toán |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptBCTCCR02.dll/
├── GLRptBCTCCR02.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLRptBCTCCR02.cs      # Main report form
│   ├── frmGLMauBS01.cs          # Form mẫu bảng cân đối
│   └── frmGLMauBS01Edit.cs      # Form chỉnh sửa mẫu
└── AsiaErp.UserInterface.My/
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

- `AsiaErp.Framework`
- `AsiaErp.UserInterface.My`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCTCCR02` | `frmReport` | Form báo cáo Bảng cân đối kế toán |
| `frmGLMauBS01` | - | Form quản lý mẫu bảng cân đối |
| `frmGLMauBS01Edit` | - | Form chỉnh sửa mẫu bảng cân đối |

---

## Controls và Events chính

### frmGLRptBCTCCR02

| Control | Type | Mục đích |
|---------|------|----------|
| `cmdBS` | Button | Mở form KB Công thức |
| `chkChiTieuCoSoLieu` | CheckBox | Chỉ hiển thị chỉ tiêu có số liệu |
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Ngày bắt đầu/kết thúc |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Tùy chọn tiền tệ |

### Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| `AsTabControl.SelectedIndexChanged` | `AsTabControl_SelectedIndexChanged` | Cập nhật title bar khi chuyển tab |
| `cmdBS.Click` | `cmdBS_Click` | Mở form frmGLMauBS01 |

---

## Phương thức chính

### LoadData()
- Load dữ liệu báo cáo với các tham số:
  - CompanyID
  - FinancialYear
  - Ngày báo cáo (txtNgay2)
  - Checkbox chỉ tiêu có số liệu
  - Mã mẫu báo cáo

### CreateDrilldownArgument()
- Xử lý drill-down với các phím tắt:
  - **F5**: Chi tiết công thức/Sổ chi tiết
  - **Ctrl+F5**: Sổ chi tiết
  - **Shift+F5**: Cân đối PS công nợ
- Drill-down theo:
  - Cách tính (công thức)
  - Tài khoản (tk)

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng cân đối kế toán" - Tên báo cáo
- "KB &Công thức" - Nút mở khai báo công thức
- "Chỉ lên cho các chỉ tiêu có số liệu" - Checkbox lọc
- "F5 - Chi tiet cong thuc/So chu T, Ctrl+F5 - So chi tiet, Shift+F5 - Can doi PS cong no"

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính/công thức |
| `tk` | Tài khoản |
| `chi_tieu` | Chỉ tiêu báo cáo |
| `cong_no` | Công nợ |

---

## Mục đích sử dụng

**GLRptBCTCCR02.dll là module báo cáo "Bảng cân đối kế toán"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Bảng cân đối kế toán
- Hiển thị tình hình tài chính của doanh nghiệp tại một thời điểm
- So sánh số liệu giữa các kỳ báo cáo
- Hỗ trợ lọc chỉ tiêu có số liệu

#### 2. Quản lý mẫu báo cáo
- Tích hợp form frmGLMauBS01 để quản lý mẫu
- Hỗ trợ chỉnh sửa công thức tính toán
- Lưu trữ nhiều mẫu báo cáo khác nhau

#### 3. Drill-down chi tiết
- Xem chi tiết công thức tính
- Xem sổ chi tiết theo tài khoản
- Xem cân đối phát sinh công nợ

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Sử dụng DataBinding với DataTable
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)
- Tích hợp drill-down đa cấp

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn Bảng cân đối kế toán - một báo cáo tài chính quan trọng theo quy định của pháp luật kế toán Việt Nam.

---

*Ngày phân tích: 2026-03-29*
