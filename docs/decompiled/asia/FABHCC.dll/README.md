# Báo cáo Phân tích DLL: FABHCC.dll

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
| Assembly Name | FABHCC |
| Assembly Title | Báo hỏng công cụ dụng cụ |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | a3709b08-9615-4898-b843-ccd484c122ee |
| ComVisible | false |

---

## Cấu trúc File

```
FABHCC.dll/
├── FABHCC.csproj              # Project file
├── app.ico                    # Application icon
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmFABHCC.cs           # Main form class (danh mục view)
│   └── frmFABHCCEdit.cs       # Edit form class
├── AsiaErp.DataAccess/
│   ├── IFABHCCDAO.cs          # DAO Interface
│   └── MsSqlFABHCCDAO.cs      # SQL Server DAO implementation
└── My/
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    ├── MyApplication.cs
    └── MyComputer.cs
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
| `frmFABHCC` | `frmDMView` | Form xem danh mục báo hỏng công cụ |
| `frmFABHCCEdit` | `frmDMEdit` | Form nhập liệu báo hỏng công cụ |
| `IFABHCCDAO` | - | Interface cho DAO |
| `MsSqlFABHCCDAO` | - | SQL Server DAO implementation |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo hỏng công cụ dụng cụ" - Tên chức năng chính
- "Mã công cụ", "Tên công cụ", "Đơn vị tính"
- "Số lượng hỏng", "Tiền hỏng", "Đơn giá hỏng"
- "Ngày báo hỏng", "Số phiếu xuất", "Ngày xuất"
- "Mã bpsd" (bộ phận sử dụng)
- "TK chi phí", "TK phân bổ"
- "Giá gốc", "Còn lại"

### Thuật ngữ kế toán

| Thuật tính | Ý nghĩa |
|------------|---------|
| `ma_cc` | Mã công cụ |
| `ten_cc` | Tên công cụ |
| `sl_hong` | Số lượng hỏng |
| `tien_hong` | Tiền hỏng |
| `don_gia_hong` | Đơn giá hỏng |
| `ngay_bh` | Ngày báo hỏng |
| `ngay_xuat` | Ngày xuất |
| `so_px` | Số phiếu xuất |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `tk_cp` | Tài khoản chi phí |
| `tk_cc` | Tài khoản công cụ |
| `stt_rec` | Số thứ tự record |
| `stt_rec_cc` | Số thứ tự record công cụ |

---

## Mục đích sử dụng

**FABHCC.dll là module quản lý "Báo hỏng công cụ dụng cụ"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu báo hỏng công cụ
- Quản lý thông tin công cụ (mã CC, tên CC, đơn vị tính)
- Nhập số lượng hỏng, đơn giá hỏng, tiền hỏng
- Quản lý ngày báo hỏng, số phiếu xuất, ngày xuất
- Thông tin bộ phận sử dụng (ma_bpsd)
- Tài khoản chi phí và tài khoản phân bổ

#### 2. Kiểm tra validation
- Kiểm tra số lượng hỏng không vượt quá số lượng còn lại
- Validate mã công cụ tồn tại
- Kiểm tra tài khoản chi phí

#### 3. Tính toán tự động
- Tính tiền hỏng = số lượng hỏng × đơn giá hỏng
- Lấy thông tin giá gốc, đơn vị tính từ danh mục công cụ

#### 4. Tra cứu công cụ
- Hỗ trợ phím F5 tra cứu mã công cụ dụng cụ
- Auto-lookup mã công cụ với điều kiện tg=1 (đang sử dụng)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra validation dữ liệu đầu vào (mã CC, số lượng)
- Tích hợp với module xuất kho để lấy thông tin phiếu xuất
- Lookup mã công cụ với điều kiện tg=1

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý báo hỏng công cụ dụng cụ - một chức năng quan trọng trong quản lý tài sản cố định và công cụ dụng cụ của doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
