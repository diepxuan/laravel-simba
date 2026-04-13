# Báo cáo Phân tích DLL: SiReOrderVoucherNumber.dll

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
| Assembly Name | SiReOrderVoucherNumber |
| Assembly Title | Kết chuyển tự động |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly File Version | 1.0.0.0 |
| GUID | fbcae1bc-4a96-467b-9a6e-b6a74302b9a1 |
| ComVisible | false |

---

## Cấu trúc File

```
SiReOrderVoucherNumber.dll/
├── SiReOrderVoucherNumber.csproj    # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── SiReOrderVoucherNumberDAO.cs # Data Access Object
│   └── MsSqlSiReOrderVoucherNumberDAO.cs  # SQL Server Implementation
├── AsiaErp.UserInterface/
│   └── frmSiReOrderVoucherNumber.cs # Main form class
└── My/
    ├── MyApplication.cs             # Application settings
    ├── MyComputer.cs                # Computer info
    ├── MySettings.cs                # User settings
    ├── MySettingsProperty.cs        # Settings property
    └── MyProject.cs                 # Project helpers
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| System.Data | Data access |
| System.Core | Core functionality |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `System.Threading`, `System.ComponentModel`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSiReOrderVoucherNumber` | `frmAsiaRoot` | Form sắp xếp lại số chứng từ |
| `SiReOrderVoucherNumberDAO` | Interface | Data access interface |
| `MsSqlSiReOrderVoucherNumberDAO` | - | SQL Server implementation |

---

## Các trường dữ liệu chính

### Form frmSiReOrderVoucherNumber

#### Controls chính

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `cboKyBc` | AsComboBox | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Khoảng ngày thực hiện |
| `chkSelectAll` | AsCheckBox | Chọn tất cả |
| `dgvDmKC` | AsDataGridView | Grid danh mục kết chuyển |
| `cmdKc` | Button | Thực hiện kết chuyển |
| `cmdCancel` | Button | Hủy bỏ |
| `prbExecute` | ProgressBar | Thanh tiến trình |
| `bgwk` | BackgroundWorker | Xử lý nền |

#### DataGridView Columns

| Column | DataProperty | Header |
|--------|--------------|--------|
| `colSelect` | Select | Chọn |
| `colTT_BT` | TT_BT | Số thứ tự |
| `dgvcMa_ct_me` | Ma_ct_me | Mã chứng từ mẹ |
| `colTenBT` | TenBT | Tên bút toán |
| `dgvcVn_prefix` | Vn_prefix | Prefix số VN |
| `dgvcVn_pattern` | Vn_pattern | Pattern số VN |
| `dgvcVn_width` | Vn_width | Độ rộng số VN |
| `dgvcKieuTrung` | KieuTrung | Kiểu trùng |
| `dgvcSoctMax` | SoctMax | Số CT max |
| `dgvcSo_ct` | So_ct | Số CT hiện tại |

---

## Mục đích sử dụng

**SiReOrderVoucherNumber.dll là module sắp xếp lại số chứng từ** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục kết chuyển
- Hiển thị danh sách các bút toán/bảng kê cần sắp xếp số
- Lọc theo kỳ báo cáo và khoảng ngày
- Chọn lọc từng bút toán hoặc chọn tất cả

#### 2. Cấu hình số chứng từ
- **Prefix**: Tiền tố số chứng từ (VN)
- **Pattern**: Mẫu số chứng từ
- **Width**: Độ rộng số chứng từ
- **KieuTrung**: Kiểu kiểm tra trùng số
- **SoctMax**: Số chứng từ lớn nhất hiện tại
- **So_ct**: Số chứng từ hiện hành

#### 3. Thực hiện sắp xếp lại
- Sử dụng BackgroundWorker để xử lý nền
- Hiển thị progress bar trong quá trình thực hiện
- Hỗ trợ hủy bỏ quá trình (cmdCancel)
- Cập nhật tiến trình theo thời gian thực

#### 4. Xử lý bất đồng bộ
- `ThreadComplete` delegate để xử lý hoàn thành
- `ManualResetEvent` để đồng bộ thread
- `BackgroundWorker` cho xử lý nền không lock UI

### Đặc điểm kỹ thuật

- Kế thừa từ `frmAsiaRoot` của Framework
- Sử dụng DAO pattern cho data access
- DataBinding với DataTable (`f_tblDmkc`)
- Hỗ trợ multi-threading với BackgroundWorker
- Progress reporting qua `prbExecute`
- Filter theo kỳ báo cáo (`cboKyBc`) và khoảng ngày

### Quy trình xử lý

1. Người dùng chọn kỳ báo cáo và khoảng ngày
2. Hệ thống load danh sách bút toán/bảng kê
3. Người dùng chọn các mục cần sắp xếp lại số
4. Nhấn "Kết chuyển" để thực hiện
5. Hệ thống đánh số lại theo pattern đã cấu hình
6. Hiển thị tiến trình và thông báo kết quả

---

## Kết luận

Đây là module tiện ích quan trọng trong hệ thống ERP Asia, cho phép sắp xếp lại số chứng từ theo quy tắc đánh số tự động. Module hỗ trợ cấu hình linh hoạt prefix, pattern, độ rộng số và kiểm tra trùng số, đảm bảo tính nhất quán trong việc đánh số chứng từ kế toán.

---

*Ngày phân tích: 2026-03-29*
