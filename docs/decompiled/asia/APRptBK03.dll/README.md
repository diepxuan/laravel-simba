# Báo cáo Phân tích DLL: APRptBK03.dll

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
| Assembly Name | APRptBK03 |
| Assembly Title | Bảng kê phiếu chi thanh toán tiền hàng |
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
APRptBK03.dll/
├── APRptBK03.csproj              # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmAPRptBK03.cs           # Report form chính
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

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmAPRptBK03` | `frmReport` | Form báo cáo bảng kê chứng từ thanh toán |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng kê phiếu chi thanh toán tiền hàng" - Tên chức năng chính
- "Mã khách hàng", "Tên khách hàng"
- "Nhóm KH" (Nhóm khách hàng)
- "P.Loại KH1", "P.Loại KH2", "P.Loại KH3" (Phân loại khách hàng)
- "Giao dịch" - Loại giao dịch (Hóa đơn/Đơn hàng)
- "Chứng từ số", "đến số"
- "Sắp xếp" - Tùy chọn sắp xếp
- "Chỉ xem" - Lọc trạng thái

### Các trường lọc báo cáo

| Trường | Ý nghĩa |
|--------|---------|
| txtMa_Kh | Mã khách hàng/NCC |
| txtMa_NhKh | Nhóm khách hàng |
| txtMa_plkh1 | Phân loại KH 1 |
| txtMa_plkh2 | Phân loại KH 2 |
| txtMa_plkh3 | Phân loại KH 3 |
| cboGiao_dich | Loại giao dịch |
| txtSo_Ct1 | Chứng từ từ số |
| txtSo_Ct2 | Chứng từ đến số |
| ChkSap_xep | Sắp xếp theo KH |
| cboChi_xem | Chỉ xem (tất toán/chưa tất toán/tất cả) |

### Các giá trị ComboBox

**cboGiao_dich:**
- "Tất cả"
- "Hóa đơn"
- "Đơn hàng"

**cboChi_xem:**
- "Tất toán"
- "Chưa tất toán"
- "Tất cả"

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_kh` | Mã khách hàng/NCC |
| `ma_nhkh` | Mã nhóm khách hàng |
| `ma_plkh` | Mã phân loại khách hàng |
| `ma_gd` | Mã giao dịch |
| `so_ct` | Số chứng từ |
| `chi_xem` | Chỉ xem (trạng thái tất toán) |

---

## Mục đích sử dụng

**APRptBK03.dll là module báo cáo "Bảng kê chứng từ thanh toán"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo chứng từ thanh toán
- Liệt kê các phiếu chi/ủy nhiệm chi thanh toán
- Theo dõi các khoản thanh toán cho nhà cung cấp
- Phân loại theo loại giao dịch (hóa đơn/đơn hàng)
- Kiểm tra trạng thái tất toán

#### 2. Lọc dữ liệu đa dạng
- Lọc theo khách hàng/nhà cung cấp
- Lọc theo nhóm khách hàng
- Lọc theo phân loại khách hàng (3 cấp)
- Lọc theo loại giao dịch
- Lọc theo số chứng từ (từ số - đến số)
- Lọc theo trạng thái tất toán

#### 3. Tính năng bổ sung
- Sắp xếp theo khách hàng
- Chọn kỳ báo cáo
- Chọn mẫu báo cáo
- Lọc theo ngoại tệ (VND/NT)
- Tùy chỉnh tiêu đề báo cáo

#### 4. Tích hợp dữ liệu
- Lấy danh sách giao dịch từ DmMagd (theo par1)
- Tích hợp với module phân bổ thanh toán

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Form báo cáo chuẩn của Framework
- Sử dụng ToolTip cho các combobox dài
- AutoLookup cho các trường mã (KH, nhóm KH, phân loại)
- Xử lý sự kiện GotFocus và SelectedIndexChanged cho combobox
- Tích hợp với Asia ERP Framework

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in bảng kê chứng từ thanh toán - một báo cáo quan trọng trong quản lý chi phí và công nợ phải trả.

---

*Ngày phân tích: 2026-03-29*
