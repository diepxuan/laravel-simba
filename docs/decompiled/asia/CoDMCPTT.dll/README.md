# Báo cáo Phân tích DLL: CoDMCPTT.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| Chức năng | Danh mục chi phí tập trung |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | CoDMCPTT |
| Assembly Title | FADMCC |
| Assembly Product | FADMCC |
| Assembly Company | - |
| Assembly Copyright | Copyright © 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | b71f3569-e439-4607-b511-60dc5628362c |
| ComVisible | false |

---

## Cấu trúc File

```
CoDMCPTT.dll/
├── CoDMCPTT.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmCoDMCPTT.cs           # Main form class (danh mục view)
│   └── frmCoDMCPTTEdit.cs       # Edit form class
├── AsiaErp.DataAccess/
│   ├── CODMCPTTDAO.cs           # DAO Interface
│   └── MsSqlCODMCPTTDAO.cs      # SQL Server DAO implementation
└── My/
    ├── MyProject.cs             # VB.NET My project support
    ├── MyApplication.cs         # Application support
    ├── MyComputer.cs            # Computer support
    ├── MySettings.cs            # Settings support
    └── InternalXmlHelper.cs     # XML helper
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| System.Drawing | Graphics support |
| Microsoft.VisualBasic | VB.NET runtime support |
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.DataAccess | Asia ERP Data Access Layer |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCoDMCPTT` | `frmDMComplexView` | Form danh sách danh mục chi phí tập trung |
| `frmCoDMCPTTEdit` | `frmDMComplexEdit` | Form nhập liệu chi tiết chi phí tập trung |
| `CODMCPTTDAO` | `DAO` | Interface định nghĩa các phương thức CRUD |
| `MsSqlCODMCPTTDAO` | `CODMCPTTDAO` | Implementation SQL Server cho DAO |

---

## Các trường dữ liệu chính (frmCoDMCPTTEdit)

### Thông tin cơ bản
| Control | Field | Mô tả |
|---------|-------|-------|
| txtMa_cptt | ma_cptt | Mã chi phí tập trung |
| txtTen_cptt | ten_cptt | Tên chi phí tập trung |
| txtDvt | dvt | Đơn vị tính |
| txtSo_ct | so_ct | Số chứng từ |
| txtNgay_ct | ngay_ct | Ngày chứng từ |

### Thông tin số lượng và giá
| Control | Field | Mô tả |
|---------|-------|-------|
| txtSo_luong | so_luong | Số lượng |
| txtDon_gia | don_gia | Đơn giá |
| txtSo_ky_BP | so_ky | Số kỳ phân bổ |
| txtNguyen_gia | ng_gia | Nguyên giá |

### Thông tin phân bổ
| Control | Field | Mô tả |
|---------|-------|-------|
| txtGia_tri_da_pb | gt_da_kh | Giá trị đã phân bổ |
| txtGiatri_pn_con_lai | gt_cl | Giá trị phân bổ còn lại |
| txtGiatri_pb_1ky | kh_ky | Giá trị phân bổ 1 kỳ |
| txtNgay_bdau_bp | ngay_bdkh | Ngày bắt đầu phân bổ |
| txtNgay_gtcl | ngay_gt_cl | Ngày giá trị còn lại |
| Chk_Giatri_pb1ky | sua_kh | Cho phép sửa phân bổ |

### Tài khoản và mã phân bổ
| Control | Field | Mô tả |
|---------|-------|-------|
| txtTK_pb | tk_cptt | TK phân bổ |
| txtTK_chiphi | tk_cp | TK chi phí |
| txtMa_bpsd | ma_bpsd | Mã bộ phận sử dụng |
| txtMa_spct | ma_spct | Mã sản phẩm chi tiết |
| txtMa_phi | MA_PHI | Mã phí |

---

## Business Logic

### Tính toán tự động

1. **Nguyên giá**: `txtNguyen_gia = txtSo_luong * txtDon_gia`
2. **Giá trị còn lại**: `txtGiatri_pn_con_lai = txtNguyen_gia - txtGia_tri_da_pb`
3. **Giá trị phân bổ 1 kỳ**: `txtGiatri_pb_1ky = txtNguyen_gia / txtSo_ky_BP`

### Validation

- Mã chi phí (ma_cptt) không được rỗng
- Tên chi phí (ten_cptt) không được rỗng
- Số lượng > 0
- Số kỳ phân bổ > 0
- TK phân bổ không được rỗng
- TK chi phí không được rỗng
- Ngày chứng từ, ngày bắt đầu PB, ngày GTCL phải hợp lệ
- Ngày GTCL phải >= Ngày bắt đầu PB
- Nguyên giá > 0

### DAO Methods

| Method | Mô tả |
|--------|-------|
| `InsCPTT` | Thêm mới chi phí tập trung |
| `UpdCPTT` | Cập nhật chi phí tập trung |
| `DelCPTT` | Xóa chi phí tập trung |

---

## Mục đích sử dụng

**CoDMCPTT.dll là module quản lý Danh mục chi phí tập trung** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý danh mục chi phí tập trung
- Khai báo các loại chi phí tập trung (CPTT)
- Quản lý thông tin cơ bản: mã, tên, đơn vị tính, số chứng từ
- Theo dõi số lượng và đơn giá

#### 2. Phân bổ chi phí
- Xác định số kỳ phân bổ
- Tính toán giá trị phân bổ cho từng kỳ
- Theo dõi giá trị đã phân bổ và còn lại
- Hỗ trợ sửa đổi giá trị phân bổ 1 kỳ (nếu được phép)

#### 3. Tích hợp tài khoản kế toán
- TK phân bổ: Tài khoản ghi nhận phân bổ
- TK chi phí: Tài khoản chi phí tương ứng
- Mã bộ phận sử dụng, mã phí, mã SPCT để phân bổ chi tiết

#### 4. Quản lý thời gian
- Ngày chứng từ
- Ngày bắt đầu phân bổ
- Ngày tính giá trị còn lại

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc khai báo và quản lý danh mục chi phí tập trung - một phần quan trọng trong kế toán quản trị và phân bổ chi phí gián tiếp.

---

*Ngày phân tích: 2026-03-29*
