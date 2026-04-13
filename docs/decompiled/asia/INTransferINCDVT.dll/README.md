# Báo cáo Phân tích DLL: INTransferINCDVT.dll

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
| Assembly Name | INTransferINCDVT |
| Assembly Title | Chuyển tồn kho sang năm sau |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | "" |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | aee5ba0c-ea97-45a5-ae8f-25ed2faddb55 |
| ComVisible | false |

---

## Cấu trúc File

```
INTransferINCDVT.dll/
├── INTransferINCDVT.csproj      # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.UserInterface/
│   └── frmINTransferINCDVT.cs   # Main form class
├── AsiaERP.UserInterface.My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   └── InternalXmlHelper.cs
└── AsiaERP.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | LINQ to XML |
| System.Core | .NET Core extensions |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Collections.Generic`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINTransferINCDVT` | `frmCalc` | Form chuyển tồn kho sang năm sau |

---

## Controls và Events

| Control | Loại | Mục đích |
|---------|------|----------|
| `lblSure` | Label | Cảnh báo xác nhận (màu đỏ) |
| `lblMa_kho` | Label | Nhãn mã kho |
| `txtMa_kho` | AsTextBox | Chọn mã kho (AutoLookup MA_KHO) |
| `lblTen_kho` | Label | Hiển thị tên kho |
| `lblFinal_day` | Label | Nhãn ngày cuối năm |
| `txtFinal_day` | AsMaskedTextBox | Ngày cuối năm hiện thời (readonly) |
| `lblMa_so` | Label | Nhãn mã số |
| `txtMa_so` | TextBox | Mã số xác nhận (random) |
| `lblConfirm` | Label | Nhãn xác nhận |
| `txtConfirm` | TextBox | Nhập lại mã số để xác nhận |
| `bgWorker` | BackgroundWorker | Xử lý chuyển dữ liệu async |

### Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| `txtConfirm.TextChanged` | `txtConfirm_TextChanged` | Kiểm tra mã xác nhận, enable OK |
| `bgWorker.DoWork` | `bgWorker_DoWork` | Thực hiện chuyển tồn kho |
| `bgWorker.RunWorkerCompleted` | `bgWorker_RunWorkerCompleted` | Thông báo kết quả |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Chuyển tồn kho sang năm sau" - Tên chức năng chính
- "Bạn có chắc chuyển dữ liệu sang năm sau?" - Cảnh báo xác nhận (màu đỏ)
- "Ngày cuối năm hiện thời" - Ngày kết thúc năm tài chính
- "Mã kho" - Chọn kho cần chuyển
- "Mã số" - Mã số ngẫu nhiên để xác nhận
- "Xác nhận" - Nhập lại mã số

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `cdvt` | Công nợ đầu kỳ vật tư / Tồn đầu kỳ |
| `ma_kho` | Mã kho |
| `final_day` | Ngày cuối năm |
| `company_id` | Mã công ty |
| `ngay_cntc` | Ngày chuyển năm tài chính |

---

## Mục đích sử dụng

**INTransferINCDVT.dll là module chuyển tồn kho sang năm tài chính mới** trong hệ thống AsiaERP của ASIASOFT.

### Chức năng chính

#### 1. Chuyển tồn kho cuối năm
- Chuyển số tồn kho từ năm cũ sang năm mới
- Tính toán tồn đầu kỳ cho năm tài chính mới
- Dựa trên ngày cuối năm tài chính hiện tại
- Hỗ trợ chọn kho cụ thể để chuyển

#### 2. Xác nhận an toàn
- Sinh mã số ngẫu nhiên (Random.Next())
- Yêu cầu nhập lại mã số để xác nhận
- Chỉ thực hiện khi mã số khớp
- Ngăn ngừa thao tác nhầm lẫn

#### 3. Xử lý background
- Sử dụng BackgroundWorker để không block UI
- Thông báo kết quả sau khi hoàn thành
- Tự động đóng form khi thành công

### Đặc điểm kỹ thuật

- Kế thừa từ `frmCalc` (form tính toán/xử lý)
- AsTextBox với AutoLookup cho mã kho (MA_KHO)
- MaskedTextBox cho ngày tháng (định dạng dd/MM/yyyy, readonly)
- BackgroundWorker cho xử lý async
- Transaction đảm bảo toàn vẹn dữ liệu
- Lấy ngày cuối năm từ `SystemInformations.FinancialYear` (31/12)

### Quy trình xử lý

1. Hiển thị ngày cuối năm tài chính (31/12 của năm hiện tại)
2. Sinh mã số xác nhận ngẫu nhiên
3. Người dùng chọn kho cần chuyển
4. Người dùng nhập lại mã số vào ô Xác nhận
5. Kiểm tra khớp mã số → enable nút OK
6. Thực hiện chuyển dữ liệu qua BackgroundWorker
7. Thông báo kết quả (50015=thành công, 50010=thất bại)
8. Đóng form

### Phân biệt với GLTransferGLCDTK

| | INTransferINCDVT | GLTransferGLCDTK |
|---|------------------|------------------|
| Module | IN (Inventory) | GL (General Ledger) |
| Chức năng | Chuyển tồn kho | Chuyển số dư tài khoản |
| Đối tượng | Vật tư trong kho | Tài khoản kế toán |
| Có chọn kho | Có | Không |

---

## Kết luận

Đây là module Windows Forms của hệ thống AsiaERP, phục vụ cho việc chuyển tồn kho sang năm tài chính mới - một chức năng quan trọng trong kỳ kết chuyển cuối năm của module Inventory (IN), đảm bảo số dư tồn kho đầu kỳ được chuyển giao chính xác sang năm mới cho từng kho cụ thể.

---

*Ngày phân tích: 2026-03-29*
