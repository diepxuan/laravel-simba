# Báo cáo Phân tích DLL: POUtilities.dll

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
| Assembly Name | POUtilities |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| ComVisible | false |

---

## Cấu trúc File

```
POUtilities.dll/
├── POUtilities.csproj           # Project file
├── app.ico                      # Application icon
├── frmCA4PO.cs                  # Form thanh toán PO
├── frmCA4PO.resx                # Resource file
├── Resources.resx               # Resources
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.DataAccess/
│   └── (DAO classes)            # Data Access Objects
├── AsiaErp.POUtilities/
│   └── (Utility classes)        # Utility classes
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
| System.Xml.Linq | XML LINQ support |
| System.Core | .NET Core extensions |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| CrystalDecisions.CrystalReports.Engine | Crystal Reports |
| CrystalDecisions.Shared | Crystal Reports Shared |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `CrystalDecisions.CrystalReports.Engine`
- `CrystalDecisions.Shared`
- `System`, `System.Data`, `System.Drawing`, `System.Drawing.Printing`, `System.IO`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCA4PO` | `frmAsiaRoot` | Form thanh toán chứng từ PO (Báo nợ/Phiếu chi) |
| `MsSqlCA4PODAO` | - | Data Access Object cho CA4PO |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Số chứng từ" - Số chứng từ thanh toán
- "Ngày chứng từ" - Ngày lập chứng từ
- "Tài khoản có" - TK có trong hạch toán
- "Người giao dịch" - Người liên hệ
- "Diễn giải" - Mô tả giao dịch
- "Thanh toán" - Tổng số tiền thanh toán
- "Loại chứng từ" - Phân loại chứng từ
- "Đã chi" - Trạng thái đã thanh toán

### Loại chứng từ

| Loại | Mã | Ý nghĩa |
|------|-----|---------|
| Phiếu chi | CA2 | Chứng từ chi tiền mặt |
| Báo nợ | CA4 | Chứng từ báo nợ ngân hàng |

### Cột DataGridView (Chi tiết hạch toán)

| Cột | Ý nghĩa |
|-----|---------|
| Tk nợ | Tài khoản nợ |
| Tên tài khoản nợ | Tên TK nợ |
| Ps nợ | Phát sinh nợ |
| B. phận | Bộ phận |
| Phí | Mã phí |
| H. đồng | Hợp đồng |
| SPCT | Sản phẩm chi tiết |
| Lô | Mã lô |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_kh` | Mã khách hàng |
| `ten_kh` | Tên khách hàng |
| `dia_chi_kh` | Địa chỉ KH |
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `t_tien_nt` | Tổng tiền ngoại tệ |
| `t_tien` | Tổng tiền VND |
| `tk_co` | Tài khoản có |
| `ps_no_nt` | Phát sinh nợ ngoại tệ |
| `stt_rec` | Số thứ tự bản ghi |
| `stt_rec_hd` | Số thứ tự hóa đơn |

---

## Mục đích sử dụng

**POUtilities.dll là module tiện ích cho Purchasing (PO)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Thanh toán chứng từ PO
- Tạo chứng từ thanh toán cho các hóa đơn mua hàng
- Hỗ trợ 2 loại: Phiếu chi (CA2) và Báo nợ (CA4)
- Quản lý thông tin người giao dịch, diễn giải
- Tự động tính tổng tiền thanh toán

#### 2. Quản lý tài khoản
- Chọn tài khoản có (tk_co)
- Hiển thị tên tài khoản tự động
- Chi tiết hạch toán nợ/có

#### 3. In ấn chứng từ
- Tích hợp Crystal Reports
- Hỗ trợ xem trước và in trực tiếp
- Cấu hình số bản in, máy in
- Công thức trường báo cáo động

#### 4. Xử lý dữ liệu
- Lưu chứng từ vào database (Save2DB)
- Transaction processing (RequireTrans, CommitTrans, RollBackTrans)
- Tính toán tổng tiền từ chi tiết

### Đặc điểm kỹ thuật

- Sử dụng DAO pattern (MsSqlCA4PODAO)
- Transaction management cho data integrity
- Crystal Reports integration cho in ấn
- Multi-currency support (ngoại tệ/VND)
- Formula fields động cho báo cáo

### Mã chứng từ liên quan

**CA2** (Phiếu chi) - Chứng từ chi tiền mặt
**CA4** (Báo nợ) - Chứng từ báo nợ ngân hàng

---

## Kết luận

Đây là module tiện ích của hệ thống ERP Asia Enterprise, cung cấp chức năng thanh toán cho module Purchasing. Module hỗ trợ tạo phiếu chi và báo nợ, tích hợp in ấn Crystal Reports và quản lý transaction.

---

*Ngày phân tích: 2026-03-29*
