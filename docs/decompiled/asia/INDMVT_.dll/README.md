# Báo cáo Phân tích DLL: INDMVT_.dll

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
| Assembly Name | INDMVT |
| Assembly Title | Danh mục bộ phận |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
INDMVT_.dll/
├── INDMVT_.csproj               # Project file
├── app.ico                      # Application icon
├── INDMVT_/                     # Resource folder
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmINDMVT.cs             # Main form class (danh sách)
    └── frmINDMVTEdit.cs         # Edit form (thêm/sửa)
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
- `System`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINDMVT` | `frmDMView` | Form xem danh sách vật tư |
| `frmINDMVTEdit` | `frmDMEdit` | Form thêm/sửa vật tư |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Danh mục bộ phận" - Tên chức năng chính
- "Mã vật tư", "Tên" - Thông tin cơ bản
- "Đvt" - Đơn vị tính (Cái, Chiếc, Con, Cặp, Bộ, Đôi)
- "Nhóm" - Nhóm vật tư
- "Loại" - Loại vật tư
- "Giá tồn" - Phương pháp tính giá tồn kho
- "Theo dõi tồn kho" - Checkbox quản lý tồn

### Đơn vị tính mặc định
- Cái, Chiếc, Con, Cặp, Bộ, Đôi

### Tài khoản kế toán

| Tài khoản | Ý nghĩa |
|-----------|---------|
| TK kho | Tài khoản vật tư (Tk_Vt) |
| TK doanh thu | Tài khoản doanh thu (Tk_Dt) |
| TK DT nội bộ | Tài khoản doanh thu nội bộ (Tk_DtNb) |
| TK giá vốn | Tài khoản giá vốn (Tk_Gv) |
| TK trả lại | Tài khoản trả lại (Tk_Tl) |
| TK chiết khấu | Tài khoản chiết khấu (Tk_Ck) |

### Thuế và giá

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ts_gtgt` | Thuế suất GTGT |
| `ts_ttdb` | Thuế suất TTĐB |
| `ts_nk` | Thuế suất nhập khẩu |
| `ts_xk` | Thuế suất xuất khẩu |
| `gia_nt0` | Giá mua |
| `gia_nt2` | Giá bán |
| `sl_min` | Tồn tối thiểu |
| `sl_max` | Tồn tối đa |

### BOM (Bill of Materials)

- "BOM" - Tab quản lý linh kiện/lắp ráp
- "Mã chi tiết" - Mã linh kiện
- "Tên chi tiết" - Tên linh kiện
- "Số lượng" - Số lượng trong BOM
- "Hệ số" - Hệ số quy đổi

---

## Mục đích sử dụng

**INDMVT_.dll là module quản lý danh mục vật tư (phiên bản khác)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý thông tin vật tư
- Mã vật tư, tên vật tư, đơn vị tính
- Nhóm vật tư, loại vật tư
- Theo dõi tồn kho (có/không)
- Mã kho mặc định

#### 2. Quản lý tài khoản kế toán
- Tài khoản vật tư (Tk_Vt)
- Tài khoản doanh thu (Tk_Dt)
- Tài khoản giá vốn (Tk_Gv)
- Tài khoản chiết khấu, trả lại

#### 3. Quản lý thuế
- Thuế suất GTGT
- Thuế suất TTĐB
- Thuế suất nhập/xuất khẩu
- Mã thuế GTGT

#### 4. Quản lý giá và tồn kho
- Giá mua, giá bán mặc định
- Tồn tối thiểu, tồn tối đa
- Phương pháp tính giá tồn
- Đơn vị tính mua/bán và hệ số quy đổi

#### 5. Quản lý BOM (Bill of Materials)
- Định nghĩa cấu trúc lắp ráp
- Quản lý linh kiện thành phần
- Số lượng và hệ số linh kiện

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` và `frmDMEdit`
- DataBinding với DataTable
- AutoLookup cho các trường mã (AsTextBox)
- Validation dữ liệu đầu vào
- Hỗ trợ transaction cho BOM

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục vật tư đầy đủ với hỗ trợ BOM - một module quan trọng trong Inventory (IN).

---

*Ngày phân tích: 2026-03-29*
