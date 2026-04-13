# Báo cáo Phân tích DLL: GLRptBCT03.dll

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
| Assembly Name | GLRptBCT03 |
| Assembly Title | Tờ khai giá trị gia tăng |
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
GLRptBCT03.dll/
├── GLRptBCT03.csproj              # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── GLRptBCT03DAO.cs         # Data Access Object interface
│   └── MsSqlGLRptBCT03DAO.cs    # SQL Server implementation
└── AsiaErp.UserInterface/
    └── frmGLRptBCT03.cs           # Main report form
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
| AsiaErp.DataAccess | Data Access Layer |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCT03` | `frmReport` | Form tờ khai thuế GTGT |
| `GLRptBCT03DAO` | - | Interface DAO cho tờ khai GTGT |
| `MsSqlGLRptBCT03DAO` | - | SQL Server implementation |

---

## Controls và UI Components

### Input Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Từ ngày, đến ngày |
| `cboKyBc` | ComboBox | Kỳ báo cáo |
| `cboMau_bc` | ComboBox | Mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Lựa chọn tiền tệ |
| `txtTieu_De` | TextBox | Tiêu đề báo cáo |

### DataGridView

| Control | Mục đích |
|---------|----------|
| `dgvBC` | Grid hiển thị dữ liệu tờ khai GTGT |

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

- "Tờ khai giá trị gia tăng" - Tên chức năng chính
- "ma_so2" - Mã số chỉ tiêu trên tờ khai
- "thue" - Cột thuế GTGT
- "doanh_so" - Cột doanh số
- "cong_thuc" - Công thức tính toán

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_so2` | Mã số chỉ tiêu trên tờ khai GTGT |
| `thue` | Thuế GTGT |
| `doanh_so` | Doanh số bán hàng/dịch vụ |
| `cong_thuc` | Công thức tính toán chỉ tiêu |
| `stt_rec` | Số thứ tự bản ghi |
| `usertype` | Loại người dùng (cho phép sửa hay không) |

### Cột DataGridView

| Cột | Ý nghĩa |
|-----|----------|
| `ma_so2` | Mã số chỉ tiêu |
| `thue` | Số thuế GTGT |
| `doanh_so` | Doanh số |
| `cong_thuc` | Công thức tính |

---

## Mục đích sử dụng

**GLRptBCT03.dll là module "Tờ khai giá trị gia tăng"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Hiển thị tờ khai GTGT
- Hiển thị các chỉ tiêu trên tờ khai GTGT theo mẫu chuẩn
- Hỗ trợ chỉnh sửa số liệu trực tiếp trên grid (nếu có quyền)
- Tính toán tự động theo công thức định nghĩa

#### 2. Điều chỉnh số liệu
- Cho phép điều chỉnh số thuế GTGT theo từng chỉ tiêu
- Cập nhật xuống database qua `DieuChinhBCT03` method
- Tự động tính toán lại các chỉ tiêu liên quan

#### 3. Tính toán công thức
- Hỗ trợ công thức tính toán giữa các chỉ tiêu
- Ví dụ: [01] + [02] - [03] = Tổng
- Tự động cập nhật khi có thay đổi

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form báo cáo của Asia ERP
- Sử dụng DataGridView với EditMode
- CellEnter/CellEndEdit events để xử lý nhập liệu
- DAO pattern để truy cập database
- WeakReference pattern để quản lý memory

### Events

| Event | Mục đích |
|-------|----------|
| `dgvBC_CellEnter` | Xử lý khi focus vào cell |
| `dgvBC_CellEndEdit` | Xử lý sau khi sửa cell, tính toán công thức |

### Tham số truy vấn

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtNgay1.Value);                 // Từ ngày
params.Add(txtNgay2.Value);                 // Đến ngày
```

### Điều chỉnh dữ liệu

```csharp
ArrayList adjustParams = new ArrayList();
adjustParams.Add(CompanyInformations.CompanyID);
adjustParams.Add(Month(txtNgay1.Value));    // Tháng
adjustParams.Add(Month(txtNgay2.Value));    // Tháng
adjustParams.Add(SystemInformations.FinancialYear); // Năm tài chính
adjustParams.Add(stt_rec);                    // Số thứ tự bản ghi
adjustParams.Add(doanh_so);                   // Doanh số
adjustParams.Add(thue);                       // Thuế GTGT
```

---

## Kết luận

Đây là module tờ khai thuế GTGT trong hệ thống ERP Asia Enterprise, phục vụ cho việc lập và điều chỉnh tờ khai thuế GTGT theo quy định của Tổng cục Thuế Việt Nam. Module hỗ trợ nhập liệu trực tiếp và tính toán tự động theo công thức.

---

*Ngày phân tích: 2026-03-29*
