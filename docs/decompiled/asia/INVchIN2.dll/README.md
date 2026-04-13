# Báo cáo Phân tích DLL: INVchIN2.dll

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
| Assembly Name | INVchIN2 |
| Assembly Title | Phiếu xuất kho |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |

---

## Cấu trúc File

```
INVchIN2.dll/
├── INVchIN2.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmInVchIN2.cs         # Main form - Phiếu xuất kho
│   └── frmInVchIN2Find.cs     # Search form
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
| `frmInVchIN2` | `frmVoucher` | Form nhập liệu chính cho phiếu xuất kho |
| `frmInVchIN2Find` | `frmVoucherFind` | Form tìm kiếm phiếu xuất kho |
| `Resources` | - | Resource manager cho localization |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Số phiếu xuất" - Số chứng từ
- "Ngày phiếu xuất" - Ngày chứng từ
- "Mã khách hàng", "Người giao dịch", "Địa chỉ", "Diễn giải"
- "Ngày lập", "Tỷ giá", "Tiền xuất"
- "Loại phiếu xuất" - Phân loại phiếu xuất

### Cột DataGridView (Chi tiết phiếu xuất)

| Cột | Ý nghĩa |
|-----|---------|
| Mã hàng | Mã vật tư |
| Tên hàng | Tên vật tư |
| Đvt | Đơn vị tính |
| Kho | Mã kho xuất |
| Tồn | Số lượng tồn kho |
| Số lượng | Số lượng xuất |
| Giá | Giá xuất ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| Tk nợ | Tài khoản nợ |
| Tk có | Tài khoản có |
| Giá VND | Giá xuất VND |
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
| `tk_vt` | Tài khoản vật tư (có) |
| `ma_gd` | Mã giao dịch/loại phiếu |

### Tùy chọn đặc biệt

- "Phiếu xuất giá đích danh" - Xuất kho theo giá đích danh (FIFO, LIFO)

---

## Mục đích sử dụng

**INVchIN2.dll là module quản lý "Phiếu xuất kho"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu phiếu xuất kho
- Quản lý thông tin khách hàng (mã KH, tên, địa chỉ, người giao dịch)
- Quản lý kho xuất (mã kho, tồn kho)
- Xử lý đa tiền tệ (tỷ giá, giá ngoại tệ/VNĐ)
- Chi tiết xuất kho với các thông tin: vật tư, số lượng, giá, TK nợ/có, bộ phận, phí, hợp đồng, lô

#### 2. Tính toán tự động
- Tính thành tiền theo số lượng x giá
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính tổng tiền xuất
- Tính tổng số lượng

#### 3. Xuất kho giá đích danh
- Hỗ trợ xuất kho theo giá đích danh
- Theo dõi lô hàng xuất (FIFO, LIFO)

#### 4. Tìm kiếm
- Tìm kiếm phiếu xuất theo nhiều tiêu chí: KH, kho, vật tư, TK, hợp đồng, SPCT, phí, bộ phận, lô

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, mã kho, mã vật tư)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với module kế toán (TK nợ/có)
- Kiểm tra tồn kho trước khi xuất
- Hỗ trợ xuất giá đích danh

### Mã chứng từ

**IN2** (Phiếu xuất kho) - chứng từ xuất hàng hóa/vật tư khỏi kho trong kế toán doanh nghiệp.

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý phiếu xuất kho - chứng từ quan trọng trong quản lý kho và kế toán hàng tồn kho.

---

*Ngày phân tích: 2026-03-29*
