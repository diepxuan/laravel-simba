# Báo cáo Phân tích DLL: INVchIN1.dll

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
| Assembly Name | INVchIN1 |
| Assembly Title | Phiếu nhập kho |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |

---

## Cấu trúc File

```
INVchIN1.dll/
├── INVchIN1.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmInVchIN1.cs         # Main form - Phiếu nhập kho
│   └── frmInVchIN1Find.cs     # Search form
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
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
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmInVchIN1` | `frmVoucher` | Form nhập liệu chính cho phiếu nhập kho |
| `frmInVchIN1Find` | `frmVoucherFind` | Form tìm kiếm phiếu nhập kho |
| `Resources` | - | Resource manager cho localization |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Số phiếu nhập" - Số chứng từ
- "Ngày phiếu nhập" - Ngày chứng từ
- "Mã khách hàng", "Người giao dịch", "Địa chỉ", "Diễn giải"
- "Ngày lập", "Tỷ giá", "Tiền nhập"
- "Loại phiếu nhập" - Phân loại phiếu nhập

### Cột DataGridView (Chi tiết phiếu nhập)

| Cột | Ý nghĩa |
|-----|---------|
| Mã hàng | Mã vật tư |
| Tên hàng | Tên vật tư |
| Đvt | Đơn vị tính |
| Kho | Mã kho nhập |
| Tồn | Số lượng tồn kho |
| Số lượng | Số lượng nhập |
| Giá | Giá nhập ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| Tk nợ | Tài khoản nợ |
| Tk có | Tài khoản có |
| Giá VND | Giá nhập VND |
| Tiền VND | Thành tiền VND |
| SPCT | Sản phẩm chi tiết |
| Hợp đồng | Mã hợp đồng |
| Phí | Mã phí |
| Bộ phận | Mã bộ phận |
| Lô | Mã lô |

### Thuật ngữ kế toán kho

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
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `ma_gd` | Mã giao dịch/loại phiếu |

### Loại phiếu nhập

| Mã | Ý nghĩa |
|-----|---------|
| 1 | Phiếu nhập thành phẩm |
| 2 | Phiếu nhập khác |

### Tùy chọn đặc biệt

- "Phiếu nhập giá trung bình" - Tính giá xuất kho theo phương pháp giá trung bình
- "Tự động cập nhật giá" - Tự động cập nhật giá vốn

---

## Mục đích sử dụng

**INVchIN1.dll là module quản lý "Phiếu nhập kho"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu phiếu nhập kho
- Quản lý thông tin khách hàng (mã KH, tên, địa chỉ, người giao dịch)
- Quản lý kho nhập (mã kho, tồn kho)
- Xử lý đa tiền tệ (tỷ giá, giá ngoại tệ/VNĐ)
- Chi tiết nhập kho với các thông tin: vật tư, số lượng, giá, TK nợ/có, bộ phận, phí, hợp đồng, lô

#### 2. Tính toán tự động
- Tính thành tiền theo số lượng x giá
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính tổng tiền nhập
- Tính tổng số lượng

#### 3. Phân loại phiếu nhập
- Phiếu nhập thành phẩm (sản xuất)
- Phiếu nhập khác (mua hàng, nhập điều chỉnh...)

#### 4. Tìm kiếm
- Tìm kiếm phiếu nhập theo nhiều tiêu chí: KH, kho, vật tư, TK, hợp đồng, SPCT, phí, bộ phận

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, mã kho, mã vật tư)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với module kế toán (TK nợ/có)

### Mã chứng từ

**IN1** (Phiếu nhập kho) - chứng từ nhập hàng hóa/vật tư vào kho trong kế toán doanh nghiệp.

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý phiếu nhập kho - chứng từ quan trọng trong quản lý kho và kế toán hàng tồn kho.

---

*Ngày phân tích: 2026-03-29*
