# Báo cáo Phân tích DLL: GLRptBCTCCR04.dll

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
| Assembly Name | GLRptBCTCCR04 |
| Assembly Title | Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp |
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
GLRptBCTCCR04.dll/
├── GLRptBCTCCR04.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLRptBCTCCR04.cs      # Main report form
│   ├── frmGLMauCF01.cs          # Form mẫu cash flow
│   └── frmGLMauCF01Edit.cs      # Form chỉnh sửa mẫu
└── AsiaErp.UserInterface.My/
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
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCTCCR04` | `frmReport` | Form báo cáo Lưu chuyển tiền tệ (phương pháp trực tiếp) |
| `frmGLMauCF01` | - | Form quản lý mẫu cash flow |
| `frmGLMauCF01Edit` | - | Form chỉnh sửa mẫu cash flow |

---

## Controls và Events chính

### frmGLRptBCTCCR04

| Control | Type | Mục đích |
|---------|------|----------|
| `cmdCF` | Button | Mở form KB Công thức cash flow |
| `cboKyTruoc` | ComboBox | Chọn kỳ trước để so sánh |
| `txtNgay01`, `txtNgay02` | AsMaskedTextBox | Ngày kỳ trước |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Ngày kỳ báo cáo |
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Tùy chọn tiền tệ |

### Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| `cboKyTruoc.SelectedValueChanged` | `cboKyTruoc_SelectedValueChanged` | Cập nhật ngày kỳ trước |
| `cmdCF.Click` | `cmdCF_Click` | Mở form frmGLMauCF01 |

---

## Phương thức chính

### InitKyBaoCaoTruoc()
- Khởi tạo danh sách kỳ báo cáo trước
- DataSource từ `AsiaErp.Framework.Environment.GetKyBaoCao()`
- ValueMember: "ma", DisplayMember: "ten_ky"

### LoadData()
- Load dữ liệu báo cáo với các tham số:
  - CompanyID
  - FinancialYear
  - Ngày kỳ báo cáo (txtNgay1, txtNgay2)
  - Ngày kỳ trước (txtNgay01, txtNgay02)
  - Mã mẫu báo cáo
  - Mã ngoại tệ

### GetFilterCondiction()
- Tạo chuỗi mô tả điều kiện lọc:
  - Kỳ báo cáo
  - Kỳ trước
  - Mã ngoại tệ

### CreateDrilldownArgument()
- Xử lý drill-down với phím F5
- Drill-down theo:
  - Cách tính (công thức): Hiển thị các chỉ tiêu tham gia công thức
  - Tài khoản nợ (tk_no) và Tài khoản có (tk_co)

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp" - Tên báo cáo
- "KB &Công thức" - Nút mở khai báo công thức
- "Kỳ trước" - Nhãn chọn kỳ so sánh

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính/công thức |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `chi_tieu` | Chỉ tiêu báo cáo |

---

## Mục đích sử dụng

**GLRptBCTCCR04.dll là module báo cáo "Lưu chuyển tiền tệ theo phương pháp trực tiếp"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Lưu chuyển tiền tệ (Direct Method)
- Hiển thị dòng tiền vào/ra của doanh nghiệp
- Phân loại theo hoạt động kinh doanh, đầu tư, tài chính
- So sánh với kỳ trước

#### 2. Phương pháp trực tiếp (Direct Method)
- Theo dõi trực tiếp các khoản thu/chi tiền mặt
- Không điều chỉnh từ lợi nhuận
- Phù hợp với chuẩn mực kế toán quốc tế

#### 3. Quản lý mẫu báo cáo
- Tích hợp form frmGLMauCF01 để quản lý mẫu cash flow
- Hỗ trợ chỉnh sửa công thức tính toán

#### 4. Drill-down chi tiết
- Xem chi tiết công thức tính các chỉ tiêu
- Xem sổ chi tiết theo TK nợ/TK có

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Hỗ trợ so sánh kỳ (kỳ hiện tại vs kỳ trước)
- Hỗ trợ đa tiền tệ
- Tích hợp drill-down đa cấp

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp - một báo cáo tài chính quan trọng theo quy định của pháp luật kế toán Việt Nam và chuẩn mực quốc tế.

---

*Ngày phân tích: 2026-03-29*
