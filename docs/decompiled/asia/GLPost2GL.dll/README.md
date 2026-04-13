# Báo cáo Phân tích DLL: GLPost2GL.dll

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
| Assembly Name | GLPost2GL |
| Assembly Title | Chuyển số liệu vào sổ cái |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 1165f1d1-a507-4a9a-86f3-5d0ebc57f341 |
| ComVisible | false |

---

## Cấu trúc File

```
GLPost2GL.dll/
├── GLPost2GL.csproj              # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
├── AsiaERP.DataAccess/
│   ├── IGLPost2GLDAO.cs        # DAO Interface
│   └── MssqlGLPost2GLDAO.cs    # SQL Server DAO implementation
├── AsiaERP.UserInterface/
│   ├── frmGLPost2GL.cs         # Main form class
│   ├── frmGLPost2GLFilter.cs   # Filter form
│   └── VoucherInfoDatasource.cs  # Voucher info data source
├── My/
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MyApplication.cs
│   ├── MySettingsProperty.cs
│   └── MyComputer.cs
└── My.Resources/
    └── Resources.cs              # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Core | LINQ support |
| System.Data.DataSetExtensions | DataSet extensions |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaERP.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `System.Collections.Generic`, `System.Linq`, `System.Threading`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLPost2GL` | `frmAsiaRoot` | Form chuyển số liệu vào sổ cái |
| `frmGLPost2GLFilter` | `frmDMFilter` | Form lọc chứng từ |
| `VoucherInfoDatasource` | - | Data source cho voucher info |
| `IGLPost2GLDAO` | `DAO` | Interface cho data access |
| `MssqlGLPost2GLDAO` | `MsSqlDAO` | SQL Server implementation |

---

## UI Controls (frmGLPost2GL)

### Input Controls
| Control | Loại | Mục đích |
|---------|------|----------|
| cboCT | AsComboBox | Chọn loại chứng từ |
| chkSelectAll | AsCheckBox | Chọn/bỏ chọn tất cả |
| prbExecute | ProgressBar | Hiển thị tiến độ xử lý |
| bgWork | BackgroundWorker | Xử lý async |

### DataGridView Columns (dgvCT)
| Cột | Ý nghĩa |
|-----|---------|
| colChuyen | Chọn để chuyển vào sổ cái |
| colMa_ct | Mã chứng từ |
| colSo_ct | Số chứng từ |
| colNgay_ct | Ngày chứng từ |
| colMa_kh | Mã khách hàng |
| colTen_kh | Tên khách hàng |
| colMa_nt | Mã ngoại tệ |
| colSum_money | Tổng tiền (VNĐ) |
| colSum_money_nt | Tổng tiền ngoại tệ |

### Buttons
| Button | Text | Chức năng |
|--------|------|-------------|
| cmdOK | Thực hiện | Chuyển chứng từ vào sổ cái |
| cmdCancel | Quay ra | Đóng form |

---

## UI Controls (frmGLPost2GLFilter)

### Filter Controls
| Control | Loại | Mục đích |
|---------|------|----------|
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Từ ngày |
| txtNgay2 | AsMaskedTextBox | Đến ngày |
| txtSo_ct1 | TextBox | Từ số chứng từ |
| txtSo_ct2 | TextBox | Đến số chứng từ |
| cboMa_ct | AsComboBox | Mã chứng từ |
| cboStatus | AsComboBox | Trạng thái (chưa/đã chuyển) |

---

## Business Logic

### IGLPost2GLDAO Interface

| Method | Parameters | Return | Mô tả |
|--------|-----------|--------|---------|
| GetSiCt4PostGl | pMa_cty, pMa_ph, pMa_ct, pLang | List<VoucherInfoDatasource> | Lấy danh sách chứng từ |
| GetVoucher2Post | pMa_cty, pNgay1, pNgay2, pSo_ct1, pSo_ct2, pMa_Ct, pPost2Gl | DataSet | Lấy chứng từ cần post |
| Post2GL | pMa_cty, pStt_rec, pMa_ct, pPost | int | Chuyển vào sổ cái |

### Stored Procedures

| Tên | Mục đích |
|-----|----------|
| asSiGetCt4PostGL | Lấy danh sách chứng từ có thể post |
| asGetVoucher2Post | Lấy chi tiết chứng từ cần post |
| asPost2Gl | Thực hiện post/unpost vào sổ cái |

---

## Mục đích sử dụng

**GLPost2GL.dll là module "Chuyển số liệu vào sổ cái"** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Lọc chứng từ
- Chọn kỳ báo cáo (tự động cập nhật ngày)
- Lọc theo số chứng từ (từ - đến)
- Lọc theo mã chứng từ
- Lọc theo trạng thái: Chưa chuyển / Đã chuyển vào sổ cái

#### 2. Chuyển số liệu vào sổ cái
- Hiển thị danh sách chứng từ theo điều kiện lọc
- Chọn một hoặc nhiều chứng từ để chuyển
- Xử lý async với progress bar
- Hỗ trợ chuyển (post) và hủy chuyển (unpost)

#### 3. Thông tin chứng từ hiển thị
- Mã chứng từ, số chứng từ, ngày chứng từ
- Thông tin khách hàng (mã, tên)
- Mã ngoại tệ
- Tổng tiền VNĐ và ngoại tệ

### Đặc điểm kỹ thuật

- Sử dụng BackgroundWorker để xử lý async
- ThreadPool để xử lý đa luồng
- Progress bar hiển thị tiến độ
- DataBinding với DataTable
- Lưu trữ kỳ báo cáo vào PublicVariables
- Kiểm tra khóa sổ (ngay_ks) trước khi thực hiện

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| Post2GL | Chuyển vào sổ cái (General Ledger) |
| ma_ct | Mã chứng từ |
| so_ct | Số chứng từ |
| ngay_ct | Ngày chứng từ |
| stt_rec | Số thứ tự record |
| ma_kh | Mã khách hàng |
| ma_nt | Mã ngoại tệ |
| t_tien | Tổng tiền |
| post2gl | Trạng thái đã chuyển sổ cái |

### Trạng thái chuyển sổ

| Giá trị | Ý nghĩa |
|---------|---------|
| 0 | Chưa chuyển vào sổ cái |
| 1 | Đã chuyển vào sổ cái |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP AsiaERP, phục vụ cho việc chuyển số liệu chứng từ vào sổ cái - một chức năng quan trọng trong kế toán để tổng hợp dữ liệu từ các module nghiệp vụ vào sổ cái tổng hợp.

---

*Ngày phân tích: 2026-03-29*
