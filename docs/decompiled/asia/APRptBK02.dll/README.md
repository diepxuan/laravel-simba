# Báo cáo Phân tích DLL: APRptBK02.dll

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
| Assembly Name | ApRptBK02 |
| Assembly Title | Bảng kê hóa đơn theo hạn thanh toán |
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
APRptBK02.dll/
├── ApRptBK02.csproj              # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmAPRptBK02.cs           # Report form chính
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
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmAPRptBK02` | `frmReport` | Form báo cáo bảng kê công nợ theo hạn thanh toán |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng kê hóa đơn theo hạn thanh toán" - Tên chức năng chính
- "Ngày so sánh" - Ngày để so sánh hạn thanh toán
- "Hạn kỳ 1", "Hạn kỳ 2", "Hạn kỳ 3" - Các mốc hạn thanh toán
- "Mã NCC" (Nhà cung cấp)
- "Nhóm NCC"
- "Sắp xếp" - Tùy chọn sắp xếp theo nhà cung cấp
- "Chỉ xem" - Lọc trạng thái hóa đơn

### Các trường lọc báo cáo

| Trường | Ý nghĩa |
|--------|---------|
| txtNgay_Ss | Ngày so sánh |
| txtHan_ky1 | Hạn kỳ 1 (số ngày) |
| txtHan_ky2 | Hạn kỳ 2 (số ngày) |
| txtHan_ky3 | Hạn kỳ 3 (số ngày) |
| txtMa_Kh | Mã nhà cung cấp |
| txtMa_NhKh | Nhóm nhà cung cấp |
| ChkSap_xep | Sắp xếp theo NCC |
| cboChi_xem | Chỉ xem (chưa tất toán/đã tất toán/tất cả) |

### Các giá trị ComboBox

**cboChi_xem:**
- "Các hóa đơn chưa tất toán"
- "Các hóa đơn đã tất toán"
- "Tất cả các hóa đơn"

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ngay_ss` | Ngày so sánh |
| `han_ky` | Hạn kỳ thanh toán |
| `ma_kh` | Mã nhà cung cấp |
| `ma_nhkh` | Mã nhóm nhà cung cấp |
| `chi_xem` | Chỉ xem (trạng thái) |

---

## Mục đích sử dụng

**APRptBK02.dll là module báo cáo "Bảng kê công nợ phải trả theo hạn"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Phân tích công nợ theo hạn thanh toán
- So sánh ngày hóa đơn với ngày hiện tại
- Phân loại công nợ theo các mốc hạn kỳ (1, 2, 3)
- Theo dõi hóa đơn quá hạn thanh toán
- Đánh giá tình trạng thanh toán của nhà cung cấp

#### 2. Cấu hình hạn kỳ
- Hạn kỳ 1, 2, 3 được cấu hình trong SOConfiguration
- Giá trị mặc định: han_tt_ss1, han_tt_ss2, han_tt_ss3
- Validation: Hạn kỳ phải >= 0

#### 3. Lọc và sắp xếp
- Lọc theo nhà cung cấp/nhóm nhà cung cấp
- Lọc theo trạng thái thanh toán (chưa/đã/tất cả)
- Sắp xếp theo nhà cung cấp
- Lọc theo ngoại tệ

#### 4. Báo cáo
- Hiển thị danh sách hóa đơn theo hạn thanh toán
- Phân loại: còn hạn, quá hạn kỳ 1, quá hạn kỳ 2, quá hạn kỳ 3
- Tổng hợp công nợ theo nhóm

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Form báo cáo chuẩn
- Sử dụng SOConfiguration để lấy cấu hình hạn kỳ
- AutoLookup cho các trường mã (NCC, nhóm NCC)
- Validation dữ liệu đầu vào (Hạn kỳ >= 0)
- Tích hợp với Asia ERP Framework

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc theo dõi và báo cáo công nợ phải trả theo hạn thanh toán - một công cụ quan trọng trong quản lý dòng tiền và đánh giá nhà cung cấp.

---

*Ngày phân tích: 2026-03-29*
