# Báo cáo Phân tích DLL: INVchIN3.dll

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
| Assembly Name | INVchIN3 |
| Assembly Title | Phiếu chuyển kho |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |

---

## Cấu trúc File

```
INVchIN3.dll/
├── INVchIN3.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmInVchIN3.cs         # Main form - Phiếu chuyển kho
│   └── frmInVchIN3Find.cs     # Search form
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
| `frmInVchIN3` | `frmVoucher` | Form nhập liệu chính cho phiếu chuyển kho |
| `frmInVchIN3Find` | `frmVoucherFind` | Form tìm kiếm phiếu chuyển kho |
| `Resources` | - | Resource manager cho localization |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Số phiếu xuất" - Số chứng từ xuất
- "Ngày phiếu xuất" - Ngày chứng từ
- "Số phiếu nhập" - Số chứng từ nhập (liên kết)
- "Mã khách hàng", "Người giao dịch", "Địa chỉ", "Diễn giải"
- "Ngày lập", "Tỷ giá", "Tiền xuất"

### Cột DataGridView (Chi tiết phiếu chuyển kho)

| Cột | Ý nghĩa |
|-----|---------|
| Mã hàng | Mã vật tư |
| Tên hàng | Tên vật tư |
| Đvt | Đơn vị tính |
| Kho xuất | Mã kho xuất hàng |
| Kho nhập | Mã kho nhập hàng |
| Số lượng | Số lượng chuyển |
| Giá | Giá ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| Tk nợ | Tài khoản nợ |
| Tk có | Tài khoản có |
| Giá VND | Giá VND |
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
| `ma_khox` | Mã kho xuất |
| `ma_khon` | Mã kho nhập |
| `so_luong` | Số lượng |
| `gia_nt` | Giá ngoại tệ |
| `tien_nt` | Tiền ngoại tệ |
| `gia` | Giá VND |
| `tien` | Tiền VND |
| `tk_no` | Tài khoản nợ |
| `tk_vt` | Tài khoản vật tư (có) |
| `so_pn` | Số phiếu nhập (liên kết) |

### Tùy chọn đặc biệt

- "Phiếu xuất giá đích danh" - Chuyển kho theo giá đích danh

---

## Mục đích sử dụng

**INVchIN3.dll là module quản lý "Phiếu chuyển kho"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu phiếu chuyển kho
- Quản lý thông tin khách hàng (mã KH, tên, địa chỉ, người giao dịch)
- Quản lý kho xuất và kho nhập (chuyển nội bộ giữa các kho)
- Xử lý đa tiền tệ (tỷ giá, giá ngoại tệ/VNĐ)
- Chi tiết chuyển kho với các thông tin: vật tư, số lượng, giá, TK nợ/có, bộ phận, phí, hợp đồng, lô
- Liên kết số phiếu nhập tương ứng

#### 2. Tính toán tự động
- Tính thành tiền theo số lượng x giá
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính tổng tiền chuyển
- Tính tổng số lượng

#### 3. Đặc điểm chuyển kho
- Một phiếu xuất kho tạo ra một phiếu nhập kho tương ứng
- Giá trị hàng chuyển kho không thay đổi (giá vốn)
- Kiểm tra tồn kho ở kho xuất trước khi chuyển

#### 4. Tìm kiếm
- Tìm kiếm phiếu chuyển kho theo nhiều tiêu chí: KH, kho xuất, kho nhập, vật tư, hợp đồng, SPCT, phí, bộ phận, lô

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, kho xuất, kho nhập, mã vật tư)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với module kế toán (TK nợ/có)
- Kiểm tra tồn kho trước khi chuyển
- Tự động tạo phiếu nhập liên kết

### Mã chứng từ

**IN3** (Phiếu chuyển kho) - chứng từ chuyển hàng hóa/vật tư giữa các kho trong cùng đơn vị.

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý phiếu chuyển kho - chứng từ quan trọng trong quản lý kho nội bộ và điều phối hàng tồn kho giữa các kho.

---

*Ngày phân tích: 2026-03-29*
