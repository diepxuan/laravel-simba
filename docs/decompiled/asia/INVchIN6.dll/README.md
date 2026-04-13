# Báo cáo Phân tích DLL: INVchIN6.dll

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
| Assembly Name | INVchIN6 |
| Assembly Title | Phiếu lắp ráp/tháo dỡ |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |

---

## Cấu trúc File

```
INVchIN6.dll/
├── INVchIN6.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.Business/
│   └── INVchIN6Controller.cs  # Business logic controller
├── AsiaErp.DataAccess/
│   ├── INVchIN6DAO.cs         # DAO interface
│   └── MsSqlINVchIN6DAO.cs    # SQL Server DAO implementation
├── AsiaErp.UserInterface/
│   ├── frmInVchIN6.cs         # Main form - Phiếu lắp ráp/tháo dỡ
│   └── frmInVchIN6Find.cs     # Search form
└── My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Core | LINQ và core extensions |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| CrystalDecisions.CrystalReports.Engine | Crystal Reports cho in ấn |

### Namespaces sử dụng

- `AsiaErp.Business`, `AsiaErp.DataAccess`, `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`, `System.Linq`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmInVchIN6` | `frmVoucher` | Form nhập liệu chính cho phiếu lắp ráp/tháo dỡ |
| `frmInVchIN6Find` | `frmVoucherFind` | Form tìm kiếm phiếu lắp ráp/tháo dỡ |
| `INVchIN6Controller` | `VoucherController` | Business logic controller |
| `INVchIN6DAO` | - | DAO interface |
| `MsSqlINVchIN6DAO` | - | SQL Server DAO implementation |
| `Resources` | - | Resource manager cho localization |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã khách hàng", "Người giao dịch", "Địa chỉ", "Diễn giải"
- "Ngày lập", "Tỷ giá", "Tiền xuất"
- "Mã giao dịch" - Phân loại lắp ráp/tháo dỡ

### Cột DataGridView Master (Thành phẩm/Bộ)

| Cột | Ý nghĩa |
|-----|---------|
| Mã bộ | Mã vật tư thành phẩm/bộ |
| Tên bộ | Tên vật tư thành phẩm |
| Đvt | Đơn vị tính |
| Kho | Mã kho nhập/xuất |
| Số lượng | Số lượng thành phẩm |
| Giá | Giá ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| TK kho | Tài khoản kho |
| Mã NX | Mã nhập xuất |
| Giá VND | Giá VND |
| Tiền VND | Thành tiền VND |
| H. đồng | Hợp đồng |
| SPCT | Sản phẩm chi tiết |
| Phí | Mã phí |
| B. phận | Bộ phận |

### Cột DataGridView Detail (Chi tiết/Thành phần)

| Cột | Ý nghĩa |
|-----|---------|
| Mã chi tiết | Mã vật tư chi tiết |
| Tên chi tiết | Tên vật tư chi tiết |
| Đvt | Đơn vị tính |
| Kho | Mã kho |
| Số lượng | Số lượng chi tiết |
| Giá | Giá ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| TK kho | Tài khoản kho |
| Mã NX | Mã nhập xuất |
| Giá VND | Giá VND |
| Tiền VND | Thành tiền VND |
| H. đồng | Hợp đồng |
| SPCT | Sản phẩm chi tiết |
| Phí | Mã phí |
| B. phận | Bộ phận |
| Mã bộ | Liên kết mã bộ |

### Thuật ngữ kế toán sản xuất

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ma_vt` | Mã vật tư |
| `ma_kho` | Mã kho |
| `so_luong` | Số lượng |
| `gia_nt` | Giá ngoại tệ |
| `tien_nt` | Tiền ngoại tệ |
| `gia` | Giá VND |
| `tien` | Tiền VND |
| `tk_vt` | Tài khoản kho |
| `ma_nx` | Mã nhập xuất |
| `ma_gd` | Mã giao dịch (1=Lắp ráp, 2=Tháo dỡ) |

### Loại giao dịch

| Mã | Ý nghĩa |
|-----|---------|
| 1 | Lắp ráp (Assembly) - Xuất chi tiết, nhập thành phẩm |
| 2 | Tháo dỡ (Disassembly) - Xuất thành phẩm, nhập chi tiết |

### Tùy chọn đặc biệt

- "Tính giá trung bình" - Tính giá vốn theo phương pháp giá trung bình
- "Chỉ xem chi tiết từng bộ" - Lọc hiển thị chi tiết theo bộ

---

## Mục đích sử dụng

**INVchIN6.dll là module quản lý "Phiếu lắp ráp/tháo dỡ"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu phiếu lắp ráp/tháo dỡ
- Quản lý thông tin khách hàng (mã KH, tên, địa chỉ, người giao dịch)
- Quản lý kho thành phẩm và kho chi tiết
- Xử lý đa tiền tệ (tỷ giá, giá ngoại tệ/VNĐ)
- Hai loại giao dịch: Lắp ráp và Tháo dỡ

#### 2. Lắp ráp (Assembly)
- Xuất các chi tiết/thành phần từ kho
- Nhập thành phẩm/bộ vào kho
- Tính giá thành phẩm dựa trên tổng giá chi tiết

#### 3. Tháo dỡ (Disassembly)
- Xuất thành phẩm/bộ từ kho
- Nhập các chi tiết/thành phần vào kho
- Phân bổ giá thành phẩm cho các chi tiết

#### 4. Quản lý BOM (Bill of Materials)
- Tích hợp với định mức BOM
- Tự động lấy chi tiết từ BOM khi lắp ráp
- Tính toán số lượng chi tiết theo số lượng thành phẩm

#### 5. Tính toán tự động
- Tính thành tiền theo số lượng x giá
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính tổng tiền
- Tính tổng số lượng
- Tính giá trung bình

#### 6. Tìm kiếm
- Tìm kiếm phiếu lắp ráp/tháo dỡ theo nhiều tiêu chí: KH, kho, vật tư, TK, hợp đồng, SPCT

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable, CTDTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, mã kho, mã vật tư)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với module kế toán (TK kho)
- Kiểm tra tồn kho trước khi xuất
- Tích hợp Crystal Reports cho in ấn
- Controller pattern với INVchIN6Controller xử lý business logic
- DAO pattern với MsSqlINVchIN6DAO cho data access

### Business Logic (INVchIN6Controller)

| Method | Mục đích |
|--------|---------|
| `Insert` | Thêm mới phiếu lắp ráp/tháo dỡ (PH + CT + CTD) |
| `Update` | Cập nhật phiếu lắp ráp/tháo dỡ |
| `GetBoMByMa_vt` | Lấy BOM theo mã vật tư |
| `GetPrintDataSource` | Lấy dữ liệu in ấn |
| `SearchBOM` | Tìm kiếm BOM |
| `GetDataCTD` | Đọc dữ liệu chi tiết (CTD) |
| `InsertCTD` | Thêm chi tiết CTD |
| `DeleteCTD` | Xóa chi tiết CTD |

### Mã chứng từ

**IN6** (Phiếu lắp ráp/tháo dỡ) - chứng từ chuyển đổi giữa chi tiết và thành phẩm trong sản xuất/assembly.

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý phiếu lắp ráp/tháo dỡ - chứng từ quan trọng trong quản lý sản xuất, assembly và chuyển đổi giữa chi tiết/thành phẩm. Module này có kiến trúc phân tầng rõ ràng với Controller và DAO.

---

*Ngày phân tích: 2026-03-29*
