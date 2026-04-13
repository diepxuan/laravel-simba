# Báo cáo Phân tích DLL: GLRptBCTCCR03.dll

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
| Assembly Name | GLRptBCTCCR03 |
| Assembly Title | Báo cáo kết quả hoạt động kinh doanh |
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
GLRptBCTCCR03.dll/
├── GLRptBCTCCR03.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLRptBCTCCR03.cs      # Main report form
│   ├── frmGLMauPL01.cs          # Template management form
│   └── frmGLMauPL01Edit.cs      # Template edit form
└── AsiaErp.UserInterface.My/
    ├── MySettingsProperty.cs    # Settings property
    └── MySettings.cs            # Settings manager
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
| `frmGLRptBCTCCR03` | `frmReport` | Form báo cáo kết quả hoạt động kinh doanh |
| `frmGLMauPL01` | `frmDMView` | Form quản lý mẫu biểu báo cáo |
| `frmGLMauPL01Edit` | `frmDMEdit` | Form chỉnh sửa mẫu biểu báo cáo |

---

## Chi tiết Forms

### frmGLRptBCTCCR03

Form báo cáo chính, kế thừa từ `frmReport`.

#### Controls

| Control | Type | Mục đích |
|---------|------|----------|
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo hiện tại |
| `cboKyTruoc` | ComboBox | Chọn kỳ báo cáo trước |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Ngày bắt đầu/kết thúc kỳ hiện tại |
| `txtNgay01`, `txtNgay02` | AsMaskedTextBox | Ngày bắt đầu/kết thúc kỳ trước |
| `txtMa_Bp` | AsTextBox | Mã bộ phận lọc báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `txtTieu_De` | TextBox | Tiêu đề báo cáo |
| `optVND`, `optNt` | RadioButton | Tùy chọn đơn vị tiền tệ |
| `cmdPL` | Button | Mở form khai báo công thức |
| `cmdOk`, `cmdCancel`, `cmdExcel` | Button | Xác nhận/Hủy/Xuất Excel |

#### Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| `cboKyTruoc.SelectedValueChanged` | `cboKyTruoc_SelectedValueChanged` | Tự động tính ngày kỳ trước |
| `cmdPL.Click` | `cmdPL_Click` | Mở form quản lý mẫu công thức |

#### Business Logic

- **LoadData**: Gọi stored procedure với các tham số:
  - `CompanyID`, `FinancialYear`
  - Ngày kỳ hiện tại (`txtNgay1`, `txtNgay2`)
  - Ngày kỳ trước (`txtNgay01`, `txtNgay02`)
  - Mã mẫu báo cáo, mã bộ phận, mã ngoại tệ

- **Drilldown**: Hỗ trợ drill-down khi nhấn F5:
  - Nếu có `cach_tinh`: Drill-down theo công thức
  - Nếu có `tk_no` hoặc `tk_co`: Drill-down theo tài khoản

### frmGLMauPL01

Form quản lý danh mục mẫu biểu phụ lục 01.

#### Chức năng
- Kế thừa từ `frmDMView` (danh mục dạng view)
- Quản lý các mẫu công thức tính toán cho báo cáo
- Lọc theo mã mẫu (`ma_mau`) được truyền vào constructor

### frmGLMauPL01Edit

Form chỉnh sửa chi tiết mẫu biểu.

#### Controls

| Control | Type | Mục đích |
|---------|------|----------|
| `txtStt` | TextBox | Số thứ tự |
| `txtMa_so` | TextBox | Mã số chỉ tiêu |
| `txtChi_tieu` | TextBox | Tên chỉ tiêu |
| `txtTm` | TextBox | Thuyết minh |
| `chkIn_ck` | AsCheckBox | In/Không in |
| `chkBold` | AsCheckBox | Đậm/Không đậm |
| `chkCach_tinh` | AsCheckBox | Tính theo SD TK / Tính theo công thức |
| `txtDsTk_no` | AsTextBox | Danh sách TK nợ |
| `txtDsTK_co` | AsTextBox | Danh sách TK có |
| `chkgiam_tru` | AsCheckBox | Tính/Không tính giảm trừ |
| `txtCach_tinh` | TextBox | Công thức tính toán |

#### Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| `chkCach_tinh.Click` | `chkCach_tinh_Click` | Chuyển đổi chế độ tính toán |
| `chkCach_tinh.Validated` | `chkCach_tinh_Validated` | Focus control phù hợp |

#### Business Logic

- **Hai chế độ tính toán**:
  1. **Tính theo số dư tài khoản**: Nhập danh sách TK nợ/có, tính số dư
  2. **Tính theo công thức**: Nhập công thức tính từ các chỉ tiêu khác

- **Validation**:
  - Kiểm tra tồn tại của các tài khoản trong danh sách
  - Bắt buộc nhập công thức hoặc danh sách TK

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo cáo kết quả hoạt động kinh doanh" - Tên chức năng chính
- "Kỳ trước" - Lựa chọn kỳ so sánh
- "Mã bộ phận", "Tên bộ phận"
- "KB Công thức" - Nút khai báo công thức
- "Mã số", "Chỉ tiêu", "Thuyết minh"
- "Số thứ tự"

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ma_bp` | Mã bộ phận |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `cach_tinh` | Cách tính/Công thức |
| `chi_tieu` | Chỉ tiêu báo cáo |
| `sodu_duong` | Số dư dương (giảm trừ) |
| `KyBaoCao` | Kỳ báo cáo |

### Chế độ tính toán

- "Tính theo số dư tài khoản / tính theo công thức"
- "Tính / không tính giảm trừ"
- "Đậm / không đậm"
- "In / không in"

---

## Mục đích sử dụng

**GLRptBCTCCR03.dll là module báo cáo "Kết quả hoạt động kinh doanh"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo kết quả hoạt động kinh doanh
- Chọn kỳ báo cáo hiện tại và kỳ trước để so sánh
- Lọc theo bộ phận, ngoại tệ
- Hỗ trợ nhiều mẫu báo cáo khác nhau
- Xuất báo cáo ra Excel

#### 2. Quản lý mẫu công thức
- Khai báo công thức tính toán cho từng chỉ tiêu
- Hỗ trợ hai chế độ tính:
  - Tính theo số dư tài khoản (nhập DSTK nợ/có)
  - Tính theo công thức (cộng/trừ các chỉ tiêu khác)
- Thiết lập in đậm, ẩn/hiện chỉ tiêu

#### 3. Drill-down chi tiết
- Nhấn F5 để xem chi tiết chỉ tiêu
- Drill-down theo công thức: Hiển thị các chỉ tiêu tham gia tính toán
- Drill-down theo tài khoản: Xem sổ chi tiết TK nợ/có

### Đặc điểm kỹ thuật

- Sử dụng `KyBaoCao` object để quản lý các kỳ báo cáo
- Tự động tính ngày bắt đầu/kết thúc kỳ trước dựa trên năm tài chính
- DataBinding với DataTable cho form chỉnh sửa
- Validation tài khoản khi nhập danh sách TK
- Hỗ trợ public variables để lưu trạng thái lựa chọn kỳ báo cáo

### Mã báo cáo

**BCTCCR03** - Báo cáo Tài chính - Kết quả hoạt động kinh doanh (theo thông tư 03).

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc lập báo cáo Kết quả hoạt động kinh doanh theo chuẩn mực kế toán Việt Nam. Module hỗ trợ linh hoạt việc định nghĩa công thức tính toán và so sánh số liệu giữa các kỳ.

---

*Ngày phân tích: 2026-03-29*
