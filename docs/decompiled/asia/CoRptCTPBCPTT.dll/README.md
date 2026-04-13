# Báo cáo Phân tích DLL: CoRptCTPBCPTT.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| Chức năng | Báo cáo chi tiết phân bổ chi phí tập trung |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | CoRptCTPBCPTT |
| Assembly Title | Báo cáo tồn kho cuối kỳ |
| Assembly Product | AsiaERP |
| Assembly Company | ASIASOFT |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 6cf0aa81-5a68-42ff-8764-7956a0ff3a07 |
| ComVisible | false |

---

## Cấu trúc File

```
CoRptCTPBCPTT.dll/
├── CoRptCTPBCPTT.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmCoRptCTPBCPTT.cs      # Main form class
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs             # VB.NET My project support
    ├── MyApplication.cs         # Application support
    ├── MyComputer.cs            # Computer support
    ├── MySettings.cs            # Settings support
    └── MySettingsProperty.cs    # Settings property
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| System.Drawing | Graphics support |
| Microsoft.VisualBasic | VB.NET runtime support |
| AsiaErp.Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCoRptCTPBCPTT` | `frmReport` | Form báo cáo chi tiết phân bổ chi phí |

---

## Các controls chính

### Filter Controls
| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_bpsd | AsTextBox | Mã bộ phận sử dụng |
| lblTen_bpsd | Label | Tên bộ phận sử dụng |
| lblMa_bpsd | Label | Nhãn "Mã BPSD" |
| txtMa_cp | AsTextBox | Mã chi phí |
| lblTen_cp | Label | Tên chi phí |
| lblMa_cp | Label | Nhãn "Mã chi phí" |
| txtTk_pb | AsTextBox | TK phân bổ |
| lblTen_tkpb | Label | Tên TK phân bổ |
| lblTk_pb | Label | Nhãn "TK phân bổ" |
| txtTk_cp | AsTextBox | TK chi phí |
| lblTen_tkcp | Label | Tên TK chi phí |
| lblTk_cp | Label | Nhãn "TK chi phí" |
| txtMa_phi | AsTextBox | Mã phí |
| lblTen_phi | Label | Tên phí |
| lblMa_phi | Label | Nhãn "Mã phí" |
| txtMa_spct | AsTextBox | Mã SPCT |
| lblTen_spct | Label | Tên SPCT |
| lblMa_spct | Label | Nhãn "Mã SPCT" |

### Report Controls (kế thừa từ frmReport)
| Control | Mô tả |
|---------|-------|
| cboKyBc | Kỳ báo cáo |
| txtNgay1 | Từ ngày |
| txtNgay2 | Đến ngày |
| cboMau_bc | Mẫu báo cáo |
| txtTieu_De | Tiêu đề báo cáo |
| cmdOk | Xem báo cáo |
| cmdCancel | Hủy |
| cmdExcel | Xuất Excel |
| cmdModifyReport | Sửa mẫu báo cáo |

---

## Business Logic

### Quy trình báo cáo

1. **Chọn kỳ**: Người dùng chọn kỳ báo cáo (tự động tính từ ngày - đến ngày)
2. **Lọc dữ liệu**: Nhập các điều kiện lọc (bộ phận, chi phí, TK, phí, SPCT)
3. **LoadData**: Gọi controller lấy dữ liệu theo các tham số
4. **Hiển thị**: Hiển thị dữ liệu trên DataGridView và cho phép in/xuất

### Methods

| Method | Mô tả |
|--------|-------|
| `LoadData()` | Lấy dữ liệu báo cáo từ database |
| `GetFilterTitle()` | Tạo chuỗi mô tả điều kiện lọc |

### Parameters truyền vào Controller

| Parameter | Mô tả |
|-----------|-------|
| CompanyID | Mã công ty |
| Ngay1 | Từ ngày |
| Ngay2 | Đến ngày |
| Ma_bpsd | Mã bộ phận sử dụng |
| Ma_cp | Mã chi phí |
| Tk_pb | TK phân bổ |
| Tk_cp | TK chi phí |
| Ma_phi | Mã phí |
| Ma_spct | Mã SPCT |

### Lookup Codes

| Control | LookupCode | Điều kiện |
|---------|------------|-----------|
| txtMa_bpsd | MA_BPSD | - |
| txtMa_cp | MA_CPTT | MODULEID = 'CO' |
| txtTk_pb | TK | - |
| txtTk_cp | TK | - |
| txtMa_phi | MA_PHI | - |
| txtMa_spct | MA_SPCT | - |

---

## Mục đích sử dụng

**CoRptCTPBCPTT.dll là module báo cáo chi tiết phân bổ chi phí tập trung** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Báo cáo chi tiết phân bổ
- Hiển thị chi tiết các bút toán phân bổ chi phí tập trung
- Theo dõi giá trị phân bổ theo từng kỳ
- Phân tích theo bộ phận, chi phí, tài khoản

#### 2. Lọc đa chiều
- Lọc theo bộ phận sử dụng
- Lọc theo mã chi phí
- Lọc theo TK phân bổ và TK chi phí
- Lọc theo mã phí và mã SPCT

#### 3. Xuất dữ liệu
- Xem trực tiếp trên form
- In ấn báo cáo
- Xuất ra Excel

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc tra cứu và báo cáo chi tiết các bút toán phân bổ chi phí tập trung, giúp người dùng theo dõi và kiểm soát việc phân bổ chi phí trong doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
