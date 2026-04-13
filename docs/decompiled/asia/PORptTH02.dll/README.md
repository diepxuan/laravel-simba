# Báo cáo Phân tích DLL: PORptTH02.dll

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
| Assembly Name | PORptTH02 |
| Assembly Title | Báo cáo tổng hợp mua hàng 02 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
PORptTH02.dll/
├── PORptTH02.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmPORptTH02.cs        # Main report form
│   └── lstVoucherInfo.cs        # Voucher info list class
├── AsiaErp.UserInterface.My/
│   └── Resources/
│       └── Resources.cs         # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (native-apps/ASIA/Helper.dll) |
| System.Data | Data access |
| System.Core | LINQ support |
| System.Xml.Linq | XML LINQ support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Runtime.InteropServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPORptTH02` | `frmReport` | Form báo cáo tổng hợp mua hàng 02 |
| `lstVoucherInfo` | - | Danh sách thông tin chứng từ |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo cáo tổng hợp mua hàng 02" - Tên chức năng chính
- "Loại" (`cboLoai`) - Theo tháng/quý/năm
- "Loại chứng từ" (`cboLoai_ct`)
- "Loại phiếu" (`cboLoaiPhieu`)
- "Từ tháng" (`txtTu_thang`)
- "Số kỳ" (`txtSo_ky`)
- "Năm" (`txtNam`)

### Các loại báo cáo

| Loại | Mã | Mô tả |
|------|-----|--------|
| Theo tháng | THANG | Báo cáo theo từng tháng |
| Theo quý | QUY | Báo cáo theo từng quý |
| Theo năm | NAM | Báo cáo theo năm |

### Các loại chứng từ

| Loại chứng từ |
|----------------|
| Phiếu nhập mua |
| Hóa đơn mua hàng |

### Các loại phiếu hỗ trợ

| Loại phiếu |
|-------------|
| Tất cả |
| Phiếu đề nghị mua hàng |
| Đơn hàng mua |
| Phiếu nhập mua |
| Hoá đơn mua hàng |
| Phiếu chi phí mua hàng |
| Phiếu xuất trả lại NCC |
| Hoá đơn mua dịch vụ |
| Hoá đơn mua hàng nhập khẩu |

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `loai` | Loại báo cáo (tháng/quý/năm) |
| `loai_ct` | Loại chứng từ |
| `loai_phieu` | Loại phiếu |
| `tu_thang` | Tháng bắt đầu báo cáo |
| `so_ky` | Số kỳ báo cáo |
| `nam` | Năm báo cáo |

---

## Mục đích sử dụng

**PORptTH02.dll là module Báo cáo tổng hợp mua hàng 02** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo tổng hợp theo thời gian
- Báo cáo theo tháng (12 tháng)
- Báo cáo theo quý (4 quý)
- Báo cáo theo năm

#### 2. Các tham số báo cáo

##### Thời gian báo cáo
- **Từ tháng**: Tháng bắt đầu báo cáo (1-12)
- **Số kỳ**: Số kỳ báo cáo
  - Theo tháng: 1-12 kỳ
  - Theo quý: 1-4 kỳ
  - Theo năm: 1 kỳ
- **Năm**: Năm báo cáo (1900-2079)

##### Loại chứng từ
- Phiếu nhập mua
- Hóa đơn mua hàng

##### Loại phiếu
- Hỗ trợ lọc theo tất cả các loại phiếu trong module PO

#### 3. Validation dữ liệu
- Kiểm tra từ tháng >= 1
- Kiểm tra năm trong khoảng 1900-2079
- Kiểm tra số kỳ hợp lệ theo loại báo cáo

#### 4. Xuất báo cáo
- Hỗ trợ nhiều mẫu báo cáo (`cboMau_bc`)
- Xuất ra Crystal Report
- Xuất ra Excel (`cmdExcel`)
- In ấn trực tiếp
- Xem trước khi in

#### 5. Drill-down
- Hỗ trợ xem chi tiết từ báo cáo tổng hợp
- Drill-down theo mã vật tư
- Chuyển đến báo cáo chi tiết

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` (Framework chuẩn của Asia ERP)
- Sử dụng `AsTextNumeric` cho các trường số (tháng, năm, số kỳ)
- Sử dụng `AsComboBox` cho các dropdown
- Tích hợp Crystal Report cho xuất báo cáo
- Validation dữ liệu đầu vào chặt chẽ
- Hỗ trợ đa ngôn ngữ (sử dụng `Environment.getLangSysMessageResX`)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc tạo báo cáo tổng hợp mua hàng theo thời gian (tháng/quý/năm), hỗ trợ quản lý và phân tích xu hướng mua hàng theo các kỳ.

---

*Ngày phân tích: 2026-03-29*
