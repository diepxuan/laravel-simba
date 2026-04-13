# Báo cáo Phân tích DLL: GLRptBk02.dll

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
| Assembly Name | GLRptBk02 |
| Assembly Title | Bảng kê chứng từ nhóm theo chỉ tiêu |
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
GLRptBk02.dll/
├── GLRptBk02.csproj             # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptBk02.cs          # Main report form
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
| `frmGlRptBk02` | `frmReport` | Form báo cáo Bảng kê chứng từ nhóm theo chỉ tiêu |

---

## Controls và Events chính

### frmGlRptBk02

| Control | Type | Mục đích |
|---------|------|----------|
| `txtSo_Ct1`, `txtSo_Ct2` | TextBox | Số chứng từ từ/đến |
| `cboNo_Co` | ComboBox | Lọc Nợ/Có (0-Tất cả, 1-Nợ, 2-Có) |
| `txtTk` | AsTextBox | Tài khoản |
| `lblTen_Tk` | Label | Tên tài khoản |
| `txtTk_Du` | AsTextBox | Tài khoản đối ứng |
| `lblTen_Tk_Du` | Label | Tên TK đối ứng |
| `txtMa_Kh` | AsTextBox | Mã khách hàng (isKH=1) |
| `lblTen_Kh` | Label | Tên khách hàng |
| `txtMa_NhKh` | AsTextBox | Nhóm khách hàng |
| `lblTen_NhKh` | Label | Tên nhóm KH |
| `txtMa_Bp` | AsTextBox | Mã bộ phận |
| `lblTen_Bp` | Label | Tên bộ phận |
| `txtMa_Phi` | AsTextBox | Mã phí |
| `lblTen_Phi` | Label | Tên phí |
| `txtMa_Hd` | AsTextBox | Mã hợp đồng |
| `lblTen_Hd` | Label | Tên hợp đồng |
| `txtMa_Ku` | AsTextBox | Mã khế ước |
| `lblTen_Ku` | Label | Tên khế ước |
| `txtMa_Spct` | AsTextBox | Mã SPCT |
| `lblTen_Spct` | Label | Tên SPCT |
| `txtMa_Ct` | AsTextBox | Mã chứng từ |
| `lblTen_Ct` | Label | Tên chứng từ |
| `txtDien_giai` | TextBox | Diễn giải |
| `cboNhom_Theo` | ComboBox | Nhóm theo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Tùy chọn tiền tệ |

---

## Phương thức chính

### InitOtherComponents()
- Khởi tạo giá trị mặc định cho `cboNo_Co` (selected index 0)
- Thiết lập DataSource cho `cboNhom_Theo`:
  - "MA_KH": Khách hàng
  - "TK": Tài khoản
  - "TK_DU": Tài khoản đối ứng
  - "MA_BP": Bộ phận
  - "MA_HD": Hợp đồng
  - "MA_PHI": Phí
  - "MA_SPCT": Sản phẩm

### LoadData()
- Load dữ liệu bảng kê với các tham số:
  - CompanyID
  - Ngày bắt đầu/kết thúc (txtNgay1, txtNgay2)
  - Nhóm theo (cboNhom_Theo)
  - Số chứng từ từ/đến
  - Tài khoản
  - Nợ/Có
  - TK đối ứng
  - Mã KH, nhóm KH, BP, phí, HD, KU, SPCT
  - Mã chứng từ
  - Diễn giải
  - Mã ngoại tệ

### GetFilterTitle()
- Tạo chuỗi mô tả điều kiện lọc hiển thị trên báo cáo
- Bao gồm: Kỳ BC, Nhóm theo, Số CT, TK, Nợ/Có, TK đối ứng, KH, Nhóm KH, BP, Phí, HD, KU, SPCT, CT, NT

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng kê chứng từ nhóm theo chỉ tiêu" - Tên báo cáo
- "Chứng từ số" / "đến số" - Lọc số chứng từ
- "Tài khoản" / "Tài khoản đ/ư" - Lọc TK và TK đối ứng
- "Nợ có" - Lọc theo nợ/có (0-Tất cả, 1-Nợ, 2-Có)
- "Mã khách hàng" - Lọc theo khách hàng (isKH=1)
- "Nhóm KH" - Lọc theo nhóm khách hàng
- "Mã bộ phận" - Lọc theo bộ phận
- "Mã phí" - Lọc theo phí
- "Mã hợp đồng" - Lọc theo hợp đồng
- "Mã khế ước" - Lọc theo khế ước
- "Mã SPCT" - Lọc theo sản phẩm chi tiết
- "Mã Ct" - Lọc theo loại chứng từ
- "Diễn giải" - Lọc theo diễn giải
- "Nhóm theo" - Nhóm dữ liệu báo cáo (bắt buộc chọn)

### Nhóm theo (cboNhom_Theo)

| Key | Value |
|-----|-------|
| MA_KH | Khách hàng |
| TK | Tài khoản |
| TK_DU | Tài khoản đối ứng |
| MA_BP | Bộ phận |
| MA_HD | Hợp đồng |
| MA_PHI | Phí |
| MA_SPCT | Sản phẩm |

---

## Mục đích sử dụng

**GLRptBk02.dll là module báo cáo "Bảng kê chứng từ nhóm theo chỉ tiêu"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Bảng kê chứng từ nhóm theo chỉ tiêu
- Liệt kê các chứng từ phát sinh trong kỳ
- Nhóm dữ liệu theo chỉ tiêu bắt buộc (không có option trống)
- Phân tích theo các đối tượng khác nhau

#### 2. Lọc đa chiều
- Theo số chứng từ, ngày tháng
- Theo tài khoản và tài khoản đối ứng
- Theo nợ/có
- Theo các đối tượng phân tích: KH, nhóm KH, BP, phí, HD, KU, SPCT
- Theo loại chứng từ và diễn giải

#### 3. Khác biệt với GlRptBk01
- Bắt buộc phải chọn nhóm theo (không có option trống)
- Thêm lọc theo nhóm khách hàng (txtMa_NhKh)
- Không có lọc theo mã lô

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Sử dụng AsTextBox với AutoLookup cho các mã đối tượng
- LookupCondition cho txtMa_Kh: "isKH=1"
- Hỗ trợ đa tiền tệ

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn Bảng kê chứng từ nhóm theo chỉ tiêu - một báo cáo kế toán tổng hợp với việc nhóm dữ liệu bắt buộc theo các chỉ tiêu phân tích.

---

*Ngày phân tích: 2026-03-29*
