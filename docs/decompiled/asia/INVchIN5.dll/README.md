# Báo cáo Phân tích DLL: INVchIN5.dll

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
| Assembly Name | INVchIN5 |
| Assembly Title | Phiếu xuất công cụ dụng cụ |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |

---

## Cấu trúc File

```
INVchIN5.dll/
├── INVchIN5.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmInVchIN5.cs         # Main form - Phiếu xuất CCDC
│   └── frmInVchIN5Find.cs     # Search form
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
| `frmInVchIN5` | `frmVoucher` | Form nhập liệu chính cho phiếu xuất CCDC |
| `frmInVchIN5Find` | `frmVoucherFind` | Form tìm kiếm phiếu xuất CCDC |
| `Resources` | - | Resource manager cho localization |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Số phiếu xuất" - Số chứng từ
- "Ngày phiếu xuất" - Ngày chứng từ
- "Mã khách hàng", "Người giao dịch", "Địa chỉ", "Diễn giải"
- "Ngày lập", "Tỷ giá", "Tiền xuất"

### Cột DataGridView (Chi tiết phiếu xuất CCDC)

| Cột | Ý nghĩa |
|-----|---------|
| Mã cc | Mã công cụ dụng cụ |
| Tên công cụ | Tên CCDC |
| Đvt | Đơn vị tính |
| Kho | Mã kho xuất |
| Tồn | Số lượng tồn kho |
| Số lượng | Số lượng xuất |
| Giá | Giá ngoại tệ |
| Thành tiền | Thành tiền ngoại tệ |
| Số kỳ PB | Số kỳ phân bổ |
| Tk pb | Tài khoản phân bổ |
| Tk cp | Tài khoản chi phí |
| Tk Cc | Tài khoản công cụ |
| Giá VND | Giá VND |
| Tiền VND | Thành tiền VND |
| Bpsd | Bộ phận sử dụng |
| SPCT | Sản phẩm chi tiết |
| Phí | Mã phí |
| Bộ phận | Mã bộ phận |
| Lô | Mã lô |

### Thuật ngữ kế toán CCDC

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ma_vt` | Mã công cụ dụng cụ |
| `ma_kho` | Mã kho |
| `so_luong` | Số lượng |
| `so_ky` | Số kỳ phân bổ |
| `gia_nt` | Giá ngoại tệ |
| `tien_nt` | Tiền ngoại tệ |
| `gia` | Giá VND |
| `tien` | Tiền VND |
| `tk_no` | Tài khoản phân bổ (nợ) |
| `tk_cp` | Tài khoản chi phí |
| `tk_vt` | Tài khoản công cụ (có) |
| `ma_bpsd` | Mã bộ phận sử dụng |

### Tùy chọn đặc biệt

- "Phiếu xuất giá đích danh" - Xuất CCDC theo giá đích danh

---

## Mục đích sử dụng

**INVchIN5.dll là module quản lý "Phiếu xuất công cụ dụng cụ (CCDC)"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu phiếu xuất CCDC
- Quản lý thông tin khách hàng/bộ phận nhận (mã KH, tên, địa chỉ, người giao dịch)
- Quản lý kho xuất CCDC
- Xử lý đa tiền tệ (tỷ giá, giá ngoại tệ/VNĐ)
- Chi tiết xuất CCDC với các thông tin: CCDC, số lượng, giá, TK phân bổ/chi phí/CCDC, bộ phận sử dụng, số kỳ phân bổ

#### 2. Quản lý phân bổ CCDC
- Theo dõi số kỳ phân bổ cho mỗi CCDC
- Tự động tính chi phí phân bổ theo kỳ
- Quản lý bộ phận sử dụng CCDC

#### 3. Tính toán tự động
- Tính thành tiền theo số lượng x giá
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính tổng tiền xuất
- Tính tổng số lượng

#### 4. Tìm kiếm
- Tìm kiếm phiếu xuất CCDC theo nhiều tiêu chí: KH, kho, CCDC, TK, hợp đồng, SPCT, phí, bộ phận, lô

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, mã kho, mã CCDC)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với module kế toán (TK phân bổ, TK chi phí, TK CCDC)
- Kiểm tra tồn kho trước khi xuất
- Quản lý số kỳ phân bổ CCDC

### Mã chứng từ

**IN5** (Phiếu xuất công cụ dụng cụ) - chứng từ xuất CCDC cho bộ phận sử dụng và phân bổ chi phí theo thời gian.

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý phiếu xuất công cụ dụng cụ - chứng từ quan trọng trong quản lý CCDC và phân bổ chi phí CCDC theo kỳ.

---

*Ngày phân tích: 2026-03-29*
