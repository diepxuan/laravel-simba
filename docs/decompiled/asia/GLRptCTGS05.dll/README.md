# Báo cáo Phân tích DLL: GLRptCTGS05.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLRptCTGS05 |
| Assembly Title | Bảng kê chứng từ |
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
GLRptCTGS05.dll/
├── GLRptCTGS05.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGLRptCTGS05.cs        # Main form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| Framework | Asia ERP Framework (AsiaErp.Framework) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.UserInterface`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptCTGS05` | `frmReport` | Form báo cáo bảng kê chứng từ với bộ lọc chi tiết |

---

## Controls chính

### Bộ lọc chứng từ

| Control | Type | Mục đích |
|---------|------|----------|
| `txtSo_Ct1`, `txtSo_Ct2` | TextBox | Khoảng số chứng từ (từ - đến) |
| `txtTk`, `lblTen_Tk` | AsTextBox, Label | Tài khoản + tên TK (lookup) |
| `txtTk_Du`, `lblTen_Tk_Du` | AsTextBox, Label | Tài khoản đối ứng + tên (lookup) |
| `txtMa_Kh`, `lblTen_Kh` | AsTextBox, Label | Mã khách hàng + tên (lookup) |
| `txtMa_NhKh`, `lblTen_NhKh` | AsTextBox, Label | Nhóm khách hàng + tên (lookup) |

### Bộ lọc phân loại

| Control | Type | Mục đích |
|---------|------|----------|
| `txtMa_Plkh1`, `lblTen_Plkh1` | AsTextBox, Label | Phân loại KH 1 (loai='1') |
| `txtMa_Plkh2`, `lblTen_Plkh2` | AsTextBox, Label | Phân loại KH 2 (loai='2') |
| `txtMa_Plkh3`, `lblTen_Plkh3` | AsTextBox, Label | Phân loại KH 3 (loai='3') |

### Bộ lọc đối tượng khác

| Control | Type | Mục đích |
|---------|------|----------|
| `txtMa_Bp`, `lblTen_Bp` | AsTextBox, Label | Mã bộ phận + tên (lookup) |
| `txtMa_Phi`, `lblTen_Phi` | AsTextBox, Label | Mã phí + tên (lookup) |
| `txtMa_Hd`, `lblTen_Hd` | AsTextBox, Label | Mã hợp đồng + tên (lookup) |
| `txtMa_Ku`, `lblTen_Ku` | AsTextBox, Label | Mã khế ước + tên (lookup) |
| `txtMa_Spct`, `lblTen_Spct` | AsTextBox, Label | Mã sản phẩm chi tiết + tên (lookup) |
| `txtMa_Ct` | AsTextBoxMulti | Mã công trình (multi-value) |
| `txtDien_giai` | TextBox | Lọc theo diễn giải (autocomplete) |

### Bộ lọc ngày lô

| Control | Type | Mục đích |
|---------|------|----------|
| `cboNgay_lo` | AsComboBox | Chọn kỳ ngày lô (NGAY/THANG/QUY/NAM) |
| `txtNgay_lo1`, `txtNgay_lo2` | AsMaskedTextBox | Khoảng ngày lô (từ - đến) |
| `txtSo_lo1`, `txtSo_lo2` | TextBox | Khoảng số lô (từ - đến) |

### Controls chuẩn

| Control | Type | Mục đích |
|---------|------|----------|
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Khoảng ngày báo cáo |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `optVND`, `optNt` | RadioButton | Chọn loại tiền |

---

## Methods quan trọng

| Method | Mục đích |
|--------|----------|
| `InitOtherComponents()` | Khởi tạo, gọi `InitNgayLo()` để load danh sách kỳ |
| `InitNgayLo()` | Load danh sách kỳ báo cáo từ Environment.GetKyBaoCao() |
| `cboKyTruoc_SelectedValueChanged()` | Xử lý thay đổi kỳ - tự động điền ngày từ/đến |
| `LoadData()` | Lấy dữ liệu với 24 tham số lọc |
| `GetFilterTitle()` | Tạo chuỗi tiêu đề lọc từ các điều kiện đã chọn |

---

## Các chuỗi Text đáng chú ý

### Nhãn UI

| Label | Ý nghĩa |
|-------|---------|
| "Chứng từ số", "đến số" | Khoảng số chứng từ |
| "Tài khoản", "Tài khoản đ/ư" | TK và TK đối ứng |
| "Mã khách hàng", "Nhóm KH" | Lọc theo KH |
| "P.loại KH1/2/3" | Phân loại khách hàng |
| "Mã bộ phận", "Mã phí" | Lọc theo BP, phí |
| "Mã hợp đồng", "Mã khế ước" | Lọc theo HĐ, khế ước |
| "Mã SPCT", "Mã Ct" | Lọc theo SPCT, công trình |
| "Diễn giải" | Lọc theo nội dung |
| "Ngày lô", "Số lô" | Lọc theo lô |

### Tham số báo cáo (24 tham số)

1. CompanyID
2. txtNgay1, txtNgay2 (ngày báo cáo)
3. txtNgay_lo1, txtNgay_lo2 (ngày lô)
4. txtMa_Ct (mã công trình)
5. txtTk (tài khoản)
6. txtTk_Du (tài khoản đối ứng)
7. txtMa_NhKh (nhóm KH)
8. txtMa_Plkh1/2/3 (phân loại KH)
9. txtMa_Kh (mã KH)
10. txtSo_Ct1, txtSo_Ct2 (số chứng từ)
11. txtSo_lo1, txtSo_lo2 (số lô)
12. txtMa_Nt (ngoại tệ)
13. txtMa_Hd (hợp đồng)
14. txtMa_Phi (phí)
15. txtDien_giai (diễn giải)
16. txtMa_Bp (bộ phận)
17. txtMa_Spct (SPCT)
18. txtMa_Ku (khế ước)

### Lookup codes

| Control | LookupCodeName | Where Condition |
|---------|---------------|-----------------|
| txtTk | TK | - |
| txtTk_Du | TK | - |
| txtMa_Kh | MA_KH | - |
| txtMa_NhKh | MA_NHKH | - |
| txtMa_Plkh1 | MA_PLKH | loai='1' |
| txtMa_Plkh2 | MA_PLKH | loai='2' |
| txtMa_Plkh3 | MA_PLKH | loai='3' |
| txtMa_Bp | MA_BP | - |
| txtMa_Phi | MA_PHI | - |
| txtMa_Hd | MA_HD | - |
| txtMa_Ku | MA_KU | - |
| txtMa_Spct | MA_SPCT | - |
| txtMa_Ct | MA_CT | - |

---

## Mục đích sử dụng

**GLRptCTGS05.dll là module báo cáo "Bảng kê chứng từ" với bộ lọc chi tiết đa chiều** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Lọc đa chiều
- Lọc theo thời gian: ngày báo cáo, ngày lô, số lô
- Lọc theo chứng từ: khoảng số chứng từ
- Lọc theo kế toán: TK, TK đối ứng
- Lọc theo khách hàng: mã KH, nhóm KH, phân loại KH 1/2/3
- Lọc theo đối tượng: bộ phận, phí, hợp đồng, khế ước, SPCT, công trình
- Lọc theo nội dung: diễn giải (autocomplete)
- Hỗ trợ đa ngoại tệ

#### 2. Xử lý kỳ báo cáo
- cboNgay_lo: chọn loại kỳ (NGAY/THANG/QUY/NAM)
- Tự động điền ngày từ/đến khi chọn kỳ
- Cho phép nhập tay khi chọn "NGAY"

#### 3. Xem và in ấn
- Hiển thị dữ liệu trên DataGridView
- Tạo filter title động từ các điều kiện đã chọn
- In báo cáo qua Crystal Report
- Xuất Excel

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Sử dụng 24 tham số để lọc dữ liệu
- Hỗ trợ lookup tự động cho hầu hết các trường
- txtMa_Ct là AsTextBoxMulti - cho phép chọn nhiều công trình
- txtDien_giai có AutoCompleteMode=Suggest
- GetFilterTitle() tạo chuỗi mô tả điều kiện lọc đầy đủ

### Mã báo cáo

**CTGS05** - Bảng kê chứng từ tổng hợp với bộ lọc chi tiết đa chiều

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem, lọc và in bảng kê chứng từ với khả năng lọc chi tiết theo nhiều tiêu chí: thời gian, chứng từ, tài khoản, khách hàng, bộ phận, hợp đồng, khế ước, sản phẩm, công trình. Đây là báo cáo linh hoạt nhất trong nhóm CTGS.

---

*Ngày phân tích: 2026-03-29*
