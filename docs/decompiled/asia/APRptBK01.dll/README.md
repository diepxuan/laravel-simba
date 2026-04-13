# Báo cáo Phân tích DLL: APRptBK01.dll

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
| Assembly Name | APRptBK01 |
| Assembly Title | Bảng kê hóa đơn phải trả |
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
APRptBK01.dll/
├── APRptBK01.csproj              # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmAPRptBK01.cs           # Report form chính
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| CrystalDecisions.Windows.Forms | Crystal Reports viewer |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `CrystalDecisions.Windows.Forms`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmAPRptBK01` | `frmReport` | Form báo cáo bảng kê chứng từ mua hàng |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng kê hóa đơn phải trả" - Tên chức năng chính
- "Mã khách hàng", "Tên khách hàng"
- "Mã vật tư", "Tên vật tư", "Nhóm vật tư"
- "Mã kho", "Mã bộ phận"
- "Mã hợp đồng", "Tên hợp đồng"
- "P.Loại KH1", "P.Loại KH2", "P.Loại KH3" (Phân loại khách hàng)
- "Số phiếu nhập"
- "Chứng từ số", "đến số"
- "Mã lô", "Mã phí", "Mã SPCT"

### Các trường lọc báo cáo

| Trường | Ý nghĩa |
|--------|---------|
| txtMa_Kh | Mã khách hàng (NCC) |
| txtMa_vt | Mã vật tư |
| txtMa_nhvt | Nhóm vật tư |
| txtMa_kho | Mã kho |
| txtMa_Bp | Mã bộ phận |
| txtMa_Hd | Mã hợp đồng |
| txtMa_plkh1 | Phân loại KH 1 |
| txtMa_plkh2 | Phân loại KH 2 |
| txtMa_plkh3 | Phân loại KH 3 |
| txtSo_PX | Số phiếu nhập |
| txtSo_Ct1 | Chứng từ từ số |
| txtSo_Ct2 | Chứng từ đến số |
| txtMa_lo | Mã lô |
| txtMa_phi | Mã phí |
| txtma_spct | Mã SPCT |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_kh` | Mã khách hàng/NCC |
| `ma_vt` | Mã vật tư |
| `ma_nhvt` | Mã nhóm vật tư |
| `ma_kho` | Mã kho |
| `ma_bp` | Mã bộ phận |
| `ma_hd` | Mã hợp đồng |
| `ma_plkh` | Mã phân loại khách hàng |
| `so_px` | Số phiếu xuất/nhập |
| `so_ct` | Số chứng từ |
| `ma_lo` | Mã lô |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |

---

## Mục đích sử dụng

**APRptBK01.dll là module báo cáo "Bảng kê chứng từ mua hàng"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo danh sách hóa đơn mua hàng
- Liệt kê các hóa đơn mua hàng từ nhà cung cấp
- Thông tin chi tiết về vật tư, số lượng, giá, thành tiền
- Theo dõi chứng từ nhập kho liên quan

#### 2. Lọc dữ liệu đa chiều
- Lọc theo nhà cung cấp (mã KH)
- Lọc theo vật tư (mã VT, nhóm VT)
- Lọc theo kho, bộ phận
- Lọc theo hợp đồng
- Lọc theo phân loại khách hàng (3 cấp)
- Lọc theo số phiếu nhập
- Lọc theo số chứng từ (từ số - đến số)
- Lọc theo lô, phí, SPCT

#### 3. Tính năng báo cáo
- Sử dụng Crystal Reports để hiển thị và in ấn
- Hỗ trợ xuất Excel
- Tùy chỉnh tiêu đề báo cáo
- Chọn mẫu báo cáo
- Chọn kỳ báo cáo
- Lọc theo ngoại tệ (VND/NT)

#### 4. Tích hợp dữ liệu
- Kết nối với danh mục khách hàng
- Kết nối với danh mục vật tư, nhóm vật tư
- Kết nối với danh mục kho, bộ phận
- Kết nối với danh mục hợp đồng
- Kết nối với danh mục phân loại khách hàng

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Form báo cáo chuẩn của Framework
- Sử dụng CrystalReportViewer để hiển thị báo cáo
- AutoLookup cho các trường mã (KH, VT, nhóm VT, kho, bộ phận, hợp đồng, phân loại)
- Xây dựng chuỗi tiêu đề lọc động (GetFilterTitle)
- Tích hợp với Asia ERP Framework

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in bảng kê chứng từ mua hàng - một báo cáo quan trọng trong quản lý mua hàng và theo dõi công nợ phải trả.

---

*Ngày phân tích: 2026-03-29*
